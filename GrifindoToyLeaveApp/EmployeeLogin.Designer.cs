namespace GrifindoToyLeaveApp
{
    partial class EmployeeLogin
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
            this.EmployeePasswordTxt = new System.Windows.Forms.TextBox();
            this.EmployeeLoginbtn = new System.Windows.Forms.Button();
            this.ShowPasswordChk = new System.Windows.Forms.CheckBox();
            this.EmployeeUserNameTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AdminLinkLabel = new System.Windows.Forms.LinkLabel();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.MinimizeFormBtn = new System.Windows.Forms.Label();
            this.CloseApplicationBtn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EmployeePasswordTxt
            // 
            this.EmployeePasswordTxt.ForeColor = System.Drawing.Color.Black;
            this.EmployeePasswordTxt.Location = new System.Drawing.Point(309, 344);
            this.EmployeePasswordTxt.Name = "EmployeePasswordTxt";
            this.EmployeePasswordTxt.Size = new System.Drawing.Size(274, 22);
            this.EmployeePasswordTxt.TabIndex = 13;
            this.EmployeePasswordTxt.Text = "Type Your Password...";
            this.EmployeePasswordTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EmployeePasswordTxt_KeyPress);
            this.EmployeePasswordTxt.Leave += new System.EventHandler(this.EmployeePasswordTxt_Leave);
            // 
            // EmployeeLoginbtn
            // 
            this.EmployeeLoginbtn.BackColor = System.Drawing.Color.Transparent;
            this.EmployeeLoginbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EmployeeLoginbtn.FlatAppearance.BorderSize = 0;
            this.EmployeeLoginbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeLoginbtn.Location = new System.Drawing.Point(309, 433);
            this.EmployeeLoginbtn.Name = "EmployeeLoginbtn";
            this.EmployeeLoginbtn.Size = new System.Drawing.Size(274, 35);
            this.EmployeeLoginbtn.TabIndex = 11;
            this.EmployeeLoginbtn.Text = "Login";
            this.EmployeeLoginbtn.UseVisualStyleBackColor = false;
            this.EmployeeLoginbtn.Click += new System.EventHandler(this.EmployeeLoginbtn_Click);
            // 
            // ShowPasswordChk
            // 
            this.ShowPasswordChk.AutoSize = true;
            this.ShowPasswordChk.BackColor = System.Drawing.Color.Transparent;
            this.ShowPasswordChk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ShowPasswordChk.ForeColor = System.Drawing.Color.White;
            this.ShowPasswordChk.Location = new System.Drawing.Point(309, 372);
            this.ShowPasswordChk.Name = "ShowPasswordChk";
            this.ShowPasswordChk.Size = new System.Drawing.Size(129, 21);
            this.ShowPasswordChk.TabIndex = 10;
            this.ShowPasswordChk.Text = "Show Password";
            this.ShowPasswordChk.UseVisualStyleBackColor = false;
            this.ShowPasswordChk.CheckedChanged += new System.EventHandler(this.ShowPasswordChk_CheckedChanged);
            // 
            // EmployeeUserNameTxt
            // 
            this.EmployeeUserNameTxt.ForeColor = System.Drawing.Color.Black;
            this.EmployeeUserNameTxt.Location = new System.Drawing.Point(309, 243);
            this.EmployeeUserNameTxt.Name = "EmployeeUserNameTxt";
            this.EmployeeUserNameTxt.Size = new System.Drawing.Size(274, 22);
            this.EmployeeUserNameTxt.TabIndex = 9;
            this.EmployeeUserNameTxt.Text = "Type Your Username...";
            this.EmployeeUserNameTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EmployeeUserNameTxt_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(305, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(305, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(282, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 37);
            this.label1.TabIndex = 8;
            this.label1.Text = "Employee Login";
            // 
            // AdminLinkLabel
            // 
            this.AdminLinkLabel.AutoSize = true;
            this.AdminLinkLabel.BackColor = System.Drawing.Color.Transparent;
            this.AdminLinkLabel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminLinkLabel.LinkColor = System.Drawing.Color.White;
            this.AdminLinkLabel.Location = new System.Drawing.Point(33, 23);
            this.AdminLinkLabel.Name = "AdminLinkLabel";
            this.AdminLinkLabel.Size = new System.Drawing.Size(98, 19);
            this.AdminLinkLabel.TabIndex = 14;
            this.AdminLinkLabel.TabStop = true;
            this.AdminLinkLabel.Text = "I\'m a Admin";
            this.AdminLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AdminLinkLabel_LinkClicked);
            // 
            // ClearBtn
            // 
            this.ClearBtn.BackColor = System.Drawing.Color.Transparent;
            this.ClearBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClearBtn.FlatAppearance.BorderSize = 0;
            this.ClearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearBtn.Location = new System.Drawing.Point(309, 483);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(274, 35);
            this.ClearBtn.TabIndex = 11;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = false;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // MinimizeFormBtn
            // 
            this.MinimizeFormBtn.AutoSize = true;
            this.MinimizeFormBtn.BackColor = System.Drawing.Color.Transparent;
            this.MinimizeFormBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeFormBtn.ForeColor = System.Drawing.Color.White;
            this.MinimizeFormBtn.Location = new System.Drawing.Point(796, 1);
            this.MinimizeFormBtn.Name = "MinimizeFormBtn";
            this.MinimizeFormBtn.Size = new System.Drawing.Size(29, 38);
            this.MinimizeFormBtn.TabIndex = 19;
            this.MinimizeFormBtn.Text = "-";
            this.MinimizeFormBtn.Click += new System.EventHandler(this.MinimizeFormBtn_Click);
            // 
            // CloseApplicationBtn
            // 
            this.CloseApplicationBtn.AutoSize = true;
            this.CloseApplicationBtn.BackColor = System.Drawing.Color.Transparent;
            this.CloseApplicationBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseApplicationBtn.ForeColor = System.Drawing.Color.White;
            this.CloseApplicationBtn.Location = new System.Drawing.Point(825, 9);
            this.CloseApplicationBtn.Name = "CloseApplicationBtn";
            this.CloseApplicationBtn.Size = new System.Drawing.Size(30, 29);
            this.CloseApplicationBtn.TabIndex = 18;
            this.CloseApplicationBtn.Text = "X";
            this.CloseApplicationBtn.Click += new System.EventHandler(this.CloseApplicationBtn_Click);
            // 
            // EmployeeLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(59)))));
            this.BackgroundImage = global::GrifindoToyLeaveApp.Properties.Resources.Glass_Effect_Login_Page___Blue2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(867, 645);
            this.Controls.Add(this.MinimizeFormBtn);
            this.Controls.Add(this.CloseApplicationBtn);
            this.Controls.Add(this.AdminLinkLabel);
            this.Controls.Add(this.EmployeePasswordTxt);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.EmployeeLoginbtn);
            this.Controls.Add(this.ShowPasswordChk);
            this.Controls.Add(this.EmployeeUserNameTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeeLogin";
            this.Text = "EmployeeLogin";
            this.Load += new System.EventHandler(this.EmployeeLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EmployeePasswordTxt;
        private System.Windows.Forms.Button EmployeeLoginbtn;
        private System.Windows.Forms.CheckBox ShowPasswordChk;
        private System.Windows.Forms.TextBox EmployeeUserNameTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel AdminLinkLabel;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Label MinimizeFormBtn;
        private System.Windows.Forms.Label CloseApplicationBtn;
    }
}