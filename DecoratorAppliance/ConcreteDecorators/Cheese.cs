namespace DecoratorAppliance.ConcreteDecorators
{
    using Component;
    using Decorator;

    public class Cheese : PizzaDecorator
    {
        #region CONSTRUCTORS

        public Cheese(Pizza pizza)
            : base(pizza)
        {
            Description = "Cheese";
        }

        #endregion

        public override string GetDescription()
        {
            return $"{_pizza.GetDescription()}, {Description}";
        }

        public override double CalculateCost()
        {
            return _pizza.CalculateCost() + 1.25;
        }
    }
}