using System;

namespace Console_Version
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter first number");
            int firstNumber = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int secondNumber = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Sum of the first and second number will be {0}.", firstNumber + secondNumber);
        }
    }
}
