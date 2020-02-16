namespace TimeKeeping.App
{
    partial class frmUsers_AE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsers_AE));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.bttnSave = new System.Windows.Forms.Button();
            this.bttnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtLastName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtUserName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMiddleName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtFirstName);
            this.groupBox1.Controls.Add(this.lblDepartment);
            this.groupBox1.Location = new System.Drawing.Point(9, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 147);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // txtLastName
            // 
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLastName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.ForeColor = System.Drawing.Color.Maroon;
            this.txtLastName.Location = new System.Drawing.Point(94, 77);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(178, 22);
            this.txtLastName.TabIndex = 3;
            this.txtLastName.Leave += new System.EventHandler(this.txtLastName_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(20, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 14);
            this.label4.TabIndex = 59;
            this.label4.Text = "Last Name:";
            // 
            // txtUserName
            // 
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.ForeColor = System.Drawing.Color.Maroon;
            this.txtUserName.Location = new System.Drawing.Point(94, 105);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(178, 22);
            this.txtUserName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(23, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 14);
            this.label2.TabIndex = 55;
            this.label2.Text = "Username:";
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMiddleName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMiddleName.ForeColor = System.Drawing.Color.Maroon;
            this.txtMiddleName.Location = new System.Drawing.Point(94, 49);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(178, 22);
            this.txtMiddleName.TabIndex = 2;
            this.txtMiddleName.Leave += new System.EventHandler(this.txtMiddleName_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(8, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 14);
            this.label1.TabIndex = 53;
            this.label1.Text = "Middle Name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFirstName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.ForeColor = System.Drawing.Color.Maroon;
            this.txtFirstName.Location = new System.Drawing.Point(94, 23);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(178, 22);
            this.txtFirstName.TabIndex = 1;
            this.txtFirstName.Leave += new System.EventHandler(this.txtFirstName_Leave);
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartment.ForeColor = System.Drawing.Color.Navy;
            this.lblDepartment.Location = new System.Drawing.Point(20, 25);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(68, 14);
            this.lblDepartment.TabIndex = 51;
            this.lblDepartment.Text = "First Name:";
            // 
            // bttnSave
            // 
            this.bttnSave.BackColor = System.Drawing.Color.Green;
            this.bttnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnSave.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnSave.ForeColor = System.Drawing.Color.White;
            this.bttnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnSave.Location = new System.Drawing.Point(143, 160);
            this.bttnSave.Margin = new System.Windows.Forms.Padding(4);
            this.bttnSave.Name = "bttnSave";
            this.bttnSave.Size = new System.Drawing.Size(86, 30);
            this.bttnSave.TabIndex = 12;
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
            this.bttnExit.Location = new System.Drawing.Point(229, 160);
            this.bttnExit.Margin = new System.Windows.Forms.Padding(4);
            this.bttnExit.Name = "bttnExit";
            this.bttnExit.Size = new System.Drawing.Size(69, 30);
            this.bttnExit.TabIndex = 13;
            this.bttnExit.Text = "&Cancel";
            this.bttnExit.UseVisualStyleBackColor = false;
            this.bttnExit.Click += new System.EventHandler(this.bttnExit_Click);
            // 
            // frmUsers_AE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 198);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bttnSave);
            this.Controls.Add(this.bttnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUsers_AE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "System User Set-up";
            this.Load += new System.EventHandler(this.frmUsers_AE_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblDepartment;
        public System.Windows.Forms.Button bttnSave;
        private System.Windows.Forms.Button bttnExit;
    }
}