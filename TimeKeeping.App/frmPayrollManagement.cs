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

        public frmPayrollManagement(IEmployeeService empSvc, IDropdownService drp, IDtrService dsvc)
        {
            this.empSvc = empSvc;
            this.drp = drp;
            this.dsvc = dsvc;
        }

        public frmPayrollManagement() : this(new EmployeeService() , new DropdownService(), new DtrService())
        {
            InitializeComponent();
            loadEmployee();
            LoadPayroll();
        }

        void loadEmployee()
        {
            cmbEmployeeName.DataSource = null;
            cmbEmployeeName.Items.Clear();
            list = drp.Employee_SelectDropdown();
            cmbEmployeeName.DataSource = list;
            cmbEmployeeName.DisplayMember = "EmployeeFullName";
            cmbEmployeeName.ValueMember = "EmployeeId";
        }

        void ClearAll()
        {
            picEmployee.Image = picEmployee.InitialImage;            
            lblDepartment.Text = "";
            lblDesignation.Text = "";
            lblEmpType.Text = "";
            lblPayOption.Text = "";
            lblRate.Text = "";
            lblTotalLate.Text = "";
            lblTotalUndertime.Text = "";
            lblTotDaysWork.Text = "";
            HAS_DTR = false;
        }

        private void frmPayrollManagement_Load(object sender, EventArgs e)
        {

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
                GetEmpDetails((int)cmbEmployeeName.SelectedValue);
                if((int)cmbPayrollPeriod.SelectedValue < 1)
                {
                    ShowMessage.CustomErrorMessage("Select Payroll period first.");
                    cmbPayrollPeriod.Focus();
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
                    lblDesignation.Text = emp.EmployeeEmpInfo.Designation;
                    lblDepartment.Text = emp.EmployeeEmpInfo.DepartmentName;
                    lblEmpType.Text = emp.EmployeeEmpInfo.EmploymentType;
                    lblRate.Text = emp.EmployeeEmpInfo.BasicPay.ToString("#,####.00");
                    lblPayOption.Text = emp.EmployeeEmpInfo.BasicRateOption;

                    try
                    {
                        var dtr = dsvc.DTR_GetDetailsForPayroll(emp.EmployeeId, (int)cmbPayrollPeriod.SelectedValue);
                        if(dtr != null)
                        {
                            lblTotalLate.Text = dtr.TotalDaysWork.ToString(".00");
                            lblTotalUndertime.Text = dtr.TotalUndertime.ToString(".00");
                            lblTotDaysWork.Text = dtr.TotalDaysWork.ToString(".00");
                            label2.Visible = false;
                            HAS_DTR = true;
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
                    catch
                    {
                        lblTotalLate.Text = "";
                        lblTotalUndertime.Text = "";
                        lblTotDaysWork.Text = "";
                        HAS_DTR = false;
                    }
                   
                }
            }
            else
            {
                ClearAll();
            }
        }

        private void cmbPayrollPeriod_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ClearAll();
                loadEmployee();
            }
            catch { }
        }
    }
}
