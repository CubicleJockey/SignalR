namespace Tutorial.Objects
{
    public class Chicken : IAnimal
    {
        #region Implementation of IAnimal

        public string Name => "Chicken";
        public int NumberOfLegs => 2;

        #endregion
    }
}