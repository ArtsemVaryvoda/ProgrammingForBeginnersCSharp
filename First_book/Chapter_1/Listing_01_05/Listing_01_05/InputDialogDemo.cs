using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace Listing_01_05
{
    class InputDialogDemo
    {
        static void Main()
        {
            string name;
            name = Interaction.InputBox(
                "What is your name?",
                "Let's know each other!"
                );
            MessageBox.Show($"Nice to meet you {name}", "Meeting Completed");
        }
    }
}
