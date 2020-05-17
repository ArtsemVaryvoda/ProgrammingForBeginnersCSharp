using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;

namespace DialogWindowsVersion
{
    class NameSurnameDemo
    {
        static void Main()
        {
            string name, surname;
            name = Interaction.InputBox("Please, enter your name.",
                "Window for name input");
            surname = Interaction.InputBox("Please, enter your surname.",
                "Window for surname input");
            MessageBox.Show($"Hello, {surname} {name}!",
                "Welcome window",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
