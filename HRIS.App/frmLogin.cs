using HRIS.App.Helpers;
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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOkay_Click(object sender, EventArgs e)
        {
            if (Validation.IsTextEmpty(txtusername))
                Validation.FocusTextBox(txtusername, "User Name");
            else if (Validation.IsTextEmpty(txtPassword))
                Validation.FocusTextBox(txtPassword, "Password");
            else
                Login(txtusername.Text, txtPassword.Text);
        }

        void Login(string username, string password)
        {
            this.Hide();
            frmMain f = new frmMain();
            f.ShowDialog();
        }
    }
}
