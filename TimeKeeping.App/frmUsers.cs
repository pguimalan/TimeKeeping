using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeKeeping.Models;
using TimeKeeping.Services;
using TimeKeeping.Services.Interface;

namespace TimeKeeping.App
{
    public partial class frmUsers : Form
    {
        private readonly IUsersService svc;

        public frmUsers(IUsersService svc)
        {
            this.svc = svc;
        }

        public frmUsers() : this(new UsersService())
        {
            InitializeComponent();
        }

        private void bttnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
        }

        private void loadvars(string txtSearch)
        {
            try
            {
                List<UserForSelect> list = svc.SystemUser_Select(txtSearch);
                listView1.Items.Clear();
                if (list.Count >= 100)
                    MessageBox.Show("Search result is limited to 100 records only. Narrow your search for specific results.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                foreach (var li in list)
                {
                    ListViewItem lv = new ListViewItem(li.UserId.ToString());
                    lv.SubItems.Add(li.UserName);
                    lv.SubItems.Add(li.UserFullName);
                    lv.Font = new Font(lv.Font, FontStyle.Regular);
                    listView1.Items.AddRange(new ListViewItem[] { lv });
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error"); }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            loadvars(txtSearch.Text);
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            loadvars("");
        }

        private void bttnAdd_Click(object sender, EventArgs e)
        {
            frmUsers_AE frm = new frmUsers_AE();
            frm.ADD_STATE = true;
            frm.ShowDialog();
            loadvars("");
        }

        private void bttnEdit_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count < 1)
            {
                MessageBox.Show("Pls. Select an Item.", "Select Item", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                frmUsers_AE f = new frmUsers_AE();
                f.ADD_STATE = false;
                f.userId = int.Parse(listView1.SelectedItems[0].Text);                
                f.ShowDialog();
                loadvars("");
            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            bttnEdit.PerformClick();
        }
    }
}
