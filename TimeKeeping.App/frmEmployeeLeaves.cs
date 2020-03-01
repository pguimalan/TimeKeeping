using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using TimeKeeping.Models;
using TimeKeeping.Services;
using TimeKeeping.Services.Interface;

namespace TimeKeeping.App
{
    public partial class frmEmployeeLeaves : Form
    {
        private readonly IDropdownService drp;
        private readonly IEmployeeLeaveService svc;

        public frmEmployeeLeaves(IDropdownService drp, IEmployeeLeaveService svc)
        {
            this.drp = drp;
            this.svc = svc;
        }

        public frmEmployeeLeaves() : this(new DropdownService(), new EmployeeLeaveService())
        {
            InitializeComponent();
            loadEmployee();
        }

        void loadEmployee()
        {
            cmbEmployeeName.DataSource = null;
            cmbEmployeeName.Items.Clear();
            List<EmployeeForDropdown> list = drp.Employee_SelectDropdown();
            cmbEmployeeName.DataSource = list;
            cmbEmployeeName.DisplayMember = "EmployeeFullName";
            cmbEmployeeName.ValueMember = "EmployeeId";
        }

        private void bttnExit_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        void loadvars(int empId, DateTime dtf, DateTime dtt)
        {
            try
            {
                if (dtf.Date > dtt.Date)
                {
                    label12.Visible = true;
                    listView1.Items.Clear();
                }
                else
                {
                    label12.Visible = false;
                    var list = svc.EmployeeLeave_Select(empId, dtf, dtt);
                    listView1.Items.Clear();
                    if (list.Count >= 100)
                        MessageBox.Show("Search result is limited to 100 records only. Narrow your search for specific results.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    foreach (var li in list)
                    {
                        ListViewItem lv = new ListViewItem(li.Id.ToString());
                        lv.SubItems.Add(li.EmployeeId.ToString("0000"));
                        lv.SubItems.Add(li.EmployeeFullName);
                        lv.SubItems.Add(li.LeaveType);
                        lv.SubItems.Add(li.LeaveDateFrom.ToShortDateString());
                        lv.SubItems.Add(li.LeaveDateTo.ToShortDateString());
                        lv.SubItems.Add(li.NoDaysLeave.ToString());
                        lv.SubItems.Add(li.LeaveStatus);
                        lv.Font = new Font(lv.Font, FontStyle.Regular);
                        listView1.Items.AddRange(new ListViewItem[] { lv });
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error"); }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void cmbEmployeeName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                loadvars((int)cmbEmployeeName.SelectedValue, dateTimePicker1.Value, dateTimePicker2.Value);
            }
            catch {
                loadvars(0, dateTimePicker1.Value, dateTimePicker2.Value);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            loadvars((int)cmbEmployeeName.SelectedValue, dateTimePicker1.Value, dateTimePicker2.Value);
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            loadvars((int)cmbEmployeeName.SelectedValue, dateTimePicker1.Value, dateTimePicker2.Value);
        }

        private void bttnAdd_Click(object sender, EventArgs e)
        {
            frmEmployeeLeaves_AE f = new frmEmployeeLeaves_AE();
            f.ShowDialog();
            loadvars(0, dateTimePicker1.Value, dateTimePicker2.Value);
        }

        private void frmEmployeeLeaves_Load(object sender, EventArgs e)
        {
            loadvars(0, DateTime.Now, DateTime.Now.AddDays(1));
        }
    }
}
