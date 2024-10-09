namespace GrifindoToyLeaveApp
{
    partial class Guardian
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Guardian));
            this.EmployeeIdCmb = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.GuardianSqlDataView = new System.Windows.Forms.DataGridView();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.Insertbtn = new System.Windows.Forms.Button();
            this.GuardNicTxt = new System.Windows.Forms.TextBox();
            this.GuardAddTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GuardRelEmpTxt = new System.Windows.Forms.TextBox();
            this.GuardianIdTxt = new System.Windows.Forms.TextBox();
            this.GuardianNameTxt = new System.Windows.Forms.TextBox();
            this.GuardianEmailTxt = new System.Windows.Forms.TextBox();
            this.SearchBoxTxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GuardianSqlDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // EmployeeIdCmb
            // 
            this.EmployeeIdCmb.FormattingEnabled = true;
            this.EmployeeIdCmb.Location = new System.Drawing.Point(53, 87);
            this.EmployeeIdCmb.Name = "EmployeeIdCmb";
            this.EmployeeIdCmb.Size = new System.Drawing.Size(276, 24);
            this.EmployeeIdCmb.TabIndex = 45;
            this.EmployeeIdCmb.SelectedIndexChanged += new System.EventHandler(this.EmployeeIdCmb_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(52, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 16);
            this.label8.TabIndex = 44;
            this.label8.Text = "Employee";
            // 
            // GuardianSqlDataView
            // 
            this.GuardianSqlDataView.AllowUserToAddRows = false;
            this.GuardianSqlDataView.AllowUserToDeleteRows = false;
            this.GuardianSqlDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GuardianSqlDataView.Location = new System.Drawing.Point(434, 103);
            this.GuardianSqlDataView.Name = "GuardianSqlDataView";
            this.GuardianSqlDataView.ReadOnly = true;
            this.GuardianSqlDataView.RowHeadersWidth = 51;
            this.GuardianSqlDataView.RowTemplate.Height = 24;
            this.GuardianSqlDataView.Size = new System.Drawing.Size(373, 357);
            this.GuardianSqlDataView.TabIndex = 43;
            this.GuardianSqlDataView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GuardianSqlDataView_CellClick);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UpdateBtn.BackgroundImage")));
            this.UpdateBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UpdateBtn.FlatAppearance.BorderSize = 0;
            this.UpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateBtn.Font = new System.Drawing.Font("Myanmar Text", 8.8F, System.Drawing.FontStyle.Bold);
            this.UpdateBtn.ForeColor = System.Drawing.Color.White;
            this.UpdateBtn.Location = new System.Drawing.Point(228, 486);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(130, 43);
            this.UpdateBtn.TabIndex = 42;
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
            this.ClearBtn.Location = new System.Drawing.Point(692, 486);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(130, 43);
            this.ClearBtn.TabIndex = 41;
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
            this.DeleteBtn.Location = new System.Drawing.Point(485, 486);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(130, 43);
            this.DeleteBtn.TabIndex = 40;
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
            this.Insertbtn.Location = new System.Drawing.Point(12, 486);
            this.Insertbtn.Name = "Insertbtn";
            this.Insertbtn.Size = new System.Drawing.Size(130, 43);
            this.Insertbtn.TabIndex = 39;
            this.Insertbtn.Text = "Save";
            this.Insertbtn.UseVisualStyleBackColor = true;
            this.Insertbtn.Click += new System.EventHandler(this.Insertbtn_Click);
            // 
            // GuardNicTxt
            // 
            this.GuardNicTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GuardNicTxt.Location = new System.Drawing.Point(55, 305);
            this.GuardNicTxt.Name = "GuardNicTxt";
            this.GuardNicTxt.Size = new System.Drawing.Size(276, 22);
            this.GuardNicTxt.TabIndex = 38;
            this.GuardNicTxt.TextChanged += new System.EventHandler(this.GuardNicTxt_TextChanged);
            // 
            // GuardAddTxt
            // 
            this.GuardAddTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GuardAddTxt.Location = new System.Drawing.Point(55, 359);
            this.GuardAddTxt.Multiline = true;
            this.GuardAddTxt.Name = "GuardAddTxt";
            this.GuardAddTxt.Size = new System.Drawing.Size(276, 50);
            this.GuardAddTxt.TabIndex = 37;
            this.GuardAddTxt.TextChanged += new System.EventHandler(this.GuardAddTxt_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 35;
            this.label4.Text = "Guardian NIC";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 417);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 16);
            this.label6.TabIndex = 34;
            this.label6.Text = "Guardian Relation to Employee";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 33;
            this.label3.Text = "Guardian Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 335);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 16);
            this.label5.TabIndex = 32;
            this.label5.Text = "Guardian Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 36;
            this.label2.Text = "Guardian Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 31;
            this.label1.Text = "Guardian ID";
            // 
            // GuardRelEmpTxt
            // 
            this.GuardRelEmpTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GuardRelEmpTxt.Location = new System.Drawing.Point(53, 441);
            this.GuardRelEmpTxt.Name = "GuardRelEmpTxt";
            this.GuardRelEmpTxt.Size = new System.Drawing.Size(276, 22);
            this.GuardRelEmpTxt.TabIndex = 37;
            this.GuardRelEmpTxt.TextChanged += new System.EventHandler(this.GuardRelEmpTxt_TextChanged);
            // 
            // GuardianIdTxt
            // 
            this.GuardianIdTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GuardianIdTxt.Location = new System.Drawing.Point(55, 143);
            this.GuardianIdTxt.Name = "GuardianIdTxt";
            this.GuardianIdTxt.Size = new System.Drawing.Size(276, 22);
            this.GuardianIdTxt.TabIndex = 38;
            this.GuardianIdTxt.TextChanged += new System.EventHandler(this.GuardianIdTxt_TextChanged);
            // 
            // GuardianNameTxt
            // 
            this.GuardianNameTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GuardianNameTxt.Location = new System.Drawing.Point(55, 197);
            this.GuardianNameTxt.Name = "GuardianNameTxt";
            this.GuardianNameTxt.Size = new System.Drawing.Size(276, 22);
            this.GuardianNameTxt.TabIndex = 38;
            this.GuardianNameTxt.TextChanged += new System.EventHandler(this.GuardianNameTxt_TextChanged);
            // 
            // GuardianEmailTxt
            // 
            this.GuardianEmailTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GuardianEmailTxt.Location = new System.Drawing.Point(53, 251);
            this.GuardianEmailTxt.Name = "GuardianEmailTxt";
            this.GuardianEmailTxt.Size = new System.Drawing.Size(276, 22);
            this.GuardianEmailTxt.TabIndex = 38;
            this.GuardianEmailTxt.TextChanged += new System.EventHandler(this.GuardianEmailTxt_TextChanged);
            // 
            // SearchBoxTxt
            // 
            this.SearchBoxTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchBoxTxt.Location = new System.Drawing.Point(591, 63);
            this.SearchBoxTxt.Name = "SearchBoxTxt";
            this.SearchBoxTxt.Size = new System.Drawing.Size(216, 22);
            this.SearchBoxTxt.TabIndex = 47;
            this.SearchBoxTxt.TextChanged += new System.EventHandler(this.SearchBoxTxt_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(433, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 16);
            this.label9.TabIndex = 46;
            this.label9.Text = "Search By Guardian ID : ";
            // 
            // Guardian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(836, 552);
            this.Controls.Add(this.SearchBoxTxt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.EmployeeIdCmb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.GuardianSqlDataView);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.Insertbtn);
            this.Controls.Add(this.GuardianIdTxt);
            this.Controls.Add(this.GuardianEmailTxt);
            this.Controls.Add(this.GuardianNameTxt);
            this.Controls.Add(this.GuardNicTxt);
            this.Controls.Add(this.GuardRelEmpTxt);
            this.Controls.Add(this.GuardAddTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Guardian";
            this.Text = "Guardian";
            this.Load += new System.EventHandler(this.Guardian_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GuardianSqlDataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox EmployeeIdCmb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView GuardianSqlDataView;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button Insertbtn;
        private System.Windows.Forms.TextBox GuardNicTxt;
        private System.Windows.Forms.TextBox GuardAddTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox GuardRelEmpTxt;
        private System.Windows.Forms.TextBox GuardianIdTxt;
        private System.Windows.Forms.TextBox GuardianNameTxt;
        private System.Windows.Forms.TextBox GuardianEmailTxt;
        private System.Windows.Forms.TextBox SearchBoxTxt;
        private System.Windows.Forms.Label label9;
    }
}