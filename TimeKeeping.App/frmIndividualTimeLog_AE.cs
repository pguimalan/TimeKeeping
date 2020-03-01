using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeKeeping.App.Helpers;
using TimeKeeping.Models;
using TimeKeeping.Services;
using TimeKeeping.Services.Interface;

namespace TimeKeeping.App
{
    public partial class frmIndividualTimeLog_AE : Form
    {
        private readonly string employeeName;
        private readonly int employeeId;
        private readonly DateTime currDate;
        private readonly int logId;
        private readonly IDtrService dtr;

        public frmIndividualTimeLog_AE(IDtrService dtr)
        {
            this.dtr = dtr;
        }

        public frmIndividualTimeLog_AE(string employeeName, int employeeId, DateTime currDate, int logId) : this(new DtrService())
        {
            InitializeComponent();
            this.employeeName = employeeName;
            this.employeeId = employeeId;
            this.currDate = currDate;
            this.logId = logId;
        }

        private void bttnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmIndividualTimeLog_AE_Load(object sender, EventArgs e)
        {
            txtEmployeeName.Text = employeeName;
            lblCurrentDate.Text = currDate.ToLongDateString();
            var md = dtr.DTR_GetById(logId);

            if (md.TimeIn_AM == "-")
            {
                dtTimeInAM.Text = "12:00 AM";
                dtTimeInAM.Enabled = false;
                chkTimeInAM.Checked = true;
            }
            else
            {
                dtTimeInAM.Text = md.TimeIn_AM;
                dtTimeInAM.Enabled = true;
                chkTimeInAM.Checked = false;
            }

            if (md.TimeOut_AM == "-")
            {
                dtTimeOutAM.Text = "12:00 AM";
                dtTimeOutAM.Enabled = false;
                chkTimeOutAM.Checked = true;
            }
            else
            {
                dtTimeOutAM.Text = md.TimeOut_AM;
                dtTimeOutAM.Enabled = true;
                chkTimeOutAM.Checked = false;
            }

            if (md.TimeIn_PM == "-")
            {
                dtTimeInPM.Text = "12:00 AM";
                dtTimeInPM.Enabled = false;
                chkTimeInPM.Checked = true;
            }
            else
            {
                dtTimeInPM.Text = md.TimeIn_PM;
                dtTimeInPM.Enabled = true;
                chkTimeInPM.Checked = false;
            }

            if (md.TimeOut_PM == "-")
            {
                dtTimeOutPM.Text = "12:00 AM";
                dtTimeOutPM.Enabled = false;
                chkTimeOutPM.Checked = true;
            }
            else
            {
                dtTimeOutPM.Text = md.TimeOut_PM;
                dtTimeOutPM.Enabled = true;
                chkTimeOutPM.Checked = false;
            }

            if (md.TimeIn_Evening == "-")
            {
                dtTimeInEvening.Text = "12:00 AM";
                dtTimeInEvening.Enabled = false;
                chkTimeInEvening.Checked = true;
            }
            else
            {
                dtTimeInEvening.Text = md.TimeIn_Evening;
                dtTimeInEvening.Enabled = true;
                chkTimeInEvening.Checked = false;
            }

            if (md.TimeOut_Evening == "-")
            {
                dtTimeOutEvening.Text = "12:00 AM";
                dtTimeOutEvening.Enabled = false;
                chkTimeOutEvening.Checked = true;
            }
            else
            {
                dtTimeOutEvening.Text = md.TimeOut_Evening;
                dtTimeOutEvening.Enabled = true;
                chkTimeOutEvening.Checked = false;
            }
        }

