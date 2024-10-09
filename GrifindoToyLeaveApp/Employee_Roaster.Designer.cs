namespace GrifindoToyLeaveApp
{
    partial class Employee_Roaster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee_Roaster));
            this.EmpRoasSqlDataView = new System.Windows.Forms.DataGridView();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.Insertbtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EmployeeIdCmb = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.StartTimeTimePicker = new System.Windows.Forms.DateTimePicker();
            this.EndTimeTimePicker = new System.Windows.Forms.DateTimePicker();
            this.HalfDayYesRB = new System.Windows.Forms.RadioButton();
            this.HalfDayNoRB = new System.Windows.Forms.RadioButton();
            this.EmployeeRoasIdTxt = new System.Windows.Forms.TextBox();
            this.SearchBoxTxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.OffDayCmb = new System.Windows.Forms.ComboBox();
            this.HalfDayCmb = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.EmpRoasSqlDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // EmpRoasSqlDataView
            // 
            this.EmpRoasSqlDataView.AllowUserToAddRows = false;
            this.EmpRoasSqlDataView.AllowUserToDeleteRows = false;
            this.EmpRoasSqlDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmpRoasSqlDataView.Location = new System.Drawing.Point(434, 120);
            this.EmpRoasSqlDataView.Name = "EmpRoasSqlDataView";
            this.EmpRoasSqlDataView.ReadOnly = true;
            this.EmpRoasSqlDataView.RowHeadersWidth = 51;
            this.EmpRoasSqlDataView.RowTemplate.Height = 24;
            this.EmpRoasSqlDataView.Size = new System.Drawing.Size(373, 357);
            this.EmpRoasSqlDataView.TabIndex = 24;
            this.EmpRoasSqlDataView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmpRoasSqlDataView_CellClick);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UpdateBtn.BackgroundImage")));
            this.UpdateBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UpdateBtn.FlatAppearance.BorderSize = 0;
            this.UpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateBtn.Font = new System.Drawing.Font("Myanmar Text", 8.8F, System.Drawing.FontStyle.Bold);
            this.UpdateBtn.ForeColor = System.Drawing.Color.White;
            this.UpdateBtn.Location = new System.Drawing.Point(231, 505);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(130, 43);
            this.UpdateBtn.TabIndex = 23;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ClearBtn.BackgroundImage")));
            this.ClearBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClearBtn.FlatAppearance.BorderSize = 0;
            this.ClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearBtn.Font = new System.Drawing.Font("Myanmar Text", 8.8F, System.Drawing.FontStyle.Bold);
            this.ClearBtn.ForeColor = System.Drawing.Color.White;
            this.ClearBtn.Location = new System.Drawing.Point(656, 505);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(130, 43);
            this.ClearBtn.TabIndex = 22;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DeleteBtn.BackgroundImage")));
            this.DeleteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DeleteBtn.FlatAppearance.BorderSize = 0;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.Font = new System.Drawing.Font("Myanmar Text", 8.8F, System.Drawing.FontStyle.Bold);
            this.DeleteBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteBtn.Location = new System.Drawing.Point(438, 505);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(130, 43);
            this.DeleteBtn.TabIndex = 21;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // Insertbtn
            // 
            this.Insertbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Insertbtn.BackgroundImage")));
            this.Insertbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Insertbtn.FlatAppearance.BorderSize = 0;
            this.Insertbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Insertbtn.Font = new System.Drawing.Font("Myanmar Text", 8.8F, System.Drawing.FontStyle.Bold);
            this.Insertbtn.ForeColor = System.Drawing.Color.White;
            this.Insertbtn.Location = new System.Drawing.Point(12, 505);
            this.Insertbtn.Name = "Insertbtn";
            this.Insertbtn.Size = new System.Drawing.Size(130, 43);
            this.Insertbtn.TabIndex = 20;
            this.Insertbtn.Text = "Save";
            this.Insertbtn.UseVisualStyleBackColor = true;
            this.Insertbtn.Click += new System.EventHandler(this.Insertbtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Off Day";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 410);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Is Morning Half Day?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "End time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 353);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Half Day";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Start Time";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Employee Roster ID";
            // 
            // EmployeeIdCmb
            // 
            this.EmployeeIdCmb.FormattingEnabled = true;
            this.EmployeeIdCmb.Location = new System.Drawing.Point(53, 77);
            this.EmployeeIdCmb.Name = "EmployeeIdCmb";
            this.EmployeeIdCmb.Size = new System.Drawing.Size(276, 24);
            this.EmployeeIdCmb.TabIndex = 27;
            this.EmployeeIdCmb.SelectedIndexChanged += new System.EventHandler(this.EmployeeIdCmb_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(52, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 16);
            this.label8.TabIndex = 26;
            this.label8.Text = "Employee ID";
            // 
            // StartTimeTimePicker
            // 
            this.StartTimeTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.StartTimeTimePicker.Location = new System.Drawing.Point(55, 196);
            this.StartTimeTimePicker.Name = "StartTimeTimePicker";
            this.StartTimeTimePicker.Size = new System.Drawing.Size(103, 22);
            this.StartTimeTimePicker.TabIndex = 28;
            this.StartTimeTimePicker.ValueChanged += new System.EventHandler(this.StartTimeTimePicker_ValueChanged);
            // 
            // EndTimeTimePicker
            // 
            this.EndTimeTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.EndTimeTimePicker.Location = new System.Drawing.Point(52, 253);
            this.EndTimeTimePicker.Name = "EndTimeTimePicker";
            this.EndTimeTimePicker.Size = new System.Drawing.Size(106, 22);
            this.EndTimeTimePicker.TabIndex = 28;
            this.EndTimeTimePicker.ValueChanged += new System.EventHandler(this.EndTimeTimePicker_ValueChanged);
            // 
            // HalfDayYesRB
            // 
            this.HalfDayYesRB.Location = new System.Drawing.Point(55, 430);
            this.HalfDayYesRB.Name = "HalfDayYesRB";
            this.HalfDayYesRB.Size = new System.Drawing.Size(103, 20);
            this.HalfDayYesRB.TabIndex = 0;
            this.HalfDayYesRB.Text = "Yes";
            this.HalfDayYesRB.UseVisualStyleBackColor = true;
            this.HalfDayYesRB.CheckedChanged += new System.EventHandler(this.HalfDayYesRB_CheckedChanged);
            // 
            // HalfDayNoRB
            // 
            this.HalfDayNoRB.Checked = true;
            this.HalfDayNoRB.Location = new System.Drawing.Point(138, 430);
            this.HalfDayNoRB.Name = "HalfDayNoRB";
            this.HalfDayNoRB.Size = new System.Drawing.Size(103, 20);
            this.HalfDayNoRB.TabIndex = 0;
            this.HalfDayNoRB.TabStop = true;
            this.HalfDayNoRB.Text = "No";
            this.HalfDayNoRB.UseVisualStyleBackColor = true;
            this.HalfDayNoRB.CheckedChanged += new System.EventHandler(this.HalfDayNoRB_CheckedChanged);
            // 
            // EmployeeRoasIdTxt
            // 
            this.EmployeeRoasIdTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmployeeRoasIdTxt.Location = new System.Drawing.Point(55, 146);
            this.EmployeeRoasIdTxt.Name = "EmployeeRoasIdTxt";
            this.EmployeeRoasIdTxt.Size = new System.Drawing.Size(276, 22);
            this.EmployeeRoasIdTxt.TabIndex = 16;
            this.EmployeeRoasIdTxt.TextChanged += new System.EventHandler(this.EmployeeRoasIdTxt_TextChanged);
            // 
            // SearchBoxTxt
            // 
            this.SearchBoxTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchBoxTxt.Location = new System.Drawing.Point(579, 79);
            this.SearchBoxTxt.Name = "SearchBoxTxt";
            this.SearchBoxTxt.Size = new System.Drawing.Size(207, 22);
            this.SearchBoxTxt.TabIndex = 42;
            this.SearchBoxTxt.TextChanged += new System.EventHandler(this.SearchBoxTxt_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(435, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 16);
            this.label9.TabIndex = 41;
            this.label9.Text = "Search By Roaster ID : ";
            // 
            // OffDayCmb
            // 
            this.OffDayCmb.FormattingEnabled = true;
            this.OffDayCmb.Location = new System.Drawing.Point(55, 313);
            this.OffDayCmb.Name = "OffDayCmb";
            this.OffDayCmb.Size = new System.Drawing.Size(276, 24);
            this.OffDayCmb.TabIndex = 43;
            this.OffDayCmb.SelectedIndexChanged += new System.EventHandler(this.OffDayCmb_SelectedIndexChanged);
            // 
            // HalfDayCmb
            // 
            this.HalfDayCmb.FormattingEnabled = true;
            this.HalfDayCmb.Location = new System.Drawing.Point(55, 383);
            this.HalfDayCmb.Name = "HalfDayCmb";
            this.HalfDayCmb.Size = new System.Drawing.Size(276, 24);
            this.HalfDayCmb.TabIndex = 43;
            this.HalfDayCmb.SelectedIndexChanged += new System.EventHandler(this.HalfDayCmb_SelectedIndexChanged);
            // 
            // Employee_Roaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(836, 565);
            this.Controls.Add(this.HalfDayCmb);
            this.Controls.Add(this.OffDayCmb);
            this.Controls.Add(this.SearchBoxTxt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.HalfDayNoRB);
            this.Controls.Add(this.HalfDayYesRB);
            this.Controls.Add(this.EndTimeTimePicker);
            this.Controls.Add(this.StartTimeTimePicker);
            this.Controls.Add(this.EmployeeIdCmb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.EmpRoasSqlDataView);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.Insertbtn);
            this.Controls.Add(this.EmployeeRoasIdTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Employee_Roaster";
            this.Load += new System.EventHandler(this.Employee_Roaster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmpRoasSqlDataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView EmpRoasSqlDataView;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button Insertbtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox EmployeeIdCmb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker StartTimeTimePicker;
        private System.Windows.Forms.DateTimePicker EndTimeTimePicker;
        private System.Windows.Forms.RadioButton HalfDayYesRB;
        private System.Windows.Forms.RadioButton HalfDayNoRB;
        private System.Windows.Forms.TextBox EmployeeRoasIdTxt;
        private System.Windows.Forms.TextBox SearchBoxTxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox OffDayCmb;
        private System.Windows.Forms.ComboBox HalfDayCmb;
    }
}