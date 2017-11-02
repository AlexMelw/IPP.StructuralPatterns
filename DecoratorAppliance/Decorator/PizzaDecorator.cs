namespace DecoratorAppliance.Decorator
{
    using Component;

    public class PizzaDecorator : Pizza
    {
        protected Pizza _pizza;

        #region CONSTRUCTORS

        public PizzaDecorator(Pizza pizza)
        {
            _pizza = pizza;
        }

        #endregion

        public override string GetDescription()
        {
            return _pizza.Description;
        }

        public override double CalculateCost()
        {
            return _pizza.CalculateCost();
        }
    }
}