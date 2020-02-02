using HRIS.App.Helpers;
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
    public partial class frmDepartment : Form
    {
        int deptId;
        private readonly IDepartmentService svc;

        public frmDepartment(IDepartmentService svc)
        {
            this.svc = svc;
        }

        public frmDepartment() : this(new DepartmentService())
        {
            InitializeComponent();
            deptId = 0;
        }

        private void bttnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loadvars(string txtSearch)
        {
            try
            {
                List<DepartmentForListModel> list = svc.Department_Select(txtSearch);
                listView1.Items.Clear();
                if (list.Count >= 100)
                    MessageBox.Show("Search result is limited to 100 records only. Narrow your search for specific results.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                foreach (var li in list)
                {
                    ListViewItem lv = new ListViewItem(li.DepartmentId.ToString());
                    lv.SubItems.Add(li.DepartmentName);
                    listView1.Items.AddRange(new ListViewItem[] { lv });
                }
                txtDeptName.Focus();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error"); }
        }

        private void frmDepartment_Load(object sender, EventArgs e)
        {
            loadvars("");
        }

        private void bttnSave_Click(object sender, EventArgs e)
        {
            if (Validation.IsTextEmpty(txtDeptName))
            {
                Validation.FocusTextBox(txtDeptName, "Department Name");
            }
            else
            {
                if(deptId <= 0)
                {
                    if (svc.Department_CheckIfExists(txtDeptName.Text))
                    {
                        ShowMessage.ShowMessageBox(4);                        
                        return;
                    }

                    svc.Department_Insert(new DepartmentForInsertModel { DepartmentName = txtDeptName.Text });
                    ShowMessage.ShowMessageBox(1);
                    txtDeptName.Text = "";
                }
                else if(deptId > 0)
                {
                    svc.Department_Update(new DepartmentForEditModel { DepartmentId = deptId, DepartmentName = txtDeptName.Text });
                    ShowMessage.ShowMessageBox(2);
                    txtDeptName.Text = "";
                }
                else ShowMessage.ShowMessageBox(3);
                loadvars("");
                bttnSave.Text = "Save Item";
            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count < 1)
            {
                MessageBox.Show("Pls. Select an Item.", "Select Item", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                deptId = int.Parse(listView1.SelectedItems[0].Text);
                txtDeptName.Text = listView1.SelectedItems[0].SubItems[1].Text;
                bttnSave.Text = "Edit Item";
            }
        }

        private void bttnReset_Click(object sender, EventArgs e)
        {            
            txtDeptName.Focus();
            Validation.NormalTextbox(txtDeptName);
            Validation.NormalTextbox(txtSearch);
            bttnSave.Text = "Save Item";
            deptId = 0;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            loadvars(txtSearch.Text);
        }

        private void txtDeptName_Leave(object sender, EventArgs e)
        {
            StringHelper.UppercaseFirst(txtDeptName);
        }
    }
}
