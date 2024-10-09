namespace GrifindoToyLeaveApp
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.AdminSqlDataView = new System.Windows.Forms.DataGridView();
            this.AdminPassTxt = new System.Windows.Forms.TextBox();
            this.AdminUserNameTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EmpIdCmb = new System.Windows.Forms.ComboBox();
            this.AdminIdTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.updateBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.AdminInsertbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AdminSqlDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // AdminSqlDataView
            // 
            this.AdminSqlDataView.AllowUserToAddRows = false;
            this.AdminSqlDataView.AllowUserToDeleteRows = false;
            this.AdminSqlDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AdminSqlDataView.Location = new System.Drawing.Point(411, 101);
            this.AdminSqlDataView.Name = "AdminSqlDataView";
            this.AdminSqlDataView.ReadOnly = true;
            this.AdminSqlDataView.RowHeadersWidth = 51;
            this.AdminSqlDataView.RowTemplate.Height = 24;
            this.AdminSqlDataView.Size = new System.Drawing.Size(373, 346);
            this.AdminSqlDataView.TabIndex = 24;
            this.AdminSqlDataView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AdminSqlDataView_CellClick);
            // 
            // AdminPassTxt
            // 
            this.AdminPassTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AdminPassTxt.ForeColor = System.Drawing.Color.Black;
            this.AdminPassTxt.Location = new System.Drawing.Point(63, 360);
            this.AdminPassTxt.Name = "AdminPassTxt";
            this.AdminPassTxt.Size = new System.Drawing.Size(276, 22);
            this.AdminPassTxt.TabIndex = 18;
            this.AdminPassTxt.TextChanged += new System.EventHandler(this.AdminPassTxt_TextChanged);
            // 
            // AdminUserNameTxt
            // 
            this.AdminUserNameTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AdminUserNameTxt.ForeColor = System.Drawing.Color.Black;
            this.AdminUserNameTxt.Location = new System.Drawing.Point(63, 264);
            this.AdminUserNameTxt.Name = "AdminUserNameTxt";
            this.AdminUserNameTxt.Size = new System.Drawing.Size(276, 22);
            this.AdminUserNameTxt.TabIndex = 13;
            this.AdminUserNameTxt.TextChanged += new System.EventHandler(this.AdminUserNameTxt_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(61, 339);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(62, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Admin ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(60, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(62, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Employee";
            // 
            // EmpIdCmb
            // 
            this.EmpIdCmb.ForeColor = System.Drawing.Color.Black;
            this.EmpIdCmb.FormattingEnabled = true;
            this.EmpIdCmb.Location = new System.Drawing.Point(63, 180);
            this.EmpIdCmb.Name = "EmpIdCmb";
            this.EmpIdCmb.Size = new System.Drawing.Size(276, 24);
            this.EmpIdCmb.TabIndex = 25;
            this.EmpIdCmb.SelectedIndexChanged += new System.EventHandler(this.EmpIdCmb_SelectedIndexChanged);
            // 
            // AdminIdTxt
            // 
            this.AdminIdTxt.BackColor = System.Drawing.SystemColors.Window;
            this.AdminIdTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AdminIdTxt.ForeColor = System.Drawing.Color.Black;
            this.AdminIdTxt.Location = new System.Drawing.Point(64, 101);
            this.AdminIdTxt.Name = "AdminIdTxt";
            this.AdminIdTxt.Size = new System.Drawing.Size(276, 22);
            this.AdminIdTxt.TabIndex = 26;
            this.AdminIdTxt.TextChanged += new System.EventHandler(this.AdminIdTxt_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(408, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Search by Admin ID :";
            // 
            // SearchBox
            // 
            this.SearchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchBox.Location = new System.Drawing.Point(555, 61);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(229, 22);
            this.SearchBox.TabIndex = 27;
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            // 
            // updateBtn
            // 
            this.updateBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("updateBtn.BackgroundImage")));
            this.updateBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.updateBtn.FlatAppearance.BorderSize = 0;
            this.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBtn.Font = new System.Drawing.Font("Myanmar Text", 8.8F, System.Drawing.FontStyle.Bold);
            this.updateBtn.ForeColor = System.Drawing.Color.White;
            this.updateBtn.Location = new System.Drawing.Point(235, 482);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(130, 43);
            this.updateBtn.TabIndex = 23;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.BackColor = System.Drawing.Color.Transparent;
            this.ClearBtn.BackgroundImage = global::GrifindoToyLeaveApp.Properties.Resources.Group_1__2_;
            this.ClearBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClearBtn.FlatAppearance.BorderSize = 0;
            this.ClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearBtn.Font = new System.Drawing.Font("Myanmar Text", 8.8F, System.Drawing.FontStyle.Bold);
            this.ClearBtn.ForeColor = System.Drawing.Color.Transparent;
            this.ClearBtn.Location = new System.Drawing.Point(646, 482);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(130, 43);
            this.ClearBtn.TabIndex = 22;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = false;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deleteBtn.BackgroundImage")));
            this.deleteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteBtn.FlatAppearance.BorderSize = 0;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Myanmar Text", 8.8F, System.Drawing.FontStyle.Bold);
            this.deleteBtn.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.Location = new System.Drawing.Point(437, 482);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(130, 43);
            this.deleteBtn.TabIndex = 21;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // AdminInsertbtn
            // 
            this.AdminInsertbtn.BackColor = System.Drawing.Color.White;
            this.AdminInsertbtn.BackgroundImage = global::GrifindoToyLeaveApp.Properties.Resources.Group_1__2_;
            this.AdminInsertbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AdminInsertbtn.FlatAppearance.BorderSize = 0;
            this.AdminInsertbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdminInsertbtn.Font = new System.Drawing.Font("Myanmar Text", 8.8F, System.Drawing.FontStyle.Bold);
            this.AdminInsertbtn.ForeColor = System.Drawing.Color.White;
            this.AdminInsertbtn.Location = new System.Drawing.Point(44, 482);
            this.AdminInsertbtn.Name = "AdminInsertbtn";
            this.AdminInsertbtn.Size = new System.Drawing.Size(130, 43);
            this.AdminInsertbtn.TabIndex = 20;
            this.AdminInsertbtn.Text = "Save";
            this.AdminInsertbtn.UseVisualStyleBackColor = false;
            this.AdminInsertbtn.Click += new System.EventHandler(this.AdminInsertbtn_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(836, 552);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.AdminIdTxt);
            this.Controls.Add(this.EmpIdCmb);
            this.Controls.Add(this.AdminSqlDataView);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.AdminInsertbtn);
            this.Controls.Add(this.AdminPassTxt);
            this.Controls.Add(this.AdminUserNameTxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AdminSqlDataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AdminSqlDataView;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button AdminInsertbtn;
        private System.Windows.Forms.TextBox AdminPassTxt;
        private System.Windows.Forms.TextBox AdminUserNameTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox EmpIdCmb;
        private System.Windows.Forms.TextBox AdminIdTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SearchBox;
    }
}