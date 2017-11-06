namespace DecoratorAppliance.Decorator
{
    using Component;

    public class PizzaDecorator : Pizza
    {
        protected readonly Pizza Pizza;

        #region CONSTRUCTORS

        public PizzaDecorator(Pizza pizza)
        {
            Pizza = pizza;
        }

        #endregion

        public override string GetDescription()
        {
            return Pizza.Description;
        }

        public override double CalculateCost()
        {
            return Pizza.CalculateCost();
        }
    }
}