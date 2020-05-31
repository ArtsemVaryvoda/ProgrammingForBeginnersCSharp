using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;

namespace Dialog_Window_Version
{
    class Program
    {
        static void Main()
        {
            string name = Interaction.InputBox("What is your name?");
            int age = Int32.Parse(Interaction.InputBox("What is your age?"));
            MessageBox.Show($"Your name is {name} and you are {age} years old."
                ,"Result"
                ,MessageBoxButtons.OK
                ,MessageBoxIcon.Information);
        }        
    }
}
