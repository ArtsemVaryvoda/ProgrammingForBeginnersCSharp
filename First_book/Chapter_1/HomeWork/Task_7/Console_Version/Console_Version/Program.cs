using System;

namespace Console_Version
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter your age");
            int age = Int32.Parse(Console.ReadLine());
            int currentYear = DateTime.Now.Year;
            Console.WriteLine("You was born in {0}!", currentYear - age);
        }
    }
}
