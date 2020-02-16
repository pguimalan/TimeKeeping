namespace TimeKeeping.App
{
    partial class frmTimeKeeping
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label lblPrompt;
            System.Windows.Forms.Label label3;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTimeKeeping));
            this.verifyControl = new DPFP.Gui.Verification.VerificationControl();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblEmployeeType = new System.Windows.Forms.Label();
            this.btnGetTimeLogs = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblRunningTime = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkTimeOutEvening = new System.Windows.Forms.CheckBox();
            this.chkTimeInEvening = new System.Windows.Forms.CheckBox();
            this.chkTimeOutPM = new System.Windows.Forms.CheckBox();
            this.chkTimeInPM = new System.Windows.Forms.CheckBox();
            this.chkTimeOutAM = new System.Windows.Forms.CheckBox();
            this.chkTimeInAM = new System.Windows.Forms.CheckBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.lblAction = new System.Windows.Forms.Label();
            this.lblTimeLog = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.logobox = new System.Windows.Forms.PictureBox();
            lblPrompt = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logobox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPrompt
            // 
            lblPrompt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            lblPrompt.AutoSize = true;
            lblPrompt.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblPrompt.ForeColor = System.Drawing.Color.Red;
            lblPrompt.Location = new System.Drawing.Point(56, 213);
            lblPrompt.Name = "lblPrompt";
            lblPrompt.Size = new System.Drawing.Size(356, 13);
            lblPrompt.TabIndex = 5;
            lblPrompt.Text = "To verify your identity, touch fingerprint reader with any enrolled finger.";
            // 
            // label3
            // 
            label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.ForeColor = System.Drawing.Color.Gray;
            label3.Location = new System.Drawing.Point(204, 110);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(166, 13);
            label3.TabIndex = 11;
            label3.Text = "Select Session Time In / Time Out";
            // 
            // verifyControl
            // 
            this.verifyControl.Active = true;
            this.verifyControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.verifyControl.Location = new System.Drawing.Point(16, 190);
            this.verifyControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.verifyControl.Name = "verifyControl";
            this.verifyControl.ReaderSerialNumber = "00000000-0000-0000-0000-000000000000";
            this.verifyControl.Size = new System.Drawing.Size(48, 49);
            this.verifyControl.TabIndex = 1;
            this.verifyControl.OnComplete += new DPFP.Gui.Verification.VerificationControl._OnComplete(this.verifyControl_OnComplete);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblEmployeeType);
            this.groupBox3.Controls.Add(this.btnGetTimeLogs);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.lblDepartment);
            this.groupBox3.Controls.Add(this.lblName);
            this.groupBox3.Controls.Add(this.pictureBox2);
            this.groupBox3.Location = new System.Drawing.Point(637, 8);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(485, 396);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            // 
            // lblEmployeeType
            // 
            this.lblEmployeeType.AutoSize = true;
            this.lblEmployeeType.BackColor = System.Drawing.Color.Transparent;
            this.lblEmployeeType.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeType.ForeColor = System.Drawing.Color.Maroon;
            this.lblEmployeeType.Location = new System.Drawing.Point(14, 340);
            this.lblEmployeeType.Name = "lblEmployeeType";
            this.lblEmployeeType.Size = new System.Drawing.Size(0, 23);
            this.lblEmployeeType.TabIndex = 11;
            // 
            // btnGetTimeLogs
            // 
            this.btnGetTimeLogs.BackColor = System.Drawing.Color.White;
            this.btnGetTimeLogs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGetTimeLogs.Location = new System.Drawing.Point(300, 19);
            this.btnGetTimeLogs.Name = "btnGetTimeLogs";
            this.btnGetTimeLogs.Size = new System.Drawing.Size(160, 53);
            this.btnGetTimeLogs.TabIndex = 10;
            this.btnGetTimeLogs.Text = "Get Time Logs";
            this.btnGetTimeLogs.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(385, 78);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(75, 20);
            this.textBox1.TabIndex = 9;
            this.textBox1.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(385, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.BackColor = System.Drawing.Color.Transparent;
            this.lblDepartment.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartment.ForeColor = System.Drawing.Color.Black;
            this.lblDepartment.Location = new System.Drawing.Point(14, 310);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(156, 29);
            this.lblDepartment.TabIndex = 7;
            this.lblDepartment.Text = "Department";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(14, 276);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(235, 33);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Employee Name";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(265, 240);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.WaitOnLoad = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblRunningTime
            // 
            this.lblRunningTime.AutoSize = true;
            this.lblRunningTime.Font = new System.Drawing.Font("Tahoma", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRunningTime.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblRunningTime.Location = new System.Drawing.Point(188, 19);
            this.lblRunningTime.Name = "lblRunningTime";
            this.lblRunningTime.Size = new System.Drawing.Size(315, 72);
            this.lblRunningTime.TabIndex = 0;
            this.lblRunningTime.Text = "12:00 PM";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(label3);
            this.groupBox2.Controls.Add(this.chkTimeOutEvening);
            this.groupBox2.Controls.Add(this.chkTimeInEvening);
            this.groupBox2.Controls.Add(this.chkTimeOutPM);
            this.groupBox2.Controls.Add(this.chkTimeInPM);
            this.groupBox2.Controls.Add(lblPrompt);
            this.groupBox2.Controls.Add(this.chkTimeOutAM);
            this.groupBox2.Controls.Add(this.chkTimeInAM);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.lblRunningTime);
            this.groupBox2.Controls.Add(this.verifyControl);
            this.groupBox2.Location = new System.Drawing.Point(7, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(625, 254);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // chkTimeOutEvening
            // 
            this.chkTimeOutEvening.AutoSize = true;
            this.chkTimeOutEvening.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTimeOutEvening.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chkTimeOutEvening.Location = new System.Drawing.Point(486, 154);
            this.chkTimeOutEvening.Name = "chkTimeOutEvening";
            this.chkTimeOutEvening.Size = new System.Drawing.Size(124, 19);
            this.chkTimeOutEvening.TabIndex = 10;
            this.chkTimeOutEvening.Text = "Evening Time-Out";
            this.chkTimeOutEvening.UseVisualStyleBackColor = true;
            this.chkTimeOutEvening.CheckedChanged += new System.EventHandler(this.chkTimeOutEvening_CheckedChanged);
            // 
            // chkTimeInEvening
            // 
            this.chkTimeInEvening.AutoSize = true;
            this.chkTimeInEvening.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTimeInEvening.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chkTimeInEvening.Location = new System.Drawing.Point(486, 126);
            this.chkTimeInEvening.Name = "chkTimeInEvening";
            this.chkTimeInEvening.Size = new System.Drawing.Size(115, 19);
            this.chkTimeInEvening.TabIndex = 9;
            this.chkTimeInEvening.Text = "Evening Time-In";
            this.chkTimeInEvening.UseVisualStyleBackColor = true;
            this.chkTimeInEvening.CheckedChanged += new System.EventHandler(this.chkTimeInEvening_CheckedChanged);
            // 
            // chkTimeOutPM
            // 
            this.chkTimeOutPM.AutoSize = true;
            this.chkTimeOutPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTimeOutPM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chkTimeOutPM.Location = new System.Drawing.Point(350, 154);
            this.chkTimeOutPM.Name = "chkTimeOutPM";
            this.chkTimeOutPM.Size = new System.Drawing.Size(132, 19);
            this.chkTimeOutPM.TabIndex = 8;
            this.chkTimeOutPM.Text = "Afternoon Time-Out";
            this.chkTimeOutPM.UseVisualStyleBackColor = true;
            this.chkTimeOutPM.CheckedChanged += new System.EventHandler(this.chkTimeOutPM_CheckedChanged);
            // 
            // chkTimeInPM
            // 
            this.chkTimeInPM.AutoSize = true;
            this.chkTimeInPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTimeInPM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chkTimeInPM.Location = new System.Drawing.Point(350, 126);
            this.chkTimeInPM.Name = "chkTimeInPM";
            this.chkTimeInPM.Size = new System.Drawing.Size(123, 19);
            this.chkTimeInPM.TabIndex = 7;
            this.chkTimeInPM.Text = "Afternoon Time-In";
            this.chkTimeInPM.UseVisualStyleBackColor = true;
            this.chkTimeInPM.CheckedChanged += new System.EventHandler(this.chkTimeInPM_CheckedChanged);
            // 
            // chkTimeOutAM
            // 
            this.chkTimeOutAM.AutoSize = true;
            this.chkTimeOutAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTimeOutAM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chkTimeOutAM.Location = new System.Drawing.Point(206, 154);
            this.chkTimeOutAM.Name = "chkTimeOutAM";
            this.chkTimeOutAM.Size = new System.Drawing.Size(126, 19);
            this.chkTimeOutAM.TabIndex = 3;
            this.chkTimeOutAM.Text = "Morning Time-Out";
            this.chkTimeOutAM.UseVisualStyleBackColor = true;
            this.chkTimeOutAM.CheckedChanged += new System.EventHandler(this.chkTimeOut_CheckedChanged);
            // 
            // chkTimeInAM
            // 
            this.chkTimeInAM.AutoSize = true;
            this.chkTimeInAM.Checked = true;
            this.chkTimeInAM.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTimeInAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTimeInAM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chkTimeInAM.Location = new System.Drawing.Point(206, 126);
            this.chkTimeInAM.Name = "chkTimeInAM";
            this.chkTimeInAM.Size = new System.Drawing.Size(120, 19);
            this.chkTimeInAM.TabIndex = 2;
            this.chkTimeInAM.Text = "Morning Time-In ";
            this.chkTimeInAM.UseVisualStyleBackColor = true;
            this.chkTimeInAM.CheckedChanged += new System.EventHandler(this.chkTimeIn_CheckedChanged);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Red;
            this.lblDate.Location = new System.Drawing.Point(151, 94);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(126, 29);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "12:00 PM";
            // 
            // lblRemarks
            // 
            this.lblRemarks.AutoSize = true;
            this.lblRemarks.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemarks.ForeColor = System.Drawing.Color.Red;
            this.lblRemarks.Location = new System.Drawing.Point(10, 348);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(0, 25);
            this.lblRemarks.TabIndex = 0;
            // 
            // lblAction
            // 
            this.lblAction.AutoSize = true;
            this.lblAction.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAction.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAction.Location = new System.Drawing.Point(8, 306);
            this.lblAction.Name = "lblAction";
            this.lblAction.Size = new System.Drawing.Size(171, 39);
            this.lblAction.TabIndex = 0;
            this.lblAction.Text = "Time In : ";
            // 
            // lblTimeLog
            // 
            this.lblTimeLog.AutoSize = true;
            this.lblTimeLog.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeLog.ForeColor = System.Drawing.Color.Green;
            this.lblTimeLog.Location = new System.Drawing.Point(176, 294);
            this.lblTimeLog.Name = "lblTimeLog";
            this.lblTimeLog.Size = new System.Drawing.Size(247, 58);
            this.lblTimeLog.TabIndex = 0;
            this.lblTimeLog.Text = "Welcome";
            this.lblTimeLog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.lblRemarks);
            this.groupBox1.Controls.Add(this.lblAction);
            this.groupBox1.Controls.Add(this.lblTimeLog);
            this.groupBox1.Location = new System.Drawing.Point(1, 132);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1131, 411);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.White;
            this.Panel1.Controls.Add(this.lblDate);
            this.Panel1.Controls.Add(this.Label2);
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Controls.Add(this.logobox);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(1139, 133);
            this.Panel1.TabIndex = 7;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label2.Location = new System.Drawing.Point(151, 69);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(542, 25);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "ASSCAT Trento Satellite Campus Biometric Attendance";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Navy;
            this.Label1.Location = new System.Drawing.Point(148, 25);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(941, 48);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Agusan Del Sur State Collete of Agriculture and Technolygy";
            // 
            // logobox
            // 
            this.logobox.Image = ((System.Drawing.Image)(resources.GetObject("logobox.Image")));
            this.logobox.Location = new System.Drawing.Point(19, 11);
            this.logobox.Name = "logobox";
            this.logobox.Size = new System.Drawing.Size(116, 111);
            this.logobox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logobox.TabIndex = 1;
            this.logobox.TabStop = false;
            // 
            // frmTimeKeeping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 546);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTimeKeeping";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmTimeKeeping_FormClosed);
            this.Load += new System.EventHandler(this.frmTimeKeeping_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logobox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DPFP.Gui.Verification.VerificationControl verifyControl;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnGetTimeLogs;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblRunningTime;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblRemarks;
        private System.Windows.Forms.Label lblAction;
        private System.Windows.Forms.Label lblTimeLog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblEmployeeType;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.PictureBox logobox;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.CheckBox chkTimeOutAM;
        private System.Windows.Forms.CheckBox chkTimeInAM;
        private System.Windows.Forms.CheckBox chkTimeOutPM;
        private System.Windows.Forms.CheckBox chkTimeInPM;
        private System.Windows.Forms.CheckBox chkTimeOutEvening;
        private System.Windows.Forms.CheckBox chkTimeInEvening;
    }
}