using System.Windows.Forms;
using System.Drawing;

namespace HRIS.App.Helpers
{
    class Validation
    {
        public Validation()
        {

        }

        public static bool IsTextEmpty(TextBox txt)
        {
            if (txt.Text == string.Empty)
                return true;

            txt.BackColor = Color.White;
            txt.ForeColor = Color.Black;
            return false;
        }

        public static bool IsComboEmpty(ComboBox txt)
        {
            if (txt.Text == string.Empty)
                return true;

            txt.BackColor = Color.White;
            txt.ForeColor = Color.Black;
            return false;
        }

        public static void FocusComboBox(ComboBox txt, string sLabel)
        {
            MessageBox.Show(sLabel + " is empty. Pls check the field.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txt.BackColor = Color.Yellow;
            txt.ForeColor = Color.Red;
            txt.DroppedDown = true;

        }

        public static void FocusTextBox(TextBox txt, string sLabel)
        {
            MessageBox.Show(sLabel + " is empty. Pls check the field.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txt.BackColor = Color.Yellow;
            txt.ForeColor = Color.Red;
            txt.Focus();
        }
    }
}
