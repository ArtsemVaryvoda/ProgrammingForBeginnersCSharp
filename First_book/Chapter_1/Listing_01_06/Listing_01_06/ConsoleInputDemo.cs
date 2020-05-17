using System;

namespace Listing_01_06
{
    class ConsoleInputDemo
    {
        static void Main()
        {
            string name;
            Console.Title = "Let's meet each other";
            Console.Write("What is your name?");
            name = Console.ReadLine();
            Console.Title = "Meeting completed!";
            Console.WriteLine($"Nice to meet ya, {name}");
        }
    }
}
