namespace GrifindoToyLeaveApp
{
    partial class Employee
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.empIDtxt = new System.Windows.Forms.TextBox();
            this.empNametxt = new System.Windows.Forms.TextBox();
            this.empEmailtxt = new System.Windows.Forms.TextBox();
            this.empAddtxt = new System.Windows.Forms.TextBox();
            this.empExpertxt = new System.Windows.Forms.TextBox();
            this.empNictxt = new System.Windows.Forms.TextBox();
            this.empPasstxt = new System.Windows.Forms.TextBox();
            this.EmpPasswordTxt = new System.Windows.Forms.TextBox();
            this.EmpSqlDataView = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.Savebtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EmpSqlDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Employee Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Employee Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Employee Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 456);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Employee Experiance";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(76, 352);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Employee NIC no";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(76, 404);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Employee Passport no";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(76, 300);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Password";
            // 
            // empIDtxt
            // 
            this.empIDtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.empIDtxt.Location = new System.Drawing.Point(76, 88);
            this.empIDtxt.Name = "empIDtxt";
            this.empIDtxt.Size = new System.Drawing.Size(276, 22);
            this.empIDtxt.TabIndex = 1;
            this.empIDtxt.TextChanged += new System.EventHandler(this.empIDtxt_TextChanged);
            // 
            // empNametxt
            // 
            this.empNametxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.empNametxt.Location = new System.Drawing.Point(76, 140);
            this.empNametxt.Name = "empNametxt";
            this.empNametxt.Size = new System.Drawing.Size(276, 22);
            this.empNametxt.TabIndex = 1;
            this.empNametxt.TextChanged += new System.EventHandler(this.empNametxt_TextChanged);
            // 
            // empEmailtxt
            // 
            this.empEmailtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.empEmailtxt.Location = new System.Drawing.Point(76, 192);
            this.empEmailtxt.Name = "empEmailtxt";
            this.empEmailtxt.Size = new System.Drawing.Size(276, 22);
            this.empEmailtxt.TabIndex = 1;
            this.empEmailtxt.TextChanged += new System.EventHandler(this.empEmailtxt_TextChanged);
            // 
            // empAddtxt
            // 
            this.empAddtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.empAddtxt.Location = new System.Drawing.Point(76, 244);
            this.empAddtxt.Multiline = true;
            this.empAddtxt.Name = "empAddtxt";
            this.empAddtxt.Size = new System.Drawing.Size(276, 49);
            this.empAddtxt.TabIndex = 1;
            this.empAddtxt.TextChanged += new System.EventHandler(this.empAddtxt_TextChanged);
            // 
            // empExpertxt
            // 
            this.empExpertxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.empExpertxt.Location = new System.Drawing.Point(76, 479);
            this.empExpertxt.Name = "empExpertxt";
            this.empExpertxt.Size = new System.Drawing.Size(276, 22);
            this.empExpertxt.TabIndex = 1;
            this.empExpertxt.TextChanged += new System.EventHandler(this.empExpertxt_TextChanged);
            // 
            // empNictxt
            // 
            this.empNictxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.empNictxt.Location = new System.Drawing.Point(76, 375);
            this.empNictxt.Name = "empNictxt";
            this.empNictxt.Size = new System.Drawing.Size(276, 22);
            this.empNictxt.TabIndex = 1;
            this.empNictxt.TextChanged += new System.EventHandler(this.empNictxt_TextChanged);
            // 
            // empPasstxt
            // 
            this.empPasstxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.empPasstxt.Location = new System.Drawing.Point(76, 427);
            this.empPasstxt.Name = "empPasstxt";
            this.empPasstxt.Size = new System.Drawing.Size(276, 22);
            this.empPasstxt.TabIndex = 1;
            this.empPasstxt.TextChanged += new System.EventHandler(this.empPasstxt_TextChanged);
            // 
            // EmpPasswordTxt
            // 
            this.EmpPasswordTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmpPasswordTxt.Location = new System.Drawing.Point(76, 323);
            this.EmpPasswordTxt.Name = "EmpPasswordTxt";
            this.EmpPasswordTxt.Size = new System.Drawing.Size(276, 22);
            this.EmpPasswordTxt.TabIndex = 1;
            this.EmpPasswordTxt.TextChanged += new System.EventHandler(this.EmpPasswordTxt_TextChanged);
            // 
            // EmpSqlDataView
            // 
            this.EmpSqlDataView.AllowUserToAddRows = false;
            this.EmpSqlDataView.AllowUserToDeleteRows = false;
            this.EmpSqlDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmpSqlDataView.Location = new System.Drawing.Point(427, 105);
            this.EmpSqlDataView.Name = "EmpSqlDataView";
            this.EmpSqlDataView.ReadOnly = true;
            this.EmpSqlDataView.RowHeadersWidth = 51;
            this.EmpSqlDataView.RowTemplate.Height = 24;
            this.EmpSqlDataView.Size = new System.Drawing.Size(373, 372);
            this.EmpSqlDataView.TabIndex = 3;
            this.EmpSqlDataView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmpSqlDataView_CellClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(427, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(159, 16);
            this.label9.TabIndex = 4;
            this.label9.Text = "Search By Employee ID : ";
            // 
            // SearchBox
            // 
            this.SearchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchBox.Location = new System.Drawing.Point(593, 67);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(207, 22);
            this.SearchBox.TabIndex = 5;
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackgroundImage = global::GrifindoToyLeaveApp.Properties.Resources.Group_1__2_;
            this.UpdateBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UpdateBtn.FlatAppearance.BorderSize = 0;
            this.UpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateBtn.Font = new System.Drawing.Font("Myanmar Text", 8.8F, System.Drawing.FontStyle.Bold);
            this.UpdateBtn.ForeColor = System.Drawing.Color.White;
            this.UpdateBtn.Location = new System.Drawing.Point(287, 517);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(130, 43);
            this.UpdateBtn.TabIndex = 2;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.BackgroundImage = global::GrifindoToyLeaveApp.Properties.Resources.Group_1__2_;
            this.ClearBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClearBtn.FlatAppearance.BorderSize = 0;
            this.ClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearBtn.Font = new System.Drawing.Font("Myanmar Text", 8.8F, System.Drawing.FontStyle.Bold);
            this.ClearBtn.ForeColor = System.Drawing.Color.White;
            this.ClearBtn.Location = new System.Drawing.Point(681, 517);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(130, 43);
            this.ClearBtn.TabIndex = 2;
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
            this.DeleteBtn.Location = new System.Drawing.Point(492, 517);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(130, 43);
            this.DeleteBtn.TabIndex = 2;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // Savebtn
            // 
            this.Savebtn.BackgroundImage = global::GrifindoToyLeaveApp.Properties.Resources.Group_1__2_;
            this.Savebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Savebtn.FlatAppearance.BorderSize = 0;
            this.Savebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Savebtn.Font = new System.Drawing.Font("Myanmar Text", 8.8F, System.Drawing.FontStyle.Bold);
            this.Savebtn.ForeColor = System.Drawing.Color.White;
            this.Savebtn.Location = new System.Drawing.Point(76, 517);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(130, 43);
            this.Savebtn.TabIndex = 2;
            this.Savebtn.Text = "Save";
            this.Savebtn.UseVisualStyleBackColor = true;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(836, 592);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.EmpSqlDataView);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.Savebtn);
            this.Controls.Add(this.EmpPasswordTxt);
            this.Controls.Add(this.empPasstxt);
            this.Controls.Add(this.empAddtxt);
            this.Controls.Add(this.empNictxt);
            this.Controls.Add(this.empEmailtxt);
            this.Controls.Add(this.empExpertxt);
            this.Controls.Add(this.empNametxt);
            this.Controls.Add(this.empIDtxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Employee";
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.Employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmpSqlDataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox empIDtxt;
        private System.Windows.Forms.TextBox empNametxt;
        private System.Windows.Forms.TextBox empEmailtxt;
        private System.Windows.Forms.TextBox empAddtxt;
        private System.Windows.Forms.TextBox empExpertxt;
        private System.Windows.Forms.TextBox empNictxt;
        private System.Windows.Forms.TextBox empPasstxt;
        private System.Windows.Forms.TextBox EmpPasswordTxt;
        private System.Windows.Forms.Button Savebtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.DataGridView EmpSqlDataView;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox SearchBox;
    }
}