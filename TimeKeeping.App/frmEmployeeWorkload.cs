using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeKeeping.App.Helpers;
using TimeKeeping.App.Reports;
using TimeKeeping.Models;
using TimeKeeping.Services;
using TimeKeeping.Services.Interface;

namespace TimeKeeping.App
{
    public partial class frmEmployeeWorkload : Form
    {
        List<EmployeeForSelectModel> empList;
        int employeeId;
        private readonly IEmployeeService empSvc;
        private readonly ISemesterService semSvc;
        private readonly IWorkloadService wsvc;
        private List<WorkloadOfEmployeeModel> list;
        public frmEmployeeWorkload(IEmployeeService empSvc, ISemesterService semSvc, IWorkloadService wsvc)
        {
            this.empSvc = empSvc;
            this.semSvc = semSvc;
            this.wsvc = wsvc;
        }

        public frmEmployeeWorkload() : this(new EmployeeService(), new SemesterService(), new WorkloadService())
        {
            InitializeComponent();
            employeeId = 0;
        }

        private void frmEmployeeWorkload_Load(object sender, EventArgs e)
        {
            empList = empSvc.Employee_Select("");
            PrepareAutoComplete();
            loadSemester();
            linkLabel1.Text = "Print workload for selected employee and " + cmbSemester.Text;
            linkLabel2.Text = "Print workload for all employees and " + cmbSemester.Text;
        }

        void loadSemester()
        {
            cmbSemester.DataSource = null;
            cmbSemester.Items.Clear();
            List<SemesterForDropdownModel> list = semSvc.Semester_SelectForDropdown();
            cmbSemester.DataSource = list;
            cmbSemester.DisplayMember = "SemesterSY";
            cmbSemester.ValueMember = "SemesterId";            
        }

        void PrepareAutoComplete()
        {
            AutoCompleteStringCollection col = new AutoCompleteStringCollection();
            foreach (var i in empList)
            {
                col.Add(i.EmployeeFullName);
            }

            txtSearch.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtSearch.AutoCompleteCustomSource = col;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (empList.Any(c => c.EmployeeFullName == txtSearch.Text))
            {
                var x = empList.Where(c => c.EmployeeFullName == txtSearch.Text);
                foreach (var data in x)
                {
                    employeeId = data.EmployeeId;
                }

                LoadWorkload(employeeId, (int)cmbSemester.SelectedValue);
            }
            else employeeId = 0;
        }

        void LoadWorkload(int empId, int semId)
        {
            try
            {
                list = wsvc.Workload_ByEmpSemId(empId, semId);
                listView1.Items.Clear();

                foreach (var li in list)
                {
                    ListViewItem lv = new ListViewItem(li.WorkloadId.ToString());
                    lv.SubItems.Add(li.DayOfWork);
                    lv.SubItems.Add(li.TimeInAM);
                    lv.SubItems.Add(li.TimeOutAM);
                    lv.SubItems.Add(li.TimeInPM);
                    lv.SubItems.Add(li.TimeOutPM);
                    lv.SubItems.Add(li.TimeInEvening);
                    lv.SubItems.Add(li.TimeOutEvening);
                    lv.SubItems.Add(string.Concat(li.TotalNumberOfHours.ToString(".00")," hrs."));
                    lv.Font = new Font(lv.Font, FontStyle.Regular);
                    listView1.Items.AddRange(new ListViewItem[] { lv });
                }              
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error"); }
        }

        private void bttnRefresh_Click(object sender, EventArgs e)
        {
            employeeId = 0;
            loadSemester();
            txtSearch.Text = "";
            listView1.Items.Clear();
            txtSearch.Focus();
            Validation.NormalTextbox(txtSearch);
        }

        private void bttnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bttnAdd_Click(object sender, EventArgs e)
        {
            if (Validation.IsTextEmpty(txtSearch) && employeeId < 1)
            {
                Validation.FocusTextBox(txtSearch, "Employee");
            }
            else if((int)cmbSemester.SelectedValue < 1)
            {
                ShowMessage.CustomErrorMessage("Semester not loaded. Click Search button to set selected semester.");
                return;
            }
            else if (listView1.Items.Count >= 7)
            {
                ShowMessage.CustomErrorMessage("Workload schedule already completed.");
            }
            else
            {
                frmEmployeeWorkload_AE f = new frmEmployeeWorkload_AE
                {
                    employeeId = employeeId,
                    semesterId = (int)cmbSemester.SelectedValue,
                    ADD_STATE = true
                };
                f.ShowDialog();
                LoadWorkload(employeeId, (int)cmbSemester.SelectedValue);
            }
        }            

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (employeeId <= 0 && txtSearch.Text.Length > 0)
            {
                ShowMessage.CustomErrorMessage("Employee not found.");
                bttnRefresh.PerformClick();
            }
            else
                Validation.NormalTextbox(txtSearch);
        }

        private void cmbSemester_SelectedIndexChanged(object sender, EventArgs e)
        {
            linkLabel1.Text = "";
            linkLabel2.Text = "";
            try
            {
                LoadWorkload(employeeId, (int)cmbSemester.SelectedValue);                
            }
            catch
            {
                LoadWorkload(0, 0);
            }
            linkLabel1.Text = "Print workload for selected employee - " + cmbSemester.Text;
            linkLabel2.Text = "Print workload for all employees and " + cmbSemester.Text;
        }

        private void bttnEdit_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count < 1)
            {
                MessageBox.Show("Pls. Select an Item.", "Select Item", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                frmEmployeeWorkload_AE f = new frmEmployeeWorkload_AE
                {
                    employeeId = employeeId,
                    semesterId = (int)cmbSemester.SelectedValue,
                    ADD_STATE = false,
                    workloadId = int.Parse(listView1.SelectedItems[0].Text)
                };

                f.ShowDialog();
                LoadWorkload(employeeId, (int)cmbSemester.SelectedValue);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRptViewer frm = new frmRptViewer();
            string exeFolder = Path.GetDirectoryName(Application.StartupPath);
            string reportPath = Path.Combine(exeFolder, "..\\Reports\\RptEmpWorkloadById.rdlc");
            frm.reportViewer1.LocalReport.ReportPath = reportPath;
            ReportParameter generatedBy = new ReportParameter("UserFullName", GlobalSession.UserFullName);

            frm.reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource rs = new ReportDataSource { Name = "ds_Workload", Value = list };

            frm.reportViewer1.LocalReport.DataSources.Add(rs);
            frm.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { generatedBy });
            frm.ShowDialog();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRptViewer frm = new frmRptViewer();
            string exeFolder = Path.GetDirectoryName(Application.StartupPath);
            string reportPath = Path.Combine(exeFolder, "..\\Reports\\RptEmpWorkloadBySemId.rdlc");
            frm.reportViewer1.LocalReport.ReportPath = reportPath;
            ReportParameter generatedBy = new ReportParameter("UserFullName", GlobalSession.UserFullName);

            frm.reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource rs = new ReportDataSource { Name = "ds_Workload", Value = wsvc.Workload_BySemId((int)cmbSemester.SelectedValue) };

            frm.reportViewer1.LocalReport.DataSources.Add(rs);
            frm.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { generatedBy });
            frm.ShowDialog();
        }
    }
}
