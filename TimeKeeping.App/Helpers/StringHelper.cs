using System.Globalization;
using System.Windows.Forms;

namespace TimeKeeping.App.Helpers
{
    class StringHelper
    {
        public StringHelper()
        {

        }

        public static void UppercaseFirst(TextBox txt)
        {
            txt.Text = CultureInfo.InvariantCulture.TextInfo.ToTitleCase(txt.Text);
        }

        public static void NumbersOnly(string str, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == '.')) { e.Handled = true; }

            if (e.KeyChar == '.' && str.Contains("."))
            {
                e.Handled = true;
            }
        }

        public static void FormatAmountNumber(TextBox txt)
        {
            txt.Text = decimal.Parse(txt.Text).ToString("#,####.00");
        }
    }
}
