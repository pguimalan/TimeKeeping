namespace TimeKeeping.App
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.systemSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.semesterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.systemusersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.logoffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetLoginPasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeMasterlistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.workloadManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ToolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.dailyTimeRecordToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.StatusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.transactionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.systemSettingsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.logoffToolStripMenuItem,
            this.resetLoginPasswordToolStripMenuItem,
            this.exitApplicationToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // systemSettingsToolStripMenuItem
            // 
            this.systemSettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addressToolStripMenuItem,
            this.departmentsToolStripMenuItem,
            this.semesterToolStripMenuItem,
            this.toolStripMenuItem2,
            this.systemusersToolStripMenuItem});
            this.systemSettingsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("systemSettingsToolStripMenuItem.Image")));
            this.systemSettingsToolStripMenuItem.Name = "systemSettingsToolStripMenuItem";
            this.systemSettingsToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.systemSettingsToolStripMenuItem.Text = "System Settings";
            // 
            // addressToolStripMenuItem
            // 
            this.addressToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addressToolStripMenuItem.Image")));
            this.addressToolStripMenuItem.Name = "addressToolStripMenuItem";
            this.addressToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.addressToolStripMenuItem.Text = "Address";
            this.addressToolStripMenuItem.Click += new System.EventHandler(this.addressToolStripMenuItem_Click);
            // 
            // departmentsToolStripMenuItem
            // 
            this.departmentsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("departmentsToolStripMenuItem.Image")));
            this.departmentsToolStripMenuItem.Name = "departmentsToolStripMenuItem";
            this.departmentsToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.departmentsToolStripMenuItem.Text = "Departments";
            this.departmentsToolStripMenuItem.Click += new System.EventHandler(this.departmentsToolStripMenuItem_Click);
            // 
            // semesterToolStripMenuItem
            // 
            this.semesterToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("semesterToolStripMenuItem.Image")));
            this.semesterToolStripMenuItem.Name = "semesterToolStripMenuItem";
            this.semesterToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.semesterToolStripMenuItem.Text = "Semester";
            this.semesterToolStripMenuItem.Click += new System.EventHandler(this.semesterToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(141, 6);
            // 
            // systemusersToolStripMenuItem
            // 
            this.systemusersToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("systemusersToolStripMenuItem.Image")));
            this.systemusersToolStripMenuItem.Name = "systemusersToolStripMenuItem";
            this.systemusersToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.systemusersToolStripMenuItem.Text = "System-users";
            this.systemusersToolStripMenuItem.Click += new System.EventHandler(this.systemusersToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(185, 6);
            // 
            // logoffToolStripMenuItem
            // 
            this.logoffToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("logoffToolStripMenuItem.Image")));
            this.logoffToolStripMenuItem.Name = "logoffToolStripMenuItem";
            this.logoffToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.logoffToolStripMenuItem.Text = "Log-off";
            this.logoffToolStripMenuItem.Click += new System.EventHandler(this.logoffToolStripMenuItem_Click);
            // 
            // resetLoginPasswordToolStripMenuItem
            // 
            this.resetLoginPasswordToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("resetLoginPasswordToolStripMenuItem.Image")));
            this.resetLoginPasswordToolStripMenuItem.Name = "resetLoginPasswordToolStripMenuItem";
            this.resetLoginPasswordToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.resetLoginPasswordToolStripMenuItem.Text = "Reset Login Password";
            this.resetLoginPasswordToolStripMenuItem.Click += new System.EventHandler(this.resetLoginPasswordToolStripMenuItem_Click);
            // 
            // exitApplicationToolStripMenuItem
            // 
            this.exitApplicationToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitApplicationToolStripMenuItem.Image")));
            this.exitApplicationToolStripMenuItem.Name = "exitApplicationToolStripMenuItem";
            this.exitApplicationToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.exitApplicationToolStripMenuItem.Text = "Exit Application";
            this.exitApplicationToolStripMenuItem.Click += new System.EventHandler(this.exitApplicationToolStripMenuItem_Click);
            // 
            // transactionsToolStripMenuItem
            // 
            this.transactionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeMasterlistToolStripMenuItem,
            this.workloadManagementToolStripMenuItem,
            this.dailyTimeRecordToolStripMenuItem1});
            this.transactionsToolStripMenuItem.Name = "transactionsToolStripMenuItem";
            this.transactionsToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.transactionsToolStripMenuItem.Text = "Transactions";
            // 
            // employeeMasterlistToolStripMenuItem
            // 
            this.employeeMasterlistToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("employeeMasterlistToolStripMenuItem.Image")));
            this.employeeMasterlistToolStripMenuItem.Name = "employeeMasterlistToolStripMenuItem";
            this.employeeMasterlistToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.employeeMasterlistToolStripMenuItem.Text = "Employee Masterlist";
            this.employeeMasterlistToolStripMenuItem.Click += new System.EventHandler(this.employeeMasterlistToolStripMenuItem_Click);
            // 
            // workloadManagementToolStripMenuItem
            // 
            this.workloadManagementToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("workloadManagementToolStripMenuItem.Image")));
            this.workloadManagementToolStripMenuItem.Name = "workloadManagementToolStripMenuItem";
            this.workloadManagementToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.workloadManagementToolStripMenuItem.Text = "Workload Management";
            this.workloadManagementToolStripMenuItem.Click += new System.EventHandler(this.workloadManagementToolStripMenuItem_Click);
            // 
            // StatusStrip1
            // 
            this.StatusStrip1.BackColor = System.Drawing.SystemColors.Info;
            this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripStatusLabel1,
            this.tsUser,
            this.ToolStripStatusLabel3,
            this.tsDate});
            this.StatusStrip1.Location = new System.Drawing.Point(0, 428);
            this.StatusStrip1.Name = "StatusStrip1";
            this.StatusStrip1.Size = new System.Drawing.Size(800, 22);
            this.StatusStrip1.TabIndex = 13;
            this.StatusStrip1.Text = "StatusStrip1";
            // 
            // ToolStripStatusLabel1
            // 
            this.ToolStripStatusLabel1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripStatusLabel1.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripStatusLabel1.Image")));
            this.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
            this.ToolStripStatusLabel1.Size = new System.Drawing.Size(97, 17);
            this.ToolStripStatusLabel1.Text = "Active User :";
            // 
            // tsUser
            // 
            this.tsUser.AutoSize = false;
            this.tsUser.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsUser.Name = "tsUser";
            this.tsUser.Size = new System.Drawing.Size(90, 17);
            this.tsUser.Text = " NONE";
            this.tsUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ToolStripStatusLabel3
            // 
            this.ToolStripStatusLabel3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripStatusLabel3.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripStatusLabel3.Image")));
            this.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3";
            this.ToolStripStatusLabel3.Size = new System.Drawing.Size(59, 17);
            this.ToolStripStatusLabel3.Text = "Date :";
            // 
            // tsDate
            // 
            this.tsDate.AutoSize = false;
            this.tsDate.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsDate.Name = "tsDate";
            this.tsDate.Size = new System.Drawing.Size(121, 17);
            this.tsDate.Text = " mm/dd/yyyy";
            this.tsDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dailyTimeRecordToolStripMenuItem1
            // 
            this.dailyTimeRecordToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("dailyTimeRecordToolStripMenuItem1.Image")));
            this.dailyTimeRecordToolStripMenuItem1.Name = "dailyTimeRecordToolStripMenuItem1";
            this.dailyTimeRecordToolStripMenuItem1.Size = new System.Drawing.Size(199, 22);
            this.dailyTimeRecordToolStripMenuItem1.Text = "Daily Time Record";
            this.dailyTimeRecordToolStripMenuItem1.Click += new System.EventHandler(this.dailyTimeRecordToolStripMenuItem1_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StatusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ASSCAT  Biometric Daily Time Record System ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.StatusStrip1.ResumeLayout(false);
            this.StatusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem systemSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem logoffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addressToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetLoginPasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeMasterlistToolStripMenuItem;
        internal System.Windows.Forms.StatusStrip StatusStrip1;
        internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel1;
        internal System.Windows.Forms.ToolStripStatusLabel tsUser;
        internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel3;
        internal System.Windows.Forms.ToolStripStatusLabel tsDate;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem systemusersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem semesterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem workloadManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dailyTimeRecordToolStripMenuItem1;
    }
}