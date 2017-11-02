namespace DecoratorAppliance.ConcreteComponents
{
    using Component;

    public class SmallPizza : Pizza
    {
        #region CONSTRUCTORS

        public SmallPizza()
        {
            Description = "Small Pizza";
        }

        #endregion

        public override string GetDescription()
        {
            return Description;
        }

        public override double CalculateCost()
        {
            return 3.00;
        }
    }
}