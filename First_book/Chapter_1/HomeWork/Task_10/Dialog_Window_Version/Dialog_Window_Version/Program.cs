using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;

namespace Dialog_Window_Version
{
    class Program
    {
        static void Main()
        {
            int firstNumber = Int32.Parse(Interaction.InputBox("Enter first number"));
            int secondNumber = Int32.Parse(Interaction.InputBox("Enter second number"));
            MessageBox.Show($"Sum of these numbers will be {firstNumber + secondNumber}, and the result of their substraction will be {firstNumber - secondNumber}.");
        }
    }
}
