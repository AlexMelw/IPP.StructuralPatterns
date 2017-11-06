namespace DecoratorAppliance.ConcreteDecorators
{
    using Component;
    using Decorator;

    public class Cheese : PizzaDecorator
    {
        #region CONSTRUCTORS

        public Cheese(Pizza pizza)
            : base(pizza) => Description = "Cheese";

        #endregion

        public override string GetDescription()
        {
            return $"{Pizza.GetDescription()}, {Description}";
        }

        public override double CalculateCost()
        {
            return Pizza.CalculateCost() + 1.25;
        }
    }
}