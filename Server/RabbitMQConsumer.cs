using RabbitMq.OneWayMessage.Receiver;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server
{
    public class RabbitMQConsumer : IDisposable
    {
        private const string HostName = "localhost";
        private const string UserName = "guest";
        private const string Password = "guest";
        private const string QueueName = "PangeaRepoQueue";
        //  Using the default exchange as this is empty
        private const string ExchangeName = "";
        //  Msg does not need to survive server reboot so set to false
        private const bool IsDurable = false;

        public bool Enabled { get; set; }

        private ConnectionFactory _connectionFactory;
        private IConnection _connection;
        private IModel _model;

        /// <summary>
        /// Constructor with a key to lookup the configuration
        /// </summary>
        public RabbitMQConsumer()
        {
            DisplaySettings();
            SetupRabbitMq();
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

            //  Quality of service :: 1 msg at a time
            _model.BasicQos(0, 1, false);
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
        /// Starts receiving a message from a queue
        /// </summary>
        public void Start()
        {
            //  Get an events consumer
            var consumer = new PangeaOneWayMessageReceiver(_model);

            //  No auto ack messages
            _model.BasicConsume(QueueName, false, consumer);
        }
        /// <summary>
        /// Dispose
        /// </summary>
        public void Dispose()
        {
            if (_model != null)
                _model.Dispose();
            if (_connection != null)
                _connection.Dispose();

            _connectionFactory = null;

            GC.SuppressFinalize(this);
        }
    }
}
 