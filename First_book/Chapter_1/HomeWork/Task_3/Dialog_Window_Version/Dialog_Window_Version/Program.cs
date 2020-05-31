using System;
using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace Dialog_Window_Version
{
    class Program
    {
        private static void Main()
        {
            string dayOfTheWeek = Interaction.InputBox("Please, enter current day of the week");
            string monthName = Interaction.InputBox("Please, enter current month");
            int dayNumber = Int32.Parse(Interaction.InputBox("Please, enter current day of the month"));
            MessageBox.Show($"Today is {dayOfTheWeek}, {dayNumber} of {monthName}"
                , "Today's date"
                , MessageBoxButtons.OK
                , MessageBoxIcon.Information);
        }
    }
}
