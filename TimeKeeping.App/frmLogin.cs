using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeKeeping.App.Helpers;
using TimeKeeping.Services;
using TimeKeeping.Services.Interface;

namespace TimeKeeping.App
{
    public partial class frmLogin : Form
    {
        private readonly IUsersService svc;
        int counts;
        public frmLogin(IUsersService svc)
        {
            this.svc = svc;
        }

        public frmLogin() : this(new UsersService())
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
                int hasAccess = svc.Login(username, password);
                if (hasAccess <= 0)
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
                    frm.tssUsername = txtusername.Text;
                    var model = svc.SystemUser_SelectById(hasAccess);
                    GlobalSession.UserFullName = model.UserFullName;
                    GlobalSession.UserId = model.UserId;
                    frm.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Login failed");
            }
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.ExitThread();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmTimeKeeping f = new frmTimeKeeping();
            this.Hide();
            f.ShowDialog();
        }
    }
}
