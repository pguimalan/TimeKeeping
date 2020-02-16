namespace TimeKeeping.App
{
    partial class frmEnrollFinger
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEnrollFinger));
            this.enrollControl = new DPFP.Gui.Enrollment.EnrollmentControl();
            this.SuspendLayout();
            // 
            // enrollControl
            // 
            this.enrollControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.enrollControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.enrollControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.enrollControl.EnrolledFingerMask = 0;
            this.enrollControl.Location = new System.Drawing.Point(0, 0);
            this.enrollControl.MaxEnrollFingerCount = 10;
            this.enrollControl.Name = "enrollControl";
            this.enrollControl.ReaderSerialNumber = "00000000-0000-0000-0000-000000000000";
            this.enrollControl.Size = new System.Drawing.Size(495, 314);
            this.enrollControl.TabIndex = 1;
            this.enrollControl.OnDelete += new DPFP.Gui.Enrollment.EnrollmentControl._OnDelete(this.enrollControl_OnDelete);
            this.enrollControl.OnEnroll += new DPFP.Gui.Enrollment.EnrollmentControl._OnEnroll(this.enrollControl_OnEnroll);
            // 
            // frmEnrollFinger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 314);
            this.Controls.Add(this.enrollControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEnrollFinger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Finger Print Enrollment";
            this.Load += new System.EventHandler(this.frmEnrollFinger_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DPFP.Gui.Enrollment.EnrollmentControl enrollControl;
    }
}