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
    public partial class frmEmployeeLeaves_AE : Form
    {
        public bool ADD_STATE;
        public int leaveId;
        private readonly IDropdownService drp;
        private readonly IEmployeeService empSvc;
        private readonly IEmployeeLeaveService svc;
        bool IsWithPay;
        string LeaveType;

        public frmEmployeeLeaves_AE(IDropdownService drp, IEmployeeService empSvc, IEmployeeLeaveService svc)
        {
            this.drp = drp;
            this.empSvc = empSvc;
            this.svc = svc;
        }

        public frmEmployeeLeaves_AE() : this(new DropdownService(), new EmployeeService(), new EmployeeLeaveService())
        {
            InitializeComponent();
            ADD_STATE = true;
            leaveId = 0;
        }

        private void frmEmployeeLeaves_AE_Load(object sender, EventArgs e)
        {
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

        void loadLeaveCredits(int employeeId)
        {
            EmployeeLeaveCreditsModel md = empSvc.LeaveCredits_Select(employeeId);
            txtVL.Text = md.VL.ToString();
            txtSL.Text = md.SL.ToString();
        }

        private void cmbEmployeeName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                loadLeaveCredits((int)cmbEmployeeName.SelectedValue);
                if (decimal.Parse(txtVL.Text) <= 0)
                    rdVLwithPay.Enabled = false;
                else rdVLwithPay.Enabled = true;

                if (decimal.Parse(txtSL.Text) <= 0)
                    rdSLwithPay.Enabled = false;
                else rdSLwithPay.Enabled = true;

                var diffDays = (dtTo.Value - dtFrom.Value.AddDays(-1)).TotalDays;
                lblNoDays.Text = Math.Round(diffDays, 1).ToString();
            }
            catch
            {
                loadLeaveCredits(0);
            }
        }

        private void bttnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttnRefresh_Click(object sender, EventArgs e)
        {
            loadEmployee();
            loadLeaveCredits(0);
            rdVLwithPay.Enabled = true;
            rdSLwithoutPay.Enabled = true;
            rdSLwithPay.Enabled = true;
            rdVLwithoutPay.Enabled = true;
            rdVLwithPay.Checked = false;
            rdSLwithoutPay.Checked = false;
            rdSLwithPay.Checked = false;
            rdVLwithoutPay.Checked = false;           
            txtRemarks.Text = "";
            lblNoDays.Text = "";
        }

        private void rdVLwithPay_CheckedChanged(object sender, EventArgs e)
        {
            if ((int)cmbEmployeeName.SelectedValue == 0 && rdVLwithPay.Checked)
            {
                ShowMessage.CustomErrorMessage("Select employee first.");
                cmbEmployeeName.Focus();
                rdVLwithPay.Checked = false;
                return;
            }
            else
            {
                IsWithPay = true;
                LeaveType = "VL";
            }
        }

        private void rdVLwithoutPay_CheckedChanged(object sender, EventArgs e)
        {
            if ((int)cmbEmployeeName.SelectedValue == 0 && rdVLwithoutPay.Checked)
            {
                ShowMessage.CustomErrorMessage("Select employee first.");
                cmbEmployeeName.Focus();
                rdVLwithoutPay.Checked = false;
            }
            else
            {
                IsWithPay = false;
                LeaveType = "VL";
            }
        }

        private void rdSLwithPay_CheckedChanged(object sender, EventArgs e)
        {
            if ((int)cmbEmployeeName.SelectedValue == 0 && rdSLwithPay.Checked)
            {
                ShowMessage.CustomErrorMessage("Select employee first.");
                cmbEmployeeName.Focus();
                rdSLwithPay.Checked = false;
            }
            else
            {
                IsWithPay = true;
                LeaveType = "SL";
            }
        }

        private void rdSLwithoutPay_CheckedChanged(object sender, EventArgs e)
        {
            if ((int)cmbEmployeeName.SelectedValue == 0 && rdSLwithoutPay.Checked)
            {
                ShowMessage.CustomErrorMessage("Select employee first.");
                cmbEmployeeName.Focus();
                rdSLwithoutPay.Checked = false;
            }
            else
            {
                IsWithPay = false;
                LeaveType = "SL";
            }
        }

        private void dtFrom_ValueChanged(object sender, EventArgs e)
        {
            if ((int)cmbEmployeeName.SelectedValue == 0)
            {
                ShowMessage.CustomErrorMessage("Select employee first.");
                return;
            }
            else
            {
                var diffDays = (dtTo.Value - dtFrom.Value.AddDays(-1)).TotalDays;
                lblNoDays.Text = Math.Round(diffDays,1).ToString();
            }
        }

        private void dtTo_ValueChanged(object sender, EventArgs e)
        {
            if ((int)cmbEmployeeName.SelectedValue == 0)
            {
                ShowMessage.CustomErrorMessage("Select employee first.");
                return;
            }
            else
            {
                var diffDays = (dtTo.Value - dtFrom.Value.AddDays(-1)).TotalDays;
                lblNoDays.Text = Math.Round(diffDays, 1).ToString();
            }
        }

        private void bttnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if ((int)cmbEmployeeName.SelectedValue == 0)
                {
                    ShowMessage.CustomErrorMessage("Select employee first.");
                    cmbEmployeeName.Focus();
                }
                else if (lblNoDays.Text == "")
                {
                    ShowMessage.CustomErrorMessage("Input inclusive dates.");
                    dtFrom.Focus();
                }
                else if (int.Parse(lblNoDays.Text) <= 0)
                {
                    ShowMessage.CustomErrorMessage("Invalid no. of days value.");
                    dtFrom.Focus();
                }
                else
                {
                    var lv = new EmployeeLeaveForInsertodel
                    {
                        EmployeeId = (int)cmbEmployeeName.SelectedValue,
                        IsWithPay = IsWithPay,
                        LeaveType = LeaveType,
                        LeaveDateFrom = dtFrom.Value,
                        LeaveDateTo = dtTo.Value,
                        LeaveRemarks = txtRemarks.Text,
                        CreatedBy = GlobalSession.UserFullName
                    };

                    if (ADD_STATE)
                    {
                        var result = svc.EmployeeLeave_Insert(lv);
                        if (result > 0)
                        {
                            ShowMessage.ShowMessageBox(1);
                        }
                        else if (result == -1)
                            ShowMessage.ShowMessageBox(4);
                        else
                            ShowMessage.ShowMessageBox(3);
                    }
                    else
                    {
                        lv.Id = leaveId;
                        svc.EmployeeLeave_Update(lv);
                        ShowMessage.ShowMessageBox(2);
                    }

                    bttnRefresh.PerformClick();
                }
            }
            catch
            {
                ShowMessage.ShowMessageBox(3);
            }
        }
    }
}
