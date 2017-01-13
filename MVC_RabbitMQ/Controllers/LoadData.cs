using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RabbitMQ.Client;
using System.Text;
using MVC_RabbitMQ.Controllers.RabbitMQShared;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MVC_RabbitMQ.Controllers
{
    public class LoadData : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            //  Instantiate the RabbitMQ sender
            var sender = new RabbitMQSender();

            //  Send "Load Data"
            sender.Send("Load Data");

            



            return View();
        }
    }
}
