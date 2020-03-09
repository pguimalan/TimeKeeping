using DPFP;
using DPFP.Verification;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeKeeping.App.Helpers;
using TimeKeeping.Models;
using TimeKeeping.Services;
using TimeKeeping.Services.Interface;

namespace TimeKeeping.App
{
    public partial class frmTimeKeeping : Form
    {
        private List<FingerTemplates> fingerTemplateList;
        private List<FingerPrintModel> fingerPrintsModel;
        private readonly IFingerPrintService svc;
        private readonly IEmployeeService empSvc;
        private readonly IDtrService dsvc;
        string tkEvent = "";

        public frmTimeKeeping(IFingerPrintService svc, IEmployeeService empSvc, IDtrService dsvc)
        {
            this.svc = svc;
            this.empSvc = empSvc;
            this.dsvc = dsvc;
        }

        public frmTimeKeeping() : this(new FingerPrintService(), new EmployeeService(), new DtrService())
        {
            InitializeComponent();            
        }

        [DllImport("winmm.dll")]
        private static extern long mciSendString(string strCommand, StringBuilder strReturn, int iReturnLength, IntPtr hwndCallback);

        List<FingerTemplates> GetAllTemplates()
        {
            var ftemplist = new List<FingerTemplates>();
            string dir = AppDomain.CurrentDomain.BaseDirectory + "\\EmpPics\\ProfilePic\\";
            foreach (var fp in fingerPrintsModel)
            {
                var file = dir + fp.EmployeeId + "\\" + fp.Finger+ ".fpt";
                if (!File.Exists(file))
                    continue;
                var fpTemplate = new FingerTemplates();
                using (var fs = File.OpenRead(file))
                {
                    fpTemplate.FPTemplateFile = new Template(fs);
                    fpTemplate.EmpID = fp.EmployeeId;
                    fpTemplate.FilePath = file;
                    ftemplist.Add(fpTemplate);
                }
            }
            return ftemplist;
        }

        private void verifyControl_OnComplete(object Control, DPFP.FeatureSet featureSet, ref DPFP.Gui.EventHandlerStatus EventHandlerStatus)
        {
            if(!chkTimeInAM.Checked && !chkTimeOutAM.Checked && !chkTimeInPM.Checked && !chkTimeOutPM.Checked && !chkTimeOutEvening.Checked && !chkTimeInEvening.Checked)
            {
                lblTimeLog.Text = "Toggle event first.";
                return;
            }

            var ver = new Verification();
            var res = new Verification.Result();
            //ClearProfile();
            var stat = 0;
            // Compare feature set with all stored templates.
           
            foreach (var ft in fingerTemplateList.Where(ft => ft.FPTemplateFile != null))
            {
                // Compare feature set with particular template.
                ver.Verify(featureSet, ft.FPTemplateFile, ref res);

                if (!res.Verified)
                    continue;
                GetProfile(ft.EmpID);
                stat = 1;
                break; // success
            }

            ShowNotFound(stat);
        }

        void GetProfile(int empID)
        {
            try
            {
                var timelogged = DateTime.Now;
                var emp = empSvc.Employee_BasicInfo(empID);
                lblDepartment.Text = emp.DepartmentName;
                lblName.Text = emp.EmployeeFullName;
                lblName.ForeColor = Color.Black;
                pictureBox2.Image = File.Exists(AppDomain.CurrentDomain.BaseDirectory + "\\EmpPics\\ProfilePic\\" + empID + "\\" + emp.PicName) ? Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "\\EmpPics\\ProfilePic\\" + empID + "\\" + emp.PicName) : pictureBox2.InitialImage;
                lblTimeLog.Text = timelogged.ToString("hh:mm:ss tt", DateTimeFormatInfo.InvariantInfo);
                lblEmployeeType.Text = emp.EmploymentType;
                
                var retVal = dsvc.DTR_Log(empID, timelogged, tkEvent);
                switch (retVal)
                {
                    case 1:
                        lblRemarks.Text = "Employee successfully logged in.";
                        break;
                    case 2:
                        lblRemarks.Text = "Employee successfully logged out.";
                        break;
                    case 3:
                        lblRemarks.Text = "Employee successfully logged in.";
                        break;
                    case 4:
                        lblRemarks.Text = "Employee successfully logged out.";
                        break;
                    case 5:
                        lblRemarks.Text = "Employee successfully logged in.";
                        break;
                    case 6:
                        lblRemarks.Text = "Employee successfully logged out.";
                        break;
                    case -1:
                        lblRemarks.Text = "Employee has no workload yet.";
                        break;
                    case -2:
                        lblRemarks.Text = "Semester has not been set-up.";
                        break;
                    case -3:
                        lblRemarks.Text = "No morning shift for this employee.";
                        break;
                    case -4:
                        lblRemarks.Text = "Employee already logged in for morning shift.";
                        break;
                    case -5:
                        lblRemarks.Text = "No morning shift for this employee.";
                        break;
                    case -6:
                        lblRemarks.Text = "Employee already logged out for morning shift.";
                        break;
                    case -7:
                        lblRemarks.Text = "No afternoon shift for this employee.";
                        break;
                    case -8:
                        lblRemarks.Text = "Employee already logged in for afternoon shift.";
                        break;
                    case -9:
                        lblRemarks.Text = "No afternoon shift for this employee.";
                        break;
                    case -10:
                        lblRemarks.Text = "Employee already logged out for afternoon shift.";
                        break;
                    case -11:
                        lblRemarks.Text = "No evening shift for this employee.";
                        break;
                    case -12:
                        lblRemarks.Text = "Employee already logged in for evening shift.";
                        break;
                    case -13:
                        lblRemarks.Text = "No evening shift for this employee.";
                        break;
                    case -14:
                        lblRemarks.Text = "Employee already logged out for evening shift.";
                        break;
                }
            }
            catch
            {
                ShowNotFound(0);
            }
        }

