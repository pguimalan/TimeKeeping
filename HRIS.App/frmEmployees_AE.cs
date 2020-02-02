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
    }
}
