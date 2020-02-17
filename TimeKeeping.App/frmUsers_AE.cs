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
    public partial class frmUsers_AE : Form
    {
        public bool ADD_STATE;
        public int userId;

        private readonly IUsersService svc;

        public frmUsers_AE(IUsersService svc)
        {
            this.svc = svc;
        }

        public frmUsers_AE() : this(new UsersService())
        {
            InitializeComponent();
            ADD_STATE = true;
            userId = 0;
        }

        private void bttnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bttnSave_Click(object sender, EventArgs e)
        {
            int result;
            if (Validation.IsTextEmpty(txtFirstName))
            {
                Validation.FocusTextBox(txtMiddleName, "First Name");
            }
            else if (Validation.IsTextEmpty(txtMiddleName))
            {
                Validation.FocusTextBox(txtMiddleName, "Middle Name");
            }
            else if (Validation.IsTextEmpty(txtLastName))
            {
                Validation.FocusTextBox(txtLastName, "Last Name");
            }
            else if (Validation.IsTextEmpty(txtUserName))
            {
                Validation.FocusTextBox(txtUserName, "Username");
            }
            else
            {
                if (ADD_STATE == true)
                {
                    result = svc.SystemUser_Insert(new UserModel
                    {
                        FirstName = txtFirstName.Text,
                        MiddleName = txtMiddleName.Text,
                        LastName = txtLastName.Text,
                        UserName = txtUserName.Text
                    });
                    if (result > 0)
                    {
                        ShowMessage.ShowMessageBox(1);
                    }
                    else if (result == -1)
                        ShowMessage.ShowMessageBox(4);
                    else
                        ShowMessage.ShowMessageBox(3);
                }
                else
                {
                    svc.SystemUser_Update(new UserModel
                    {
                        UserId = userId,
                        FirstName = txtFirstName.Text,
                        MiddleName = txtMiddleName.Text,
                        LastName = txtLastName.Text,
                        UserName = txtUserName.Text
                    });
                    ShowMessage.ShowMessageBox(1);
                }
                this.Close();             
            }
        }

        private void frmUsers_AE_Load(object sender, EventArgs e)
        {
            if(!ADD_STATE && userId > 0)
            {
                UserModel u = svc.SystemUser_SelectById(userId);
                txtFirstName.Text = u.FirstName;
                txtLastName.Text = u.LastName;
                txtMiddleName.Text = u.MiddleName;
                txtUserName.Text = u.UserName;
                bttnSave.Text = "Edit Item";
                button1.Visible = true;
            }
        }

        private void txtFirstName_Leave(object sender, EventArgs e)
        {
            StringHelper.UppercaseFirst(txtFirstName);
        }

        private void txtMiddleName_Leave(object sender, EventArgs e)
        {
            StringHelper.UppercaseFirst(txtMiddleName);
        }

        private void txtLastName_Leave(object sender, EventArgs e)
        {
            StringHelper.UppercaseFirst(txtLastName);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            svc.SystemUser_ResetPassword(new UserForResetPassword { UserId = userId, strPassword = "12345678" });
            MessageBox.Show("Password successfully reset to default password.","Reset", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
