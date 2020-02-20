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
    public partial class frmEmployees : Form
    {
        private readonly IEmployeeService svc;
        private List<EmployeeForSelectModel> list;
        public frmEmployees(IEmployeeService svc)
        {
            this.svc = svc;
        }

        public frmEmployees() : this(new EmployeeService())
        {
            InitializeComponent();
        }

        private void bttnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttnAdd_Click(object sender, EventArgs e)
        {
            frmEmployee_AE f = new frmEmployee_AE();
            f.ADD_STATE = true;    
            f.ShowDialog();
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
                frmEmployee_AE f = new frmEmployee_AE();
                f.ADD_STATE = false;
                f.employeeId = int.Parse(listView1.SelectedItems[0].Text);
                f.ShowDialog();
                loadvars("");
            }
        }

        private void loadvars(string txtSearch)
        {
            try
            {
                list = svc.Employee_Select(txtSearch);
                listView1.Items.Clear();
                if (list.Count >= 100)
                    MessageBox.Show("Search result is limited to 100 records only. Narrow your search for specific results.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                foreach (var li in list)
                {
                    ListViewItem lv = new ListViewItem(li.EmployeeId.ToString());
                    lv.SubItems.Add(li.EmployeeIDNumber);
                    lv.SubItems.Add(string.Concat(li.EmployeeFullName, " ", li.Suffix));
                    lv.SubItems.Add(li.Designation);
                    lv.SubItems.Add(li.ContactNumbers);
                    lv.SubItems.Add(li.Department);
                    lv.Font = new Font(lv.Font, FontStyle.Regular);
                    listView1.Items.AddRange(new ListViewItem[] { lv });
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error"); }
        }

        private void frmEmployees_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            frmRptViewer frm = new frmRptViewer();
            string exeFolder = Path.GetDirectoryName(Application.StartupPath);
            string reportPath = Path.Combine(exeFolder, "..\\Reports\\RptEmpMasterlist.rdlc");
            frm.reportViewer1.LocalReport.ReportPath = reportPath;
            ReportParameter generatedBy = new ReportParameter("UserFullName", GlobalSession.UserFullName);

            frm.reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource rs = new ReportDataSource { Name = "ds_EmpMasterlist", Value = list };

            frm.reportViewer1.LocalReport.DataSources.Add(rs);
            frm.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { generatedBy });
            frm.ShowDialog();
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (listView1.SelectedItems.Count < 1)
            {
                MessageBox.Show("Pls. Select an Item.", "Select Item", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                EmployeeForInsertModel emp = svc.Employee_SelectById(int.Parse(listView1.SelectedItems[0].Text));
                frmRptViewer frm = new frmRptViewer();
                string exeFolder = Path.GetDirectoryName(Application.StartupPath);
                string reportPath = Path.Combine(exeFolder, "..\\Reports\\RptEmpProfile.rdlc");
                frm.reportViewer1.LocalReport.ReportPath = reportPath;
                ReportParameter generatedBy = new ReportParameter("UserFullName", GlobalSession.UserFullName);
                ReportParameter imagePath = new ReportParameter("ImagePath", AppDomain.CurrentDomain.BaseDirectory + "EmpPics\\ProfilePic\\" + listView1.SelectedItems[0].Text + "\\" + emp.EmployeeBasicInfo.PicName);
                List<EmployeeBasicInfoForInsertModel> empBasicinfo = new List<EmployeeBasicInfoForInsertModel>();
                List<EmployeeContactInfoForInsertModel> empContactInfo = new List<EmployeeContactInfoForInsertModel>();
                List<EmployeeEducationForInsertModel> empEducation = new List<EmployeeEducationForInsertModel>();
                List<EmployeeEmpInfoForInsertModel> empEmployment = new List<EmployeeEmpInfoForInsertModel>();
                empBasicinfo.Add(emp.EmployeeBasicInfo);
                empContactInfo.Add(emp.EmployeeContactInfo);
                empEducation.Add(emp.EmployeeEducation);
                empEmployment.Add(emp.EmployeeEmpInfo);
                frm.reportViewer1.LocalReport.DataSources.Clear();
                ReportDataSource rs = new ReportDataSource { Name = "ds_employee_basicinfo", Value = empBasicinfo };
                ReportDataSource rs1 = new ReportDataSource { Name = "ds_employee_contactinfo", Value = empContactInfo };
                ReportDataSource rs2 = new ReportDataSource { Name = "ds_employee_education", Value = empContactInfo };
                ReportDataSource rs3 = new ReportDataSource { Name = "ds_employee_employment", Value = empEmployment };

                frm.reportViewer1.LocalReport.DataSources.Add(rs);
                frm.reportViewer1.LocalReport.DataSources.Add(rs1);
                frm.reportViewer1.LocalReport.DataSources.Add(rs2);
                frm.reportViewer1.LocalReport.DataSources.Add(rs3);
                frm.reportViewer1.LocalReport.EnableExternalImages = true;
                frm.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { generatedBy, imagePath });
                frm.ShowDialog();
            }
        }
    }
}
