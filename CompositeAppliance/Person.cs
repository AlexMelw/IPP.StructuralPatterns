namespace CompositeAppliance
{
    using System;

    public class Person : IPerson
    {
        public string Name { get; set; }
        public int Gold { get; set; }

        public void Stats()
        {
            Console.WriteLine($"{Name} has {Gold} gold coins.");
        }
    }
}