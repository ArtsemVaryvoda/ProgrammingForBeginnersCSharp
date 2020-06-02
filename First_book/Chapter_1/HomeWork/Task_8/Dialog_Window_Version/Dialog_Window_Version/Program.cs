using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Dialog_Window_Version
{
    class Program
    {
        static void Main()
        {
            int firstNumber = Int32.Parse(Interaction.InputBox("Enter first number."));
            int secondNumber = Int32.Parse(Interaction.InputBox("Enter second number."));
            MessageBox.Show($"Sum of first and second number will be {firstNumber + secondNumber}"
                ,"Sum of numbers"
                ,MessageBoxButtons.OK
                ,MessageBoxIcon.Information);
        }
    }
}