        private void chkTimeInAM_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTimeInAM.Checked)
            {
                dtTimeInAM.Enabled = false;
            }
            else dtTimeInAM.Enabled = true;
        }

        private void chkTimeOutAM_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTimeOutAM.Checked)
            {
                dtTimeOutAM.Enabled = false;
            }
            else dtTimeOutAM.Enabled = true;
        }

        private void chkTimeInPM_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTimeInPM.Checked)
            {
                dtTimeInPM.Enabled = false;
            }
            else dtTimeInPM.Enabled = true;
        }

        private void chkTimeOutPM_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTimeOutPM.Checked)
            {
                dtTimeOutPM.Enabled = false;
            }
            else dtTimeOutPM.Enabled = true;
        }

        private void chkTimeInEvening_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTimeInEvening.Checked)
            {
                dtTimeInEvening.Enabled = false;
            }
            else dtTimeInEvening.Enabled = true;
        }

        private void chkTimeOutEvening_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTimeOutEvening.Checked)
            {
                dtTimeOutEvening.Enabled = false;
            }
            else dtTimeOutEvening.Enabled = true;
        }

        private void bttnSave_Click(object sender, EventArgs e)
        {
            if (!chkTimeInAM.Checked && dtTimeInAM.Text.Trim() == "12:00 AM")
            {
                MessageBox.Show("Invalid AM Time-in data. Pleae cheeck.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtTimeInAM.Focus();
                return;
            }
            else if (!chkTimeOutAM.Checked && dtTimeOutAM.Text.Trim() == "12:00 AM")
            {
                MessageBox.Show("Invalid AM Time-out data. Pleae cheeck.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtTimeOutAM.Focus();
                return;
            }
            else if (!chkTimeInPM.Checked && dtTimeInPM.Text.Trim() == "12:00 AM")
            {
                MessageBox.Show("Invalid PM Time-in data. Pleae cheeck.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtTimeInPM.Focus();
                return;
            }
            else if (!chkTimeOutPM.Checked && dtTimeOutPM.Text.Trim() == "12:00 AM")
            {
                MessageBox.Show("Invalid PM Time-out data. Pleae cheeck.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtTimeOutPM.Focus();
                return;
            }
            else if (!chkTimeInEvening.Checked && dtTimeInEvening.Text.Trim() == "12:00 AM")
            {
                MessageBox.Show("Invalid Evening Time-in data. Pleae cheeck.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtTimeInEvening.Focus();
                return;
            }
            else if (!chkTimeOutEvening.Checked && dtTimeOutEvening.Text.Trim() == "12:00 AM")
            {
                MessageBox.Show("Invalid Evening Time-out data. Pleae cheeck.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtTimeOutEvening.Focus();
                return;
            }
            else if (!chkTimeInAM.Checked && !chkTimeOutAM.Checked && !chkTimeInPM.Checked && !chkTimeOutPM.Checked && !chkTimeInEvening.Checked && !chkTimeOutEvening.Checked)
            {
                MessageBox.Show("Invalid Time-in/Time-out data. Pleae cheeck.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                var log = new DTRForceUpdateModel
                {
                    LogId = logId,
                    EmployeeId = employeeId,
                    CurrentDate = currDate,
                    TimeIn_AM = chkTimeInAM.Checked ? TimeSpan.Zero : dtTimeInAM.Value.TimeOfDay,
                    TimeOut_AM = chkTimeOutAM.Checked ? TimeSpan.Zero : dtTimeOutAM.Value.TimeOfDay,
                    TimeIn_PM = chkTimeInPM.Checked ? TimeSpan.Zero : dtTimeInPM.Value.TimeOfDay,
                    TimeOut_PM = chkTimeOutPM.Checked ? TimeSpan.Zero : dtTimeOutPM.Value.TimeOfDay,
                    TimeIn_Evening = chkTimeInEvening.Checked ? TimeSpan.Zero : dtTimeInEvening.Value.TimeOfDay,
                    TimeOut_Evening = chkTimeOutEvening.Checked ? TimeSpan.Zero : dtTimeOutEvening.Value.TimeOfDay,
                    UserId = GlobalSession.UserId
                };
                int result = dtr.DTR_ForceUpdate(log);
                switch (result)
                {
                    case 1:
                    case 2:
                        ShowMessage.ShowMessageBox(2);
                        break;
                    case -1:
                        ShowMessage.CustomErrorMessage("Semester has not been set-up.");
                        break;
                    case -2:
                        ShowMessage.CustomErrorMessage("No morning shift for this employee.");
                        break;
                    case -3:
                        ShowMessage.CustomErrorMessage("No afternoon shift for this employee.");
                        break;
                    case -4:
                        ShowMessage.CustomErrorMessage("No evening shift for this employee.");
                        break;
                    case 0:
                        ShowMessage.CustomErrorMessage("Something went wrong.");
                        break;
                }
                this.Close();
            }
        }
    }
}
