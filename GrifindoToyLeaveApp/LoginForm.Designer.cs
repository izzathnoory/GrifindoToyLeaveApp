namespace GrifindoToyLeaveApp
{
    partial class LoginForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AdminUserNametxt = new System.Windows.Forms.TextBox();
            this.ShowPasswordChk = new System.Windows.Forms.CheckBox();
            this.AdminLoginbtn = new System.Windows.Forms.Button();
            this.AdminPasswordtxt = new System.Windows.Forms.TextBox();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.EmployeeLinkLabel = new System.Windows.Forms.LinkLabel();
            this.CloseApplicationBtn = new System.Windows.Forms.Label();
            this.MinimizeFormBtn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(284, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(307, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(307, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Username";
            // 
            // AdminUserNametxt
            // 
            this.AdminUserNametxt.Location = new System.Drawing.Point(311, 239);
            this.AdminUserNametxt.Name = "AdminUserNametxt";
            this.AdminUserNametxt.Size = new System.Drawing.Size(274, 22);
            this.AdminUserNametxt.TabIndex = 1;
            this.AdminUserNametxt.Text = "Type your Username...";
            this.AdminUserNametxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AdminUserNametxt_KeyPress);
            // 
            // ShowPasswordChk
            // 
            this.ShowPasswordChk.AutoSize = true;
            this.ShowPasswordChk.BackColor = System.Drawing.Color.Transparent;
            this.ShowPasswordChk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ShowPasswordChk.ForeColor = System.Drawing.Color.White;
            this.ShowPasswordChk.Location = new System.Drawing.Point(311, 352);
            this.ShowPasswordChk.Name = "ShowPasswordChk";
            this.ShowPasswordChk.Size = new System.Drawing.Size(129, 21);
            this.ShowPasswordChk.TabIndex = 2;
            this.ShowPasswordChk.Text = "Show Password";
            this.ShowPasswordChk.UseVisualStyleBackColor = false;
            this.ShowPasswordChk.CheckedChanged += new System.EventHandler(this.ShowPasswordChk_CheckedChanged);
            // 
            // AdminLoginbtn
            // 
            this.AdminLoginbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminLoginbtn.Location = new System.Drawing.Point(311, 428);
            this.AdminLoginbtn.Name = "AdminLoginbtn";
            this.AdminLoginbtn.Size = new System.Drawing.Size(274, 35);
            this.AdminLoginbtn.TabIndex = 3;
            this.AdminLoginbtn.Text = "Login";
            this.AdminLoginbtn.UseVisualStyleBackColor = true;
            this.AdminLoginbtn.Click += new System.EventHandler(this.AdminLoginbtn_Click);
            // 
            // AdminPasswordtxt
            // 
            this.AdminPasswordtxt.Location = new System.Drawing.Point(311, 324);
            this.AdminPasswordtxt.Name = "AdminPasswordtxt";
            this.AdminPasswordtxt.Size = new System.Drawing.Size(274, 22);
            this.AdminPasswordtxt.TabIndex = 5;
            this.AdminPasswordtxt.Text = "Type your password...";
            this.AdminPasswordtxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AdminPasswordtxt_KeyPress);
            this.AdminPasswordtxt.Leave += new System.EventHandler(this.AdminPasswordtxt_Leave);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearBtn.Location = new System.Drawing.Point(311, 469);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(274, 35);
            this.ClearBtn.TabIndex = 3;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // EmployeeLinkLabel
            // 
            this.EmployeeLinkLabel.AutoSize = true;
            this.EmployeeLinkLabel.BackColor = System.Drawing.Color.Transparent;
            this.EmployeeLinkLabel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeLinkLabel.LinkColor = System.Drawing.Color.White;
            this.EmployeeLinkLabel.Location = new System.Drawing.Point(42, 33);
            this.EmployeeLinkLabel.Name = "EmployeeLinkLabel";
            this.EmployeeLinkLabel.Size = new System.Drawing.Size(132, 19);
            this.EmployeeLinkLabel.TabIndex = 15;
            this.EmployeeLinkLabel.TabStop = true;
            this.EmployeeLinkLabel.Text = "I\'m an Employee";
            this.EmployeeLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.EmployeeLinkLabel_LinkClicked);
            // 
            // CloseApplicationBtn
            // 
            this.CloseApplicationBtn.AutoSize = true;
            this.CloseApplicationBtn.BackColor = System.Drawing.Color.Transparent;
            this.CloseApplicationBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseApplicationBtn.ForeColor = System.Drawing.Color.White;
            this.CloseApplicationBtn.Location = new System.Drawing.Point(832, 3);
            this.CloseApplicationBtn.Name = "CloseApplicationBtn";
            this.CloseApplicationBtn.Size = new System.Drawing.Size(30, 29);
            this.CloseApplicationBtn.TabIndex = 16;
            this.CloseApplicationBtn.Text = "X";
            this.CloseApplicationBtn.Click += new System.EventHandler(this.CloseApplicationBtn_Click);
            // 
            // MinimizeFormBtn
            // 
            this.MinimizeFormBtn.AutoSize = true;
            this.MinimizeFormBtn.BackColor = System.Drawing.Color.Transparent;
            this.MinimizeFormBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeFormBtn.ForeColor = System.Drawing.Color.White;
            this.MinimizeFormBtn.Location = new System.Drawing.Point(803, -5);
            this.MinimizeFormBtn.Name = "MinimizeFormBtn";
            this.MinimizeFormBtn.Size = new System.Drawing.Size(29, 38);
            this.MinimizeFormBtn.TabIndex = 17;
            this.MinimizeFormBtn.Text = "-";
            this.MinimizeFormBtn.Click += new System.EventHandler(this.MinimizeFormBtn_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::GrifindoToyLeaveApp.Properties.Resources.Glass_Effect_Login_Page___Blue1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(867, 645);
            this.Controls.Add(this.MinimizeFormBtn);
            this.Controls.Add(this.CloseApplicationBtn);
            this.Controls.Add(this.EmployeeLinkLabel);
            this.Controls.Add(this.AdminPasswordtxt);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.AdminLoginbtn);
            this.Controls.Add(this.ShowPasswordChk);
            this.Controls.Add(this.AdminUserNametxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AdminUserNametxt;
        private System.Windows.Forms.Button AdminLoginbtn;
        private System.Windows.Forms.TextBox AdminPasswordtxt;
        private System.Windows.Forms.CheckBox ShowPasswordChk;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.LinkLabel EmployeeLinkLabel;
        private System.Windows.Forms.Label CloseApplicationBtn;
        private System.Windows.Forms.Label MinimizeFormBtn;
    }
}