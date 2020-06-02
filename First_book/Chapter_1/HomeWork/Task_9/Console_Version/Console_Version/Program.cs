using System;

namespace Console_Version
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter number which will be incremented and decremented.");
            int number = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"The sequence of numbers related for this task will be: {number - 1}, {number} and {number + 1}.");
        }
    }
}
