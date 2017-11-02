namespace DecoratorAppliance.ConcreteDecorators
{
    using Component;
    using Decorator;

    public class Ham : PizzaDecorator
    {
        #region CONSTRUCTORS

        public Ham(Pizza pizza)
            : base(pizza)
        {
            Description = "Ham";
        }

        #endregion

        public override string GetDescription()
        {
            return $"{_pizza.GetDescription()}, {Description}";
        }

        public override double CalculateCost()
        {
            return _pizza.CalculateCost() + 1.00;
        }
    }
}