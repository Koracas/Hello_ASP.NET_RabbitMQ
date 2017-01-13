using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_RabbitMQ.Controllers.RabbitMQShared
{
    public class RabbitMQSender : IDisposable
    {
        private const string HostName = "localhost";
        private const string UserName = "guest";
        private const string Password = "guest";
        private const string QueueName = "PangeaRepoQueue";
        //  Using the default exchange as this is empty
        private const string ExchangeName = "";
        //  Msg does not need to survive server reboot so set to false
        private const bool IsDurable = false;

        private ConnectionFactory _connectionFactory;
        private IConnection _connection;
        private IModel _model;

        //
        //  Constructor
        //
        public RabbitMQSender()
        {
            DisplaySettings();
            SetupRabbitMq();
        }

        //
        //  Write the settings of the RabbitMQ connection
        //
        private void DisplaySettings()
        {
            Console.WriteLine("Host: {0}", HostName);
            Console.WriteLine("Username: {0}", UserName);
            Console.WriteLine("Password: {0}", Password);
            Console.WriteLine("QueueName: {0}", QueueName);
            Console.WriteLine("ExchangeName: {0}", ExchangeName);
            Console.WriteLine("Is Durable: {0}", IsDurable);
        }
        /// <summary>
        /// Sets up the connections for rabbitMQ
        /// </summary>
        private void SetupRabbitMq()
        {
            //  Instantiate connection factory to access rabbitMQ
            _connectionFactory = new ConnectionFactory
            {
                HostName = HostName,
                UserName = UserName,
                Password = Password
            };

            //  Create a connection
            _connection = _connectionFactory.CreateConnection();

            //  Create the model object
            _model = _connection.CreateModel();         
        }

        //
        //  Run time creation and binding of queue and exchange
        //
        private void SetupServer_Runtime()
        {
           if( _model != null )
            {
                //  Create the queue in runtime
                _model.QueueDeclare("PangeaRepoQueue", false, false, false, null);
                Console.WriteLine("Queue Created.");

                //  Create the exchange in runtime
                _model.ExchangeDeclare("PangeaRepoExchange", ExchangeType.Topic);
                Console.WriteLine("Exhcnage Created.");

                //  Bind the queue and exchange at runtime
                _model.QueueBind("PangeaRepoQueue", "PangeaRepoExchange", "PangeaData");
                Console.WriteLine("Exchange and queue bound.");
            }
        }

        //
        //  Used to send a string message
        //
        public void Send(string message)
        {
            //  Properties which will be used on our message
            var properties = _model.CreateBasicProperties();

            //  Msg does not need to survive server reboot so set to false
            properties.Persistent = false;

            //  Serialize the message to a byte array
            byte[] msgBuffer = Encoding.ASCII.GetBytes(message);

            //Send message
            _model.BasicPublish(ExchangeName, QueueName, properties, msgBuffer);
        }

        //
        //  Clean up
        //
        public void Dispose()
        {
            //  Close the connection
            if (_connection != null)
                _connection.Close();
            
            //  Abort the model
            if (_model != null && _model.IsOpen)
                _model.Abort();

            //  Set hte connection factory to null
            _connectionFactory = null;

            //  Garbage collect
            GC.SuppressFinalize(this);
        }
    }
}
