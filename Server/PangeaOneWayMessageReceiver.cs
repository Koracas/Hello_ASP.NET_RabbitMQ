using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RabbitMQ.Client;                  //  Needed for RabbitMQ
using System.Text;                      //  Needed for Encoding of messages
using System.Diagnostics;
using System.Net;
using System.Net.Http.Headers;          //  Used for http request headers 
using System.Net.Http;                  //  Used for http request
using Newtonsoft.Json;
using Server.DataModel;
using Microsoft.EntityFrameworkCore;

namespace RabbitMq.OneWayMessage.Receiver
{
    public class PangeaOneWayMessageReceiver : DefaultBasicConsumer
    {
        private readonly IModel _model;

        //  Constructor that passing in the channel 
        public PangeaOneWayMessageReceiver(IModel model)
        {
            _model = model;
        }

        public override void HandleBasicDeliver(string consumerTag, ulong deliveryTag, bool redelivered, string exchange, string routingKey, IBasicProperties properties, byte[] body)
        {
            String message = Encoding.UTF8.GetString(body);

            //  Output that message was recieved
            Console.WriteLine("Message received by the consumer. Check the debug window for details.");
            Console.WriteLine(string.Concat("Message received from the exchange ", exchange));
            Console.WriteLine(string.Concat("Content type: ", properties.ContentType));
            Console.WriteLine(string.Concat("Consumer tag: ", consumerTag));
            Console.WriteLine(string.Concat("Delivery tag: ", deliveryTag));
            Console.WriteLine(string.Concat("Message: ", message));

            //  Json object to hole the data 
            List<Server.DataModel.RepoData> jObjPangeaRepo = new List<Server.DataModel.RepoData>();

            if (message == "Load Data")
            {
                using (var pangeaRepo = new HttpClient())
                {
                    //  Get client base address for Pinterest
                    pangeaRepo.BaseAddress = new Uri("https://api.github.com");
                    pangeaRepo.DefaultRequestHeaders.Accept.Clear();
                    pangeaRepo.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    //Add a user-agent header to the GET request. 
                    var headers = pangeaRepo.DefaultRequestHeaders;

                    //The safe way to add a header value is to use the TryParseAdd method and verify the return value is true,
                    //especially if the header value is coming from user input.
                    string header = "Mozilla/5.0 (compatible; MSIE 10.0; Windows NT 6.2; WOW64; Trident/6.0)";
                    if (!headers.UserAgent.TryParseAdd(header))
                    {
                        throw new Exception("Invalid header value: " + header);
                    }

                    //  Get the user informaiton
                    HttpResponseMessage pangeaRepoInfo = pangeaRepo.GetAsync("/orgs/gopangea/repos").Result;

                    if (pangeaRepoInfo.IsSuccessStatusCode)
                    {
                        //  Get the json result as string
                        string pangeaRepoInfo_strJson = pangeaRepoInfo.Content.ReadAsStringAsync().Result;

                        try
                        {
                            //Deserialize the string to JSON object
                            jObjPangeaRepo = JsonConvert.DeserializeObject<List<Server.DataModel.RepoData>>(pangeaRepoInfo_strJson);

                            foreach (Server.DataModel.RepoData curRepo in jObjPangeaRepo)
                            {
                                //  Access the DB
                                using (var db = new Server.PangeaRepoDataContext() )
                                {
                                    //
                                    //  Add in owner data
                                    //

                                    //  Transform the owner data
                                    Server.Owner repoOwner = new Server.Owner(curRepo.owner);
                                    int dbOwnerId = 0;
                                    var curOwners = (from cur in db.Owner
                                                     where cur.GitHubId == repoOwner.GitHubId
                                                     select cur).ToList();
                                    //  If exists
                                    if( curOwners.Count > 0 )
                                    {
                                        //  Grgab the old ids
                                        dbOwnerId = curOwners.FirstOrDefault().Id;
                                        //  ToDo :: should see if there are changes to modify here...
                                    }
                                    //  Does not exists add it to the table
                                    else
                                    {
                                        db.Owner.Add(repoOwner);
                                        db.SaveChanges();
                                        dbOwnerId = repoOwner.Id;
                                    }

                                    //
                                    //  Add in permission data
                                    //

                                    //  Transform the permission data
                                    Server.Permissions repoPerm = new Server.Permissions(curRepo.permissions);
                                    int dbPermissionId = 0;
                                    var curPermissions = (from cur in db.Permissions
                                                        where (cur.Admin == repoPerm.Admin && cur.Pull == repoPerm.Pull && repoPerm.Push == cur.Push)
                                                        select cur).ToList();
                                    //  If exists
                                    if (curPermissions.Count > 0)
                                    {
                                        //  Grgab the old ids
                                        dbPermissionId = curPermissions.FirstOrDefault().Id;
                                        //  ToDo :: should see if there are changes to modify here...
                                    }
                                    //  Does not exists add it to the table
                                    else
                                    {
                                        db.Permissions.Add(repoPerm);
                                        db.SaveChanges();
                                        dbPermissionId = repoPerm.Id;
                                    }

                                    //
                                    //  Add in Repo data
                                    //

                                    //  Transform the repo data
                                    Server.RepoData repoData = new Server.RepoData(curRepo, dbOwnerId, dbPermissionId);
                                    var curRepos = (from cur in db.RepoData
                                                          where (cur.GitHubId == repoData.GitHubId)
                                                          select cur).ToList();
                                    //  If exists skip it...
                                    if (curRepos.Count > 1)
                                    {
                                        //  ToDo :: should see if there are changes to modify here...
                                    }
                                    else
                                    {
                                        db.RepoData.Add(repoData);
                                        db.SaveChanges();
                                    }
                                }
                            }
                        }
                        catch(Exception ex)
                        {
                            Console.WriteLine(ex.GetType().Name + ": " + ex.Message);
                        }
                    }                  
                }
            }

            //  Ack msg to release message from the queue
            _model.BasicAck(deliveryTag, false);

        }
    }
}