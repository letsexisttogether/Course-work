using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnterProcessHelpful
{
    public static class PasswordProcessor
    {
        static public void AsterixsReplace(RichTextBox passwordBox, StringBuilder password)
        {
            if (passwordBox.Text.Length == 0)
            {
                return;
            }

            Char lastSymbol = passwordBox.Text.Last();

            password.Append(lastSymbol);
            passwordBox.Text = passwordBox.Text.Replace(lastSymbol, '*');
            passwordBox.SelectionStart = passwordBox.Text.Length;
        }

        static public void NewSymbolHandle(RichTextBox passwordBox, StringBuilder password)
        {
            if (passwordBox.Text.Length == 0)
            {
                password.Clear();
            }

            if (passwordBox.Text.Length < password.Length)
            {
                PasswordProcessor.EraseHandle(password);
            }
            else
            {
                PasswordProcessor.AsterixsReplace(passwordBox, password);
            }
        }

        static public void EraseHandle(StringBuilder password)
        {
            password.Remove(password.Length - 1, 1);   
        }
    }
}
