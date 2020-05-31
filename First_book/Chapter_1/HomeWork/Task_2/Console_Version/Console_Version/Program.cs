using System;

namespace Console_Version
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please, enter your age. Age should be number");
            int age = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please, enter your name");
            string name = Console.ReadLine();
            Console.WriteLine($"Your name is {name}, and you're {age} years old");
        }
    }
}
