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
    public partial class frmEmployeeWorkload_AE : Form
    {
        public int employeeId;
        public int workloadId;
        public int semesterId;
        public bool ADD_STATE;
        private readonly IWorkloadService svc;

        public frmEmployeeWorkload_AE(IWorkloadService svc)
        {
            this.svc = svc;
        }

        public frmEmployeeWorkload_AE() : this(new WorkloadService())
        {
            InitializeComponent();
        }

        private void bttnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkAM_CheckedChanged(object sender, EventArgs e)
        {            
            if (!chkAM.Checked)
                groupBox3.Enabled = true;
            else
                groupBox3.Enabled = false;
        }

        private void chkPM_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkPM.Checked)
                groupBox2.Enabled = true;
            else
                groupBox2.Enabled = false;
        }

        private void bttnSave_Click(object sender, EventArgs e)
        {
            int result;
            if(employeeId < 1)
            {
                ShowMessage.CustomErrorMessage("Employee not selected. Select employee first.");
                this.Close();
            }
            else if (semesterId < 1)
            {
                ShowMessage.CustomErrorMessage("Semester not selected. Select semester first.");
                this.Close();
            }
            else if (Validation.IsComboEmpty(cmbDay))
            {
                Validation.FocusComboBox(cmbDay, "Day of Week");
                return;
            }
            else if(!chkAM.Checked && (dtTimeInAM.Value > dtTimeOutAM.Value))
            {
                ShowMessage.CustomErrorMessage("Time-In AM must be greater than Time-Out AM");
                dtTimeOutAM.Focus();
            }
            else if (!chkPM.Checked && (dtTimeInPM.Value > dtTimeOutPM.Value))
            {
                ShowMessage.CustomErrorMessage("Time-In PM must be greater than Time-Out PM");
                dtTimeInPM.Focus();
            }
            else
            {
                WorkloadModel md = new WorkloadModel { 
                    DayOfWork = cmbDay.Text,
                    EmployeeId = employeeId,
                    SemesterId = semesterId,
                    TimeInAM = chkAM.Checked ? TimeSpan.Zero : dtTimeInAM.Value.TimeOfDay,
                    TimeOutAM = chkAM.Checked ? TimeSpan.Zero : dtTimeOutAM.Value.TimeOfDay,
                    TimeInPM = chkPM.Checked ? TimeSpan.Zero : dtTimeInPM.Value.TimeOfDay,
                    TimeOutPM = chkPM.Checked ? TimeSpan.Zero : dtTimeOutPM.Value.TimeOfDay,
                    TimeInEvening = chkEvening.Checked ? TimeSpan.Zero : dtTimeInEvening.Value.TimeOfDay,
                    TimeOutEvening = chkEvening.Checked ? TimeSpan.Zero : dtTimeOutEvening.Value.TimeOfDay
                };

                if (ADD_STATE)
                {
                    result = svc.Workload_Insert(md);
                    if (result > 0)
                    {
                        ShowMessage.ShowMessageBox(1);
                        this.Close();
                    }
                    else if (result == -1)
                        ShowMessage.ShowMessageBox(4);
                    else
                        ShowMessage.ShowMessageBox(3);
                }
                else
                {
                    md.WorkloadId = workloadId;
                    svc.Workload_Update(md);
                    ShowMessage.ShowMessageBox(2);
                    this.Close();
                }
            }
        }

        private void frmEmployeeWorkload_AE_Load(object sender, EventArgs e)
        {
            if(!ADD_STATE && workloadId > 0)
            {
                var md = svc.Workload_SelectById(workloadId);
                cmbDay.Text = md.DayOfWork;
                if(md.TimeInAM == null && md.TimeOutAM == null)
                {
                    chkAM.Checked = true;
                }
                else
                {
                    dtTimeInAM.Text = md.TimeInAM.ToString();
                    dtTimeOutAM.Text = md.TimeOutAM.ToString();
                }
                if (md.TimeInPM == null && md.TimeOutPM == null)
                {
                    chkPM.Checked = true;
                }
                else
                {
                    dtTimeInPM.Text = md.TimeInPM.ToString();
                    dtTimeOutPM.Text = md.TimeOutPM.ToString();
                }
                if(md.TimeInEvening == null && md.TimeOutEvening == null)
                {
                    chkEvening.Checked = true;
                }
                else
                {
                    dtTimeInEvening.Text = md.TimeInEvening.ToString();
                    dtTimeOutEvening.Text = md.TimeOutEvening.ToString();
                }
                bttnSave.Text = "Edit Item";
            }
        }

        private void chkEvening_CheckedChanged(object sender, EventArgs e)
        {
            if(!chkEvening.Checked)
                groupBox4.Enabled = true;
            else
                groupBox4.Enabled = false;
        }

        private void bttnRefresh_Click(object sender, EventArgs e)
        {
            cmbDay.Text = "";

            chkAM.Checked = false;
            dtTimeInAM.Text = "07:30 AM";
            dtTimeOutAM.Text = "12:00 PM";

            chkPM.Checked = false;
            dtTimeInPM.Text = "01:15 PM";
            dtTimeOutPM.Text = "05:00 PM";

            chkEvening.Checked = false;
            dtTimeInEvening.Text = "05:15 PM";
            dtTimeOutEvening.Text = "10:00 PM";
        }
    }
}
