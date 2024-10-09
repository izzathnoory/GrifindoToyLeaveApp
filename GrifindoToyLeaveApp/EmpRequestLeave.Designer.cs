namespace GrifindoToyLeaveApp
{
    partial class EmpRequestLeave
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmpRequestLeave));
            this.LeaveEndDaDTP = new System.Windows.Forms.DateTimePicker();
            this.LeaveBegDaDTP = new System.Windows.Forms.DateTimePicker();
            this.Reasontxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.LeavReqInserbtn = new System.Windows.Forms.Button();
            this.LeaveReqIdTxt = new System.Windows.Forms.TextBox();
            this.EmprequestLeaveSqlDataView = new System.Windows.Forms.DataGridView();
            this.EmpNameTxt = new System.Windows.Forms.Label();
            this.ShortLeaveRB = new System.Windows.Forms.RadioButton();
            this.CasualLeaveRb = new System.Windows.Forms.RadioButton();
            this.AnnualLeaveRB = new System.Windows.Forms.RadioButton();
            this.PendingRB = new System.Windows.Forms.RadioButton();
            this.AccesptRB = new System.Windows.Forms.RadioButton();
            this.RejectRB = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ShortLeaveDTP = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.EmprequestLeaveSqlDataView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeaveEndDaDTP
            // 
            this.LeaveEndDaDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.LeaveEndDaDTP.Location = new System.Drawing.Point(39, 355);
            this.LeaveEndDaDTP.Name = "LeaveEndDaDTP";
            this.LeaveEndDaDTP.Size = new System.Drawing.Size(109, 22);
            this.LeaveEndDaDTP.TabIndex = 38;
            this.LeaveEndDaDTP.ValueChanged += new System.EventHandler(this.LeaveEndDaDTP_ValueChanged);
            // 
            // LeaveBegDaDTP
            // 
            this.LeaveBegDaDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.LeaveBegDaDTP.Location = new System.Drawing.Point(39, 302);
            this.LeaveBegDaDTP.Name = "LeaveBegDaDTP";
            this.LeaveBegDaDTP.Size = new System.Drawing.Size(109, 22);
            this.LeaveBegDaDTP.TabIndex = 39;
            this.LeaveBegDaDTP.ValueChanged += new System.EventHandler(this.LeaveBegDaDTP_ValueChanged);
            // 
            // Reasontxt
            // 
            this.Reasontxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Reasontxt.Location = new System.Drawing.Point(39, 214);
            this.Reasontxt.Multiline = true;
            this.Reasontxt.Name = "Reasontxt";
            this.Reasontxt.Size = new System.Drawing.Size(276, 57);
            this.Reasontxt.TabIndex = 37;
            this.Reasontxt.TextChanged += new System.EventHandler(this.Reasontxt_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 16);
            this.label8.TabIndex = 35;
            this.label8.Text = "Reason";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 16);
            this.label3.TabIndex = 33;
            this.label3.Text = "Leave End date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 16);
            this.label6.TabIndex = 30;
            this.label6.Text = "Employee";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 16);
            this.label2.TabIndex = 36;
            this.label2.Text = "Leave Begin Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 32;
            this.label1.Text = "Leave request ID";
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UpdateBtn.BackgroundImage")));
            this.UpdateBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UpdateBtn.FlatAppearance.BorderSize = 0;
            this.UpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateBtn.Font = new System.Drawing.Font("Myanmar Text", 8.8F, System.Drawing.FontStyle.Bold);
            this.UpdateBtn.ForeColor = System.Drawing.Color.White;
            this.UpdateBtn.Location = new System.Drawing.Point(239, 503);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(130, 43);
            this.UpdateBtn.TabIndex = 47;
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
            this.ClearBtn.Location = new System.Drawing.Point(637, 503);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(130, 43);
            this.ClearBtn.TabIndex = 46;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // Deletebtn
            // 
            this.Deletebtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Deletebtn.BackgroundImage")));
            this.Deletebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Deletebtn.FlatAppearance.BorderSize = 0;
            this.Deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Deletebtn.Font = new System.Drawing.Font("Myanmar Text", 8.8F, System.Drawing.FontStyle.Bold);
            this.Deletebtn.ForeColor = System.Drawing.Color.White;
            this.Deletebtn.Location = new System.Drawing.Point(438, 503);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(130, 43);
            this.Deletebtn.TabIndex = 45;
            this.Deletebtn.Text = "Delete";
            this.Deletebtn.UseVisualStyleBackColor = true;
            this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // LeavReqInserbtn
            // 
            this.LeavReqInserbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LeavReqInserbtn.BackgroundImage")));
            this.LeavReqInserbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LeavReqInserbtn.FlatAppearance.BorderSize = 0;
            this.LeavReqInserbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LeavReqInserbtn.Font = new System.Drawing.Font("Myanmar Text", 8.8F, System.Drawing.FontStyle.Bold);
            this.LeavReqInserbtn.ForeColor = System.Drawing.Color.White;
            this.LeavReqInserbtn.Location = new System.Drawing.Point(36, 503);
            this.LeavReqInserbtn.Name = "LeavReqInserbtn";
            this.LeavReqInserbtn.Size = new System.Drawing.Size(130, 43);
            this.LeavReqInserbtn.TabIndex = 44;
            this.LeavReqInserbtn.Text = "Save";
            this.LeavReqInserbtn.UseVisualStyleBackColor = true;
            this.LeavReqInserbtn.Click += new System.EventHandler(this.LeavReqInserbtn_Click);
            // 
            // LeaveReqIdTxt
            // 
            this.LeaveReqIdTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LeaveReqIdTxt.Location = new System.Drawing.Point(42, 157);
            this.LeaveReqIdTxt.Name = "LeaveReqIdTxt";
            this.LeaveReqIdTxt.Size = new System.Drawing.Size(276, 22);
            this.LeaveReqIdTxt.TabIndex = 48;
            this.LeaveReqIdTxt.TextChanged += new System.EventHandler(this.LeaveReqIdTxt_TextChanged);
            // 
            // EmprequestLeaveSqlDataView
            // 
            this.EmprequestLeaveSqlDataView.AllowUserToAddRows = false;
            this.EmprequestLeaveSqlDataView.AllowUserToDeleteRows = false;
            this.EmprequestLeaveSqlDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmprequestLeaveSqlDataView.Location = new System.Drawing.Point(388, 74);
            this.EmprequestLeaveSqlDataView.Name = "EmprequestLeaveSqlDataView";
            this.EmprequestLeaveSqlDataView.ReadOnly = true;
            this.EmprequestLeaveSqlDataView.RowHeadersWidth = 51;
            this.EmprequestLeaveSqlDataView.RowTemplate.Height = 24;
            this.EmprequestLeaveSqlDataView.Size = new System.Drawing.Size(406, 357);
            this.EmprequestLeaveSqlDataView.TabIndex = 49;
            this.EmprequestLeaveSqlDataView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmprequestLeaveSqlDataView_CellClick);
            // 
            // EmpNameTxt
            // 
            this.EmpNameTxt.AutoSize = true;
            this.EmpNameTxt.Location = new System.Drawing.Point(39, 84);
            this.EmpNameTxt.Name = "EmpNameTxt";
            this.EmpNameTxt.Size = new System.Drawing.Size(109, 16);
            this.EmpNameTxt.TabIndex = 50;
            this.EmpNameTxt.Text = "Employee Name";
            this.EmpNameTxt.Click += new System.EventHandler(this.EmpNameTxt_Click);
            // 
            // ShortLeaveRB
            // 
            this.ShortLeaveRB.AutoSize = true;
            this.ShortLeaveRB.Location = new System.Drawing.Point(203, 21);
            this.ShortLeaveRB.Name = "ShortLeaveRB";
            this.ShortLeaveRB.Size = new System.Drawing.Size(59, 20);
            this.ShortLeaveRB.TabIndex = 52;
            this.ShortLeaveRB.Text = "Short";
            this.ShortLeaveRB.UseVisualStyleBackColor = true;
            this.ShortLeaveRB.CheckedChanged += new System.EventHandler(this.ShortLeaveRB_CheckedChanged);
            // 
            // CasualLeaveRb
            // 
            this.CasualLeaveRb.AutoSize = true;
            this.CasualLeaveRb.Location = new System.Drawing.Point(111, 21);
            this.CasualLeaveRb.Name = "CasualLeaveRb";
            this.CasualLeaveRb.Size = new System.Drawing.Size(70, 20);
            this.CasualLeaveRb.TabIndex = 53;
            this.CasualLeaveRb.Text = "Casual";
            this.CasualLeaveRb.UseVisualStyleBackColor = true;
            this.CasualLeaveRb.CheckedChanged += new System.EventHandler(this.CasualLeaveRb_CheckedChanged);
            // 
            // AnnualLeaveRB
            // 
            this.AnnualLeaveRB.AutoSize = true;
            this.AnnualLeaveRB.Location = new System.Drawing.Point(22, 21);
            this.AnnualLeaveRB.Name = "AnnualLeaveRB";
            this.AnnualLeaveRB.Size = new System.Drawing.Size(69, 20);
            this.AnnualLeaveRB.TabIndex = 54;
            this.AnnualLeaveRB.Text = "Annual";
            this.AnnualLeaveRB.UseVisualStyleBackColor = true;
            this.AnnualLeaveRB.CheckedChanged += new System.EventHandler(this.AnnualLeaveRB_CheckedChanged);
            // 
            // PendingRB
            // 
            this.PendingRB.AutoSize = true;
            this.PendingRB.Checked = true;
            this.PendingRB.Location = new System.Drawing.Point(187, 21);
            this.PendingRB.Name = "PendingRB";
            this.PendingRB.Size = new System.Drawing.Size(78, 20);
            this.PendingRB.TabIndex = 56;
            this.PendingRB.TabStop = true;
            this.PendingRB.Text = "Pending";
            this.PendingRB.UseVisualStyleBackColor = true;
            this.PendingRB.CheckedChanged += new System.EventHandler(this.PendingRB_CheckedChanged);
            // 
            // AccesptRB
            // 
            this.AccesptRB.AutoSize = true;
            this.AccesptRB.Location = new System.Drawing.Point(95, 21);
            this.AccesptRB.Name = "AccesptRB";
            this.AccesptRB.Size = new System.Drawing.Size(86, 20);
            this.AccesptRB.TabIndex = 57;
            this.AccesptRB.Text = "Accepted";
            this.AccesptRB.UseVisualStyleBackColor = true;
            this.AccesptRB.CheckedChanged += new System.EventHandler(this.AccesptRB_CheckedChanged);
            // 
            // RejectRB
            // 
            this.RejectRB.AutoSize = true;
            this.RejectRB.Location = new System.Drawing.Point(6, 21);
            this.RejectRB.Name = "RejectRB";
            this.RejectRB.Size = new System.Drawing.Size(83, 20);
            this.RejectRB.TabIndex = 58;
            this.RejectRB.Text = "Rejected";
            this.RejectRB.UseVisualStyleBackColor = true;
            this.RejectRB.CheckedChanged += new System.EventHandler(this.RejectRB_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ShortLeaveRB);
            this.groupBox1.Controls.Add(this.AnnualLeaveRB);
            this.groupBox1.Controls.Add(this.CasualLeaveRb);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(36, 383);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 48);
            this.groupBox1.TabIndex = 61;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Leave Type";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.AccesptRB);
            this.groupBox2.Controls.Add(this.RejectRB);
            this.groupBox2.Controls.Add(this.PendingRB);
            this.groupBox2.Location = new System.Drawing.Point(36, 449);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(279, 48);
            this.groupBox2.TabIndex = 62;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Leave Status";
            // 
            // ShortLeaveDTP
            // 
            this.ShortLeaveDTP.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.ShortLeaveDTP.Location = new System.Drawing.Point(187, 309);
            this.ShortLeaveDTP.Name = "ShortLeaveDTP";
            this.ShortLeaveDTP.Size = new System.Drawing.Size(109, 22);
            this.ShortLeaveDTP.TabIndex = 64;
            this.ShortLeaveDTP.ValueChanged += new System.EventHandler(this.ShortLeaveDTP_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(184, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 16);
            this.label4.TabIndex = 63;
            this.label4.Text = "ShortLeaveStartTime";
            // 
            // EmpRequestLeave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(836, 552);
            this.Controls.Add(this.ShortLeaveDTP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.EmpNameTxt);
            this.Controls.Add(this.EmprequestLeaveSqlDataView);
            this.Controls.Add(this.LeaveReqIdTxt);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.Deletebtn);
            this.Controls.Add(this.LeavReqInserbtn);
            this.Controls.Add(this.LeaveEndDaDTP);
            this.Controls.Add(this.LeaveBegDaDTP);
            this.Controls.Add(this.Reasontxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EmpRequestLeave";
            this.Text = "RequestLeave";
            this.Load += new System.EventHandler(this.RequestLeave_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmprequestLeaveSqlDataView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker LeaveEndDaDTP;
        private System.Windows.Forms.DateTimePicker LeaveBegDaDTP;
        private System.Windows.Forms.TextBox Reasontxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.Button LeavReqInserbtn;
        private System.Windows.Forms.TextBox LeaveReqIdTxt;
        private System.Windows.Forms.DataGridView EmprequestLeaveSqlDataView;
        private System.Windows.Forms.Label EmpNameTxt;
        private System.Windows.Forms.RadioButton ShortLeaveRB;
        private System.Windows.Forms.RadioButton CasualLeaveRb;
        private System.Windows.Forms.RadioButton AnnualLeaveRB;
        private System.Windows.Forms.RadioButton PendingRB;
        private System.Windows.Forms.RadioButton AccesptRB;
        private System.Windows.Forms.RadioButton RejectRB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker ShortLeaveDTP;
        private System.Windows.Forms.Label label4;
    }
}