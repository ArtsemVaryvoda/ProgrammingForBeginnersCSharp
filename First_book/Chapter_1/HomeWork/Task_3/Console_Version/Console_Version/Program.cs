using System;

namespace Console_Version
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please, enter current day of the week.");
            string dayName = Console.ReadLine();
            Console.WriteLine("Please, enter current month");
            string currentMonth = Console.ReadLine();
            Console.WriteLine("Please, input number of the day in month (It should be integer)");
            int dayNumber = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"Today is {dayName}, {dayNumber} of {currentMonth}.");
        }
    }
}
