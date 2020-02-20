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
        private readonly IDropdownService drp;
        private List<WorkloadOfEmployeeModel> list;
        public frmEmployeeWorkload(IEmployeeService empSvc, ISemesterService semSvc, IWorkloadService wsvc, IDropdownService drp)
        {
            this.empSvc = empSvc;
            this.semSvc = semSvc;
            this.wsvc = wsvc;
            this.drp = drp;
        }

        public frmEmployeeWorkload() : this(new EmployeeService(), new SemesterService(), new WorkloadService(), new DropdownService())
        {
            InitializeComponent();
            employeeId = 0;
        }

        private void frmEmployeeWorkload_Load(object sender, EventArgs e)
        {
            empList = empSvc.Employee_Select("");
            loadEmployee();
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

        void loadEmployee()
        {
            cmbEmployeeName.DataSource = null;
            cmbEmployeeName.Items.Clear();
            List<EmployeeForDropdown> list = drp.Employee_SelectDropdown();
            cmbEmployeeName.DataSource = list;
            cmbEmployeeName.DisplayMember = "EmployeeFullName";
            cmbEmployeeName.ValueMember = "EmployeeId";
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
            loadEmployee();
            listView1.Items.Clear();            
        }

        private void bttnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bttnAdd_Click(object sender, EventArgs e)
        {
            if ((int)cmbEmployeeName.SelectedValue < 1)
            {
                ShowMessage.CustomErrorMessage("Select Employee.");
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

        private void cmbEmployeeName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                employeeId = (int)cmbEmployeeName.SelectedValue;
                LoadWorkload(employeeId, (int)cmbSemester.SelectedValue);
            }
            catch
            {
                employeeId = 0;
            }
        }
    }
}
