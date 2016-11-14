namespace Tutorial.Objects
{
    public class Dog : IAnimal
    {
        #region Implementation of IAnimal

        public string Name => "Dog";
        public int NumberOfLegs => 4;

        #endregion
    }
}