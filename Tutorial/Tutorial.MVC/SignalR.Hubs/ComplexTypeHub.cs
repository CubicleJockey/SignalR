using System.Collections.Generic;
using Microsoft.AspNet.SignalR;
using Tutorial.MVC.Models;

namespace Tutorial.MVC.SignalR.Hubs
{
    public class ComplexTypeHub : Hub
    {
        public void ListAnimals()
        {
            Clients.All.getAnimals(GetAnimals());
        }

        public IEnumerable<IAnimal> SuperList()
        {
            var result = new List<IAnimal>();
            result.AddRange(GetAnimals());
            result.AddRange(GetAnimals());
            result.AddRange(GetAnimals());
            result.AddRange(GetAnimals());
            return result;
        } 

        private static IEnumerable<IAnimal> GetAnimals()
        {
            return new IAnimal[]
            {
                new Dog(), new Chicken(), new Dog(), new Chicken(), new Chicken()
            };
        }

    }
}