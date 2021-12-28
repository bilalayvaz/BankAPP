namespace BankApp.WindowsFormsUI
{
    partial class frmCustomerPanel
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCustomerPanelPayments = new System.Windows.Forms.Button();
            this.btnCustomerPanelVirman = new System.Windows.Forms.Button();
            this.btnCustomerPanelAccountInfo = new System.Windows.Forms.Button();
            this.btnCustomerPanelCustomerInfo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Beige;
            this.groupBox1.Controls.Add(this.btnCustomerPanelPayments);
            this.groupBox1.Controls.Add(this.btnCustomerPanelVirman);
            this.groupBox1.Controls.Add(this.btnCustomerPanelAccountInfo);
            this.groupBox1.Controls.Add(this.btnCustomerPanelCustomerInfo);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(169, 219);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kullanıcı İşlemleri";
            // 
            // btnCustomerPanelPayments
            // 
            this.btnCustomerPanelPayments.Location = new System.Drawing.Point(24, 158);
            this.btnCustomerPanelPayments.Name = "btnCustomerPanelPayments";
            this.btnCustomerPanelPayments.Size = new System.Drawing.Size(116, 23);
            this.btnCustomerPanelPayments.TabIndex = 3;
            this.btnCustomerPanelPayments.Text = "Ödeme İşlemleri";
            this.btnCustomerPanelPayments.UseVisualStyleBackColor = true;
            // 
            // btnCustomerPanelVirman
            // 
            this.btnCustomerPanelVirman.Location = new System.Drawing.Point(24, 117);
            this.btnCustomerPanelVirman.Name = "btnCustomerPanelVirman";
            this.btnCustomerPanelVirman.Size = new System.Drawing.Size(116, 23);
            this.btnCustomerPanelVirman.TabIndex = 2;
            this.btnCustomerPanelVirman.Text = "Havale / Virman";
            this.btnCustomerPanelVirman.UseVisualStyleBackColor = true;
            this.btnCustomerPanelVirman.Click += new System.EventHandler(this.btnCustomerPanelVirman_Click);
            // 
            // btnCustomerPanelAccountInfo
            // 
            this.btnCustomerPanelAccountInfo.Location = new System.Drawing.Point(24, 79);
            this.btnCustomerPanelAccountInfo.Name = "btnCustomerPanelAccountInfo";
            this.btnCustomerPanelAccountInfo.Size = new System.Drawing.Size(116, 23);
            this.btnCustomerPanelAccountInfo.TabIndex = 1;
            this.btnCustomerPanelAccountInfo.Text = "Hesap Bilgileri";
            this.btnCustomerPanelAccountInfo.UseVisualStyleBackColor = true;
            this.btnCustomerPanelAccountInfo.Click += new System.EventHandler(this.btnCustomerPanelAccountInfo_Click);
            // 
            // btnCustomerPanelCustomerInfo
            // 
            this.btnCustomerPanelCustomerInfo.Location = new System.Drawing.Point(24, 38);
            this.btnCustomerPanelCustomerInfo.Name = "btnCustomerPanelCustomerInfo";
            this.btnCustomerPanelCustomerInfo.Size = new System.Drawing.Size(116, 23);
            this.btnCustomerPanelCustomerInfo.TabIndex = 0;
            this.btnCustomerPanelCustomerInfo.Text = "Kullanıcı Bilgileri";
            this.btnCustomerPanelCustomerInfo.UseVisualStyleBackColor = true;
            this.btnCustomerPanelCustomerInfo.Click += new System.EventHandler(this.btnCustomerPanelCustomerInfo_Click);
            // 
            // frmCustomerPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(196, 245);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "frmCustomerPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Paneli";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCustomerPanelVirman;
        private System.Windows.Forms.Button btnCustomerPanelAccountInfo;
        private System.Windows.Forms.Button btnCustomerPanelCustomerInfo;
        private System.Windows.Forms.Button btnCustomerPanelPayments;
    }
}