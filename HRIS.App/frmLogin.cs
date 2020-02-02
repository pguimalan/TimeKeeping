using HRIS.App.Helpers;
using HRIS.Services;
using HRIS.Services.Interface;
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
        private readonly IAuthService svc;
        int counts;

        public frmLogin(IAuthService svc)
        {
            this.svc = svc;
        }

        public frmLogin() : this(new AuthService())
        {
            InitializeComponent();
            counts = 3;
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
            try
            {
                bool hasAccess = svc.Login(username, password);
                if (!hasAccess)
                {
                    counts--;
                    MessageBox.Show("Invalid username or password.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (counts == 0)
                    {
                        MessageBox.Show("You have entered invalid username and password 3 times.", "Exit", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Application.ExitThread();
                    }
                }
                else
                {
                    MessageBox.Show("Welcome " + username + "!", "Access Granted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmMain frm = new frmMain();

                    frm.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Login failed");
            }
        }
    }
}
