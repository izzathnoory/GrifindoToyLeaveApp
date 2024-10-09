namespace GrifindoToyLeaveApp
{
    partial class IntroForm
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
            this.AdminBtn = new System.Windows.Forms.PictureBox();
            this.EmployeeBtn = new System.Windows.Forms.PictureBox();
            this.MinimizeFormBtn = new System.Windows.Forms.Label();
            this.CloseApplicationBtn = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AdminBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // AdminBtn
            // 
            this.AdminBtn.BackColor = System.Drawing.Color.Transparent;
            this.AdminBtn.Location = new System.Drawing.Point(193, 437);
            this.AdminBtn.Name = "AdminBtn";
            this.AdminBtn.Size = new System.Drawing.Size(100, 72);
            this.AdminBtn.TabIndex = 7;
            this.AdminBtn.TabStop = false;
            this.AdminBtn.Click += new System.EventHandler(this.AdminBtn_Click);
            // 
            // EmployeeBtn
            // 
            this.EmployeeBtn.BackColor = System.Drawing.Color.Transparent;
            this.EmployeeBtn.Location = new System.Drawing.Point(569, 443);
            this.EmployeeBtn.Name = "EmployeeBtn";
            this.EmployeeBtn.Size = new System.Drawing.Size(137, 72);
            this.EmployeeBtn.TabIndex = 8;
            this.EmployeeBtn.TabStop = false;
            this.EmployeeBtn.Click += new System.EventHandler(this.EmployeeBtn_Click);
            // 
            // MinimizeFormBtn
            // 
            this.MinimizeFormBtn.AutoSize = true;
            this.MinimizeFormBtn.BackColor = System.Drawing.Color.Transparent;
            this.MinimizeFormBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeFormBtn.ForeColor = System.Drawing.Color.White;
            this.MinimizeFormBtn.Location = new System.Drawing.Point(808, -4);
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
            this.CloseApplicationBtn.Location = new System.Drawing.Point(836, 3);
            this.CloseApplicationBtn.Name = "CloseApplicationBtn";
            this.CloseApplicationBtn.Size = new System.Drawing.Size(30, 29);
            this.CloseApplicationBtn.TabIndex = 18;
            this.CloseApplicationBtn.Text = "X";
            this.CloseApplicationBtn.Click += new System.EventHandler(this.CloseApplicationBtn_Click);
            // 
            // IntroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(59)))));
            this.BackgroundImage = global::GrifindoToyLeaveApp.Properties.Resources.Glass_Effect_Login_Page___Blue__4_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(867, 645);
            this.Controls.Add(this.MinimizeFormBtn);
            this.Controls.Add(this.CloseApplicationBtn);
            this.Controls.Add(this.EmployeeBtn);
            this.Controls.Add(this.AdminBtn);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IntroForm";
            this.Text = "IntroForm";
            ((System.ComponentModel.ISupportInitialize)(this.AdminBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox AdminBtn;
        private System.Windows.Forms.PictureBox EmployeeBtn;
        private System.Windows.Forms.Label MinimizeFormBtn;
        private System.Windows.Forms.Label CloseApplicationBtn;
    }
}