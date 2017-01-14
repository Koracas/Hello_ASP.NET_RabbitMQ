using Microsoft.AspNetCore.Mvc;
using System.Linq;
using MVC_RabbitMQ.Entity;
using System.Collections.Generic;

namespace MVC_RabbitMQ.Controllers
{
    public class Repositories : Controller
    {
        private PangeaRepoDataContext _context;

        // ASP.NET dependency injection will passing an instance of PangeaRepoDataContext into your controller.
        public Repositories(PangeaRepoDataContext context)
        {
            _context = context;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            //  Get current list of repos
            List<MVC_RabbitMQ.Entity.RepoData> repoDataList = _context.RepoData.ToList();

            //  Final refactored list of repos
            List<MVC_RabbitMQ.DataModel.RepoData> refactorDataList = new List<MVC_RabbitMQ.DataModel.RepoData>();

            //  Go through each repo
            foreach (MVC_RabbitMQ.Entity.RepoData curRepoData in repoDataList)
            {
                //  Pull the Owner
                MVC_RabbitMQ.Entity.Owner curOwner = (from curOwn in _context.Owner
                                                      where curRepoData.OwnerId == curOwn.Id
                                                      select curOwn).FirstOrDefault();
                //  Pull the Permissions
                MVC_RabbitMQ.Entity.Permissions curPermissions = (from curPerm in _context.Permissions
                                                      where curRepoData.PermissionsId == curPerm.Id
                                                      select curPerm).FirstOrDefault();

                MVC_RabbitMQ.DataModel.RepoData refactorRepoData = new MVC_RabbitMQ.DataModel.RepoData(curRepoData, curOwner, curPermissions);
                refactorDataList.Add(refactorRepoData);

            }


            return View(refactorDataList);
        }
    }
}
