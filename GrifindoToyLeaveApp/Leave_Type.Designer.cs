namespace GrifindoToyLeaveApp
{
    partial class Leave_Type
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Leave_Type));
            this.LeaTypSqlDataView = new System.Windows.Forms.DataGridView();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.Insertbtn = new System.Windows.Forms.Button();
            this.AnnuaLeaCounTxt = new System.Windows.Forms.TextBox();
            this.ShortLeaTxt = new System.Windows.Forms.TextBox();
            this.CasuaLeaCounTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EmployeeIdCmb = new System.Windows.Forms.ComboBox();
            this.LeaveTypeIdTxt = new System.Windows.Forms.TextBox();
            this.SearchBoxTxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LeaTypSqlDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // LeaTypSqlDataView
            // 
            this.LeaTypSqlDataView.AllowUserToAddRows = false;
            this.LeaTypSqlDataView.AllowUserToDeleteRows = false;
            this.LeaTypSqlDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LeaTypSqlDataView.Location = new System.Drawing.Point(434, 102);
            this.LeaTypSqlDataView.Name = "LeaTypSqlDataView";
            this.LeaTypSqlDataView.ReadOnly = true;
            this.LeaTypSqlDataView.RowHeadersWidth = 51;
            this.LeaTypSqlDataView.RowTemplate.Height = 24;
            this.LeaTypSqlDataView.Size = new System.Drawing.Size(373, 375);
            this.LeaTypSqlDataView.TabIndex = 24;
            this.LeaTypSqlDataView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LeaTypSqlDataView_CellClick);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UpdateBtn.BackgroundImage")));
            this.UpdateBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UpdateBtn.FlatAppearance.BorderSize = 0;
            this.UpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateBtn.Font = new System.Drawing.Font("Myanmar Text", 8.8F, System.Drawing.FontStyle.Bold);
            this.UpdateBtn.ForeColor = System.Drawing.Color.White;
            this.UpdateBtn.Location = new System.Drawing.Point(258, 497);
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
            this.ClearBtn.Location = new System.Drawing.Point(677, 497);
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
            this.DeleteBtn.Location = new System.Drawing.Point(474, 497);
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
            this.Insertbtn.Location = new System.Drawing.Point(52, 497);
            this.Insertbtn.Name = "Insertbtn";
            this.Insertbtn.Size = new System.Drawing.Size(130, 43);
            this.Insertbtn.TabIndex = 20;
            this.Insertbtn.Text = "Save";
            this.Insertbtn.UseVisualStyleBackColor = true;
            this.Insertbtn.Click += new System.EventHandler(this.Insertbtn_Click);
            // 
            // AnnuaLeaCounTxt
            // 
            this.AnnuaLeaCounTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AnnuaLeaCounTxt.Location = new System.Drawing.Point(54, 233);
            this.AnnuaLeaCounTxt.Name = "AnnuaLeaCounTxt";
            this.AnnuaLeaCounTxt.Size = new System.Drawing.Size(276, 22);
            this.AnnuaLeaCounTxt.TabIndex = 18;
            this.AnnuaLeaCounTxt.TextChanged += new System.EventHandler(this.AnnuaLeaCounTxt_TextChanged);
            // 
            // ShortLeaTxt
            // 
            this.ShortLeaTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ShortLeaTxt.Location = new System.Drawing.Point(54, 403);
            this.ShortLeaTxt.Name = "ShortLeaTxt";
            this.ShortLeaTxt.Size = new System.Drawing.Size(276, 22);
            this.ShortLeaTxt.TabIndex = 19;
            this.ShortLeaTxt.TextChanged += new System.EventHandler(this.ShortLeaTxt_TextChanged);
            // 
            // CasuaLeaCounTxt
            // 
            this.CasuaLeaCounTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CasuaLeaCounTxt.Location = new System.Drawing.Point(54, 310);
            this.CasuaLeaCounTxt.Name = "CasuaLeaCounTxt";
            this.CasuaLeaCounTxt.Size = new System.Drawing.Size(276, 22);
            this.CasuaLeaCounTxt.TabIndex = 13;
            this.CasuaLeaCounTxt.TextChanged += new System.EventHandler(this.CasuaLeaCounTxt_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(54, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "Annual Leave Count";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 384);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Short Leave";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Casual Leave Count";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Leave Type ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Employee";
            // 
            // EmployeeIdCmb
            // 
            this.EmployeeIdCmb.FormattingEnabled = true;
            this.EmployeeIdCmb.Location = new System.Drawing.Point(54, 102);
            this.EmployeeIdCmb.Name = "EmployeeIdCmb";
            this.EmployeeIdCmb.Size = new System.Drawing.Size(276, 24);
            this.EmployeeIdCmb.TabIndex = 28;
            this.EmployeeIdCmb.SelectedIndexChanged += new System.EventHandler(this.EmployeeIdCmb_SelectedIndexChanged);
            // 
            // LeaveTypeIdTxt
            // 
            this.LeaveTypeIdTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LeaveTypeIdTxt.Location = new System.Drawing.Point(54, 168);
            this.LeaveTypeIdTxt.Name = "LeaveTypeIdTxt";
            this.LeaveTypeIdTxt.Size = new System.Drawing.Size(276, 22);
            this.LeaveTypeIdTxt.TabIndex = 18;
            this.LeaveTypeIdTxt.TextChanged += new System.EventHandler(this.LeaveTypeIdTxt_TextChanged);
            // 
            // SearchBoxTxt
            // 
            this.SearchBoxTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchBoxTxt.Location = new System.Drawing.Point(594, 62);
            this.SearchBoxTxt.Name = "SearchBoxTxt";
            this.SearchBoxTxt.Size = new System.Drawing.Size(213, 22);
            this.SearchBoxTxt.TabIndex = 70;
            this.SearchBoxTxt.TextChanged += new System.EventHandler(this.SearchBoxTxt_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(436, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 16);
            this.label9.TabIndex = 69;
            this.label9.Text = "Search By Lea Type ID : ";
            // 
            // Leave_Type
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(836, 552);
            this.Controls.Add(this.SearchBoxTxt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.EmployeeIdCmb);
            this.Controls.Add(this.LeaTypSqlDataView);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.Insertbtn);
            this.Controls.Add(this.LeaveTypeIdTxt);
            this.Controls.Add(this.AnnuaLeaCounTxt);
            this.Controls.Add(this.ShortLeaTxt);
            this.Controls.Add(this.CasuaLeaCounTxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Leave_Type";
            this.Text = "Leave_Type";
            this.Load += new System.EventHandler(this.Leave_Type_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LeaTypSqlDataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView LeaTypSqlDataView;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button Insertbtn;
        private System.Windows.Forms.TextBox AnnuaLeaCounTxt;
        private System.Windows.Forms.TextBox ShortLeaTxt;
        private System.Windows.Forms.TextBox CasuaLeaCounTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox EmployeeIdCmb;
        private System.Windows.Forms.TextBox LeaveTypeIdTxt;
        private System.Windows.Forms.TextBox SearchBoxTxt;
        private System.Windows.Forms.Label label9;
    }
}