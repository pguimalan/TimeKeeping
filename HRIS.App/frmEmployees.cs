using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRIS.App
{
    public partial class frmEmployees : Form
    {
        public frmEmployees()
        {
            InitializeComponent();
        }

        private void bttnAdd_Click(object sender, EventArgs e)
        {
            frmEmployees_AE f = new frmEmployees_AE();
            this.Hide();
            f.ShowDialog();
        }
    }
}
