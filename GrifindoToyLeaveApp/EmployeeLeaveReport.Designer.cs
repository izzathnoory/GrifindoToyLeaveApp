namespace GrifindoToyLeaveApp
{
    partial class EmployeeLeaveReport
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
            this.label3 = new System.Windows.Forms.Label();
            this.EndDateDTP = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.StartDateDTP = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.ReportsGenerateBtn = new System.Windows.Forms.Button();
            this.LeaveDetailGenerateGridView = new System.Windows.Forms.DataGridView();
            this.LeaveCountGenerateGridView = new System.Windows.Forms.DataGridView();
            this.EmployeeNameTxt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LeaveDetailGenerateGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeaveCountGenerateGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Employee :";
            // 
            // EndDateDTP
            // 
            this.EndDateDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.EndDateDTP.Location = new System.Drawing.Point(537, 68);
            this.EndDateDTP.Name = "EndDateDTP";
            this.EndDateDTP.Size = new System.Drawing.Size(116, 22);
            this.EndDateDTP.TabIndex = 14;
            this.EndDateDTP.ValueChanged += new System.EventHandler(this.EndDateDTP_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(459, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "End Date :";
            // 
            // StartDateDTP
            // 
            this.StartDateDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.StartDateDTP.Location = new System.Drawing.Point(149, 68);
            this.StartDateDTP.Name = "StartDateDTP";
            this.StartDateDTP.Size = new System.Drawing.Size(123, 22);
            this.StartDateDTP.TabIndex = 12;
            this.StartDateDTP.ValueChanged += new System.EventHandler(this.StartDateDTP_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Start Date :";
            // 
            // ReportsGenerateBtn
            // 
            this.ReportsGenerateBtn.BackgroundImage = global::GrifindoToyLeaveApp.Properties.Resources.Group_1__2_;
            this.ReportsGenerateBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ReportsGenerateBtn.FlatAppearance.BorderSize = 0;
            this.ReportsGenerateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReportsGenerateBtn.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportsGenerateBtn.ForeColor = System.Drawing.Color.White;
            this.ReportsGenerateBtn.Location = new System.Drawing.Point(325, 470);
            this.ReportsGenerateBtn.Name = "ReportsGenerateBtn";
            this.ReportsGenerateBtn.Size = new System.Drawing.Size(203, 48);
            this.ReportsGenerateBtn.TabIndex = 10;
            this.ReportsGenerateBtn.Text = "Generate Report";
            this.ReportsGenerateBtn.UseVisualStyleBackColor = true;
            this.ReportsGenerateBtn.Click += new System.EventHandler(this.ReportsGenerateBtn_Click);
            // 
            // LeaveDetailGenerateGridView
            // 
            this.LeaveDetailGenerateGridView.AllowUserToAddRows = false;
            this.LeaveDetailGenerateGridView.AllowUserToDeleteRows = false;
            this.LeaveDetailGenerateGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LeaveDetailGenerateGridView.Location = new System.Drawing.Point(51, 281);
            this.LeaveDetailGenerateGridView.Name = "LeaveDetailGenerateGridView";
            this.LeaveDetailGenerateGridView.ReadOnly = true;
            this.LeaveDetailGenerateGridView.RowHeadersWidth = 51;
            this.LeaveDetailGenerateGridView.RowTemplate.Height = 24;
            this.LeaveDetailGenerateGridView.Size = new System.Drawing.Size(772, 170);
            this.LeaveDetailGenerateGridView.TabIndex = 8;
            // 
            // LeaveCountGenerateGridView
            // 
            this.LeaveCountGenerateGridView.AllowUserToAddRows = false;
            this.LeaveCountGenerateGridView.AllowUserToDeleteRows = false;
            this.LeaveCountGenerateGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LeaveCountGenerateGridView.Location = new System.Drawing.Point(51, 105);
            this.LeaveCountGenerateGridView.Name = "LeaveCountGenerateGridView";
            this.LeaveCountGenerateGridView.ReadOnly = true;
            this.LeaveCountGenerateGridView.RowHeadersWidth = 51;
            this.LeaveCountGenerateGridView.RowTemplate.Height = 24;
            this.LeaveCountGenerateGridView.Size = new System.Drawing.Size(772, 170);
            this.LeaveCountGenerateGridView.TabIndex = 9;
            // 
            // EmployeeNameTxt
            // 
            this.EmployeeNameTxt.AutoSize = true;
            this.EmployeeNameTxt.Location = new System.Drawing.Point(133, 17);
            this.EmployeeNameTxt.Name = "EmployeeNameTxt";
            this.EmployeeNameTxt.Size = new System.Drawing.Size(44, 16);
            this.EmployeeNameTxt.TabIndex = 16;
            this.EmployeeNameTxt.Text = "Name";
            //this.EmployeeNameTxt.Click += new System.EventHandler(this.EmployeeNameTxt_Click);
            // 
            // EmployeeLeaveReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(874, 534);
            this.Controls.Add(this.EmployeeNameTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EndDateDTP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StartDateDTP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ReportsGenerateBtn);
            this.Controls.Add(this.LeaveDetailGenerateGridView);
            this.Controls.Add(this.LeaveCountGenerateGridView);
            this.Name = "EmployeeLeaveReport";
            this.Text = "EmployeeLeaveReport";
            this.Load += new System.EventHandler(this.EmployeeLeaveReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LeaveDetailGenerateGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeaveCountGenerateGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker EndDateDTP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker StartDateDTP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ReportsGenerateBtn;
        private System.Windows.Forms.DataGridView LeaveDetailGenerateGridView;
        private System.Windows.Forms.DataGridView LeaveCountGenerateGridView;
        private System.Windows.Forms.Label EmployeeNameTxt;
    }
}