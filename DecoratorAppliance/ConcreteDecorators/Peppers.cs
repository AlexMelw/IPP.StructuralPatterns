namespace DecoratorAppliance.ConcreteDecorators
{
    using Component;
    using Decorator;

    public class Peppers : PizzaDecorator
    {
        #region CONSTRUCTORS

        public Peppers(Pizza pizza)
            : base(pizza)
        {
            Description = "Peppers";
        }

        #endregion

        public override string GetDescription()
        {
            return string.Format("{0}, {1}", _pizza.GetDescription(), Description);
        }

        public override double CalculateCost()
        {
            return _pizza.CalculateCost() + 2.00;
        }
    }
}