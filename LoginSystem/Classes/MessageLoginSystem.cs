using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginSystem.Classes
{
    internal class MessageLoginSystem
    {
        internal static void ShowMessage(string message, string title)
        {
            MessageBox.Show(message, title);
        }
    }
}
