using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRIS.App.Helpers
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
    }
}
