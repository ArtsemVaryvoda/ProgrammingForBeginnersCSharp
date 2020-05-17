using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Listing_01_07
{
    class EnteringInteger
    {
        static void Main()
        {
            string input;
            int year = 2017, age, born;
            input = Interaction.InputBox("In which year you was born?", "Year of birth");
            born = Int32.Parse(input);
            age = year - born;
            MessageBox.Show($"Then your age is {age}","Actual age.");
        }
    }
}
