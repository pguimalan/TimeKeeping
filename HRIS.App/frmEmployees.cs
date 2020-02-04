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
    public partial class frmEmployees : Form
    {
        private readonly IEmployeeService svc;

        public frmEmployees(IEmployeeService svc)
        {
            this.svc = svc;
        }

        public frmEmployees() :this(new EmployeeService())
        {
            InitializeComponent();
        }

        private void bttnAdd_Click(object sender, EventArgs e)
        {
            frmEmployees_AE f = new frmEmployees_AE();
            f.ADD_STATE = true;
            this.Hide();
            f.ShowDialog();
        }

        private void loadvars(string txtSearch)
        {
            try
            {
                List<EmployeeForSelectModel> list = svc.Employee_Select(txtSearch);
                listView1.Items.Clear();
                if (list.Count >= 100)
                    MessageBox.Show("Search result is limited to 100 records only. Narrow your search for specific results.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                foreach (var li in list)
                {
                    ListViewItem lv = new ListViewItem(li.EmployeeId.ToString());
                    lv.SubItems.Add(li.EmployeeIDNumber);
                    lv.SubItems.Add(string.Concat(li.EmployeeFullName," ", li.Suffix));
                    lv.SubItems.Add(li.Designation);
                    lv.SubItems.Add(li.ContactNumbers);
                    lv.SubItems.Add(li.Department);
                    listView1.Items.AddRange(new ListViewItem[] { lv });
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error"); }
        }

        private void frmEmployees_Load(object sender, EventArgs e)
        {
            loadvars("");
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            loadvars(txtSearch.Text);
        }

        private void bttnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
        }

        private void bttnEdit_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count < 1)
            {
                MessageBox.Show("Pls. Select an Item.", "Select Item", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                frmEmployees_AE f = new frmEmployees_AE();
                f.ADD_STATE = false;
                f.employeeId = int.Parse(listView1.SelectedItems[0].Text);
                f.ShowDialog();
                loadvars("");
            }
        }
    }
}
