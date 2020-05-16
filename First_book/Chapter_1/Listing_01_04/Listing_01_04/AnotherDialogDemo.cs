using System.Windows.Forms;

namespace Listing_01_04
{
    class AnotherDialogDemo
    {
        static void Main()
        {
            //Displaying of the message
            MessageBox.Show("Hello everyone!", //Message
                "Funny name of the window",    //Name of the window
                MessageBoxButtons.OK,          //Button of the window
                MessageBoxIcon.Information);   //Actual icon
        }
    }
}
