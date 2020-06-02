using System;

namespace Console_Version
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter first number.");
            int firstNumber = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number.");
            int secondNumber = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"Sum of this numbers will be {firstNumber + secondNumber}, and result of their substraction will be {firstNumber - secondNumber}");
        }
    }
}
