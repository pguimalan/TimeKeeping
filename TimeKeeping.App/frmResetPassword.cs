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
using TimeKeeping.Models;
using TimeKeeping.Services;
using TimeKeeping.Services.Interface;

namespace TimeKeeping.App
{
    public partial class frmResetPassword : Form
    {
        private readonly IUsersService svc;

        public frmResetPassword(IUsersService svc)
        {
            this.svc = svc;
        }

        public frmResetPassword() : this(new UsersService())
        {
            InitializeComponent();
        }

        private void btnOkay_Click(object sender, EventArgs e)
        {
            if (Validation.IsTextEmpty(txtusername))
                Validation.FocusTextBox(txtusername, "User Name");
            else if (Validation.IsTextEmpty(txtPassword))
                Validation.FocusTextBox(txtPassword, "User Password");
            else if (Validation.IsTextEmpty(txtNewPassword))
                Validation.FocusTextBox(txtNewPassword, "New Password");
            else if (txtNewPassword.Text.Length < 8)
            {
                ShowMessage.CustomErrorMessage("New Password must contain a minimum of 8 characters.");
                txtNewPassword.Focus();
            }
            else if (Validation.IsTextEmpty(txtConfirmPassword))
            {
                Validation.FocusTextBox(txtConfirmPassword, "Confirm Password");
                txtConfirmPassword.Focus();
            }
            else if (txtNewPassword.Text != txtConfirmPassword.Text)
                ShowMessage.CustomErrorMessage("New Passwordand Confirm Password does not match.");
            else
            {
                var login = svc.Login(txtusername.Text, txtPassword.Text);
                if (login > 0)
                {
                    svc.SystemUser_ResetPassword(new UserForResetPassword { UserId = login, strPassword = txtNewPassword.Text });
                    ShowMessage.CustomEUpdateMessage("Password successfully changed.");
                    this.Close();
                }
                else
                {
                    ShowMessage.CustomErrorMessage("Invalid credentials. Password change failed.");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmResetPassword_Load(object sender, EventArgs e)
        {
            txtPassword.Focus();
        }
    }
}
