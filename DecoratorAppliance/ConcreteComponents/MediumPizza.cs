namespace DecoratorAppliance.ConcreteComponents
{
    using Component;

    public class MediumPizza : Pizza
    {
        #region CONSTRUCTORS

        public MediumPizza()
        {
            Description = "Medium Pizza";
        }

        #endregion

        public override string GetDescription()
        {
            return Description;
        }

        public override double CalculateCost()
        {
            return 6.00;
        }
    }
}