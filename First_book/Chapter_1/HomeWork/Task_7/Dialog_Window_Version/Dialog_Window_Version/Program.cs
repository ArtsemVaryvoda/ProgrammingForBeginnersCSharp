using System;
using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace Dialog_Window_Version
{
    class Program
    {
        static void Main()
        {
            int age = Int32.Parse(Interaction.InputBox("Enter your age"));
            MessageBox.Show($"You was born in {DateTime.Now.Year - age}"
                , "User year of birth"
                , MessageBoxButtons.OK
                , MessageBoxIcon.Information);
        }
    }
}
