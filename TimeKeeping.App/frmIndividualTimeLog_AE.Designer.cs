namespace TimeKeeping.App
{
    partial class frmIndividualTimeLog_AE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIndividualTimeLog_AE));
            this.bttnExit = new System.Windows.Forms.Button();
            this.bttnRefresh = new System.Windows.Forms.Button();
            this.bttnSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chkTimeOutEvening = new System.Windows.Forms.CheckBox();
            this.chkTimeInEvening = new System.Windows.Forms.CheckBox();
            this.dtTimeOutEvening = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtTimeInEvening = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkTimeOutPM = new System.Windows.Forms.CheckBox();
            this.chkTimeInPM = new System.Windows.Forms.CheckBox();
            this.dtTimeOutPM = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtTimeInPM = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkTimeOutAM = new System.Windows.Forms.CheckBox();
            this.chkTimeInAM = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtTimeOutAM = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtTimeInAM = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmployeeName = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblCurrentDate = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
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
            this.bttnExit.Location = new System.Drawing.Point(820, 252);
            this.bttnExit.Margin = new System.Windows.Forms.Padding(4);
            this.bttnExit.Name = "bttnExit";
            this.bttnExit.Size = new System.Drawing.Size(69, 30);
            this.bttnExit.TabIndex = 22;
            this.bttnExit.Text = "&Cancel";
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
            this.bttnRefresh.Location = new System.Drawing.Point(747, 252);
            this.bttnRefresh.Name = "bttnRefresh";
            this.bttnRefresh.Size = new System.Drawing.Size(72, 31);
            this.bttnRefresh.TabIndex = 21;
            this.bttnRefresh.Text = "&Refresh";
            this.bttnRefresh.UseVisualStyleBackColor = false;
            // 
            // bttnSave
            // 
            this.bttnSave.BackColor = System.Drawing.Color.Green;
            this.bttnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnSave.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnSave.ForeColor = System.Drawing.Color.White;
            this.bttnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnSave.Location = new System.Drawing.Point(660, 253);
            this.bttnSave.Margin = new System.Windows.Forms.Padding(4);
            this.bttnSave.Name = "bttnSave";
            this.bttnSave.Size = new System.Drawing.Size(86, 30);
            this.bttnSave.TabIndex = 20;
            this.bttnSave.Text = "&Save Item";
            this.bttnSave.UseVisualStyleBackColor = false;
            this.bttnSave.Click += new System.EventHandler(this.bttnSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Location = new System.Drawing.Point(12, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(877, 202);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chkTimeOutEvening);
            this.groupBox4.Controls.Add(this.chkTimeInEvening);
            this.groupBox4.Controls.Add(this.dtTimeOutEvening);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.dtTimeInEvening);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox4.Location = new System.Drawing.Point(590, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(273, 170);
            this.groupBox4.TabIndex = 179;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Evening";
            // 
            // chkTimeOutEvening
            // 
            this.chkTimeOutEvening.AutoSize = true;
            this.chkTimeOutEvening.ForeColor = System.Drawing.Color.Red;
            this.chkTimeOutEvening.Location = new System.Drawing.Point(22, 125);
            this.chkTimeOutEvening.Name = "chkTimeOutEvening";
            this.chkTimeOutEvening.Size = new System.Drawing.Size(117, 20);
            this.chkTimeOutEvening.TabIndex = 36;
            this.chkTimeOutEvening.Text = "check if no data";
            this.chkTimeOutEvening.UseVisualStyleBackColor = true;
            this.chkTimeOutEvening.CheckedChanged += new System.EventHandler(this.chkTimeOutEvening_CheckedChanged);
            // 
            // chkTimeInEvening
            // 
            this.chkTimeInEvening.AutoSize = true;
            this.chkTimeInEvening.ForeColor = System.Drawing.Color.Red;
            this.chkTimeInEvening.Location = new System.Drawing.Point(22, 53);
            this.chkTimeInEvening.Name = "chkTimeInEvening";
            this.chkTimeInEvening.Size = new System.Drawing.Size(117, 20);
            this.chkTimeInEvening.TabIndex = 35;
            this.chkTimeInEvening.Text = "check if no data";
            this.chkTimeInEvening.UseVisualStyleBackColor = true;
            this.chkTimeInEvening.CheckedChanged += new System.EventHandler(this.chkTimeInEvening_CheckedChanged);
            // 
            // dtTimeOutEvening
            // 
            this.dtTimeOutEvening.CustomFormat = "  hh:mm tt";
            this.dtTimeOutEvening.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTimeOutEvening.Location = new System.Drawing.Point(129, 98);
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
            this.label1.Location = new System.Drawing.Point(19, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "Time Out PM";
            // 
            // dtTimeInEvening
            // 
            this.dtTimeInEvening.CustomFormat = "  hh:mm tt";
            this.dtTimeInEvening.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTimeInEvening.Location = new System.Drawing.Point(129, 26);
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
            this.label6.Location = new System.Drawing.Point(19, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 16);
            this.label6.TabIndex = 29;
            this.label6.Text = "Time In PM";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkTimeOutPM);
            this.groupBox2.Controls.Add(this.chkTimeInPM);
            this.groupBox2.Controls.Add(this.dtTimeOutPM);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dtTimeInPM);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox2.Location = new System.Drawing.Point(305, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(273, 170);
            this.groupBox2.TabIndex = 177;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PM";
            // 
            // chkTimeOutPM
            // 
            this.chkTimeOutPM.AutoSize = true;
            this.chkTimeOutPM.ForeColor = System.Drawing.Color.Red;
            this.chkTimeOutPM.Location = new System.Drawing.Point(25, 122);
            this.chkTimeOutPM.Name = "chkTimeOutPM";
            this.chkTimeOutPM.Size = new System.Drawing.Size(117, 20);
            this.chkTimeOutPM.TabIndex = 34;
            this.chkTimeOutPM.Text = "check if no data";
            this.chkTimeOutPM.UseVisualStyleBackColor = true;
            this.chkTimeOutPM.CheckedChanged += new System.EventHandler(this.chkTimeOutPM_CheckedChanged);
            // 
            // chkTimeInPM
            // 
            this.chkTimeInPM.AutoSize = true;
            this.chkTimeInPM.ForeColor = System.Drawing.Color.Red;
            this.chkTimeInPM.Location = new System.Drawing.Point(25, 50);
            this.chkTimeInPM.Name = "chkTimeInPM";
            this.chkTimeInPM.Size = new System.Drawing.Size(117, 20);
            this.chkTimeInPM.TabIndex = 33;
            this.chkTimeInPM.Text = "check if no data";
            this.chkTimeInPM.UseVisualStyleBackColor = true;
            this.chkTimeInPM.CheckedChanged += new System.EventHandler(this.chkTimeInPM_CheckedChanged);
            // 
            // dtTimeOutPM
            // 
            this.dtTimeOutPM.CustomFormat = "  hh:mm tt";
            this.dtTimeOutPM.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTimeOutPM.Location = new System.Drawing.Point(132, 98);
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
            this.label4.Location = new System.Drawing.Point(22, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 16);
            this.label4.TabIndex = 28;
            this.label4.Text = "Time Out PM";
            // 
            // dtTimeInPM
            // 
            this.dtTimeInPM.CustomFormat = "  hh:mm tt";
            this.dtTimeInPM.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTimeInPM.Location = new System.Drawing.Point(132, 26);
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
            this.label3.Location = new System.Drawing.Point(22, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 29;
            this.label3.Text = "Time In PM";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkTimeOutAM);
            this.groupBox3.Controls.Add(this.chkTimeInAM);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.dtTimeOutAM);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.dtTimeInAM);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox3.Location = new System.Drawing.Point(15, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(273, 170);
            this.groupBox3.TabIndex = 176;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "AM";
            // 
            // chkTimeOutAM
            // 
            this.chkTimeOutAM.AutoSize = true;
            this.chkTimeOutAM.ForeColor = System.Drawing.Color.Red;
            this.chkTimeOutAM.Location = new System.Drawing.Point(20, 122);
            this.chkTimeOutAM.Name = "chkTimeOutAM";
            this.chkTimeOutAM.Size = new System.Drawing.Size(117, 20);
            this.chkTimeOutAM.TabIndex = 33;
            this.chkTimeOutAM.Text = "check if no data";
            this.chkTimeOutAM.UseVisualStyleBackColor = true;
            this.chkTimeOutAM.CheckedChanged += new System.EventHandler(this.chkTimeOutAM_CheckedChanged);
            // 
            // chkTimeInAM
            // 
            this.chkTimeInAM.AutoSize = true;
            this.chkTimeInAM.ForeColor = System.Drawing.Color.Red;
            this.chkTimeInAM.Location = new System.Drawing.Point(20, 53);
            this.chkTimeInAM.Name = "chkTimeInAM";
            this.chkTimeInAM.Size = new System.Drawing.Size(117, 20);
            this.chkTimeInAM.TabIndex = 32;
            this.chkTimeInAM.Text = "check if no data";
            this.chkTimeInAM.UseVisualStyleBackColor = true;
            this.chkTimeInAM.CheckedChanged += new System.EventHandler(this.chkTimeInAM_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(17, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 30;
            this.label2.Text = "Time Out AM";
            // 
            // dtTimeOutAM
            // 
            this.dtTimeOutAM.CustomFormat = "  hh:mm tt";
            this.dtTimeOutAM.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTimeOutAM.Location = new System.Drawing.Point(130, 98);
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
            this.label5.Location = new System.Drawing.Point(17, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 31;
            this.label5.Text = "Time In AM";
            // 
            // dtTimeInAM
            // 
            this.dtTimeInAM.CustomFormat = "  hh:mm tt";
            this.dtTimeInAM.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTimeInAM.Location = new System.Drawing.Point(130, 26);
            this.dtTimeInAM.Name = "dtTimeInAM";
            this.dtTimeInAM.ShowUpDown = true;
            this.dtTimeInAM.Size = new System.Drawing.Size(113, 23);
            this.dtTimeInAM.TabIndex = 27;
            this.dtTimeInAM.Value = new System.DateTime(2012, 3, 25, 7, 30, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(9, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 14);
            this.label7.TabIndex = 296;
            this.label7.Text = "Employee Name:";
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.BackColor = System.Drawing.Color.White;
            this.txtEmployeeName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmployeeName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeName.ForeColor = System.Drawing.Color.Maroon;
            this.txtEmployeeName.Location = new System.Drawing.Point(112, 13);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(342, 23);
            this.txtEmployeeName.TabIndex = 297;
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartment.ForeColor = System.Drawing.Color.Navy;
            this.lblDepartment.Location = new System.Drawing.Point(475, 15);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(37, 14);
            this.lblDepartment.TabIndex = 174;
            this.lblDepartment.Text = "Date:";
            // 
            // lblCurrentDate
            // 
            this.lblCurrentDate.BackColor = System.Drawing.Color.White;
            this.lblCurrentDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCurrentDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentDate.ForeColor = System.Drawing.Color.Maroon;
            this.lblCurrentDate.Location = new System.Drawing.Point(518, 13);
            this.lblCurrentDate.Name = "lblCurrentDate";
            this.lblCurrentDate.Size = new System.Drawing.Size(326, 23);
            this.lblCurrentDate.TabIndex = 298;
            // 
            // frmIndividualTimeLog_AE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 290);
            this.Controls.Add(this.lblCurrentDate);
            this.Controls.Add(this.txtEmployeeName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.bttnExit);
            this.Controls.Add(this.bttnRefresh);
            this.Controls.Add(this.bttnSave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblDepartment);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmIndividualTimeLog_AE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Individual Time Log Set-up";
            this.Load += new System.EventHandler(this.frmIndividualTimeLog_AE_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttnExit;
        private System.Windows.Forms.Button bttnRefresh;
        public System.Windows.Forms.Button bttnSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DateTimePicker dtTimeOutEvening;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtTimeInEvening;
        private System.Windows.Forms.Label label6;
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label txtEmployeeName;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.CheckBox chkTimeOutEvening;
        private System.Windows.Forms.CheckBox chkTimeInEvening;
        private System.Windows.Forms.CheckBox chkTimeOutPM;
        private System.Windows.Forms.CheckBox chkTimeInPM;
        private System.Windows.Forms.CheckBox chkTimeOutAM;
        private System.Windows.Forms.CheckBox chkTimeInAM;
        private System.Windows.Forms.Label lblCurrentDate;
    }
}