namespace TimeKeeping.App
{
    partial class frmUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsers));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bttnExit = new System.Windows.Forms.Button();
            this.bttnEdit = new System.Windows.Forms.Button();
            this.bttnAdd = new System.Windows.Forms.Button();
            this.bttnRefresh = new System.Windows.Forms.Button();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.bttnExit);
            this.groupBox1.Controls.Add(this.bttnEdit);
            this.groupBox1.Controls.Add(this.bttnAdd);
            this.groupBox1.Controls.Add(this.bttnRefresh);
            this.groupBox1.Controls.Add(this.lblDepartment);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Location = new System.Drawing.Point(9, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 413);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
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
            this.bttnExit.Location = new System.Drawing.Point(344, 373);
            this.bttnExit.Name = "bttnExit";
            this.bttnExit.Size = new System.Drawing.Size(64, 30);
            this.bttnExit.TabIndex = 180;
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
            this.bttnEdit.Location = new System.Drawing.Point(271, 373);
            this.bttnEdit.Name = "bttnEdit";
            this.bttnEdit.Size = new System.Drawing.Size(71, 30);
            this.bttnEdit.TabIndex = 179;
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
            this.bttnAdd.Location = new System.Drawing.Point(192, 373);
            this.bttnAdd.Name = "bttnAdd";
            this.bttnAdd.Size = new System.Drawing.Size(77, 30);
            this.bttnAdd.TabIndex = 178;
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
            this.bttnRefresh.Location = new System.Drawing.Point(336, 16);
            this.bttnRefresh.Name = "bttnRefresh";
            this.bttnRefresh.Size = new System.Drawing.Size(72, 25);
            this.bttnRefresh.TabIndex = 177;
            this.bttnRefresh.Text = "&Refresh";
            this.bttnRefresh.UseVisualStyleBackColor = false;
            this.bttnRefresh.Click += new System.EventHandler(this.bttnRefresh_Click);
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartment.ForeColor = System.Drawing.Color.Navy;
            this.lblDepartment.Location = new System.Drawing.Point(156, 18);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(48, 14);
            this.lblDepartment.TabIndex = 175;
            this.lblDepartment.Text = "Search:";
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Maroon;
            this.txtSearch.Location = new System.Drawing.Point(210, 16);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(120, 22);
            this.txtSearch.TabIndex = 176;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.White;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.ForeColor = System.Drawing.Color.Maroon;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(11, 47);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(397, 320);
            this.listView1.TabIndex = 174;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Username";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 129;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Full Name";
            this.columnHeader3.Width = 266;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(11, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 23);
            this.label3.TabIndex = 259;
            this.label3.Text = "USERNAME";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(142, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 23);
            this.label1.TabIndex = 260;
            this.label1.Text = "USER FULL NAME";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 426);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "System Users Management";
            this.Load += new System.EventHandler(this.frmUsers_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label lblDepartment;
        public System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button bttnRefresh;
        private System.Windows.Forms.Button bttnExit;
        private System.Windows.Forms.Button bttnEdit;
        private System.Windows.Forms.Button bttnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}