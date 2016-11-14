using System.Collections.Generic;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using Tutorial.Objects;

namespace Tutorial.Hubs
{
    [HubName("animal")]
    public class ComplexTypeHub : Hub
    {
        public IEnumerable<IAnimal> showAnimals()
        {
            return new IAnimal[]
            {
                new Dog(), new Chicken(), 
                new Chicken(), new Dog()
            };
        }
    }
}