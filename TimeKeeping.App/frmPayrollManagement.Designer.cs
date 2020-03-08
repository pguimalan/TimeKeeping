namespace TimeKeeping.App
{
    partial class frmPayrollManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPayrollManagement));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPayrollPeriod = new System.Windows.Forms.ComboBox();
            this.lblRate = new System.Windows.Forms.Label();
            this.lblPayOption = new System.Windows.Forms.Label();
            this.lblEmpType = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblDesignation = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.picEmployee = new System.Windows.Forms.PictureBox();
            this.cmbEmployeeName = new System.Windows.Forms.ComboBox();
            this.lblEmpName = new System.Windows.Forms.Label();
            this.lblTotDaysWork = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotalLate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotalUndertime = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblTotalUndertime);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblTotalLate);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblTotDaysWork);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbPayrollPeriod);
            this.groupBox1.Controls.Add(this.lblRate);
            this.groupBox1.Controls.Add(this.lblPayOption);
            this.groupBox1.Controls.Add(this.lblEmpType);
            this.groupBox1.Controls.Add(this.lblDepartment);
            this.groupBox1.Controls.Add(this.lblDesignation);
            this.groupBox1.Controls.Add(this.label57);
            this.groupBox1.Controls.Add(this.label56);
            this.groupBox1.Controls.Add(this.label55);
            this.groupBox1.Controls.Add(this.label54);
            this.groupBox1.Controls.Add(this.picEmployee);
            this.groupBox1.Controls.Add(this.cmbEmployeeName);
            this.groupBox1.Controls.Add(this.lblEmpName);
            this.groupBox1.Location = new System.Drawing.Point(6, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(792, 453);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(65, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 14);
            this.label1.TabIndex = 313;
            this.label1.Text = "Payroll Period:";
            // 
            // cmbPayrollPeriod
            // 
            this.cmbPayrollPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPayrollPeriod.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPayrollPeriod.ForeColor = System.Drawing.Color.Maroon;
            this.cmbPayrollPeriod.FormattingEnabled = true;
            this.cmbPayrollPeriod.Items.AddRange(new object[] {
            "",
            "First Semester",
            "Second Semester",
            "Summer"});
            this.cmbPayrollPeriod.Location = new System.Drawing.Point(148, 19);
            this.cmbPayrollPeriod.Name = "cmbPayrollPeriod";
            this.cmbPayrollPeriod.Size = new System.Drawing.Size(279, 24);
            this.cmbPayrollPeriod.TabIndex = 1;
            this.cmbPayrollPeriod.SelectedIndexChanged += new System.EventHandler(this.cmbPayrollPeriod_SelectedIndexChanged);
            // 
            // lblRate
            // 
            this.lblRate.BackColor = System.Drawing.Color.White;
            this.lblRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRate.ForeColor = System.Drawing.Color.Maroon;
            this.lblRate.Location = new System.Drawing.Point(148, 165);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(113, 23);
            this.lblRate.TabIndex = 311;
            // 
            // lblPayOption
            // 
            this.lblPayOption.BackColor = System.Drawing.Color.White;
            this.lblPayOption.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPayOption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayOption.ForeColor = System.Drawing.Color.Maroon;
            this.lblPayOption.Location = new System.Drawing.Point(267, 165);
            this.lblPayOption.Name = "lblPayOption";
            this.lblPayOption.Size = new System.Drawing.Size(160, 23);
            this.lblPayOption.TabIndex = 310;
            // 
            // lblEmpType
            // 
            this.lblEmpType.BackColor = System.Drawing.Color.White;
            this.lblEmpType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEmpType.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpType.ForeColor = System.Drawing.Color.Maroon;
            this.lblEmpType.Location = new System.Drawing.Point(148, 137);
            this.lblEmpType.Name = "lblEmpType";
            this.lblEmpType.Size = new System.Drawing.Size(278, 23);
            this.lblEmpType.TabIndex = 309;
            // 
            // lblDepartment
            // 
            this.lblDepartment.BackColor = System.Drawing.Color.White;
            this.lblDepartment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDepartment.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartment.ForeColor = System.Drawing.Color.Maroon;
            this.lblDepartment.Location = new System.Drawing.Point(148, 109);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(278, 23);
            this.lblDepartment.TabIndex = 308;
            // 
            // lblDesignation
            // 
            this.lblDesignation.BackColor = System.Drawing.Color.White;
            this.lblDesignation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDesignation.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesignation.ForeColor = System.Drawing.Color.Maroon;
            this.lblDesignation.Location = new System.Drawing.Point(148, 79);
            this.lblDesignation.Name = "lblDesignation";
            this.lblDesignation.Size = new System.Drawing.Size(278, 23);
            this.lblDesignation.TabIndex = 307;
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label57.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label57.Location = new System.Drawing.Point(69, 79);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(79, 16);
            this.label57.TabIndex = 305;
            this.label57.Text = "Designation:";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label56.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label56.Location = new System.Drawing.Point(68, 108);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(80, 16);
            this.label56.TabIndex = 304;
            this.label56.Text = "Department:";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label55.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label55.Location = new System.Drawing.Point(47, 166);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(101, 16);
            this.label55.TabIndex = 303;
            this.label55.Text = "Basic Pay (Php):";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label54.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label54.Location = new System.Drawing.Point(74, 138);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(74, 16);
            this.label54.TabIndex = 302;
            this.label54.Text = "Emp. Type:";
            // 
            // picEmployee
            // 
            this.picEmployee.BackColor = System.Drawing.Color.White;
            this.picEmployee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picEmployee.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.picEmployee.Image = ((System.Drawing.Image)(resources.GetObject("picEmployee.Image")));
            this.picEmployee.InitialImage = ((System.Drawing.Image)(resources.GetObject("picEmployee.InitialImage")));
            this.picEmployee.Location = new System.Drawing.Point(449, 19);
            this.picEmployee.Name = "picEmployee";
            this.picEmployee.Size = new System.Drawing.Size(125, 148);
            this.picEmployee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picEmployee.TabIndex = 297;
            this.picEmployee.TabStop = false;
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
            this.cmbEmployeeName.Location = new System.Drawing.Point(148, 49);
            this.cmbEmployeeName.Name = "cmbEmployeeName";
            this.cmbEmployeeName.Size = new System.Drawing.Size(279, 24);
            this.cmbEmployeeName.TabIndex = 2;
            this.cmbEmployeeName.SelectedIndexChanged += new System.EventHandler(this.cmbEmployeeName_SelectedIndexChanged);
            // 
            // lblEmpName
            // 
            this.lblEmpName.AutoSize = true;
            this.lblEmpName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpName.ForeColor = System.Drawing.Color.Navy;
            this.lblEmpName.Location = new System.Drawing.Point(45, 49);
            this.lblEmpName.Name = "lblEmpName";
            this.lblEmpName.Size = new System.Drawing.Size(103, 14);
            this.lblEmpName.TabIndex = 293;
            this.lblEmpName.Text = "Employee Name: ";
            // 
            // lblTotDaysWork
            // 
            this.lblTotDaysWork.BackColor = System.Drawing.Color.White;
            this.lblTotDaysWork.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotDaysWork.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotDaysWork.ForeColor = System.Drawing.Color.Maroon;
            this.lblTotDaysWork.Location = new System.Drawing.Point(148, 197);
            this.lblTotDaysWork.Name = "lblTotDaysWork";
            this.lblTotDaysWork.Size = new System.Drawing.Size(113, 23);
            this.lblTotDaysWork.TabIndex = 315;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(41, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 16);
            this.label3.TabIndex = 314;
            this.label3.Text = "Total Days Work:";
            // 
            // lblTotalLate
            // 
            this.lblTotalLate.BackColor = System.Drawing.Color.White;
            this.lblTotalLate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalLate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalLate.ForeColor = System.Drawing.Color.Maroon;
            this.lblTotalLate.Location = new System.Drawing.Point(148, 225);
            this.lblTotalLate.Name = "lblTotalLate";
            this.lblTotalLate.Size = new System.Drawing.Size(113, 23);
            this.lblTotalLate.TabIndex = 317;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(43, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 16);
            this.label5.TabIndex = 316;
            this.label5.Text = "Total Late (min):";
            // 
            // lblTotalUndertime
            // 
            this.lblTotalUndertime.BackColor = System.Drawing.Color.White;
            this.lblTotalUndertime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalUndertime.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalUndertime.ForeColor = System.Drawing.Color.Maroon;
            this.lblTotalUndertime.Location = new System.Drawing.Point(148, 253);
            this.lblTotalUndertime.Name = "lblTotalUndertime";
            this.lblTotalUndertime.Size = new System.Drawing.Size(113, 23);
            this.lblTotalUndertime.TabIndex = 319;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label7.Location = new System.Drawing.Point(8, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 16);
            this.label7.TabIndex = 318;
            this.label7.Text = "Total Undertime (min):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(267, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(337, 16);
            this.label2.TabIndex = 320;
            this.label2.Text = "No Individual Time Record for the selected payroll period.";
            this.label2.Visible = false;
            // 
            // frmPayrollManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 459);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPayrollManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payroll Management";
            this.Load += new System.EventHandler(this.frmPayrollManagement_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEmployee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbEmployeeName;
        private System.Windows.Forms.Label lblEmpName;
        private System.Windows.Forms.PictureBox picEmployee;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Label lblPayOption;
        private System.Windows.Forms.Label lblEmpType;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblDesignation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPayrollPeriod;
        private System.Windows.Forms.Label lblTotalUndertime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTotalLate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTotDaysWork;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}