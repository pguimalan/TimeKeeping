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
    public partial class frmIndividualTimeLog : Form
    {
        private readonly IDropdownService drp;
        private readonly IDtrService dtr;
        List<IndividualDTR> list;
        public frmIndividualTimeLog(IDropdownService drp, IDtrService dtr)
        {
            this.drp = drp;
            this.dtr = dtr;
        }

        public frmIndividualTimeLog() : this(new DropdownService(), new DtrService())
        {
            InitializeComponent();
        }

        private void frmIndividualTimeLog_Load(object sender, EventArgs e)
        {
            loadSemester();
            loadEmployee();
        }

        void loadSemester()
        {
            cmbPayrollPeriod.DataSource = null;
            cmbPayrollPeriod.Items.Clear();
            List<PayrollPeriodDropdown> list = drp.PayrollPeriod_SelectDropdown();
            cmbPayrollPeriod.DataSource = list;
            cmbPayrollPeriod.DisplayMember = "PPMonthYear";
            cmbPayrollPeriod.ValueMember = "PeriodId";
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

        void LoadDTR(int empId, int payrollId)
        {
            try
            {
                list = dtr.DTR_IndividualTimeLog(empId, payrollId);
                listView1.Items.Clear();

                foreach (var li in list)
                {
                    ListViewItem lv = new ListViewItem(li.LogId.ToString());
                    lv.SubItems.Add(li.DayOfWeekName);
                    lv.SubItems.Add(li.TimeIn_AM);
                    lv.SubItems.Add(li.TimeIn_AM_MinsLate);
                    lv.SubItems.Add(li.TimeOut_AM);
                    lv.SubItems.Add(li.UnderTime_AM);
                    lv.SubItems.Add(li.TimeIn_PM);
                    lv.SubItems.Add(li.TimeIn_PM_MinsLate);
                    lv.SubItems.Add(li.TimeOut_PM);
                    lv.SubItems.Add(li.UnderTime_PM);
                    lv.SubItems.Add(li.TimeIn_Evening);
                    lv.SubItems.Add(li.TimeIn_Evening_MinsLate);
                    lv.SubItems.Add(li.TimeOut_Evening);
                    lv.SubItems.Add(li.UnderTime_Evening);
                    lv.SubItems.Add(li.CurrDate.ToString());
                    lv.Font = new Font(lv.Font, FontStyle.Regular);
                    listView1.Items.AddRange(new ListViewItem[] { lv });
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error"); }
        }

        private void bttnRefresh_Click(object sender, EventArgs e)
        {
            loadSemester();
            loadEmployee();
        }

        private void bttnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbEmployeeName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                LoadDTR((int)cmbEmployeeName.SelectedValue, (int)cmbPayrollPeriod.SelectedValue);
            }
            catch
            {
                LoadDTR(0,0);
            }
        }

        private void cmbPayrollPeriod_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                LoadDTR((int)cmbEmployeeName.SelectedValue, (int)cmbPayrollPeriod.SelectedValue);
            }
            catch
            {
                LoadDTR(0, 0);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRptViewer frm = new frmRptViewer();
            string exeFolder = Path.GetDirectoryName(Application.StartupPath);
            string reportPath = Path.Combine(exeFolder, "..\\Reports\\RptDTR_Individual.rdlc");
            frm.reportViewer1.LocalReport.ReportPath = reportPath;
            ReportParameter generatedBy = new ReportParameter("UserFullName", GlobalSession.UserFullName);

            frm.reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource rs = new ReportDataSource { Name = "ds_DTR_IndividualLog", Value = list };

            frm.reportViewer1.LocalReport.DataSources.Add(rs);
            frm.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { generatedBy });
            frm.ShowDialog();
        }

        private void bttnEdit_Click(object sender, EventArgs e)
        {

            if (listView1.SelectedItems.Count < 1)
            {
                MessageBox.Show("Pls. Select an Item.", "Select Item", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                frmIndividualTimeLog_AE f = new frmIndividualTimeLog_AE(cmbEmployeeName.Text, (int)cmbEmployeeName.SelectedValue, DateTime.Parse(listView1.Items[listView1.FocusedItem.Index].SubItems[14].Text), int.Parse(listView1.SelectedItems[0].Text));
                f.ShowDialog();
                LoadDTR((int)cmbEmployeeName.SelectedValue, (int)cmbPayrollPeriod.SelectedValue);
            }            
        }
    }
}
