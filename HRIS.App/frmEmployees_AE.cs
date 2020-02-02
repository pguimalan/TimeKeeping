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
    public partial class frmEmployees_AE : Form
    {
        public frmEmployees_AE()
        {
            InitializeComponent();
        }

        private void bttnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEmployees f = new frmEmployees();           
            f.ShowDialog();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtCurrentAddress1.Text = txtResidentialAddress1.Text;
                txtCurrentAddress2.Text = txtResidentialAddress2.Text;
            }
            else
            {
                txtCurrentAddress1.Clear();
                txtCurrentAddress2.Text = "";
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

        private void cmbCivilStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCivilStatus.Text != "Single")
            {
                txtSpouseName.Enabled = true;
                txtSpouseName.Text = "";
                txtSpouseOccupation.Enabled = true;
                txtSpouseOccupation.Text = "";
                dtSpouseBdate.Enabled = true;
            }
            else
            {
                txtSpouseName.Enabled = false;
                txtSpouseName.Text = "N/A";
                txtSpouseOccupation.Enabled = false;
                txtSpouseOccupation.Text = "N/A";
                dtSpouseBdate.Enabled = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                txtParentAddress1.Text = txtResidentialAddress1.Text;
                txtParentAddress2.Text = txtResidentialAddress2.Text;
            }
            else
            {
                txtParentAddress1.Clear();
                txtParentAddress2.Text = "";
            }
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tabControl1.SelectedIndex = 3;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmAddress f = new frmAddress
            {
                IsSelectAddress = true
            };
            f.ShowDialog();
            txtResidentialAddress2.Text = f.strAddressSelected;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAddress f = new frmAddress
            {
                IsSelectAddress = true
            };
            f.ShowDialog();
            txtCurrentAddress2.Text = f.strAddressSelected;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmAddress f = new frmAddress
            {
                IsSelectAddress = true
            };
            f.ShowDialog();
            txtParentAddress2.Text = f.strAddressSelected;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmAddress f = new frmAddress
            {
                IsSelectAddress = true
            };
            f.ShowDialog();
            txtContactPersonAddress2.Text = f.strAddressSelected;
        }

        private void txtLastName_Leave(object sender, EventArgs e)
        {
            StringHelper.UppercaseFirst(txtLastName);
        }

        private void txtFirstName_Leave(object sender, EventArgs e)
        {
            StringHelper.UppercaseFirst(txtFirstName);
        }

        private void txtMiddleName_Leave(object sender, EventArgs e)
        {
            StringHelper.UppercaseFirst(txtMiddleName);
        }

        private void txtPlaceOfBirth_Leave(object sender, EventArgs e)
        {
            StringHelper.UppercaseFirst(txtPlaceOfBirth);
        }

        private void txtResidentialAddress1_Leave(object sender, EventArgs e)
        {
            StringHelper.UppercaseFirst(txtResidentialAddress1);
        }

        private void txtCurrentAddress1_Leave(object sender, EventArgs e)
        {
            StringHelper.UppercaseFirst(txtCurrentAddress1);
        }

        private void txtElementary_Leave(object sender, EventArgs e)
        {
            StringHelper.UppercaseFirst(txtElementary);
        }

        private void txtHighSchool_Leave(object sender, EventArgs e)
        {
            StringHelper.UppercaseFirst(txtHighSchool);
        }

        private void txtVocational_Leave(object sender, EventArgs e)
        {
            StringHelper.UppercaseFirst(txtVocational);
        }

        private void txtCollege_Leave(object sender, EventArgs e)
        {
            StringHelper.UppercaseFirst(txtCollege);
        }

        private void txtSpouseName_Leave(object sender, EventArgs e)
        {
            StringHelper.UppercaseFirst(txtSpouseName);
        }

        private void txtSpouseOccupation_Leave(object sender, EventArgs e)
        {
            StringHelper.UppercaseFirst(txtSpouseOccupation);
        }

        private void txtFatherName_Leave(object sender, EventArgs e)
        {
            StringHelper.UppercaseFirst(txtFatherName);
        }

        private void txtFatherOccupation_Leave(object sender, EventArgs e)
        {
            StringHelper.UppercaseFirst(txtFatherOccupation);
        }

        private void txtMotherName_Leave(object sender, EventArgs e)
        {
            StringHelper.UppercaseFirst(txtMotherName);
        }

        private void txtMotherOccupation_Leave(object sender, EventArgs e)
        {
            StringHelper.UppercaseFirst(txtMotherOccupation);
        }

        private void txtParentAddress1_Leave(object sender, EventArgs e)
        {
            StringHelper.UppercaseFirst(txtParentAddress1);
        }

        private void txtContactPersonName_Leave(object sender, EventArgs e)
        {
            StringHelper.UppercaseFirst(txtContactPersonName);
        }

        private void txtContactPersonAddress1_Leave(object sender, EventArgs e)
        {
            StringHelper.UppercaseFirst(txtContactPersonAddress1);
        }

        private void txtCharRefFullName1_Leave(object sender, EventArgs e)
        {
            StringHelper.UppercaseFirst(txtCharRefFullName1);
        }

        private void txtCharRefFullName2_Leave(object sender, EventArgs e)
        {
            StringHelper.UppercaseFirst(txtCharRefFullName2);
        }

        private void txtCharRefFullName3_Leave(object sender, EventArgs e)
        {
            StringHelper.UppercaseFirst(txtCharRefFullName3);
        }
    }
}
