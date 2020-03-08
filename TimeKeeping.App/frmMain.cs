using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeKeeping.App.Reports;

namespace TimeKeeping.App
{
    public partial class frmMain : Form
    {
        public string tssUsername = "";
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.ExitThread();
        }

        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to exit?", "Exit Application", MessageBoxButtons.YesNo,
                  MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void logoffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            var frm = new frmLogin();            
            frm.Show();
        }

        private void addressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddress f1 = new frmAddress();
            f1.ShowDialog();
        }

        private void departmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDepartment f = new frmDepartment();
            f.ShowDialog();
        }

        private void employeeMasterlistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmployees f = new frmEmployees();
            f.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            tsUser.Text = tssUsername;
            tsDate.Text = DateTime.Now.ToShortDateString();
        }

        private void resetLoginPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmResetPassword frm = new frmResetPassword();
            frm.ShowDialog();
        }

        private void systemusersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsers frm = new frmUsers();
            frm.ShowDialog();
        }

        private void semesterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSemester frm = new frmSemester();
            frm.ShowDialog();
        }

        private void workloadManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmployeeWorkload frm = new frmEmployeeWorkload();
            frm.ShowDialog();
        }

        private void dailyTimeRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDTR f = new frmDTR();
            f.ShowDialog();
        }

        private void individualLogSheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIndividualTimeLog f = new frmIndividualTimeLog();
            f.ShowDialog();
        }

        private void leaveMgtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmployeeLeaves f = new frmEmployeeLeaves();
            f.ShowDialog();
        }

        private void payrollManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPayrollManagement f = new frmPayrollManagement();
            f.ShowDialog();
        }
    }
}
