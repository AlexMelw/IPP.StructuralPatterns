namespace DecoratorAppliance
{
    using System;
    using System.Globalization;
    using Component;
    using ConcreteComponents;
    using ConcreteDecorators;

    class Program
    {
        static void Main(string[] args)
        {
            Pizza largePizza = new LargePizza();
            largePizza = new Cheese(largePizza);
            largePizza = new Ham(largePizza);
            largePizza = new Peppers(largePizza);

            Console.WriteLine($"{largePizza.GetDescription()}.");

            Console.WriteLine($@"Total cost: {
                    largePizza.CalculateCost().ToString("C2", CultureInfo.CreateSpecificCulture("en-us"))
                }");

            Console.ReadKey();
        }
    }
}