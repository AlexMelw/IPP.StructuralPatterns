namespace DecoratorAppliance.ConcreteComponents
{
    using Component;

    public class LargePizza : Pizza
    {
        #region CONSTRUCTORS

        public LargePizza()
        {
            Description = "Large Pizza";
        }

        #endregion

        public override string GetDescription()
        {
            return Description;
        }

        public override double CalculateCost()
        {
            return 9.00;
        }
    }
}