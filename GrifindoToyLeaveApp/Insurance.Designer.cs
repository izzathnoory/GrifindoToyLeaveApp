namespace GrifindoToyLeaveApp
{
    partial class Insurance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Insurance));
            this.EmployeeIdCmb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.InsuranceSqlDataView = new System.Windows.Forms.DataGridView();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.Insertbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.InsuranceAmountTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.InsuranceTypeTxt = new System.Windows.Forms.TextBox();
            this.InsuranceIdTxt = new System.Windows.Forms.TextBox();
            this.SearchBoxTxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.InsuranceSqlDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // EmployeeIdCmb
            // 
            this.EmployeeIdCmb.FormattingEnabled = true;
            this.EmployeeIdCmb.Location = new System.Drawing.Point(70, 124);
            this.EmployeeIdCmb.Name = "EmployeeIdCmb";
            this.EmployeeIdCmb.Size = new System.Drawing.Size(276, 24);
            this.EmployeeIdCmb.TabIndex = 64;
            this.EmployeeIdCmb.SelectedIndexChanged += new System.EventHandler(this.EmployeeIdCmb_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 63;
            this.label4.Text = "Employee ID";
            // 
            // InsuranceSqlDataView
            // 
            this.InsuranceSqlDataView.AllowUserToAddRows = false;
            this.InsuranceSqlDataView.AllowUserToDeleteRows = false;
            this.InsuranceSqlDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InsuranceSqlDataView.Location = new System.Drawing.Point(418, 105);
            this.InsuranceSqlDataView.Name = "InsuranceSqlDataView";
            this.InsuranceSqlDataView.ReadOnly = true;
            this.InsuranceSqlDataView.RowHeadersWidth = 51;
            this.InsuranceSqlDataView.RowTemplate.Height = 24;
            this.InsuranceSqlDataView.Size = new System.Drawing.Size(373, 351);
            this.InsuranceSqlDataView.TabIndex = 60;
            this.InsuranceSqlDataView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.InsuranceSqlDataView_CellClick);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UpdateBtn.BackgroundImage")));
            this.UpdateBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UpdateBtn.FlatAppearance.BorderSize = 0;
            this.UpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateBtn.Font = new System.Drawing.Font("Myanmar Text", 8.8F, System.Drawing.FontStyle.Bold);
            this.UpdateBtn.ForeColor = System.Drawing.Color.White;
            this.UpdateBtn.Location = new System.Drawing.Point(253, 485);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(130, 43);
            this.UpdateBtn.TabIndex = 59;
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
            this.ClearBtn.Location = new System.Drawing.Point(683, 485);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(130, 43);
            this.ClearBtn.TabIndex = 58;
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
            this.DeleteBtn.Location = new System.Drawing.Point(467, 485);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(130, 43);
            this.DeleteBtn.TabIndex = 57;
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
            this.Insertbtn.Location = new System.Drawing.Point(37, 485);
            this.Insertbtn.Name = "Insertbtn";
            this.Insertbtn.Size = new System.Drawing.Size(130, 43);
            this.Insertbtn.TabIndex = 56;
            this.Insertbtn.Text = "Save";
            this.Insertbtn.UseVisualStyleBackColor = true;
            this.Insertbtn.Click += new System.EventHandler(this.Insertbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 52;
            this.label1.Text = "Insurance ID";
            // 
            // InsuranceAmountTxt
            // 
            this.InsuranceAmountTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InsuranceAmountTxt.Location = new System.Drawing.Point(71, 331);
            this.InsuranceAmountTxt.Name = "InsuranceAmountTxt";
            this.InsuranceAmountTxt.Size = new System.Drawing.Size(276, 22);
            this.InsuranceAmountTxt.TabIndex = 55;
            this.InsuranceAmountTxt.TextChanged += new System.EventHandler(this.InsuranceAmountTxt_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 53;
            this.label3.Text = "Insure Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 54;
            this.label2.Text = "Insure Amount";
            // 
            // InsuranceTypeTxt
            // 
            this.InsuranceTypeTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InsuranceTypeTxt.Location = new System.Drawing.Point(70, 256);
            this.InsuranceTypeTxt.Name = "InsuranceTypeTxt";
            this.InsuranceTypeTxt.Size = new System.Drawing.Size(276, 22);
            this.InsuranceTypeTxt.TabIndex = 55;
            this.InsuranceTypeTxt.TextChanged += new System.EventHandler(this.InsuranceTypeTxt_TextChanged);
            // 
            // InsuranceIdTxt
            // 
            this.InsuranceIdTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InsuranceIdTxt.Location = new System.Drawing.Point(70, 194);
            this.InsuranceIdTxt.Name = "InsuranceIdTxt";
            this.InsuranceIdTxt.Size = new System.Drawing.Size(276, 22);
            this.InsuranceIdTxt.TabIndex = 55;
            this.InsuranceIdTxt.TextChanged += new System.EventHandler(this.InsuranceIdTxt_TextChanged);
            // 
            // SearchBoxTxt
            // 
            this.SearchBoxTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchBoxTxt.Location = new System.Drawing.Point(575, 77);
            this.SearchBoxTxt.Name = "SearchBoxTxt";
            this.SearchBoxTxt.Size = new System.Drawing.Size(213, 22);
            this.SearchBoxTxt.TabIndex = 66;
            this.SearchBoxTxt.TextChanged += new System.EventHandler(this.SearchBoxTxt_TextChanged_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(417, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 16);
            this.label9.TabIndex = 65;
            this.label9.Text = "Search By Insurance ID : ";
            // 
            // Insurance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(836, 552);
            this.Controls.Add(this.SearchBoxTxt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.EmployeeIdCmb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.InsuranceSqlDataView);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.Insertbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InsuranceIdTxt);
            this.Controls.Add(this.InsuranceTypeTxt);
            this.Controls.Add(this.InsuranceAmountTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Insurance";
            this.Text = "Insurance";
            this.Load += new System.EventHandler(this.Insurance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InsuranceSqlDataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox EmployeeIdCmb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView InsuranceSqlDataView;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button Insertbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox InsuranceAmountTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox InsuranceTypeTxt;
        private System.Windows.Forms.TextBox InsuranceIdTxt;
        private System.Windows.Forms.TextBox SearchBoxTxt;
        private System.Windows.Forms.Label label9;
    }
}