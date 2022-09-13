using System;


namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            var name = Console.ReadLine();

            Console.Write("What is your favorite food: ");
            var favoriteFood = Console.ReadLine();

            Console.Write("Where do you want to visit: ");
            var location = Console.ReadLine();

            Console.Write("What is your favorite activity: ");
            var activity = Console.ReadLine();

            StoryBuild(name, favoriteFood, location, activity);
        }

        public static void StoryBuild(string name, string food, string place, string passTime)
        {
            Console.WriteLine($"{name} travelled to {place} " +
                              $"to eat some {food} and do some {passTime}.");
        }
    }
}