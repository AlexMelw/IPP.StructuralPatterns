namespace DecoratorAppliance.ConcreteDecorators
{
    using Component;
    using Decorator;

    public class Peppers : PizzaDecorator
    {
        #region CONSTRUCTORS

        public Peppers(Pizza pizza)
            : base(pizza) => Description = "Peppers";

        #endregion

        public override string GetDescription()
        {
            return $"{Pizza.GetDescription()}, {Description}";
        }

        public override double CalculateCost()
        {
            return Pizza.CalculateCost() + 2.00;
        }
    }
}