using System;

namespace Console_Version
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your year of birth.");
            int yearOfBirth = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"Nice to meet you {name}, {DateTime.Now.Year - yearOfBirth} years old.");
        }
    }
}
