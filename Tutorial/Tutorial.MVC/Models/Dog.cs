namespace Tutorial.MVC.Models
{
    public class Dog : IAnimal
    {
        public string Name => "Dog";
        public int NumberOfLegs => 4;
    }
}