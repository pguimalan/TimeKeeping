using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeKeeping.App.Helpers;
using TimeKeeping.Models;
using TimeKeeping.Services;
using TimeKeeping.Services.Interface;

namespace TimeKeeping.App
{
    public partial class frmSemester_AE : Form
    {
        public int semesterId;
        public bool ADD_STATE;

        private readonly ISemesterService svc;

        public frmSemester_AE(ISemesterService svc)
        {
            this.svc = svc;
        }

        public frmSemester_AE() : this(new SemesterService())
        {
            InitializeComponent();
            semesterId = 0;
            ADD_STATE = true;
        }

        private void bttnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSemester_AE_Load(object sender, EventArgs e)
        {
            if (ADD_STATE)
            {
                int yearStart = dtStart.Value.Year;
                int yearEnd = yearStart + 1;
                txtSchoolYear.Text = string.Concat(yearStart.ToString(), "-", yearEnd.ToString());
            }
            else if(!ADD_STATE && semesterId > 0)
            {
                SemesterModel md = svc.Semester_SelectById(semesterId);
                cmbSemester.Text = md.SemesterDesc;
                dtStart.Value = md.StartDate;
                dtEnd.Value = md.EndDate;
                txtSchoolYear.Text = md.SchoolYear;
                if (md.IsActive)
                {
                    rdActive.Checked = true;
                    rdInactive.Checked = false;
                }
                else
                {
                    rdActive.Checked = false;
                    rdInactive.Checked = true;
                }
                bttnSave.Text = "Edit Item";
            }
        }

        private void dtStart_ValueChanged(object sender, EventArgs e)
        {
            int yearStart = dtStart.Value.Year;
            int yearEnd = yearStart + 1;
            txtSchoolYear.Text = string.Concat(yearStart.ToString(), "-", yearEnd.ToString());
        }

        private void rdActive_CheckedChanged(object sender, EventArgs e)
        {
            if (rdActive.Checked)
                rdInactive.Checked = false;
            else rdInactive.Checked = true;
        }

        private void rdInactive_CheckedChanged(object sender, EventArgs e)
        {
            if (rdInactive.Checked)
                rdActive.Checked = false;
            else rdActive.Checked = true;
        }

        private void bttnSave_Click(object sender, EventArgs e)
        {
            int result;
            if (Validation.IsComboEmpty(cmbSemester))
            {
                Validation.FocusComboBox(cmbSemester, "Semester Description");
                return;
            }
            else if (dtStart.Value > dtEnd.Value)
            {
                ShowMessage.CustomErrorMessage("End date must be greater that start date.");
                return;
            }
            else if (ADD_STATE && !rdActive.Checked)
            {
                ShowMessage.CustomErrorMessage("New Semester set-up must be active by default.");
                return;
            }

            else if(txtSchoolYear.Text.Length< 9)
            {
                ShowMessage.CustomErrorMessage("Invalid school year value or format. must be 0000-0000");
                txtSchoolYear.Focus();
                return;
            }
            else if(txtSchoolYear.Text.Length > 8)
            {
                var y1 = int.Parse(txtSchoolYear.Text.Split('-')[0]);
                var y2 = int.Parse(txtSchoolYear.Text.Split('-')[1]);
                if(y1 > y2)
                {
                    ShowMessage.CustomErrorMessage("Invalid school year value or format. Start year must be equal or less than to end year");
                    return;
                }
                else
                {
                    SemesterModel md = new SemesterModel
                    {
                        SemesterDesc = cmbSemester.Text,
                        StartDate = dtStart.Value,
                        EndDate = dtEnd.Value,
                        SchoolYear = txtSchoolYear.Text,
                        IsActive = rdActive.Checked
                    };

                    if (ADD_STATE)
                    {
                        result = svc.Semester_Insert(md);
                        if (result > 0)
                        {
                            ShowMessage.ShowMessageBox(1);
                            Close();
                        }
                        else if (result == -1)
                            ShowMessage.ShowMessageBox(4);
                        else
                            ShowMessage.ShowMessageBox(3);
                    }
                    else
                    {
                        md.SemesterId = semesterId;
                        svc.Semester_Update(md);
                        ShowMessage.ShowMessageBox(2);
                        Close();
                    }
                }
            }
        }
    }
}
