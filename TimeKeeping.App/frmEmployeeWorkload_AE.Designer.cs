namespace TimeKeeping.App
{
    partial class frmEmployeeWorkload_AE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployeeWorkload_AE));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkPM = new System.Windows.Forms.CheckBox();
            this.chkAM = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtTimeOutPM = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtTimeInPM = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtTimeOutAM = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtTimeInAM = new System.Windows.Forms.DateTimePicker();
            this.cmbDay = new System.Windows.Forms.ComboBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.bttnExit = new System.Windows.Forms.Button();
            this.bttnRefresh = new System.Windows.Forms.Button();
            this.bttnSave = new System.Windows.Forms.Button();
            this.chkEvening = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dtTimeOutEvening = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtTimeInEvening = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkEvening);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.chkPM);
            this.groupBox1.Controls.Add(this.chkAM);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.cmbDay);
            this.groupBox1.Controls.Add(this.lblDepartment);
            this.groupBox1.Location = new System.Drawing.Point(9, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(876, 174);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // chkPM
            // 
            this.chkPM.AutoSize = true;
            this.chkPM.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.chkPM.Location = new System.Drawing.Point(305, 55);
            this.chkPM.Name = "chkPM";
            this.chkPM.Size = new System.Drawing.Size(158, 20);
            this.chkPM.TabIndex = 178;
            this.chkPM.Text = "No Afternoon Schedule";
            this.chkPM.UseVisualStyleBackColor = true;
            this.chkPM.CheckedChanged += new System.EventHandler(this.chkPM_CheckedChanged);
            // 
            // chkAM
            // 
            this.chkAM.AutoSize = true;
            this.chkAM.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.chkAM.Location = new System.Drawing.Point(16, 55);
            this.chkAM.Name = "chkAM";
            this.chkAM.Size = new System.Drawing.Size(148, 20);
            this.chkAM.TabIndex = 179;
            this.chkAM.Text = "No Morning Schedule";
            this.chkAM.UseVisualStyleBackColor = true;
            this.chkAM.CheckedChanged += new System.EventHandler(this.chkAM_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtTimeOutPM);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dtTimeInPM);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox2.Location = new System.Drawing.Point(305, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(273, 79);
            this.groupBox2.TabIndex = 177;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PM";
            // 
            // dtTimeOutPM
            // 
            this.dtTimeOutPM.CustomFormat = "  hh:mm tt";
            this.dtTimeOutPM.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTimeOutPM.Location = new System.Drawing.Point(130, 41);
            this.dtTimeOutPM.Name = "dtTimeOutPM";
            this.dtTimeOutPM.ShowUpDown = true;
            this.dtTimeOutPM.Size = new System.Drawing.Size(113, 23);
            this.dtTimeOutPM.TabIndex = 25;
            this.dtTimeOutPM.Value = new System.DateTime(2012, 3, 25, 17, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(20, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 16);
            this.label4.TabIndex = 28;
            this.label4.Text = "Time Out PM";
            // 
            // dtTimeInPM
            // 
            this.dtTimeInPM.CustomFormat = "  hh:mm tt";
            this.dtTimeInPM.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTimeInPM.Location = new System.Drawing.Point(130, 14);
            this.dtTimeInPM.Name = "dtTimeInPM";
            this.dtTimeInPM.ShowUpDown = true;
            this.dtTimeInPM.Size = new System.Drawing.Size(113, 23);
            this.dtTimeInPM.TabIndex = 24;
            this.dtTimeInPM.Value = new System.DateTime(2012, 3, 25, 13, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(20, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 29;
            this.label3.Text = "Time In PM";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.dtTimeOutAM);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.dtTimeInAM);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox3.Location = new System.Drawing.Point(15, 81);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(273, 79);
            this.groupBox3.TabIndex = 176;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "AM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(17, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 30;
            this.label2.Text = "Time Out AM";
            // 
            // dtTimeOutAM
            // 
            this.dtTimeOutAM.CustomFormat = "  hh:mm tt";
            this.dtTimeOutAM.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTimeOutAM.Location = new System.Drawing.Point(130, 41);
            this.dtTimeOutAM.Name = "dtTimeOutAM";
            this.dtTimeOutAM.ShowUpDown = true;
            this.dtTimeOutAM.Size = new System.Drawing.Size(113, 23);
            this.dtTimeOutAM.TabIndex = 26;
            this.dtTimeOutAM.Value = new System.DateTime(2012, 3, 25, 12, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(17, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 31;
            this.label5.Text = "Time In AM";
            // 
            // dtTimeInAM
            // 
            this.dtTimeInAM.CustomFormat = "  hh:mm tt";
            this.dtTimeInAM.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTimeInAM.Location = new System.Drawing.Point(130, 14);
            this.dtTimeInAM.Name = "dtTimeInAM";
            this.dtTimeInAM.ShowUpDown = true;
            this.dtTimeInAM.Size = new System.Drawing.Size(113, 23);
            this.dtTimeInAM.TabIndex = 27;
            this.dtTimeInAM.Value = new System.DateTime(2012, 3, 25, 7, 30, 0, 0);
            // 
            // cmbDay
            // 
            this.cmbDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDay.FormattingEnabled = true;
            this.cmbDay.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.cmbDay.Location = new System.Drawing.Point(100, 20);
            this.cmbDay.Name = "cmbDay";
            this.cmbDay.Size = new System.Drawing.Size(250, 21);
            this.cmbDay.TabIndex = 175;
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartment.ForeColor = System.Drawing.Color.Navy;
            this.lblDepartment.Location = new System.Drawing.Point(12, 22);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(82, 14);
            this.lblDepartment.TabIndex = 174;
            this.lblDepartment.Text = "Day of Week:";
            // 
            // bttnExit
            // 
            this.bttnExit.BackColor = System.Drawing.Color.Red;
            this.bttnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bttnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnExit.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnExit.ForeColor = System.Drawing.Color.White;
            this.bttnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnExit.Location = new System.Drawing.Point(816, 185);
            this.bttnExit.Margin = new System.Windows.Forms.Padding(4);
            this.bttnExit.Name = "bttnExit";
            this.bttnExit.Size = new System.Drawing.Size(69, 30);
            this.bttnExit.TabIndex = 18;
            this.bttnExit.Text = "&Close";
            this.bttnExit.UseVisualStyleBackColor = false;
            this.bttnExit.Click += new System.EventHandler(this.bttnExit_Click);
            // 
            // bttnRefresh
            // 
            this.bttnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bttnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnRefresh.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnRefresh.ForeColor = System.Drawing.Color.White;
            this.bttnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnRefresh.Location = new System.Drawing.Point(743, 185);
            this.bttnRefresh.Name = "bttnRefresh";
            this.bttnRefresh.Size = new System.Drawing.Size(72, 31);
            this.bttnRefresh.TabIndex = 17;
            this.bttnRefresh.Text = "&Refresh";
            this.bttnRefresh.UseVisualStyleBackColor = false;
            this.bttnRefresh.Click += new System.EventHandler(this.bttnRefresh_Click);
            // 
            // bttnSave
            // 
            this.bttnSave.BackColor = System.Drawing.Color.Green;
            this.bttnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnSave.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnSave.ForeColor = System.Drawing.Color.White;
            this.bttnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnSave.Location = new System.Drawing.Point(656, 186);
            this.bttnSave.Margin = new System.Windows.Forms.Padding(4);
            this.bttnSave.Name = "bttnSave";
            this.bttnSave.Size = new System.Drawing.Size(86, 30);
            this.bttnSave.TabIndex = 16;
            this.bttnSave.Text = "&Save Item";
            this.bttnSave.UseVisualStyleBackColor = false;
            this.bttnSave.Click += new System.EventHandler(this.bttnSave_Click);
            // 
            // chkEvening
            // 
            this.chkEvening.AutoSize = true;
            this.chkEvening.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEvening.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.chkEvening.Location = new System.Drawing.Point(590, 55);
            this.chkEvening.Name = "chkEvening";
            this.chkEvening.Size = new System.Drawing.Size(146, 20);
            this.chkEvening.TabIndex = 180;
            this.chkEvening.Text = "No Evening Schedule";
            this.chkEvening.UseVisualStyleBackColor = true;
            this.chkEvening.CheckedChanged += new System.EventHandler(this.chkEvening_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dtTimeOutEvening);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.dtTimeInEvening);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox4.Location = new System.Drawing.Point(590, 81);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(273, 79);
            this.groupBox4.TabIndex = 179;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "PM";
            // 
            // dtTimeOutEvening
            // 
            this.dtTimeOutEvening.CustomFormat = "  hh:mm tt";
            this.dtTimeOutEvening.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTimeOutEvening.Location = new System.Drawing.Point(130, 41);
            this.dtTimeOutEvening.Name = "dtTimeOutEvening";
            this.dtTimeOutEvening.ShowUpDown = true;
            this.dtTimeOutEvening.Size = new System.Drawing.Size(113, 23);
            this.dtTimeOutEvening.TabIndex = 25;
            this.dtTimeOutEvening.Value = new System.DateTime(2012, 3, 25, 22, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(20, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "Time Out PM";
            // 
            // dtTimeInEvening
            // 
            this.dtTimeInEvening.CustomFormat = "  hh:mm tt";
            this.dtTimeInEvening.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTimeInEvening.Location = new System.Drawing.Point(130, 14);
            this.dtTimeInEvening.Name = "dtTimeInEvening";
            this.dtTimeInEvening.ShowUpDown = true;
            this.dtTimeInEvening.Size = new System.Drawing.Size(113, 23);
            this.dtTimeInEvening.TabIndex = 24;
            this.dtTimeInEvening.Value = new System.DateTime(2012, 3, 25, 17, 15, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(20, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 16);
            this.label6.TabIndex = 29;
            this.label6.Text = "Time In PM";
            // 
            // frmEmployeeWorkload_AE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 226);
            this.Controls.Add(this.bttnExit);
            this.Controls.Add(this.bttnRefresh);
            this.Controls.Add(this.bttnSave);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEmployeeWorkload_AE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Workload Set-up";
            this.Load += new System.EventHandler(this.frmEmployeeWorkload_AE_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.CheckBox chkPM;
        private System.Windows.Forms.CheckBox chkAM;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtTimeOutPM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtTimeInPM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtTimeOutAM;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtTimeInAM;
        private System.Windows.Forms.ComboBox cmbDay;
        private System.Windows.Forms.Button bttnExit;
        private System.Windows.Forms.Button bttnRefresh;
        public System.Windows.Forms.Button bttnSave;
        private System.Windows.Forms.CheckBox chkEvening;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DateTimePicker dtTimeOutEvening;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtTimeInEvening;
        private System.Windows.Forms.Label label6;
    }
}