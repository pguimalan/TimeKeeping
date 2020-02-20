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
    public partial class frmEmployee_AE : Form
    {
        public bool ADD_STATE;
        public int employeeId;
        string picName = "";
        string picPath = "";
        private readonly IDepartmentService svc;
        private readonly IEmployeeService empSvc;
        EmployeeForInsertModel emp;

        public frmEmployee_AE(IDepartmentService svc, IEmployeeService empSvc)
        {
            this.svc = svc;
            this.empSvc = empSvc;
        }

        public frmEmployee_AE() : this(new DepartmentService(), new EmployeeService())
        {
            InitializeComponent();
        }

        private void bttnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmAddress f = new frmAddress
            {
                IsSelectAddress = true
            };
            f.ShowDialog();
            txtResidentialAddress2.Text = f.strAddressSelected;
        }

        private void bttnRefresh_Click(object sender, EventArgs e)
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else if (control is MaskedTextBox)
                        (control as MaskedTextBox).Clear();
                    else
                        func(control.Controls);
            };
            txtLastName.Focus();
            cmbCitizen.Text = "";
            cmbCivilStatus.Text = "";
            cmbEmpType.Text = "";
            cmbGender.Text = "";
            cmbReligion.Text = "";
            cmbSuffix.Text = "";
            cmbDepartment.Text = "";
            txtResidentialAddress2.Text = "";
            txtCurrentAddress2.Text = "";
            txtParentAddress2.Text = "";
            func(Controls);
            tabControl1.SelectedIndex = 0;
            ADD_STATE = true;
            employeeId = 0;
            bttnSave.Text = "Save Item";
            picEmployee.Image = picEmployee.InitialImage;
            label76.Text = "";
            txtBasicPay.Text = "0.00";
            button6.Enabled = false;
        }

        void loadDepartment()
        {
            cmbDepartment.DataSource = null;
            cmbDepartment.Items.Clear();
            List<DepartmentModel> list = svc.Department_Select("");
            cmbDepartment.DataSource = list;
            cmbDepartment.DisplayMember = "DepartmentName";
            cmbDepartment.ValueMember = "DepartmentId";
        }

        private void frmEmployee_AE_Load(object sender, EventArgs e)
        {
            loadDepartment();
            if (employeeId > 0 && !ADD_STATE)
            {
                emp = empSvc.Employee_SelectById(employeeId);
                label76.Text = "Employee ID No. : " + emp.EmployeeId.ToString("0000");
                txtLastName.Text = emp.EmployeeBasicInfo.LastName;
                txtFirstName.Text = emp.EmployeeBasicInfo.FirstName;
                txtMiddleName.Text = emp.EmployeeBasicInfo.MiddleName;
                cmbSuffix.Text = emp.EmployeeBasicInfo.Suffix;
                dtBdate.Value = DateTime.Parse(emp.EmployeeBasicInfo.BirthDate);
                txtPlaceOfBirth.Text = emp.EmployeeBasicInfo.PlaceOfBirth;
                cmbGender.Text = emp.EmployeeBasicInfo.Gender;
                cmbCitizen.Text = emp.EmployeeBasicInfo.Citizenship;
                txtHeight.Text = emp.EmployeeBasicInfo.Height;
                txtWeight.Text = emp.EmployeeBasicInfo.Weight;
                cmbReligion.Text = emp.EmployeeBasicInfo.Religion;
                txtResidentialAddress1.Text = emp.EmployeeBasicInfo.ResidentialAddress1;
                txtResidentialAddress2.Text = emp.EmployeeBasicInfo.ResidentialAddress2;
                txtCurrentAddress1.Text = emp.EmployeeBasicInfo.CurrentAddress1;
                txtCurrentAddress2.Text = emp.EmployeeBasicInfo.CurrentAddress2;
                cmbCivilStatus.Text = emp.EmployeeBasicInfo.CivilStatus;

                txtElementary.Text = emp.EmployeeEducation.Elementary;
                dtElemGraduated.Value = emp.EmployeeEducation.ElemDateGraduated;
                txtHighSchool.Text = emp.EmployeeEducation.HighSchool;
                dtHSGraduated.Value = emp.EmployeeEducation.HighSchoolDateGraduated;
                txtVocational.Text = emp.EmployeeEducation.Vocational;
                txtVocationalCourse.Text = emp.EmployeeEducation.VocationalCourse;
                dtVocGraduated.Value = emp.EmployeeEducation.VocationalDateGraduated;
                txtCollege.Text = emp.EmployeeEducation.College;
                txtCollegeCourse.Text = emp.EmployeeEducation.CollegeCourse;
                dtCollegeGraudated.Value = emp.EmployeeEducation.CollegeDateGraduated;
                txtEdcuAttainment.Text = emp.EmployeeEducation.HighestEducAttainment;
                txtRemarks.Text = emp.EmployeeEducation.EducationalBackgroundRemarks;

                txtSpouseName.Text = emp.EmployeeContactInfo.SpouseName;
                dtSpouseBdate.Value = emp.EmployeeContactInfo.SpouseBirthDate;
                txtSpouseOccupation.Text = emp.EmployeeContactInfo.SpouseOccupation;
                dtFatherBdate.Value = emp.EmployeeContactInfo.FatherBirthDate;
                txtFatherName.Text = emp.EmployeeContactInfo.FatherName;
                txtFatherOccupation.Text = emp.EmployeeContactInfo.FatherOccupation;
                txtMotherName.Text = emp.EmployeeContactInfo.MotherName;
                txtMotherOccupation.Text = emp.EmployeeContactInfo.MotherOccupation;
                dtMotherBdate.Value = emp.EmployeeContactInfo.MotherBirthDate;
                txtParentAddress1.Text = emp.EmployeeContactInfo.ParentAddress1;
                txtParentAddress2.Text = emp.EmployeeContactInfo.ParentAddress2;
                txtContactNum1.Text = emp.EmployeeContactInfo.ContactNum1;
                txtContactNum2.Text = emp.EmployeeContactInfo.ContactNum2;
                txtEmailAddress.Text = emp.EmployeeContactInfo.EmailAddress;
                txtContactPersonName.Text = emp.EmployeeContactInfo.ContactPersonName;
                txtContactPersonMobile.Text = emp.EmployeeContactInfo.ContactPersonNumber;
                txtContactPersonAddress1.Text = emp.EmployeeContactInfo.ContactPersonAddress1;
                txtContactPersonAddress2.Text = emp.EmployeeContactInfo.ContactPersonAddress2;

                if (emp.EmployeeBasicInfo.CivilStatus != "Single")
                {
                    txtSpouseName.Enabled = true;
                    txtSpouseOccupation.Enabled = true;
                    dtSpouseBdate.Enabled = true;
                }

                if ((emp.EmployeeBasicInfo.ResidentialAddress1 == emp.EmployeeBasicInfo.CurrentAddress1) && (emp.EmployeeBasicInfo.ResidentialAddress2 == emp.EmployeeBasicInfo.CurrentAddress2))
                    checkBox1.Checked = true;
                else
                    checkBox1.Checked = false;

                if ((emp.EmployeeBasicInfo.ResidentialAddress1 == emp.EmployeeContactInfo.ParentAddress1) && (emp.EmployeeBasicInfo.ResidentialAddress2 == emp.EmployeeContactInfo.ParentAddress2))
                    checkBox2.Checked = true;
                else checkBox2.Checked = false;

                if (emp.EmployeeEducation.HighestEducAttainment != "")
                    checkBox3.Checked = true;
                else checkBox3.Checked = false;

                txtDesignation.Text = emp.EmployeeEmpInfo.Designation;
                cmbDepartment.SelectedValue = emp.EmployeeEmpInfo.DepartmentId;
                cmbEmpType.Text = emp.EmployeeEmpInfo.EmploymentType;
                txtBasicPay.Text = emp.EmployeeEmpInfo.BasicPay.ToString("#,####.00");
                dtDateHired.Value = emp.EmployeeEmpInfo.DateHired;
                txtTIN.Text = emp.EmployeeEmpInfo.TINNo;
                txtSSS.Text = emp.EmployeeEmpInfo.SSSNo;
                txtPhilHealth.Text = emp.EmployeeEmpInfo.PhilHealth;
                txtPagIbig.Text = emp.EmployeeEmpInfo.PagIbigNo;
                txtCharRefFullName1.Text = emp.EmployeeEmpInfo.CharRefFullName1;
                txtCharRefFullName2.Text = emp.EmployeeEmpInfo.CharRefFullName2;
                txtCharRefFullName3.Text = emp.EmployeeEmpInfo.CharRefFullName3;
                txtCharRefOccupation1.Text = emp.EmployeeEmpInfo.CharRefOccupation1;
                txtCharRefOccupation2.Text = emp.EmployeeEmpInfo.CharRefOccupation2;
                txtCharRefOccupation3.Text = emp.EmployeeEmpInfo.CharRefOccupation3;
                txtCharRefContactNum1.Text = emp.EmployeeEmpInfo.CharRefContactNum1;
                txtCharRefContactNum2.Text = emp.EmployeeEmpInfo.CharRefContactNum2;
                txtCharRefContactNum3.Text = emp.EmployeeEmpInfo.CharRefContactNum3;
                cmbEmpStatus.Text = emp.EmployeeEmpInfo.EmpStatus;
                cmbRateOption.Text = emp.EmployeeEmpInfo.BasicRateOption;

                bttnSave.Text = "&Edit Item";
                if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "\\EmpPics\\ProfilePic\\"+ employeeId +"\\" + emp.EmployeeBasicInfo.PicName) == true)
                {
                    picEmployee.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "\\EmpPics\\ProfilePic\\"+ employeeId +"\\" + emp.EmployeeBasicInfo.PicName, true);
                }

                gbLeaveCredits.Enabled = true;

                loadLeaveCredits();
                button6.Enabled = true;
            }
        }

        void loadLeaveCredits()
        {
            EmployeeLeaveCreditsModel md = empSvc.LeaveCredits_Select(employeeId);
            txtVL.Text = md.VL.ToString();
            txtSL.Text = md.SL.ToString();
        }

        private void bttnSave_Click(object sender, EventArgs e)
        {
            int result;
            picName = (txtFirstName.Text + " " + txtLastName.Text + ".jpeg");

            if (Validation.IsTextEmpty(txtLastName))
            {
                tabControl1.SelectedIndex = 0;
                Validation.FocusTextBox(txtLastName, "Last Name");                
                return;
            }
            else if (Validation.IsTextEmpty(txtFirstName))
            {
                tabControl1.SelectedIndex = 0;
                Validation.FocusTextBox(txtFirstName, "First Name");                
                return;
            }
            else if (Validation.IsTextEmpty(txtMiddleName))
            {
                tabControl1.SelectedIndex = 0;
                Validation.FocusTextBox(txtMiddleName, "Middle Name");                
                return;
            }
            else if (Validation.IsComboEmpty(cmbGender))
            {
                tabControl1.SelectedIndex = 0;
                Validation.FocusComboBox(cmbGender, "Gender");                
                return;
            }
            else if (Validation.IsComboEmpty(cmbCivilStatus))
            {
                tabControl1.SelectedIndex = 0;
                Validation.FocusComboBox(cmbCivilStatus, "Marital Status");                
                return;
            }
            else if (Validation.IsComboEmpty(cmbCitizen))
            {
                tabControl1.SelectedIndex = 0;
                Validation.FocusComboBox(cmbCitizen, "Citizenship");                
                return;
            }
            else if (Validation.IsTextEmpty(txtResidentialAddress1))
            {
                tabControl1.SelectedIndex = 0;
                Validation.FocusTextBox(txtResidentialAddress1, "Residential street address");                
                return;
            }
            else if (txtResidentialAddress2.Text == string.Empty)
            {
                tabControl1.SelectedIndex = 0;
                ShowMessage.CustomErrorMessage("Residential Address2 is empty. Please check the field.");                
                button2.PerformClick();
            }
            else if (cmbCivilStatus.Text == "Married" && Validation.IsTextEmpty(txtSpouseName))
            {
                tabControl1.SelectedIndex = 2;
                Validation.FocusTextBox(txtSpouseName, "Spouse Name");               

                return;
            }
            else if (Validation.IsTextEmpty(txtDesignation))
            {
                tabControl1.SelectedIndex = 3;
                Validation.FocusTextBox(txtDesignation, "Designation");                
                return;
            }
            else if (Validation.IsComboEmpty(cmbDepartment))
            {
                tabControl1.SelectedIndex = 3;
                Validation.FocusComboBox(cmbDepartment, "Department");                
                return;
            }
            else if (Validation.IsComboEmpty(cmbEmpType))
            {
                tabControl1.SelectedIndex = 3;
                Validation.FocusComboBox(cmbEmpType, "Employee Type");                
                return;
            }
            else if (double.Parse(txtBasicPay.Text) <= 0) 
            {
                tabControl1.SelectedIndex = 3;
                MessageBox.Show("Invalid basic pay value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
                txtBasicPay.Focus();                
                return;
            }
            else if (Validation.IsComboEmpty(cmbRateOption))
            {
                tabControl1.SelectedIndex = 3;
                Validation.FocusComboBox(cmbRateOption, "Basic Rate Option");                
                return;
            }
            else if (Validation.IsComboEmpty(cmbEmpStatus))
            {
                tabControl1.SelectedIndex = 3;
                Validation.FocusComboBox(cmbEmpStatus, "Employee Status");                
                return;
            }
            else
            {
                EmployeeForInsertModel em = new EmployeeForInsertModel
                {
                    EmployeeBasicInfo = new EmployeeBasicInfoForInsertModel
                    {
                        LastName = txtLastName.Text,
                        FirstName = txtFirstName.Text,
                        MiddleName = txtMiddleName.Text,
                        Suffix = cmbSuffix.Text,
                        BirthDate = dtBdate.Text,
                        PlaceOfBirth = txtPlaceOfBirth.Text,
                        Gender = cmbGender.Text,
                        Citizenship = cmbCitizen.Text,
                        Height = txtHeight.Text,
                        Weight = txtWeight.Text,
                        Religion = cmbReligion.Text,
                        ResidentialAddress1 = txtResidentialAddress1.Text,
                        ResidentialAddress2 = txtResidentialAddress2.Text,
                        CurrentAddress1 = txtCurrentAddress1.Text,
                        CurrentAddress2 = txtCurrentAddress2.Text,
                        CivilStatus = cmbCivilStatus.Text
                    },
                    EmployeeEducation = new EmployeeEducationForInsertModel
                    {
                        Elementary = txtElementary.Text,
                        ElemDateGraduated = dtElemGraduated.Value,
                        HighSchool = txtHighSchool.Text,
                        HighSchoolDateGraduated = dtHSGraduated.Value,
                        Vocational = txtVocational.Text,
                        VocationalCourse = txtVocationalCourse.Text,
                        VocationalDateGraduated = dtVocGraduated.Value,
                        College = txtCollege.Text,
                        CollegeCourse = txtCollegeCourse.Text,
                        CollegeDateGraduated = dtCollegeGraudated.Value,
                        HighestEducAttainment = txtEdcuAttainment.Text,
                        EducationalBackgroundRemarks = txtRemarks.Text
                    },
                    EmployeeContactInfo = new EmployeeContactInfoForInsertModel
                    {
                        SpouseName = txtSpouseName.Text,
                        SpouseBirthDate = dtSpouseBdate.Value,
                        SpouseOccupation = txtSpouseOccupation.Text,
                        FatherBirthDate = dtFatherBdate.Value,
                        FatherName = txtFatherName.Text,
                        FatherOccupation = txtFatherOccupation.Text,
                        MotherName = txtMotherName.Text,
                        MotherOccupation = txtMotherOccupation.Text,
                        MotherBirthDate = dtMotherBdate.Value,
                        ParentAddress1 = txtParentAddress1.Text,
                        ParentAddress2 = txtParentAddress2.Text,
                        ContactNum1 = txtContactNum1.Text,
                        ContactNum2 = txtContactNum2.Text,
                        EmailAddress = txtEmailAddress.Text,
                        ContactPersonName = txtContactPersonName.Text,
                        ContactPersonNumber = txtContactPersonMobile.Text,
                        ContactPersonAddress1 = txtContactPersonAddress1.Text,
                        ContactPersonAddress2 = txtContactPersonAddress2.Text
                    },
                    EmployeeEmpInfo = new EmployeeEmpInfoForInsertModel
                    {
                        Designation = txtDesignation.Text,
                        DepartmentId = (int)cmbDepartment.SelectedValue,
                        EmploymentType = cmbEmpType.Text,
                        BasicPay = decimal.Parse(txtBasicPay.Text),
                        DateHired = dtDateHired.Value,
                        TINNo = txtTIN.Text,
                        SSSNo = txtSSS.Text,
                        PhilHealth = txtPhilHealth.Text,
                        PagIbigNo = txtPagIbig.Text,
                        CharRefFullName1 = txtCharRefFullName1.Text,
                        CharRefFullName2 = txtCharRefFullName2.Text,
                        CharRefFullName3 = txtCharRefFullName3.Text,
                        CharRefOccupation1 = txtCharRefOccupation1.Text,
                        CharRefOccupation2 = txtCharRefOccupation2.Text,
                        CharRefOccupation3 = txtCharRefOccupation3.Text,
                        CharRefContactNum1 = txtCharRefContactNum1.Text,
                        CharRefContactNum2 = txtCharRefContactNum2.Text,
                        CharRefContactNum3 = txtCharRefContactNum3.Text,
                        EmpStatus = cmbEmpStatus.Text,
                        BasicRateOption = cmbRateOption.Text
                    }
                };

                if (ADD_STATE == true)
                {
                    em.EmployeeBasicInfo.PicName = picName;
                    result = empSvc.Employee_Insert(em);

                    if (picPath.Equals(""))
                    {
                        picName = "NoPic";
                    }
                    else
                    {
                        Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "\\EmpPics\\ProfilePic\\" + result + "\\");
                        File.Copy(picPath, AppDomain.CurrentDomain.BaseDirectory + "\\EmpPics\\ProfilePic\\" + result + "\\" + picName, true);
                    }

                    if (result > 0)
                    {
                        ShowMessage.ShowMessageBox(1);
                        this.Close();
                    }
                    else if (result == -1)
                        ShowMessage.ShowMessageBox(4);
                    else
                        ShowMessage.ShowMessageBox(3);

                    this.Close();
                }
                else
                {
                    if (picPath != "")
                    {
                        em.EmployeeBasicInfo.PicName = picName;
                        if (!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + "\\EmpPics\\ProfilePic\\" + employeeId + "\\"))
                        {
                            Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "\\EmpPics\\ProfilePic\\" + employeeId + "\\");
                        }

                        if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "\\EmpPics\\ProfilePic\\" + employeeId + "\\" + picName) == true)
                        {
                            File.Delete(AppDomain.CurrentDomain.BaseDirectory + "\\EmpPics\\ProfilePic\\" + employeeId + "\\" + picName);
                            File.Copy(picPath, AppDomain.CurrentDomain.BaseDirectory + "\\EmpPics\\ProfilePic\\" + employeeId + "\\" + picName, true);
                        }
                        else
                        {
                            File.Copy(picPath, AppDomain.CurrentDomain.BaseDirectory + "\\EmpPics\\ProfilePic\\" + employeeId + "\\" + picName, true);
                        }
                    }
                    else em.EmployeeBasicInfo.PicName = emp.EmployeeBasicInfo.PicName;

                    em.EmployeeId = this.employeeId;
                    empSvc.Employee_Update(em);
                    ShowMessage.ShowMessageBox(2);                   
                }
            }
        }

        private void txtLastName_Leave(object sender, EventArgs e)
        {
            if (txtLastName.Text != "")
            {
                Validation.NormalTextbox(txtLastName);
                StringHelper.UppercaseFirst(txtLastName);
            }
        }

        private void txtFirstName_Leave(object sender, EventArgs e)
        {
            if (txtFirstName.Text != "")
            {
                Validation.NormalTextbox(txtFirstName);
                StringHelper.UppercaseFirst(txtFirstName);
            }
        }

        private void txtMiddleName_Leave(object sender, EventArgs e)
        {
            if (txtMiddleName.Text != "")
            {
                Validation.NormalTextbox(txtMiddleName);
                StringHelper.UppercaseFirst(txtMiddleName);
            }
        }

        private void txtResidentialAddress1_Leave(object sender, EventArgs e)
        {
            if (txtMiddleName.Text != "")
            {
                Validation.NormalTextbox(txtResidentialAddress1);
                StringHelper.UppercaseFirst(txtResidentialAddress1);
            }
        }

        private void bttnPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog openIMG = new OpenFileDialog();

            try
            {
                openIMG.Filter = "Known graphics format (*.bmp,*.jpg,*.gif)|*.bmp;*.jpg;*.gif;*.jpeg";
                openIMG.ShowDialog();
                picPath = openIMG.FileName;
                if (picPath != "")
                {
                    picEmployee.Image.Dispose();
                    picEmployee.Image = null;
                    picEmployee.Image = Image.FromFile(picPath);
                }
            }
            catch
            {
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAddress f = new frmAddress
            {
                IsSelectAddress = true
            };
            f.ShowDialog();
            txtCurrentAddress2.Text = f.strAddressSelected;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmAddress f = new frmAddress
            {
                IsSelectAddress = true
            };
            f.ShowDialog();
            txtParentAddress2.Text = f.strAddressSelected;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmAddress f = new frmAddress
            {
                IsSelectAddress = true
            };
            f.ShowDialog();
            txtContactPersonAddress2.Text = f.strAddressSelected;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtCurrentAddress1.Text = txtResidentialAddress1.Text;
                txtCurrentAddress2.Text = txtResidentialAddress2.Text;
            }
            else
            {
                txtCurrentAddress1.Clear();
                txtCurrentAddress2.Text = "";
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                txtParentAddress1.Text = txtResidentialAddress1.Text;
                txtParentAddress2.Text = txtResidentialAddress2.Text;
            }
            else
            {
                txtParentAddress1.Clear();
                txtParentAddress2.Text = "";
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
                txtEdcuAttainment.Enabled = true;
            else
            {
                txtEdcuAttainment.Enabled = false;
                txtEdcuAttainment.Text = "";
            }
        }

        private void txtPlaceOfBirth_Leave(object sender, EventArgs e)
        {
            StringHelper.UppercaseFirst(txtPlaceOfBirth);
        }

        private void txtCurrentAddress1_Leave(object sender, EventArgs e)
        {
            StringHelper.UppercaseFirst(txtCurrentAddress1);
        }

        private void txtElementary_Leave(object sender, EventArgs e)
        {
            StringHelper.UppercaseFirst(txtElementary);
        }

        private void txtHighSchool_Leave(object sender, EventArgs e)
        {
            StringHelper.UppercaseFirst(txtHighSchool);
        }

        private void txtVocational_Leave(object sender, EventArgs e)
        {
            StringHelper.UppercaseFirst(txtVocational);
        }

        private void txtCollege_Leave(object sender, EventArgs e)
        {
            StringHelper.UppercaseFirst(txtCollege);
        }

        private void txtSpouseName_Leave(object sender, EventArgs e)
        {
            if (txtSpouseName.Text != "")
            {
                Validation.NormalTextbox(txtSpouseName);
                StringHelper.UppercaseFirst(txtSpouseName);
            }
        }

        private void txtSpouseOccupation_Leave(object sender, EventArgs e)
        {
            StringHelper.UppercaseFirst(txtSpouseOccupation);
        }

        private void txtFatherName_Leave(object sender, EventArgs e)
        {
            StringHelper.UppercaseFirst(txtFatherName);
        }

        private void txtFatherOccupation_Leave(object sender, EventArgs e)
        {
            StringHelper.UppercaseFirst(txtFatherOccupation);
        }

        private void txtMotherName_Leave(object sender, EventArgs e)
        {
            StringHelper.UppercaseFirst(txtMotherName);
        }

        private void txtMotherOccupation_Leave(object sender, EventArgs e)
        {
            StringHelper.UppercaseFirst(txtMotherOccupation);
        }

        private void txtParentAddress1_Leave(object sender, EventArgs e)
        {
            StringHelper.UppercaseFirst(txtParentAddress1);
        }

        private void txtContactPersonName_Leave(object sender, EventArgs e)
        {
            StringHelper.UppercaseFirst(txtContactPersonName);
        }

        private void txtContactPersonAddress1_Leave(object sender, EventArgs e)
        {
            StringHelper.UppercaseFirst(txtContactPersonAddress1);
        }

        private void txtDesignation_Leave(object sender, EventArgs e)
        {
            if (txtDesignation.Text != "")
            {
                Validation.NormalTextbox(txtDesignation);
                StringHelper.UppercaseFirst(txtDesignation);
            }
        }

        private void txtCharRefFullName1_Leave(object sender, EventArgs e)
        {
            StringHelper.UppercaseFirst(txtCharRefFullName1);
        }

        private void txtCharRefFullName2_Leave(object sender, EventArgs e)
        {
            StringHelper.UppercaseFirst(txtCharRefFullName2);
        }

        private void txtCharRefFullName3_Leave(object sender, EventArgs e)
        {
            StringHelper.UppercaseFirst(txtCharRefFullName3);
        }

        private void txtCharRefOccupation1_Leave(object sender, EventArgs e)
        {
            StringHelper.UppercaseFirst(txtCharRefOccupation1);
        }

        private void txtCharRefOccupation2_Leave(object sender, EventArgs e)
        {
            StringHelper.UppercaseFirst(txtCharRefOccupation2);
        }

        private void txtCharRefOccupation3_Leave(object sender, EventArgs e)
        {
            StringHelper.UppercaseFirst(txtCharRefOccupation3);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tabControl1.SelectedIndex = 3;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int result = empSvc.LeaveCredits_Update(employeeId);
            switch (result)
            {
                case -1:
                    ShowMessage.CustomErrorMessage("Leaves will only be credited to regular employees.");
                    break;
                case -2:
                    ShowMessage.CustomErrorMessage("Employee must at least rendered 1 year of service.");
                    break;
                case -3:
                    ShowMessage.CustomErrorMessage("Already have leave credits for this year.");
                    break;
                case 1:
                    MessageBox.Show("Leave credits successfully Updated.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                default:
                    ShowMessage.ShowMessageBox(2);
                    break;

            }

            loadLeaveCredits();
        }

        private void txtBasicPay_KeyPress(object sender, KeyPressEventArgs e)
        {
            StringHelper.NumbersOnly(txtBasicPay.Text, e);
        }

        private void txtBasicPay_Leave(object sender, EventArgs e)
        {
            StringHelper.FormatAmountNumber(txtBasicPay);
        }

        private void cmbCivilStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCivilStatus.Text != "Single")
            {
                txtSpouseName.Enabled = true;
                txtSpouseOccupation.Enabled = true;
                dtSpouseBdate.Enabled = true;
            }
            else
            {
                txtSpouseName.Enabled = false;
                txtSpouseName.Text = "";
                txtSpouseOccupation.Enabled = false;
                txtSpouseOccupation.Text = "";
                dtSpouseBdate.Enabled = false;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmEnrollFinger f = new frmEnrollFinger();
            f.employeeId = employeeId;
            f.ShowDialog();
        }
    }
}
