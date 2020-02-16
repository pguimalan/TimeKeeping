using DPFP;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using TimeKeeping.Models;
using TimeKeeping.Services;
using TimeKeeping.Services.Interface;

namespace TimeKeeping.App
{
    public partial class frmEnrollFinger : Form
    {
        public int employeeId;
        private readonly IFingerPrintService svc;
        List<FingerPrintModel> fingerPrints;
        public frmEnrollFinger(IFingerPrintService svc)
        {            
            this.svc = svc;
        }
        public frmEnrollFinger() :this(new FingerPrintService())
        {
            InitializeComponent();
        }

        private void frmEnrollFinger_Load(object sender, System.EventArgs e)
        {
            if (employeeId > 0)
            {
                fingerPrints = svc.FingerPrint_ByEmpId(employeeId);

                foreach (var fp in fingerPrints)
                {
                    enrollControl.EnrolledFingerMask = fp.Mask;
                }
            }
        }

        private void enrollControl_OnDelete(object Control, int finger, ref DPFP.Gui.EventHandlerStatus EventHandlerStatus)
        {
            DeleteTemplateImage(finger);
        }

        void DeleteTemplateImage(int lFingerMask)
        {
            var file = AppDomain.CurrentDomain.BaseDirectory + "\\EmpPics\\ProfilePic\\" + employeeId + "\\" + lFingerMask + ".fpt";
            if (File.Exists(file))
            {
                File.Delete(file);
            }
        }

        private void enrollControl_OnEnroll(object Control, int finger, DPFP.Template template, ref DPFP.Gui.EventHandlerStatus EventHandlerStatus)
        {
            SaveTemplateImage(template, finger);
        }

        void SaveTemplateImage(Template fingerTemplate, int lFingerMask)
        {
            var dir = AppDomain.CurrentDomain.BaseDirectory + "\\EmpPics\\ProfilePic\\" + employeeId + "\\";
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            using (var fs = File.Open(dir + lFingerMask + ".fpt", FileMode.Create, FileAccess.Write))
            {
                fingerTemplate.Serialize(fs);
            }
            svc.FingerPrint_Insert(new FingerPrintModel { EmployeeId = employeeId, Finger = (Int16)lFingerMask, Mask = enrollControl.EnrolledFingerMask });
        }
    }
}
