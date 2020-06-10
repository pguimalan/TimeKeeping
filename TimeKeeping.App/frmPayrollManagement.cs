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
    public partial class frmPayrollManagement : Form
    {
        List<EmployeeForDropdown> list;
        EmployeeForInsertModel emp;
        bool HAS_DTR;
        private readonly IEmployeeService empSvc;
        private readonly IDropdownService drp;
        private readonly IDtrService dsvc;
        private readonly IPayrollService _payrollService;

        public frmPayrollManagement(IEmployeeService empSvc, IDropdownService drp, IDtrService dsvc, IPayrollService payrollService)
        {
            this.empSvc = empSvc;
            this.drp = drp;
            this.dsvc = dsvc;
            _payrollService = payrollService;
        }

        public frmPayrollManagement() : this(new EmployeeService(), new DropdownService(), new DtrService(), new PayrollService())
        {
            InitializeComponent();
            loadEmployee();
            LoadPayroll();
        }

        void loadEmployee(string empType = "")
        {
            try
            {
                cmbEmployeeName.DataSource = null;
                cmbEmployeeName.Items.Clear();
                list = drp.Employee_SelectDropdown(empType);
                cmbEmployeeName.DataSource = list;
                cmbEmployeeName.DisplayMember = "EmployeeFullName";
                cmbEmployeeName.ValueMember = "EmployeeId";
            }
            catch { }
        }

        void ClearAll()
        {
            picEmployee.Image = picEmployee.InitialImage;
            lblDepartment.Text = "";
            lblDesignation.Text = "";
            lblPayOption.Text = "";
            lblRate.Text = "0.00";           
            lblTotDaysWork.Text = "0.00";
            lblTotalLate.Text = "0.00";
            lblTotalUndertime.Text = "0.00";
            txtCottageRental.Text = "0.00";

            HAS_DTR = false;
            lblGrossEarning.Text = "0.00";
            //HDMF_Tax.Text = "0.00";
            txtHDMF_MPL.Text = "0.00";
            txtHDMF_Calamity.Text = "0.00";
            lblGrossEarning.Text = "0.00";
            lblNetAmount.Text = "0.00";            
        }

        private void frmPayrollManagement_Load(object sender, EventArgs e)
        {
            cmbEmpType.SelectedIndex = 0;
            cmbEmpType.Text = "[Select Employee Type]";
        }

        void LoadPayroll()
        {
            cmbPayrollPeriod.DataSource = null;
            cmbPayrollPeriod.Items.Clear();
            List<PayrollPeriodDropdown> list = drp.PayrollPeriod_SelectDropdown();
            cmbPayrollPeriod.DataSource = list;
            cmbPayrollPeriod.DisplayMember = "PPMonthYear";
            cmbPayrollPeriod.ValueMember = "PeriodId";
        }

        private void cmbEmployeeName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var id = cmbEmployeeName.SelectedValue;
                if (id != null)
                {
                    GetEmpDetails((int)cmbEmployeeName.SelectedValue);
                    ComputeGrossEarning();
                }
            }

            catch
            {
                GetEmpDetails(0);
            }
        }

        void GetEmpDetails(int employeeId)
        {
            if (employeeId > 0)
            {
                emp = empSvc.Employee_SelectById(employeeId);

                if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "\\EmpPics\\ProfilePic\\" + employeeId + "\\" + emp.EmployeeBasicInfo.PicName) == true)
                {
                    picEmployee.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "\\EmpPics\\ProfilePic\\" + employeeId + "\\" + emp.EmployeeBasicInfo.PicName, true);                  
                }


                try
                {
                    lblDesignation.Text = emp.EmployeeEmpInfo.Designation;
                    lblDepartment.Text = emp.EmployeeEmpInfo.DepartmentName;
                    lblRate.Text = emp.EmployeeEmpInfo.BasicPay.ToString("#,####.00");
                    lblPayOption.Text = emp.EmployeeEmpInfo.BasicRateOption;

                    var dtr = dsvc.DTR_GetDetailsForPayroll(emp.EmployeeId, (int)cmbPayrollPeriod.SelectedValue);
                    if (dtr != null)
                    {
                        lblTotalLate.Text = dtr.TotalDaysWork.ToString(".00");
                        lblTotalUndertime.Text = dtr.TotalUndertime.ToString(".00");
                        lblTotDaysWork.Text = dtr.TotalDaysWork.ToString(".00");
                        label2.Visible = false;
                        HAS_DTR = true;

                        if (employeeId > 0 && (int)cmbPayrollPeriod.SelectedValue > 0)
                        {
                            var model = _payrollService.GetPayrollDetails(employeeId, (int)cmbPayrollPeriod.SelectedValue);
                            if (model != null)
                            {
                                lblTotDaysWork.Text = model.TotalDaysWork.ToString("0.00");
                                lblTotalLate.Text = model.MinsLate.ToString("0.00");
                                lblTotalUndertime.Text = model.UnderTime.ToString("0.00");
                                txtCottageRental.Text = model.Cottage_Rental.ToString("#,####.00");
                                lblGrossEarning.Text = model.GrossAmount.ToString("#,####.00");
                                //HDMF_Tax.Text = model.Tax.ToString("#,####.00");
                                txtHDMF.Text = model.HDMF_Premiums.ToString("#,####.00");
                                txtHDMF_Calamity.Text = model.HDMF_Calamity.ToString("#,####.00");
                                lblNetAmount.Text = model.NetAmount.ToString("#,####.00");
                                lblLateAmount.Text = model.LateAmtDeduction.ToString("#,####.00");
                                lblUnderTime.Text = model.UnderTimeAmtDeduction.ToString("#,####.00");
                            }
                        }

                    }
                    else
                    {
                        label2.Visible = true;
                        lblTotalLate.Text = "";
                        lblTotalUndertime.Text = "";
                        lblTotDaysWork.Text = "";
                        HAS_DTR = false;
                    }

                }
                catch (Exception ex)
                {
                    lblTotalLate.Text = "";
                    lblTotalUndertime.Text = "";
                    lblTotDaysWork.Text = "";
                    HAS_DTR = false;
                }
            }
            else
            {
                ClearAll();
            }
        }

        void ComputeGrossEarning()
        {
            decimal grossEarning = 0.00M;
            var daysInLAYear = DateTime.IsLeapYear(DateTime.Now.Year) ? 366 : 365;

            if (lblRate.Text != "")
            {
                if (lblTotDaysWork.Text != "")
                {
                    if (lblPayOption.Text == "Monthly")
                    {

                        var dailyRate = (decimal.Parse(lblRate.Text) * 12) / daysInLAYear;
                        grossEarning = dailyRate * decimal.Parse(lblTotDaysWork.Text);
                    }

                    if (lblPayOption.Text == "Daily")
                    {
                        grossEarning = decimal.Parse(lblRate.Text) * decimal.Parse(lblTotDaysWork.Text);
                    }

                    if (lblPayOption.Text == "Hourly")
                    {
                        grossEarning = decimal.Parse(lblRate.Text) * 8 * decimal.Parse(lblTotDaysWork.Text);
                    }

                    lblGrossEarning.Text = grossEarning.ToString("#,###.00");
                }
            }
        }

        private void cmbPayrollPeriod_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ClearAll();
                cmbEmpType.Text = "[Select All Type]";
                if(cmbEmpType.Text != "[Select All Type]")
                {
                    loadEmployee(cmbEmpType.Text);
                }
            }
            catch { }
        }

        private void cmbEmpType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                picEmployee.Image = picEmployee.InitialImage;
                lblDepartment.Text = "";
                lblDesignation.Text = "";
                lblPayOption.Text = "";
                lblRate.Text = "";
                lblTotalLate.Text = "";
                lblTotalUndertime.Text = "";
                lblTotDaysWork.Text = "";
                lblGrossEarning.Text = "0.00";
                lblNetAmount.Text = "0.00";
                HAS_DTR = false;
                loadEmployee(cmbEmpType.Text);
            }
            catch { }
        }

        private void bttnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttnRefresh_Click(object sender, EventArgs e)
        {
            ClearAll();
            loadEmployee();
            LoadPayroll();
        }

        private void bttnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if((int)cmbPayrollPeriod.SelectedValue == 0  || cmbPayrollPeriod.SelectedValue == null)
                {
                    Validation.FocusComboBox(cmbPayrollPeriod, "Payroll Period");
                    return;
                } 
                else if (cmbEmpType.Text == "")
                {
                    Validation.FocusComboBox(cmbEmpType, "Employee Type");
                    return;
                }
                else if ((int)cmbEmployeeName.SelectedValue == 0 || cmbEmployeeName.SelectedValue == null)
                {
                    Validation.FocusComboBox(cmbEmployeeName, "Employee");
                    return;
                }
                else
                {
                    if (label2.Visible)
                    {
                        MessageBox.Show("Cannot process payroll. No record for selected employee.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    PayrollModel payrollModel = new PayrollModel
                    {
                        EmployeId = (int)cmbEmployeeName.SelectedValue,
                        PayrollPeriodId = (int)cmbPayrollPeriod.SelectedValue,
                        HDMF_Premiums = decimal.Parse(txtHDMF.Text),
                        HDMF_MPL = decimal.Parse(txtHDMF_MPL.Text),
                        HDMF_Calamity = decimal.Parse(txtHDMF_Calamity.Text),
                        Cottage_Rental = decimal.Parse(txtCottageRental.Text),
                        Tax = 0, //decimal.Parse(HDMF_Tax.Text),
                        PhilHealth = decimal.Parse("0.00"),
                        SSS = decimal.Parse("0.00"),
                        MinsLate = decimal.Parse(lblTotalLate.Text),
                        UnderTime = decimal.Parse(lblTotalUndertime.Text),
                        OverTime = decimal.Parse("0.00"),
                        PayRate = decimal.Parse(lblRate.Text),
                        PayOption = lblPayOption.Text,
                        TotalDaysWork = decimal.Parse(lblTotDaysWork.Text),
                        GrossAmount = decimal.Parse(lblGrossEarning.Text),
                        NetAmount = decimal.Parse(lblNetAmount.Text),
                        EmpType = cmbEmpType.Text,
                        GeneratedBy = GlobalSession.UserFullName,
                        LateAmtDeduction = decimal.Parse(lblLateAmount.Text),
                        UnderTimeAmtDeduction = decimal.Parse(lblUnderTime.Text)
                    };

                    _payrollService.Payroll_Process(payrollModel);

                    MessageBox.Show("Payroll successfully processed.", "Upate", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        decimal ComputeNet()
        {
           try
            {
                var grossIncome = decimal.Parse(lblGrossEarning.Text);
                var deductions = decimal.Parse(txtHDMF.Text) + decimal.Parse(txtHDMF_MPL.Text) + decimal.Parse(txtHDMF_Calamity.Text) + decimal.Parse(txtCottageRental.Text) + decimal.Parse(lblLateAmount.Text) + decimal.Parse(lblUnderTime.Text);
                var netIncome = grossIncome - deductions;
                return netIncome;
            }
            catch
            {
                return 0;
            }
        }

        private void lblGrossEarning_TextChanged(object sender, EventArgs e)
        {
            lblNetAmount.Text  = ComputeNet().ToString("#,####.00");
        }

        private void txtHDMF_TextChanged(object sender, EventArgs e)
        {
            lblNetAmount.Text = ComputeNet().ToString("#,####.00");
        }

        private void txtHDMF_MPL_TextChanged(object sender, EventArgs e)
        {
            lblNetAmount.Text = ComputeNet().ToString("#,####.00");
        }

        private void txtHDMF_Calamity_TextChanged(object sender, EventArgs e)
        {
            lblNetAmount.Text = ComputeNet().ToString("#,####.00");
        }

        private void HDMF_Tax_TextChanged(object sender, EventArgs e)
        {
            lblNetAmount.Text = ComputeNet().ToString("#,####.00");
        }

        private void txtHDMF_KeyPress(object sender, KeyPressEventArgs e)
        {
            StringHelper.NumbersOnly(txtHDMF.Text, e);
        }

        private void txtHDMF_Leave(object sender, EventArgs e)
        {

            StringHelper.FormatAmountNumber(txtHDMF);
        }

        private void txtHDMF_MPL_KeyPress(object sender, KeyPressEventArgs e)
        {
            StringHelper.NumbersOnly(txtHDMF_MPL.Text, e);
        }

        private void txtHDMF_MPL_Leave(object sender, EventArgs e)
        {
            StringHelper.FormatAmountNumber(txtHDMF_MPL); 
        }

        private void txtHDMF_Calamity_KeyPress(object sender, KeyPressEventArgs e)
        {
            StringHelper.NumbersOnly(txtHDMF_Calamity.Text, e); 
        }

        private void txtHDMF_Calamity_Leave(object sender, EventArgs e)
        {
            StringHelper.FormatAmountNumber(txtHDMF_Calamity);
        }

        //private void HDMF_Tax_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    StringHelper.NumbersOnly(HDMF_Tax.Text, e);
        //}

        //private void HDMF_Tax_Leave(object sender, EventArgs e)
        //{
        //    StringHelper.FormatAmountNumber(HDMF_Tax); 
        //}

        private void txtCottageRental_TextChanged(object sender, EventArgs e)
        {
            lblNetAmount.Text = ComputeNet().ToString("#,####.00");
        }

        private void txtCottageRental_KeyPress(object sender, KeyPressEventArgs e)
        {
            StringHelper.NumbersOnly(txtCottageRental.Text, e);
        }

        private void txtCottageRental_Leave(object sender, EventArgs e)
        {
            StringHelper.FormatAmountNumber(txtCottageRental); 
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            if ((int)cmbPayrollPeriod.SelectedValue == 0 || cmbPayrollPeriod.SelectedValue == null)
            {
                Validation.FocusComboBox(cmbPayrollPeriod, "Payroll Period");
                return;
            }
            else if (cmbEmpType.Text == "")
            {
                Validation.FocusComboBox(cmbEmpType, "Employee Type");
                return;
            }
            else
            {
                frmRptViewer frm = new frmRptViewer();
                string exeFolder = Path.GetDirectoryName(Application.StartupPath);
                string reportPath = Path.Combine(exeFolder, "..\\Reports\\RptPayrollList.rdlc");
                frm.reportViewer1.LocalReport.ReportPath = reportPath;
                ReportParameter generatedBy = new ReportParameter("UserFullName", GlobalSession.UserFullName);

                var list = _payrollService.GetPayrollList((int)cmbPayrollPeriod.SelectedValue, cmbEmpType.Text);
                frm.reportViewer1.LocalReport.DataSources.Clear();
                ReportDataSource rs = new ReportDataSource { Name = "ds_payroll", Value = list };

                frm.reportViewer1.LocalReport.DataSources.Add(rs);
                frm.reportViewer1.PrinterSettings.DefaultPageSettings.Landscape = true;
                frm.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { generatedBy });
                
                frm.ShowDialog();
            }
        }

        private void lblTotalLate_TextChanged(object sender, EventArgs e)
        {
            decimal lateAmout;
            var mins = decimal.Parse(lblTotalLate.Text);

            if(mins <= 0)
            {
                lateAmout = 0;
            }
            else
            {
                if (lblPayOption.Text == "Daily")
                    lateAmout = ((decimal.Parse(lblRate.Text) / 8) / 60) * mins;
                else if (lblPayOption.Text == "Hourly")
                    lateAmout = (decimal.Parse(lblRate.Text) / 60) * mins;
                else
                    lateAmout = 0;
            }

            lblLateAmount.Text = lateAmout.ToString("#,###.00");

            ComputeNet();
        }

        private void lblTotalUndertime_TextChanged(object sender, EventArgs e)
        {

            decimal utAmout;
            var mins = decimal.Parse(lblTotalUndertime.Text);

            if (mins <= 0)
            {
                utAmout = 0;
            }
            else
            {
                if (lblPayOption.Text == "Daily")
                    utAmout = ((decimal.Parse(lblRate.Text) / 8) / 60) * mins;
                else if (lblPayOption.Text == "Hourly")
                    utAmout = (decimal.Parse(lblRate.Text) / 60) * mins;
                else
                    utAmout = 0;
            }

            lblUnderTime.Text = utAmout.ToString("#,###.00");

            ComputeNet();
        }
    }
}
