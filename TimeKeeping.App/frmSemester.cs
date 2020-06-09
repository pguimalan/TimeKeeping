using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using TimeKeeping.Models;
using TimeKeeping.Services;
using TimeKeeping.Services.Interface;

namespace TimeKeeping.App
{
    public partial class frmSemester : Form
    {
        private readonly ISemesterService svc;

        public frmSemester(ISemesterService svc)
        {
            this.svc = svc;
        }

        public frmSemester() : this(new SemesterService())
        {
            InitializeComponent();
        }

        private void loadvars(string txtSearch)
        {
            try
            {
                List<SemesterModel> list = svc.Usp_Semester_Select(txtSearch);
                listView1.Items.Clear();
                if (list.Count >= 100)
                    MessageBox.Show("Search result is limited to 100 records only. Narrow your search for specific results.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                foreach (var li in list)
                {
                    ListViewItem lv = new ListViewItem(li.SemesterId.ToString());
                    lv.SubItems.Add(string.Concat(li.SemesterDesc, " (SY: ", li.SchoolYear, ")"));
                    lv.SubItems.Add(li.StartDate.ToShortDateString());
                    lv.SubItems.Add(li.EndDate.ToShortDateString());
                    lv.SubItems.Add(li.IsActive == true ? "Active" : "In-active");
                    lv.Font = new Font(lv.Font, FontStyle.Regular);
                    listView1.Items.AddRange(new ListViewItem[] { lv });

                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error"); }
        }

        private void bttnExit_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void frmSemester_Load(object sender, EventArgs e)
        {
            loadvars("");
        }

        private void bttnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            loadvars(txtSearch.Text);
        }

        private void bttnAdd_Click(object sender, EventArgs e)
        {
            frmSemester_AE frm = new frmSemester_AE();
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
                frmSemester_AE f = new frmSemester_AE();
                f.ADD_STATE = false;
                f.semesterId = int.Parse(listView1.SelectedItems[0].Text);
                f.ShowDialog();
                loadvars("");
            }
        }
    }
}
