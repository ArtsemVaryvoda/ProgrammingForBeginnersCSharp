using System;

namespace Console_Version
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter month");
            string month = Console.ReadLine();
            Console.WriteLine("Enter number of days in month.");
            int daysInMonth = Int32.Parse(Console.ReadLine());
            Console.WriteLine("There are {0} days in {1}",daysInMonth,month);
        }
    }
}