        void GetAllFingerPrints()
        {
            fingerPrintsModel = svc.FingerPrint_SelectAll();
        }


        void ShowNotFound(int stat)
        {
            string filename;
            if (stat == 0)
            {
                lblDepartment.Text = "";
                lblName.Text ="Employee Not Found...";
                lblRemarks.Text = "";
                lblName.ForeColor = Color.Red;
                pictureBox2.Image = pictureBox2.InitialImage;
                lblTimeLog.Text = "";
                lblEmployeeType.Text = "";
                filename = "failed.mp3";
            }
            else
            {
                filename = "loginok.mp3";
            }

            mciSendString("open \"" + filename + "\" type mpegvideo alias MediaFile", null, 0, IntPtr.Zero);
            mciSendString("play MediaFile", null, 0, IntPtr.Zero);
        }


        internal class FingerTemplates
        {
            public string FilePath { get; set; }
            public int EmpID { get; set; }
            public Template FPTemplateFile { get; set; }
        }

        private void frmTimeKeeping_Load(object sender, EventArgs e)
        {
            lblDate.Text ="Welcome, Today is: " + DateTime.Now.ToLongDateString();
            GetAllFingerPrints();
            fingerTemplateList = GetAllTemplates();
            chkTimeInAM.Checked = true;
            tkEvent = "IN_AM";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblRunningTime.Text = DateTime.Now.ToString("hh:mm:ss tt", DateTimeFormatInfo.InvariantInfo);
        }

        private void chkTimeIn_CheckedChanged(object sender, EventArgs e)
        {
            if(chkTimeInAM.Checked)
            {
                chkTimeOutAM.Checked = false;
                chkTimeInPM.Checked = false;
                chkTimeOutPM.Checked = false;
                chkTimeInEvening.Checked = false;
                chkTimeOutEvening.Checked = false;
                tkEvent = "IN_AM";
                lblAction.Text = "Time In:";
            }
            ClearProfile();
        }

        private void chkTimeOut_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTimeOutAM.Checked)
            {
                chkTimeInAM.Checked = false;
                chkTimeInPM.Checked = false;
                chkTimeOutPM.Checked = false;
                chkTimeInEvening.Checked = false;
                chkTimeOutEvening.Checked = false;
                tkEvent = "OUT_AM";
                lblAction.Text = "Time Out:";
            }
            ClearProfile();
        }

        void ClearProfile()
        {
            lblDepartment.Text = "";
            lblName.Text = "";
            pictureBox2.Image = pictureBox2.InitialImage;
            lblTimeLog.Text = "Welcome";
            lblRemarks.Text = "";
            lblEmployeeType.Text = "";
        }

        private void frmTimeKeeping_FormClosed(object sender, FormClosedEventArgs e)
        {
            Hide();
            var frm = new frmLogin();
            frm.Show();
        }

        private void chkTimeInPM_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTimeInPM.Checked)
            {
                chkTimeInAM.Checked = false;
                chkTimeOutAM.Checked = false;
                chkTimeOutPM.Checked = false;
                chkTimeInEvening.Checked = false;
                chkTimeOutEvening.Checked = false;
                tkEvent = "IN_PM";
                lblAction.Text = "Time In:";
            }
            ClearProfile();
        }

        private void chkTimeOutPM_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTimeInPM.Checked)
            {
                chkTimeInAM.Checked = false;
                chkTimeOutAM.Checked = false;
                chkTimeInPM.Checked = false;
                chkTimeInEvening.Checked = false;
                chkTimeOutEvening.Checked = false;
                tkEvent = "OUT_PM";
                lblAction.Text = "Time Out:";
            }
            ClearProfile();
        }

        private void chkTimeInEvening_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTimeInEvening.Checked)
            {
                chkTimeInAM.Checked = false;
                chkTimeOutAM.Checked = false;
                chkTimeInPM.Checked = false;
                chkTimeOutPM.Checked = false;
                chkTimeOutEvening.Checked = false;
                tkEvent = "IN_EVE";
                lblAction.Text = "Time In:";
            }
            ClearProfile();
        }

        private void chkTimeOutEvening_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTimeOutEvening.Checked)
            {
                chkTimeInAM.Checked = false;
                chkTimeOutAM.Checked = false;
                chkTimeInPM.Checked = false;
                chkTimeOutPM.Checked = false;
                chkTimeInEvening.Checked = false;
                tkEvent = "OUT_EVE";
                lblAction.Text = "Time Out:";
            }
            ClearProfile();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtIDNum.Text.Length < 4)
            {
                return;
            }
            else
            {
                GetProfile(int.Parse(txtIDNum.Text));
                txtIDNum.Text = "";                
            }

        }

        private void txtIDNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            StringHelper.NumbersOnly(txtIDNum.Text, e);
        }
    }
}
