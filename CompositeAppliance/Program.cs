namespace CompositeAppliance
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int goldForKill = 1023;

            Console.WriteLine($"You have killed the Giant IE6 Monster and gained {goldForKill} gold!");

            var joe = new Person { Name = "Joe" };
            var jake = new Person { Name = "Jake" };
            var emily = new Person { Name = "Emily" };
            var sophia = new Person { Name = "Sophia" };
            var brian = new Person { Name = "Brian" };
            var oldBob = new Person { Name = "Old Bob" };
            var newBob = new Person { Name = "New Bob" };

            var NoobPlayers = new Group
            {
                Members = { oldBob, newBob }
            };

            var ExperiencedPlayers = new Group
            {
                Name = "Developers",
                Members = { joe, jake, emily, NoobPlayers }
            };

            var TopPlayers = new Group
            {
                Members = { ExperiencedPlayers, sophia, brian }
            };

            TopPlayers.Gold += goldForKill;
            TopPlayers.Stats();

            Console.ReadKey();
        }
    }
}