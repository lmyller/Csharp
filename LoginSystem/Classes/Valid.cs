using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginSystem.Classes
{
    internal class Valid
    {
        internal static bool IsEmptyTextBox(TextBox textBox)
        {
            return string.IsNullOrEmpty(textBox.Text);
        }

        internal static bool isEqual(string string1, string string2)
        {
            return string1.Equals(string2);
        }
    }
}
