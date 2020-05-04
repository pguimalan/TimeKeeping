namespace TimeKeeping.App
{
    partial class frmEmployees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployees));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLabel5 = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtResidentialAddress2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.empno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EmployeeId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EmpName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Designation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ContactNumbers = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Department = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bttnExit = new System.Windows.Forms.Button();
            this.bttnEdit = new System.Windows.Forms.Button();
            this.bttnAdd = new System.Windows.Forms.Button();
            this.bttnRefresh = new System.Windows.Forms.Button();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.empstatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.linkLabel5);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtResidentialAddress2);
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Controls.Add(this.bttnExit);
            this.groupBox1.Controls.Add(this.bttnEdit);
            this.groupBox1.Controls.Add(this.bttnAdd);
            this.groupBox1.Controls.Add(this.bttnRefresh);
            this.groupBox1.Controls.Add(this.lblDepartment);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Location = new System.Drawing.Point(6, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(895, 456);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // linkLabel5
            // 
            this.linkLabel5.AutoSize = true;
            this.linkLabel5.Location = new System.Drawing.Point(9, 424);
            this.linkLabel5.Name = "linkLabel5";
            this.linkLabel5.Size = new System.Drawing.Size(109, 13);
            this.linkLabel5.TabIndex = 296;
            this.linkLabel5.TabStop = true;
            this.linkLabel5.Text = "Print Employee Profile";
            this.linkLabel5.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel5_LinkClicked);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(810, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 25);
            this.button1.TabIndex = 290;
            this.button1.Text = "&Print";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(614, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 23);
            this.label4.TabIndex = 259;
            this.label4.Text = "DEPARTMENT";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(430, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 23);
            this.label3.TabIndex = 258;
            this.label3.Text = "CONTACT NUMBERS";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(296, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 23);
            this.label2.TabIndex = 257;
            this.label2.Text = "DESIGNATION";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(132, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 23);
            this.label1.TabIndex = 256;
            this.label1.Text = "EMPLOYEE NAME";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtResidentialAddress2
            // 
            this.txtResidentialAddress2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtResidentialAddress2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtResidentialAddress2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txtResidentialAddress2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResidentialAddress2.ForeColor = System.Drawing.Color.White;
            this.txtResidentialAddress2.Location = new System.Drawing.Point(12, 51);
            this.txtResidentialAddress2.Name = "txtResidentialAddress2";
            this.txtResidentialAddress2.Size = new System.Drawing.Size(119, 23);
            this.txtResidentialAddress2.TabIndex = 255;
            this.txtResidentialAddress2.Text = "EMPLOYEE ID #";
            this.txtResidentialAddress2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.BackColor = System.Drawing.SystemColors.Window;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.empno,
            this.EmployeeId,
            this.EmpName,
            this.Designation,
            this.ContactNumbers,
            this.Department,
            this.empstatus});
            this.listView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listView1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.ForeColor = System.Drawing.Color.Maroon;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 51);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(870, 358);
            this.listView1.TabIndex = 175;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // empno
            // 
            this.empno.Text = "empno";
            this.empno.Width = 0;
            // 
            // EmployeeId
            // 
            this.EmployeeId.Text = "Employee ID#";
            this.EmployeeId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EmployeeId.Width = 116;
            // 
            // EmpName
            // 
            this.EmpName.Text = "Employee Name";
            this.EmpName.Width = 165;
            // 
            // Designation
            // 
            this.Designation.Text = "Designation";
            this.Designation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Designation.Width = 135;
            // 
            // ContactNumbers
            // 
            this.ContactNumbers.Text = "Contact Numbers";
            this.ContactNumbers.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ContactNumbers.Width = 183;
            // 
            // Department
            // 
            this.Department.Text = "Department";
            this.Department.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Department.Width = 166;
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
            this.bttnExit.Location = new System.Drawing.Point(817, 415);
            this.bttnExit.Name = "bttnExit";
            this.bttnExit.Size = new System.Drawing.Size(64, 30);
            this.bttnExit.TabIndex = 174;
            this.bttnExit.Text = "&Close";
            this.bttnExit.UseVisualStyleBackColor = false;
            this.bttnExit.Click += new System.EventHandler(this.bttnExit_Click);
            // 
            // bttnEdit
            // 
            this.bttnEdit.BackColor = System.Drawing.Color.Purple;
            this.bttnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnEdit.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnEdit.ForeColor = System.Drawing.Color.White;
            this.bttnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnEdit.Location = new System.Drawing.Point(744, 415);
            this.bttnEdit.Name = "bttnEdit";
            this.bttnEdit.Size = new System.Drawing.Size(71, 30);
            this.bttnEdit.TabIndex = 173;
            this.bttnEdit.Text = "&Update";
            this.bttnEdit.UseVisualStyleBackColor = false;
            this.bttnEdit.Click += new System.EventHandler(this.bttnEdit_Click);
            // 
            // bttnAdd
            // 
            this.bttnAdd.BackColor = System.Drawing.Color.DarkBlue;
            this.bttnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnAdd.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnAdd.ForeColor = System.Drawing.Color.White;
            this.bttnAdd.Location = new System.Drawing.Point(665, 415);
            this.bttnAdd.Name = "bttnAdd";
            this.bttnAdd.Size = new System.Drawing.Size(77, 30);
            this.bttnAdd.TabIndex = 172;
            this.bttnAdd.Text = "&Add New";
            this.bttnAdd.UseVisualStyleBackColor = false;
            this.bttnAdd.Click += new System.EventHandler(this.bttnAdd_Click);
            // 
            // bttnRefresh
            // 
            this.bttnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bttnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnRefresh.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnRefresh.ForeColor = System.Drawing.Color.White;
            this.bttnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnRefresh.Location = new System.Drawing.Point(736, 19);
            this.bttnRefresh.Name = "bttnRefresh";
            this.bttnRefresh.Size = new System.Drawing.Size(72, 25);
            this.bttnRefresh.TabIndex = 171;
            this.bttnRefresh.Text = "&Refresh";
            this.bttnRefresh.UseVisualStyleBackColor = false;
            this.bttnRefresh.Click += new System.EventHandler(this.bttnRefresh_Click);
            // 
            // lblDepartment
            // 
            this.lblDepartment.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartment.ForeColor = System.Drawing.Color.Navy;
            this.lblDepartment.Location = new System.Drawing.Point(481, 21);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(56, 20);
            this.lblDepartment.TabIndex = 169;
            this.lblDepartment.Text = "Search:";
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Maroon;
            this.txtSearch.Location = new System.Drawing.Point(543, 19);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(187, 22);
            this.txtSearch.TabIndex = 170;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // empstatus
            // 
            this.empstatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.empstatus.Width = 101;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(782, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 23);
            this.label5.TabIndex = 297;
            this.label5.Text = "STATUS";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 464);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEmployees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Masterlist";
            this.Load += new System.EventHandler(this.frmEmployees_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bttnExit;
        private System.Windows.Forms.Button bttnEdit;
        private System.Windows.Forms.Button bttnAdd;
        private System.Windows.Forms.Button bttnRefresh;
        private System.Windows.Forms.Label lblDepartment;
        public System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader empno;
        private System.Windows.Forms.ColumnHeader EmployeeId;
        private System.Windows.Forms.ColumnHeader EmpName;
        private System.Windows.Forms.ColumnHeader Designation;
        private System.Windows.Forms.ColumnHeader ContactNumbers;
        private System.Windows.Forms.ColumnHeader Department;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtResidentialAddress2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkLabel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ColumnHeader empstatus;
    }
}