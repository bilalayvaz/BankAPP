namespace BankApp.WindowsFormsUI
{
    partial class frmLogin
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
            this.gbxGiris = new System.Windows.Forms.GroupBox();
            this.lblLoginRegister = new System.Windows.Forms.Label();
            this.btnLoginLogin = new System.Windows.Forms.Button();
            this.lblLoginPassword = new System.Windows.Forms.Label();
            this.lblLoginTcNo = new System.Windows.Forms.Label();
            this.tbxLoginPassword = new System.Windows.Forms.TextBox();
            this.tbxLoginTcNo = new System.Windows.Forms.TextBox();
            this.gbxGiris.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxGiris
            // 
            this.gbxGiris.BackColor = System.Drawing.Color.IndianRed;
            this.gbxGiris.Controls.Add(this.lblLoginRegister);
            this.gbxGiris.Controls.Add(this.btnLoginLogin);
            this.gbxGiris.Controls.Add(this.lblLoginPassword);
            this.gbxGiris.Controls.Add(this.lblLoginTcNo);
            this.gbxGiris.Controls.Add(this.tbxLoginPassword);
            this.gbxGiris.Controls.Add(this.tbxLoginTcNo);
            this.gbxGiris.Location = new System.Drawing.Point(37, 32);
            this.gbxGiris.Name = "gbxGiris";
            this.gbxGiris.Size = new System.Drawing.Size(261, 232);
            this.gbxGiris.TabIndex = 0;
            this.gbxGiris.TabStop = false;
            this.gbxGiris.Text = "Giriş - Kayıt";
            // 
            // lblLoginRegister
            // 
            this.lblLoginRegister.AutoSize = true;
            this.lblLoginRegister.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLoginRegister.Location = new System.Drawing.Point(99, 182);
            this.lblLoginRegister.Name = "lblLoginRegister";
            this.lblLoginRegister.Size = new System.Drawing.Size(58, 17);
            this.lblLoginRegister.TabIndex = 5;
            this.lblLoginRegister.Text = "Kayıt Ol";
            this.lblLoginRegister.Click += new System.EventHandler(this.lblLoginRegister_Click);
            // 
            // btnLoginLogin
            // 
            this.btnLoginLogin.Location = new System.Drawing.Point(114, 138);
            this.btnLoginLogin.Name = "btnLoginLogin";
            this.btnLoginLogin.Size = new System.Drawing.Size(96, 23);
            this.btnLoginLogin.TabIndex = 4;
            this.btnLoginLogin.Text = "Giriş";
            this.btnLoginLogin.UseVisualStyleBackColor = true;
            this.btnLoginLogin.Click += new System.EventHandler(this.btnLoginLogin_Click);
            // 
            // lblLoginPassword
            // 
            this.lblLoginPassword.AutoSize = true;
            this.lblLoginPassword.Location = new System.Drawing.Point(33, 106);
            this.lblLoginPassword.Name = "lblLoginPassword";
            this.lblLoginPassword.Size = new System.Drawing.Size(28, 13);
            this.lblLoginPassword.TabIndex = 3;
            this.lblLoginPassword.Text = "Şifre";
            // 
            // lblLoginTcNo
            // 
            this.lblLoginTcNo.AutoSize = true;
            this.lblLoginTcNo.Location = new System.Drawing.Point(24, 59);
            this.lblLoginTcNo.Name = "lblLoginTcNo";
            this.lblLoginTcNo.Size = new System.Drawing.Size(53, 26);
            this.lblLoginTcNo.TabIndex = 2;
            this.lblLoginTcNo.Text = "Tc Kimlik \r\nNumarası";
            this.lblLoginTcNo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbxLoginPassword
            // 
            this.tbxLoginPassword.Location = new System.Drawing.Point(91, 103);
            this.tbxLoginPassword.Name = "tbxLoginPassword";
            this.tbxLoginPassword.PasswordChar = '*';
            this.tbxLoginPassword.Size = new System.Drawing.Size(139, 20);
            this.tbxLoginPassword.TabIndex = 1;
            this.tbxLoginPassword.TextChanged += new System.EventHandler(this.tbxLoginPassword_TextChanged);
            // 
            // tbxLoginTcNo
            // 
            this.tbxLoginTcNo.Location = new System.Drawing.Point(91, 59);
            this.tbxLoginTcNo.MaxLength = 11;
            this.tbxLoginTcNo.Name = "tbxLoginTcNo";
            this.tbxLoginTcNo.Size = new System.Drawing.Size(139, 20);
            this.tbxLoginTcNo.TabIndex = 0;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(339, 292);
            this.Controls.Add(this.gbxGiris);
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.gbxGiris.ResumeLayout(false);
            this.gbxGiris.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxGiris;
        private System.Windows.Forms.TextBox tbxLoginPassword;
        private System.Windows.Forms.TextBox tbxLoginTcNo;
        private System.Windows.Forms.Label lblLoginPassword;
        private System.Windows.Forms.Label lblLoginTcNo;
        private System.Windows.Forms.Label lblLoginRegister;
        private System.Windows.Forms.Button btnLoginLogin;
    }
}

