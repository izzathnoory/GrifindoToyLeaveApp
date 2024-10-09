namespace GrifindoToyLeaveApp
{
    partial class LeaveApprovel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LeaveApprovel));
            this.AccesptRB = new System.Windows.Forms.RadioButton();
            this.RejectRB = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.LeaApproveSqlDataView = new System.Windows.Forms.DataGridView();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.AdmNameTxt = new System.Windows.Forms.Label();
            this.EmpNameTxt = new System.Windows.Forms.Label();
            this.LeaveReqTxt = new System.Windows.Forms.Label();
            this.ReasonTxt = new System.Windows.Forms.Label();
            this.LeaveBegDTP = new System.Windows.Forms.DateTimePicker();
            this.LeaveEndDTP = new System.Windows.Forms.DateTimePicker();
            this.SearchBoxTxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.LeaTypTxt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LeaApproveSqlDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // AccesptRB
            // 
            this.AccesptRB.AutoSize = true;
            this.AccesptRB.Location = new System.Drawing.Point(128, 515);
            this.AccesptRB.Name = "AccesptRB";
            this.AccesptRB.Size = new System.Drawing.Size(86, 20);
            this.AccesptRB.TabIndex = 48;
            this.AccesptRB.TabStop = true;
            this.AccesptRB.Text = "Accepted";
            this.AccesptRB.UseVisualStyleBackColor = true;
            this.AccesptRB.CheckedChanged += new System.EventHandler(this.AccesptRB_CheckedChanged);
            // 
            // RejectRB
            // 
            this.RejectRB.AutoSize = true;
            this.RejectRB.Location = new System.Drawing.Point(39, 515);
            this.RejectRB.Name = "RejectRB";
            this.RejectRB.Size = new System.Drawing.Size(83, 20);
            this.RejectRB.TabIndex = 47;
            this.RejectRB.TabStop = true;
            this.RejectRB.Text = "Rejected";
            this.RejectRB.UseVisualStyleBackColor = true;
            this.RejectRB.CheckedChanged += new System.EventHandler(this.RejectRB_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(39, 515);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(83, 20);
            this.radioButton2.TabIndex = 46;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Rejected";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(39, 515);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(78, 20);
            this.radioButton1.TabIndex = 45;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Pending";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // LeaApproveSqlDataView
            // 
            this.LeaApproveSqlDataView.AllowUserToAddRows = false;
            this.LeaApproveSqlDataView.AllowUserToDeleteRows = false;
            this.LeaApproveSqlDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LeaApproveSqlDataView.Location = new System.Drawing.Point(424, 103);
            this.LeaApproveSqlDataView.Name = "LeaApproveSqlDataView";
            this.LeaApproveSqlDataView.ReadOnly = true;
            this.LeaApproveSqlDataView.RowHeadersWidth = 51;
            this.LeaApproveSqlDataView.RowTemplate.Height = 24;
            this.LeaApproveSqlDataView.Size = new System.Drawing.Size(373, 368);
            this.LeaApproveSqlDataView.TabIndex = 42;
            this.LeaApproveSqlDataView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LeaApproveSqlDataView_CellClick);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UpdateBtn.BackgroundImage")));
            this.UpdateBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateBtn.Font = new System.Drawing.Font("Myanmar Text", 8.8F, System.Drawing.FontStyle.Bold);
            this.UpdateBtn.ForeColor = System.Drawing.Color.White;
            this.UpdateBtn.Location = new System.Drawing.Point(361, 542);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(130, 43);
            this.UpdateBtn.TabIndex = 41;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 279);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 16);
            this.label8.TabIndex = 35;
            this.label8.Text = "Reason";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 490);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 34;
            this.label4.Text = "Leave Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 442);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 16);
            this.label3.TabIndex = 33;
            this.label3.Text = "Leave End date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 16);
            this.label6.TabIndex = 31;
            this.label6.Text = "Admin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 384);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 16);
            this.label2.TabIndex = 36;
            this.label2.Text = "Leave Begin Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 30;
            this.label1.Text = "Leave request ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 16);
            this.label7.TabIndex = 53;
            this.label7.Text = "Employee";
            // 
            // AdmNameTxt
            // 
            this.AdmNameTxt.AutoSize = true;
            this.AdmNameTxt.Location = new System.Drawing.Point(39, 129);
            this.AdmNameTxt.Name = "AdmNameTxt";
            this.AdmNameTxt.Size = new System.Drawing.Size(85, 16);
            this.AdmNameTxt.TabIndex = 31;
            this.AdmNameTxt.Text = "Admin Name";
            this.AdmNameTxt.Click += new System.EventHandler(this.AdmNameTxt_Click);
            // 
            // EmpNameTxt
            // 
            this.EmpNameTxt.AutoSize = true;
            this.EmpNameTxt.Location = new System.Drawing.Point(39, 187);
            this.EmpNameTxt.Name = "EmpNameTxt";
            this.EmpNameTxt.Size = new System.Drawing.Size(109, 16);
            this.EmpNameTxt.TabIndex = 31;
            this.EmpNameTxt.Text = "Employee Name";
            this.EmpNameTxt.Click += new System.EventHandler(this.EmpNameTxt_Click);
            // 
            // LeaveReqTxt
            // 
            this.LeaveReqTxt.AutoSize = true;
            this.LeaveReqTxt.Location = new System.Drawing.Point(39, 250);
            this.LeaveReqTxt.Name = "LeaveReqTxt";
            this.LeaveReqTxt.Size = new System.Drawing.Size(74, 16);
            this.LeaveReqTxt.TabIndex = 31;
            this.LeaveReqTxt.Text = "Request ID";
            this.LeaveReqTxt.Click += new System.EventHandler(this.LeaveReqTxt_Click);
            // 
            // ReasonTxt
            // 
            this.ReasonTxt.AutoSize = true;
            this.ReasonTxt.Location = new System.Drawing.Point(39, 308);
            this.ReasonTxt.Name = "ReasonTxt";
            this.ReasonTxt.Size = new System.Drawing.Size(55, 16);
            this.ReasonTxt.TabIndex = 31;
            this.ReasonTxt.Text = "Reason";
            this.ReasonTxt.Click += new System.EventHandler(this.ReasonTxt_Click);
            // 
            // LeaveBegDTP
            // 
            this.LeaveBegDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.LeaveBegDTP.Location = new System.Drawing.Point(42, 404);
            this.LeaveBegDTP.Name = "LeaveBegDTP";
            this.LeaveBegDTP.Size = new System.Drawing.Size(130, 22);
            this.LeaveBegDTP.TabIndex = 54;
            this.LeaveBegDTP.ValueChanged += new System.EventHandler(this.LeaveBegDTP_ValueChanged);
            // 
            // LeaveEndDTP
            // 
            this.LeaveEndDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.LeaveEndDTP.Location = new System.Drawing.Point(42, 461);
            this.LeaveEndDTP.Name = "LeaveEndDTP";
            this.LeaveEndDTP.Size = new System.Drawing.Size(130, 22);
            this.LeaveEndDTP.TabIndex = 54;
            this.LeaveEndDTP.ValueChanged += new System.EventHandler(this.LeaveEndDTP_ValueChanged);
            // 
            // SearchBoxTxt
            // 
            this.SearchBoxTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchBoxTxt.Location = new System.Drawing.Point(579, 62);
            this.SearchBoxTxt.Name = "SearchBoxTxt";
            this.SearchBoxTxt.Size = new System.Drawing.Size(213, 22);
            this.SearchBoxTxt.TabIndex = 72;
            this.SearchBoxTxt.TextChanged += new System.EventHandler(this.SearchBoxTxt_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(421, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(149, 16);
            this.label9.TabIndex = 71;
            this.label9.Text = "Search By Lea Req ID : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(39, 334);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 16);
            this.label10.TabIndex = 74;
            this.label10.Text = "Leave Type";
            // 
            // LeaTypTxt
            // 
            this.LeaTypTxt.AutoSize = true;
            this.LeaTypTxt.Location = new System.Drawing.Point(39, 363);
            this.LeaTypTxt.Name = "LeaTypTxt";
            this.LeaTypTxt.Size = new System.Drawing.Size(77, 16);
            this.LeaTypTxt.TabIndex = 73;
            this.LeaTypTxt.Text = "LeaveType";
            this.LeaTypTxt.Click += new System.EventHandler(this.LeaTypTxt_Click);
            // 
            // LeaveApprovel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(836, 597);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.LeaTypTxt);
            this.Controls.Add(this.SearchBoxTxt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.LeaveEndDTP);
            this.Controls.Add(this.LeaveBegDTP);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.AccesptRB);
            this.Controls.Add(this.RejectRB);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.LeaApproveSqlDataView);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ReasonTxt);
            this.Controls.Add(this.LeaveReqTxt);
            this.Controls.Add(this.EmpNameTxt);
            this.Controls.Add(this.AdmNameTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LeaveApprovel";
            this.Text = "LeaveApprovel";
            this.Load += new System.EventHandler(this.LeaveApprovel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LeaApproveSqlDataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton AccesptRB;
        private System.Windows.Forms.RadioButton RejectRB;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.DataGridView LeaApproveSqlDataView;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label AdmNameTxt;
        private System.Windows.Forms.Label EmpNameTxt;
        private System.Windows.Forms.Label LeaveReqTxt;
        private System.Windows.Forms.Label ReasonTxt;
        private System.Windows.Forms.DateTimePicker LeaveBegDTP;
        private System.Windows.Forms.DateTimePicker LeaveEndDTP;
        private System.Windows.Forms.TextBox SearchBoxTxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label LeaTypTxt;
    }
}