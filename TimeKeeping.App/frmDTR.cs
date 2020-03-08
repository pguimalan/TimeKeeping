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
    public partial class frmDTR : Form
    {
        private readonly IDtrService dsvc;
        private readonly IDepartmentService svc;
        private List<DTRLogModel> list;
        public frmDTR(IDtrService dsvc, IDepartmentService svc)
        {
            this.dsvc = dsvc;
            this.svc = svc;
        }

        public frmDTR() : this(new DtrService(), new DepartmentService())
        {
            InitializeComponent();
        }

        private void bttnRefresh_Click(object sender, EventArgs e)
        {
            dtDate.Text = DateTime.Now.ToLongDateString();
            loadDepartment();
        }

        private void dtBdate_ValueChanged(object sender, EventArgs e)
        {
            loadvars();
        }

        private void loadvars()
        {
            try
            {
                list = dsvc.DTR_GenerateLog(dtDate.Value.ToString(), dtDate.Value.ToString(), cmbDepartment.Text);
                listView1.Items.Clear();
                foreach (var li in list)
                {
                    ListViewItem lv = new ListViewItem(li.EmployeeId.ToString());
                    lv.SubItems.Add(li.EmployeeId.ToString("0000"));
                    lv.SubItems.Add(li.EmployeeName);
                    lv.SubItems.Add(li.Department);
                    lv.SubItems.Add(li.Morning_TimeIn);
                    lv.SubItems.Add(li.Morning_TimeOut);
                    lv.SubItems.Add(li.Afternoon_TimeIn);
                    lv.SubItems.Add(li.Afternoon_TimeOut);
                    lv.SubItems.Add(li.Evening_TimeIn);
                    lv.SubItems.Add(li.Evening_TimeOut);
                    lv.Font = new Font(lv.Font, FontStyle.Regular);
                    listView1.Items.AddRange(new ListViewItem[] { lv });
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error"); }
        }

        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadvars();
        }

        private void frmDTR_Load(object sender, EventArgs e)
        {
            loadDepartment();
            dtDate.Value = DateTime.Now;
        }

        void loadDepartment()
        {
            cmbDepartment.DataSource = null;
            cmbDepartment.Items.Clear();
            List<DepartmentModel> list = svc.Department_SelectForDTR();
            cmbDepartment.DataSource = list;
            cmbDepartment.DisplayMember = "DepartmentName";
            cmbDepartment.ValueMember = "DepartmentId";
        }

        private void bttnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttnEdit_Click(object sender, EventArgs e)
        {
            frmRptViewer frm = new frmRptViewer();
            string exeFolder = Path.GetDirectoryName(Application.StartupPath);
            string reportPath = Path.Combine(exeFolder, "..\\Reports\\RptDTR.rdlc");
            frm.reportViewer1.LocalReport.ReportPath = reportPath;
            ReportParameter generatedBy = new ReportParameter("UserFullName", GlobalSession.UserFullName);

            frm.reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource rs = new ReportDataSource { Name = "ds_DTRLog", Value = list };
            
            frm.reportViewer1.LocalReport.DataSources.Add(rs);
            frm.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { generatedBy });
            frm.ShowDialog();

        }
    }
}
