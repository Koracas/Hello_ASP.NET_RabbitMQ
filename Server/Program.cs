using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //  Start queue processor
            Console.WriteLine("Starting RabbitMQ Pangea queue processor");
            
            var queueProcessor = new RabbitMQConsumer() { Enabled = true };
            queueProcessor.Start();
            Console.ReadLine();
        }
    }
}
