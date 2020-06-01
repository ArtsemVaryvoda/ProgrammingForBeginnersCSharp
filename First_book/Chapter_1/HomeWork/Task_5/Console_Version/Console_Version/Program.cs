using System;

namespace Console_Version
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter your age of birth (it should be number)");
            int yearOfBirth = Int32.Parse(Console.ReadLine());
            Console.WriteLine("You was born in {0}, current year is {1}, and your age is {2}",yearOfBirth, DateTime.Now.Year, DateTime.Now.Year - yearOfBirth);
        }
    }
}
