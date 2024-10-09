namespace GrifindoToyLeaveApp
{
    partial class Employee_Mobile
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
            this.EmpMobSqlDataView = new System.Windows.Forms.DataGridView();
            this.updateBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.Insertbtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MobileNumberTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EmployeeIdCmb = new System.Windows.Forms.ComboBox();
            this.MobileIDTxt = new System.Windows.Forms.TextBox();
            this.SearchBoxTxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.EmpMobSqlDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // EmpMobSqlDataView
            // 
            this.EmpMobSqlDataView.AllowUserToAddRows = false;
            this.EmpMobSqlDataView.AllowUserToDeleteRows = false;
            this.EmpMobSqlDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmpMobSqlDataView.Location = new System.Drawing.Point(419, 139);
            this.EmpMobSqlDataView.Name = "EmpMobSqlDataView";
            this.EmpMobSqlDataView.ReadOnly = true;
            this.EmpMobSqlDataView.RowHeadersWidth = 51;
            this.EmpMobSqlDataView.RowTemplate.Height = 24;
            this.EmpMobSqlDataView.Size = new System.Drawing.Size(373, 317);
            this.EmpMobSqlDataView.TabIndex = 36;
            this.EmpMobSqlDataView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmpMobSqlDataView_CellClick);
            // 
            // updateBtn
            // 
            this.updateBtn.BackgroundImage = global::GrifindoToyLeaveApp.Properties.Resources.Group_1__2_;
            this.updateBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.updateBtn.FlatAppearance.BorderSize = 0;
            this.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBtn.Font = new System.Drawing.Font("Myanmar Text", 8.8F, System.Drawing.FontStyle.Bold);
            this.updateBtn.ForeColor = System.Drawing.Color.White;
            this.updateBtn.Location = new System.Drawing.Point(254, 491);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(130, 43);
            this.updateBtn.TabIndex = 35;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.BackgroundImage = global::GrifindoToyLeaveApp.Properties.Resources.Group_1__2_;
            this.ClearBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClearBtn.FlatAppearance.BorderSize = 0;
            this.ClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearBtn.Font = new System.Drawing.Font("Myanmar Text", 8.8F, System.Drawing.FontStyle.Bold);
            this.ClearBtn.ForeColor = System.Drawing.Color.White;
            this.ClearBtn.Location = new System.Drawing.Point(649, 491);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(130, 43);
            this.ClearBtn.TabIndex = 34;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackgroundImage = global::GrifindoToyLeaveApp.Properties.Resources.Group_1__2_;
            this.DeleteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DeleteBtn.FlatAppearance.BorderSize = 0;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.Font = new System.Drawing.Font("Myanmar Text", 8.8F, System.Drawing.FontStyle.Bold);
            this.DeleteBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteBtn.Location = new System.Drawing.Point(457, 491);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(130, 43);
            this.DeleteBtn.TabIndex = 33;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // Insertbtn
            // 
            this.Insertbtn.BackgroundImage = global::GrifindoToyLeaveApp.Properties.Resources.Group_1__2_;
            this.Insertbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Insertbtn.FlatAppearance.BorderSize = 0;
            this.Insertbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Insertbtn.Font = new System.Drawing.Font("Myanmar Text", 8.8F, System.Drawing.FontStyle.Bold);
            this.Insertbtn.ForeColor = System.Drawing.Color.White;
            this.Insertbtn.Location = new System.Drawing.Point(38, 491);
            this.Insertbtn.Name = "Insertbtn";
            this.Insertbtn.Size = new System.Drawing.Size(130, 43);
            this.Insertbtn.TabIndex = 32;
            this.Insertbtn.Text = "Save";
            this.Insertbtn.UseVisualStyleBackColor = true;
            this.Insertbtn.Click += new System.EventHandler(this.Insertbtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "Mobile ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 29;
            this.label2.Text = "Mobile Number";
            // 
            // MobileNumberTxt
            // 
            this.MobileNumberTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MobileNumberTxt.Location = new System.Drawing.Point(72, 306);
            this.MobileNumberTxt.Name = "MobileNumberTxt";
            this.MobileNumberTxt.Size = new System.Drawing.Size(276, 22);
            this.MobileNumberTxt.TabIndex = 31;
            this.MobileNumberTxt.TextChanged += new System.EventHandler(this.MobileNumberTxt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "Employee_ID";
            // 
            // EmployeeIdCmb
            // 
            this.EmployeeIdCmb.FormattingEnabled = true;
            this.EmployeeIdCmb.Location = new System.Drawing.Point(71, 158);
            this.EmployeeIdCmb.Name = "EmployeeIdCmb";
            this.EmployeeIdCmb.Size = new System.Drawing.Size(276, 24);
            this.EmployeeIdCmb.TabIndex = 38;
            this.EmployeeIdCmb.SelectedIndexChanged += new System.EventHandler(this.EmployeeIdCmb_SelectedIndexChanged);
            // 
            // MobileIDTxt
            // 
            this.MobileIDTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MobileIDTxt.Location = new System.Drawing.Point(71, 235);
            this.MobileIDTxt.Name = "MobileIDTxt";
            this.MobileIDTxt.Size = new System.Drawing.Size(276, 22);
            this.MobileIDTxt.TabIndex = 31;
            this.MobileIDTxt.TextChanged += new System.EventHandler(this.MobileIDTxt_TextChanged);
            // 
            // SearchBoxTxt
            // 
            this.SearchBoxTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchBoxTxt.Location = new System.Drawing.Point(560, 91);
            this.SearchBoxTxt.Name = "SearchBoxTxt";
            this.SearchBoxTxt.Size = new System.Drawing.Size(207, 22);
            this.SearchBoxTxt.TabIndex = 40;
            this.SearchBoxTxt.TextChanged += new System.EventHandler(this.SearchBoxTxt_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(416, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 16);
            this.label9.TabIndex = 39;
            this.label9.Text = "Search By Mobile ID : ";
            // 
            // Employee_Mobile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(836, 552);
            this.Controls.Add(this.SearchBoxTxt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.EmployeeIdCmb);
            this.Controls.Add(this.EmpMobSqlDataView);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.Insertbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MobileIDTxt);
            this.Controls.Add(this.MobileNumberTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Employee_Mobile";
            this.Text = "Employee_Mobile";
            this.Load += new System.EventHandler(this.Employee_Mobile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmpMobSqlDataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView EmpMobSqlDataView;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button Insertbtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MobileNumberTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox EmployeeIdCmb;
        private System.Windows.Forms.TextBox MobileIDTxt;
        private System.Windows.Forms.TextBox SearchBoxTxt;
        private System.Windows.Forms.Label label9;
    }
}