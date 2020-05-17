using System;

namespace ConsoleVersion
{
    class NameSurnameConsoleDemo
    {
        static void Main(string[] args)
        {
            string name, surname;
            Console.WriteLine("Please, enter your name");
            name = Console.ReadLine();
            Console.WriteLine("Please, enter your surname");
            surname = Console.ReadLine();
            Console.WriteLine($"Nice to meet you, {surname} {name}!");
        }
    }
}
