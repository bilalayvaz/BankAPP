namespace BankApp.WindowsFormsUI
{
    partial class frmAccountInfo
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
            this.dgwAccount = new System.Windows.Forms.DataGridView();
            this.btnAccountInfoNewAccount = new System.Windows.Forms.Button();
            this.btnAccountInfoDeleteAccount = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwAccount
            // 
            this.dgwAccount.AllowUserToAddRows = false;
            this.dgwAccount.AllowUserToDeleteRows = false;
            this.dgwAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwAccount.BackgroundColor = System.Drawing.Color.Cornsilk;
            this.dgwAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwAccount.Location = new System.Drawing.Point(12, 66);
            this.dgwAccount.MultiSelect = false;
            this.dgwAccount.Name = "dgwAccount";
            this.dgwAccount.ReadOnly = true;
            this.dgwAccount.RowHeadersWidth = 15;
            this.dgwAccount.Size = new System.Drawing.Size(576, 261);
            this.dgwAccount.TabIndex = 1;
            // 
            // btnAccountInfoNewAccount
            // 
            this.btnAccountInfoNewAccount.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAccountInfoNewAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAccountInfoNewAccount.Location = new System.Drawing.Point(155, 12);
            this.btnAccountInfoNewAccount.Name = "btnAccountInfoNewAccount";
            this.btnAccountInfoNewAccount.Size = new System.Drawing.Size(127, 34);
            this.btnAccountInfoNewAccount.TabIndex = 2;
            this.btnAccountInfoNewAccount.Text = "Yeni Hesap Aç";
            this.btnAccountInfoNewAccount.UseVisualStyleBackColor = false;
            this.btnAccountInfoNewAccount.Click += new System.EventHandler(this.btnAccountInfoNewAccount_Click);
            // 
            // btnAccountInfoDeleteAccount
            // 
            this.btnAccountInfoDeleteAccount.BackColor = System.Drawing.Color.Crimson;
            this.btnAccountInfoDeleteAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAccountInfoDeleteAccount.Location = new System.Drawing.Point(311, 12);
            this.btnAccountInfoDeleteAccount.Name = "btnAccountInfoDeleteAccount";
            this.btnAccountInfoDeleteAccount.Size = new System.Drawing.Size(136, 34);
            this.btnAccountInfoDeleteAccount.TabIndex = 3;
            this.btnAccountInfoDeleteAccount.Text = "Seçilen Hesabı Kapat";
            this.btnAccountInfoDeleteAccount.UseVisualStyleBackColor = false;
            this.btnAccountInfoDeleteAccount.Click += new System.EventHandler(this.btnAccountInfoDeleteAccount_Click);
            // 
            // frmAccountInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 362);
            this.Controls.Add(this.btnAccountInfoDeleteAccount);
            this.Controls.Add(this.btnAccountInfoNewAccount);
            this.Controls.Add(this.dgwAccount);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAccountInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hesap Bilgileri";
            this.Load += new System.EventHandler(this.frmAccountInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwAccount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwAccount;
        private System.Windows.Forms.Button btnAccountInfoNewAccount;
        private System.Windows.Forms.Button btnAccountInfoDeleteAccount;
    }
}