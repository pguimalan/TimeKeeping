using HRIS.Models;
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
    public partial class frmAddress : Form
    {
        private readonly IAddressService svc;

        public frmAddress(IAddressService svc)
        {
            this.svc = svc;
        }

        public frmAddress() : this(new AddressService())
        {
            InitializeComponent();
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMain f = new frmMain();
            f.ShowDialog();
        }

        private void ToolStripButton4_Click(object sender, EventArgs e)
        {
            frmAddress_AE f = new frmAddress_AE();
            f.ADD_STATE = true;
            f.button2.Text = "Save";
            f.ShowDialog();
            loadvars(f.strSearch);
        }

        private void ToolStripButton3_Click(object sender, EventArgs e)
        {
            frmAddress_AE f = new frmAddress_AE();
            f.ADD_STATE = true;
            f.button2.Text = "Update";
            f.ShowDialog();
            loadvars(f.strSearch);
        }

        private void loadvars(string txtSearch)
        {
            try
            {
                List<AddressForSelectModel> list = svc.AddressSelect(txtSearch);
                dgAddress.Rows.Clear();
                foreach (var li in list)
                {
                    dgAddress.Rows.Add(li.AddressId.ToString(), li.Barangay, li.Municipal_City, li.Province, li.Country, li.ZipCode);
                }
                if (list.Count >= 100)
                    MessageBox.Show("Search result is limited to 100 records only. Narrow your search for specific results.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error"); }
        }

        private void frmAddress_Load(object sender, EventArgs e)
        {
            loadvars("");
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            loadvars(TextBox1.Text);
        }
    }
}
