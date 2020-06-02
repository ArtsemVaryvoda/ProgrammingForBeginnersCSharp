using System;
using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace Dialog_Window_Version
{
    class Program
    {
        static void Main()
        {
            int number = Int32.Parse(Interaction.InputBox("Enter number wich should be incrementer and decrementer"));
            MessageBox.Show($"Sequence of numbers related for this task will be {number - 1}, {number} and {number + 1}."
                ,"Numbers sequence"
                ,MessageBoxButtons.OK
                ,MessageBoxIcon.Information);
        }
    }
}
