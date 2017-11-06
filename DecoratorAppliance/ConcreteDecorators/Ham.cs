namespace DecoratorAppliance.ConcreteDecorators
{
    using Component;
    using Decorator;

    public class Ham : PizzaDecorator
    {
        #region CONSTRUCTORS

        public Ham(Pizza pizza)
            : base(pizza) => Description = "Ham";

        #endregion

        public override string GetDescription()
        {
            return $"{Pizza.GetDescription()}, {Description}";
        }

        public override double CalculateCost()
        {
            return Pizza.CalculateCost() + 1.00;
        }
    }
}