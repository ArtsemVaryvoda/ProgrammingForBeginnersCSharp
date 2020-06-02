using System;
using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace Dialog_Window_Version
{
    class Program
    {
        static void Main()
        {
            string name = Interaction.InputBox("Enter your name");
            int yearOfBirth = Int32.Parse(Interaction.InputBox("Enter your year of birth"));
            int age = DateTime.Now.Year - yearOfBirth;
            MessageBox.Show($"Nice to meet you {name}, {age} years old"
                ,"User info"
                ,MessageBoxButtons.OK
                ,MessageBoxIcon.Information);
        }
    }
}
