using System;

namespace OurDotnetApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I was just created!");
            Console.WriteLine("What's your name? ");
            var name = Console.ReadLine();
            Console.WriteLine($"It is neat to meet you {name}, " + "I am Melissa's Creation! ");

        }
    }
}
