using System.Collections.Generic;
using Microsoft.AspNet.SignalR;
using System.Web.Mvc;
using Tutorial.MVC.Models;
using Tutorial.MVC.SignalR.Hubs;

namespace Tutorial.MVC.Controllers
{
    /// <summary>
    /// Callilng this controller Index is used to simulate
    /// </summary>
    public class SendController : Controller 
    {
        private readonly IHubContext hubContext;

        public SendController()
        {
            hubContext = GlobalHost.ConnectionManager.GetHubContext<ComplexTypeHub>();
        }


        // GET: Send
        public ActionResult Index()
        {
            IList<IAnimal> animals = new IAnimal[2] {new Chicken(), new Dog()};
            hubContext.Clients.All.getAnimals(animals);
            return null;
        }
    }
}