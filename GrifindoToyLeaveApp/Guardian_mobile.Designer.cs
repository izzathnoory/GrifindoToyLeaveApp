namespace GrifindoToyLeaveApp
{
    partial class Guardian_mobile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Guardian_mobile));
            this.GuardianIdCmb = new System.Windows.Forms.ComboBox();
            this.EmpGuarMobSqlDataView = new System.Windows.Forms.DataGridView();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.Insertbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.MobileNumTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EmployeeIdCmb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.GuardianMobileIdTxt = new System.Windows.Forms.TextBox();
            this.SearchBoxTxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.EmpGuarMobSqlDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // GuardianIdCmb
            // 
            this.GuardianIdCmb.FormattingEnabled = true;
            this.GuardianIdCmb.Location = new System.Drawing.Point(69, 204);
            this.GuardianIdCmb.Name = "GuardianIdCmb";
            this.GuardianIdCmb.Size = new System.Drawing.Size(276, 24);
            this.GuardianIdCmb.TabIndex = 48;
            this.GuardianIdCmb.SelectedIndexChanged += new System.EventHandler(this.GuardianIdCmb_SelectedIndexChanged);
            // 
            // EmpGuarMobSqlDataView
            // 
            this.EmpGuarMobSqlDataView.AllowUserToAddRows = false;
            this.EmpGuarMobSqlDataView.AllowUserToDeleteRows = false;
            this.EmpGuarMobSqlDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmpGuarMobSqlDataView.Location = new System.Drawing.Point(418, 124);
            this.EmpGuarMobSqlDataView.Name = "EmpGuarMobSqlDataView";
            this.EmpGuarMobSqlDataView.ReadOnly = true;
            this.EmpGuarMobSqlDataView.RowHeadersWidth = 51;
            this.EmpGuarMobSqlDataView.RowTemplate.Height = 24;
            this.EmpGuarMobSqlDataView.Size = new System.Drawing.Size(373, 332);
            this.EmpGuarMobSqlDataView.TabIndex = 47;
            this.EmpGuarMobSqlDataView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmpGuarMobSqlDataView_CellClick);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UpdateBtn.BackgroundImage")));
            this.UpdateBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UpdateBtn.FlatAppearance.BorderSize = 0;
            this.UpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateBtn.Font = new System.Drawing.Font("Myanmar Text", 8.8F, System.Drawing.FontStyle.Bold);
            this.UpdateBtn.ForeColor = System.Drawing.Color.White;
            this.UpdateBtn.Location = new System.Drawing.Point(252, 485);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(130, 43);
            this.UpdateBtn.TabIndex = 46;
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
            this.ClearBtn.Location = new System.Drawing.Point(682, 485);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(130, 43);
            this.ClearBtn.TabIndex = 45;
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
            this.DeleteBtn.Location = new System.Drawing.Point(466, 485);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(130, 43);
            this.DeleteBtn.TabIndex = 44;
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
            this.Insertbtn.Location = new System.Drawing.Point(36, 485);
            this.Insertbtn.Name = "Insertbtn";
            this.Insertbtn.Size = new System.Drawing.Size(130, 43);
            this.Insertbtn.TabIndex = 43;
            this.Insertbtn.Text = "Save";
            this.Insertbtn.UseVisualStyleBackColor = true;
            this.Insertbtn.Click += new System.EventHandler(this.Insertbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 39;
            this.label1.Text = "Guardian ID";
            // 
            // MobileNumTxt
            // 
            this.MobileNumTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MobileNumTxt.Location = new System.Drawing.Point(70, 350);
            this.MobileNumTxt.Name = "MobileNumTxt";
            this.MobileNumTxt.Size = new System.Drawing.Size(276, 22);
            this.MobileNumTxt.TabIndex = 42;
            this.MobileNumTxt.TextChanged += new System.EventHandler(this.MobileNumTxt_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 16);
            this.label3.TabIndex = 40;
            this.label3.Text = "Guardian Mobile ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 41;
            this.label2.Text = "Mobile Number";
            // 
            // EmployeeIdCmb
            // 
            this.EmployeeIdCmb.FormattingEnabled = true;
            this.EmployeeIdCmb.Location = new System.Drawing.Point(69, 143);
            this.EmployeeIdCmb.Name = "EmployeeIdCmb";
            this.EmployeeIdCmb.Size = new System.Drawing.Size(276, 24);
            this.EmployeeIdCmb.TabIndex = 51;
            this.EmployeeIdCmb.SelectedIndexChanged += new System.EventHandler(this.EmployeeIdCmb_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 50;
            this.label4.Text = "Employee ID";
            // 
            // GuardianMobileIdTxt
            // 
            this.GuardianMobileIdTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GuardianMobileIdTxt.Location = new System.Drawing.Point(69, 275);
            this.GuardianMobileIdTxt.Name = "GuardianMobileIdTxt";
            this.GuardianMobileIdTxt.Size = new System.Drawing.Size(276, 22);
            this.GuardianMobileIdTxt.TabIndex = 42;
            this.GuardianMobileIdTxt.TextChanged += new System.EventHandler(this.GuardianMobileId_TextChanged);
            // 
            // SearchBoxTxt
            // 
            this.SearchBoxTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchBoxTxt.Location = new System.Drawing.Point(603, 83);
            this.SearchBoxTxt.Name = "SearchBoxTxt";
            this.SearchBoxTxt.Size = new System.Drawing.Size(186, 22);
            this.SearchBoxTxt.TabIndex = 53;
            this.SearchBoxTxt.TextChanged += new System.EventHandler(this.SearchBoxTxt_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(415, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(182, 16);
            this.label9.TabIndex = 52;
            this.label9.Text = "Search By Guardian Mob ID : ";
            // 
            // Guardian_mobile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(836, 552);
            this.Controls.Add(this.SearchBoxTxt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.EmployeeIdCmb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.GuardianIdCmb);
            this.Controls.Add(this.EmpGuarMobSqlDataView);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.Insertbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GuardianMobileIdTxt);
            this.Controls.Add(this.MobileNumTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Guardian_mobile";
            this.Text = "Guardian_mobile";
            this.Load += new System.EventHandler(this.Guardian_mobile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmpGuarMobSqlDataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox GuardianIdCmb;
        private System.Windows.Forms.DataGridView EmpGuarMobSqlDataView;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button Insertbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MobileNumTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox EmployeeIdCmb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox GuardianMobileIdTxt;
        private System.Windows.Forms.TextBox SearchBoxTxt;
        private System.Windows.Forms.Label label9;
    }
}