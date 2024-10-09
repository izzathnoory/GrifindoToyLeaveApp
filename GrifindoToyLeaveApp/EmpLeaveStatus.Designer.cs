namespace GrifindoToyLeaveApp
{
    partial class EmpLeaveStatus
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
            this.EnddateDTP = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.StartdateDtp = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.ReportsGenerateBtn = new System.Windows.Forms.Button();
            this.ReportsGenerateGridView = new System.Windows.Forms.DataGridView();
            this.EmpNameTxt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ReportsGenerateGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Employee :";
            // 
            // EnddateDTP
            // 
            this.EnddateDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.EnddateDTP.Location = new System.Drawing.Point(518, 87);
            this.EnddateDTP.Name = "EnddateDTP";
            this.EnddateDTP.Size = new System.Drawing.Size(116, 22);
            this.EnddateDTP.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(440, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "End Date :";
            // 
            // StartdateDtp
            // 
            this.StartdateDtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.StartdateDtp.Location = new System.Drawing.Point(130, 87);
            this.StartdateDtp.Name = "StartdateDtp";
            this.StartdateDtp.Size = new System.Drawing.Size(123, 22);
            this.StartdateDtp.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Start Date :";
            // 
            // ReportsGenerateBtn
            // 
            this.ReportsGenerateBtn.BackgroundImage = global::GrifindoToyLeaveApp.Properties.Resources.Group_1__2_;
            this.ReportsGenerateBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ReportsGenerateBtn.FlatAppearance.BorderSize = 0;
            this.ReportsGenerateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReportsGenerateBtn.Font = new System.Drawing.Font("Myanmar Text", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportsGenerateBtn.ForeColor = System.Drawing.Color.White;
            this.ReportsGenerateBtn.Location = new System.Drawing.Point(315, 477);
            this.ReportsGenerateBtn.Name = "ReportsGenerateBtn";
            this.ReportsGenerateBtn.Size = new System.Drawing.Size(175, 53);
            this.ReportsGenerateBtn.TabIndex = 9;
            this.ReportsGenerateBtn.Text = "Generate Report";
            this.ReportsGenerateBtn.UseVisualStyleBackColor = true;
            // 
            // ReportsGenerateGridView
            // 
            this.ReportsGenerateGridView.AllowUserToAddRows = false;
            this.ReportsGenerateGridView.AllowUserToDeleteRows = false;
            this.ReportsGenerateGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReportsGenerateGridView.Location = new System.Drawing.Point(32, 124);
            this.ReportsGenerateGridView.Name = "ReportsGenerateGridView";
            this.ReportsGenerateGridView.ReadOnly = true;
            this.ReportsGenerateGridView.RowHeadersWidth = 51;
            this.ReportsGenerateGridView.RowTemplate.Height = 24;
            this.ReportsGenerateGridView.Size = new System.Drawing.Size(772, 337);
            this.ReportsGenerateGridView.TabIndex = 8;
            // 
            // EmpNameTxt
            // 
            this.EmpNameTxt.AutoSize = true;
            this.EmpNameTxt.Location = new System.Drawing.Point(111, 37);
            this.EmpNameTxt.Name = "EmpNameTxt";
            this.EmpNameTxt.Size = new System.Drawing.Size(44, 16);
            this.EmpNameTxt.TabIndex = 15;
            this.EmpNameTxt.Text = "Name";
            // 
            // EmpLeaveStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(836, 552);
            this.Controls.Add(this.EmpNameTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EnddateDTP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StartdateDtp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ReportsGenerateBtn);
            this.Controls.Add(this.ReportsGenerateGridView);
            this.Name = "EmpLeaveStatus";
            this.Text = "EmpLeaveStatus";
            this.Load += new System.EventHandler(this.EmpLeaveStatus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReportsGenerateGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker EnddateDTP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker StartdateDtp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ReportsGenerateBtn;
        private System.Windows.Forms.DataGridView ReportsGenerateGridView;
        private System.Windows.Forms.Label EmpNameTxt;
    }
}