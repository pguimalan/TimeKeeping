namespace TimeKeeping.App
{
    partial class frmEmployeeLeaves_AE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployeeLeaves_AE));
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.cmbEmployeeName = new System.Windows.Forms.ComboBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.gbLeaveCredits = new System.Windows.Forms.GroupBox();
            this.txtSL = new System.Windows.Forms.Label();
            this.label78 = new System.Windows.Forms.Label();
            this.txtVL = new System.Windows.Forms.Label();
            this.label79 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rdVLwithPay = new System.Windows.Forms.RadioButton();
            this.rdVLwithoutPay = new System.Windows.Forms.RadioButton();
            this.rdSLwithPay = new System.Windows.Forms.RadioButton();
            this.rdSLwithoutPay = new System.Windows.Forms.RadioButton();
            this.lblNoDays = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.bttnRefresh = new System.Windows.Forms.Button();
            this.bttnSave = new System.Windows.Forms.Button();
            this.bttnExit = new System.Windows.Forms.Button();
            this.groupBox5.SuspendLayout();
            this.gbLeaveCredits.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtRemarks);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.lblNoDays);
            this.groupBox5.Controls.Add(this.rdSLwithoutPay);
            this.groupBox5.Controls.Add(this.rdSLwithPay);
            this.groupBox5.Controls.Add(this.rdVLwithoutPay);
            this.groupBox5.Controls.Add(this.rdVLwithPay);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.gbLeaveCredits);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.dtTo);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.dtFrom);
            this.groupBox5.Controls.Add(this.cmbEmployeeName);
            this.groupBox5.Controls.Add(this.lblDepartment);
            this.groupBox5.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox5.Location = new System.Drawing.Point(11, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(656, 277);
            this.groupBox5.TabIndex = 200;
            this.groupBox5.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(261, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 301;
            this.label4.Text = "Date To";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(133, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 300;
            this.label2.Text = "Date From";
            // 
            // dtTo
            // 
            this.dtTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTo.Location = new System.Drawing.Point(239, 128);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(116, 22);
            this.dtTo.TabIndex = 7;
            this.dtTo.ValueChanged += new System.EventHandler(this.dtTo_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(18, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 14);
            this.label1.TabIndex = 299;
            this.label1.Text = "Inclusive Dates:";
            // 
            // dtFrom
            // 
            this.dtFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFrom.Location = new System.Drawing.Point(117, 129);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(116, 22);
            this.dtFrom.TabIndex = 6;
            this.dtFrom.ValueChanged += new System.EventHandler(this.dtFrom_ValueChanged);
            // 
            // cmbEmployeeName
            // 
            this.cmbEmployeeName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmployeeName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEmployeeName.ForeColor = System.Drawing.Color.Maroon;
            this.cmbEmployeeName.FormattingEnabled = true;
            this.cmbEmployeeName.Items.AddRange(new object[] {
            "",
            "First Semester",
            "Second Semester",
            "Summer"});
            this.cmbEmployeeName.Location = new System.Drawing.Point(116, 28);
            this.cmbEmployeeName.Name = "cmbEmployeeName";
            this.cmbEmployeeName.Size = new System.Drawing.Size(306, 24);
            this.cmbEmployeeName.TabIndex = 1;
            this.cmbEmployeeName.SelectedIndexChanged += new System.EventHandler(this.cmbEmployeeName_SelectedIndexChanged);
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartment.ForeColor = System.Drawing.Color.Navy;
            this.lblDepartment.Location = new System.Drawing.Point(11, 28);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(99, 14);
            this.lblDepartment.TabIndex = 296;
            this.lblDepartment.Text = "Employee Name:";
            // 
            // gbLeaveCredits
            // 
            this.gbLeaveCredits.Controls.Add(this.txtSL);
            this.gbLeaveCredits.Controls.Add(this.label78);
            this.gbLeaveCredits.Controls.Add(this.txtVL);
            this.gbLeaveCredits.Controls.Add(this.label79);
            this.gbLeaveCredits.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLeaveCredits.ForeColor = System.Drawing.Color.Maroon;
            this.gbLeaveCredits.Location = new System.Drawing.Point(451, 19);
            this.gbLeaveCredits.Name = "gbLeaveCredits";
            this.gbLeaveCredits.Size = new System.Drawing.Size(185, 98);
            this.gbLeaveCredits.TabIndex = 302;
            this.gbLeaveCredits.TabStop = false;
            this.gbLeaveCredits.Text = "Leave Credits";
            // 
            // txtSL
            // 
            this.txtSL.BackColor = System.Drawing.Color.White;
            this.txtSL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSL.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSL.ForeColor = System.Drawing.Color.Maroon;
            this.txtSL.Location = new System.Drawing.Point(132, 65);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(40, 23);
            this.txtSL.TabIndex = 260;
            // 
            // label78
            // 
            this.label78.AutoSize = true;
            this.label78.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label78.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label78.Location = new System.Drawing.Point(8, 38);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(110, 16);
            this.label78.TabIndex = 256;
            this.label78.Text = "Vacation Leave/s:";
            // 
            // txtVL
            // 
            this.txtVL.BackColor = System.Drawing.Color.White;
            this.txtVL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVL.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVL.ForeColor = System.Drawing.Color.Maroon;
            this.txtVL.Location = new System.Drawing.Point(132, 35);
            this.txtVL.Name = "txtVL";
            this.txtVL.Size = new System.Drawing.Size(40, 23);
            this.txtVL.TabIndex = 259;
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label79.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label79.Location = new System.Drawing.Point(34, 65);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(84, 16);
            this.label79.TabIndex = 257;
            this.label79.Text = "Sick Leave/s:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(35, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 14);
            this.label3.TabIndex = 303;
            this.label3.Text = "Leave Type:";
            // 
            // rdVLwithPay
            // 
            this.rdVLwithPay.AutoSize = true;
            this.rdVLwithPay.Location = new System.Drawing.Point(117, 63);
            this.rdVLwithPay.Name = "rdVLwithPay";
            this.rdVLwithPay.Size = new System.Drawing.Size(137, 17);
            this.rdVLwithPay.TabIndex = 2;
            this.rdVLwithPay.TabStop = true;
            this.rdVLwithPay.Text = "Vacation Leave w/ Pay";
            this.rdVLwithPay.UseVisualStyleBackColor = true;
            this.rdVLwithPay.CheckedChanged += new System.EventHandler(this.rdVLwithPay_CheckedChanged);
            // 
            // rdVLwithoutPay
            // 
            this.rdVLwithoutPay.AutoSize = true;
            this.rdVLwithoutPay.Location = new System.Drawing.Point(270, 63);
            this.rdVLwithoutPay.Name = "rdVLwithoutPay";
            this.rdVLwithoutPay.Size = new System.Drawing.Size(143, 17);
            this.rdVLwithoutPay.TabIndex = 3;
            this.rdVLwithoutPay.TabStop = true;
            this.rdVLwithoutPay.Text = "Vacation Leave w/o Pay";
            this.rdVLwithoutPay.UseVisualStyleBackColor = true;
            this.rdVLwithoutPay.CheckedChanged += new System.EventHandler(this.rdVLwithoutPay_CheckedChanged);
            // 
            // rdSLwithPay
            // 
            this.rdSLwithPay.AutoSize = true;
            this.rdSLwithPay.Location = new System.Drawing.Point(116, 90);
            this.rdSLwithPay.Name = "rdSLwithPay";
            this.rdSLwithPay.Size = new System.Drawing.Size(116, 17);
            this.rdSLwithPay.TabIndex = 4;
            this.rdSLwithPay.TabStop = true;
            this.rdSLwithPay.Text = "Sick Leave w/ Pay";
            this.rdSLwithPay.UseVisualStyleBackColor = true;
            this.rdSLwithPay.CheckedChanged += new System.EventHandler(this.rdSLwithPay_CheckedChanged);
            // 
            // rdSLwithoutPay
            // 
            this.rdSLwithoutPay.AutoSize = true;
            this.rdSLwithoutPay.Location = new System.Drawing.Point(270, 90);
            this.rdSLwithoutPay.Name = "rdSLwithoutPay";
            this.rdSLwithoutPay.Size = new System.Drawing.Size(122, 17);
            this.rdSLwithoutPay.TabIndex = 5;
            this.rdSLwithoutPay.TabStop = true;
            this.rdSLwithoutPay.Text = "Sick Leave w/o Pay";
            this.rdSLwithoutPay.UseVisualStyleBackColor = true;
            this.rdSLwithoutPay.CheckedChanged += new System.EventHandler(this.rdSLwithoutPay_CheckedChanged);
            // 
            // lblNoDays
            // 
            this.lblNoDays.BackColor = System.Drawing.Color.White;
            this.lblNoDays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNoDays.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoDays.ForeColor = System.Drawing.Color.Maroon;
            this.lblNoDays.Location = new System.Drawing.Point(361, 127);
            this.lblNoDays.Name = "lblNoDays";
            this.lblNoDays.Size = new System.Drawing.Size(52, 23);
            this.lblNoDays.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(358, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 312;
            this.label6.Text = "No. of Days";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(54, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 14);
            this.label7.TabIndex = 313;
            this.label7.Text = "Remarks:";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(117, 182);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRemarks.Size = new System.Drawing.Size(519, 76);
            this.txtRemarks.TabIndex = 9;
            // 
            // bttnRefresh
            // 
            this.bttnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bttnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnRefresh.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnRefresh.ForeColor = System.Drawing.Color.White;
            this.bttnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnRefresh.Location = new System.Drawing.Point(525, 296);
            this.bttnRefresh.Name = "bttnRefresh";
            this.bttnRefresh.Size = new System.Drawing.Size(72, 31);
            this.bttnRefresh.TabIndex = 11;
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
            this.bttnSave.Location = new System.Drawing.Point(438, 297);
            this.bttnSave.Margin = new System.Windows.Forms.Padding(4);
            this.bttnSave.Name = "bttnSave";
            this.bttnSave.Size = new System.Drawing.Size(86, 30);
            this.bttnSave.TabIndex = 10;
            this.bttnSave.Text = "&Save Item";
            this.bttnSave.UseVisualStyleBackColor = false;
            this.bttnSave.Click += new System.EventHandler(this.bttnSave_Click);
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
            this.bttnExit.Location = new System.Drawing.Point(598, 296);
            this.bttnExit.Margin = new System.Windows.Forms.Padding(4);
            this.bttnExit.Name = "bttnExit";
            this.bttnExit.Size = new System.Drawing.Size(69, 30);
            this.bttnExit.TabIndex = 12;
            this.bttnExit.Text = "&Cancel";
            this.bttnExit.UseVisualStyleBackColor = false;
            this.bttnExit.Click += new System.EventHandler(this.bttnExit_Click);
            // 
            // frmEmployeeLeaves_AE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 334);
            this.Controls.Add(this.bttnRefresh);
            this.Controls.Add(this.bttnSave);
            this.Controls.Add(this.bttnExit);
            this.Controls.Add(this.groupBox5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEmployeeLeaves_AE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Leaves Setup";
            this.Load += new System.EventHandler(this.frmEmployeeLeaves_AE_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.gbLeaveCredits.ResumeLayout(false);
            this.gbLeaveCredits.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.ComboBox cmbEmployeeName;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.RadioButton rdSLwithoutPay;
        private System.Windows.Forms.RadioButton rdSLwithPay;
        private System.Windows.Forms.RadioButton rdVLwithoutPay;
        private System.Windows.Forms.RadioButton rdVLwithPay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbLeaveCredits;
        private System.Windows.Forms.Label txtSL;
        private System.Windows.Forms.Label label78;
        private System.Windows.Forms.Label txtVL;
        private System.Windows.Forms.Label label79;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblNoDays;
        private System.Windows.Forms.Button bttnRefresh;
        public System.Windows.Forms.Button bttnSave;
        private System.Windows.Forms.Button bttnExit;
    }
}