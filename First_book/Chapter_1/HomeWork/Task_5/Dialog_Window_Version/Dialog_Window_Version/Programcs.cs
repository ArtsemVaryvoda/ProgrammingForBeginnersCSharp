using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Dialog_Window_Version
{
    class Programcs
    {
        static void Main()
        {
            int yearOfBirth = Int32.Parse(Interaction.InputBox("Please, enter your year of birth"));
            MessageBox.Show($"Your age is {DateTime.Now.Year - yearOfBirth}."
                ,"User age"
                ,MessageBoxButtons.OK
                ,MessageBoxIcon.Information);
        }
    }
}
