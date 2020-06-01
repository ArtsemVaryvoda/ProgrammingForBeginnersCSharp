using System;
using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace Dialog_Window_Version
{
    class Program
    {
        static void Main()
        {
            string month = Interaction.InputBox("Enter month");
            int daysinMonth = Int32.Parse(Interaction.InputBox("Enter number of days n month"));
            MessageBox.Show($"There are {daysinMonth} days in {month}."
                ,"Information about month"
                ,MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
