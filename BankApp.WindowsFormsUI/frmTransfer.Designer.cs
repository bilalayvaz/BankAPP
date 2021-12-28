namespace BankApp.WindowsFormsUI
{
    partial class frmTransfer
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
            this.gbxTransferVirmanSender = new System.Windows.Forms.GroupBox();
            this.dgwVirmanSender = new System.Windows.Forms.DataGridView();
            this.gbxTransferVirmanReceiver = new System.Windows.Forms.GroupBox();
            this.dgwVirmanReceiver = new System.Windows.Forms.DataGridView();
            this.lblVirmanSenderAccountNoAdditionalNo = new System.Windows.Forms.Label();
            this.lblVirmanReceiverAccountNoAdditionalNo = new System.Windows.Forms.Label();
            this.lblVirmanSenderAmount = new System.Windows.Forms.Label();
            this.tbxVirmanSenderAmount = new System.Windows.Forms.TextBox();
            this.a = new System.Windows.Forms.Label();
            this.lblVirmanSenderBalance = new System.Windows.Forms.Label();
            this.lblVirmanReceiverBalance = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgwHavaleSender = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbxHavaleReceiverAccountNo = new System.Windows.Forms.TextBox();
            this.tbxHavaleReceiverAdditionalNo = new System.Windows.Forms.TextBox();
            this.btnHavaleSend = new System.Windows.Forms.Button();
            this.btnVirman = new System.Windows.Forms.Button();
            this.gbxVirman = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbxHavale = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.tbxHavaleReceiverAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxTransferVirmanSender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwVirmanSender)).BeginInit();
            this.gbxTransferVirmanReceiver.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwVirmanReceiver)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwHavaleSender)).BeginInit();
            this.gbxVirman.SuspendLayout();
            this.gbxHavale.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxTransferVirmanSender
            // 
            this.gbxTransferVirmanSender.Controls.Add(this.dgwVirmanSender);
            this.gbxTransferVirmanSender.Location = new System.Drawing.Point(20, 28);
            this.gbxTransferVirmanSender.Name = "gbxTransferVirmanSender";
            this.gbxTransferVirmanSender.Size = new System.Drawing.Size(322, 145);
            this.gbxTransferVirmanSender.TabIndex = 0;
            this.gbxTransferVirmanSender.TabStop = false;
            this.gbxTransferVirmanSender.Text = "Para Aktaracak Hesap";
            // 
            // dgwVirmanSender
            // 
            this.dgwVirmanSender.AllowUserToAddRows = false;
            this.dgwVirmanSender.AllowUserToDeleteRows = false;
            this.dgwVirmanSender.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwVirmanSender.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwVirmanSender.Location = new System.Drawing.Point(6, 19);
            this.dgwVirmanSender.MultiSelect = false;
            this.dgwVirmanSender.Name = "dgwVirmanSender";
            this.dgwVirmanSender.ReadOnly = true;
            this.dgwVirmanSender.RowHeadersWidth = 15;
            this.dgwVirmanSender.Size = new System.Drawing.Size(310, 120);
            this.dgwVirmanSender.TabIndex = 0;
            this.dgwVirmanSender.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwVirmanSender_CellClick);
            // 
            // gbxTransferVirmanReceiver
            // 
            this.gbxTransferVirmanReceiver.Controls.Add(this.dgwVirmanReceiver);
            this.gbxTransferVirmanReceiver.Location = new System.Drawing.Point(367, 28);
            this.gbxTransferVirmanReceiver.Name = "gbxTransferVirmanReceiver";
            this.gbxTransferVirmanReceiver.Size = new System.Drawing.Size(333, 145);
            this.gbxTransferVirmanReceiver.TabIndex = 1;
            this.gbxTransferVirmanReceiver.TabStop = false;
            this.gbxTransferVirmanReceiver.Text = "Para Aktarılacak Hesap";
            // 
            // dgwVirmanReceiver
            // 
            this.dgwVirmanReceiver.AllowUserToAddRows = false;
            this.dgwVirmanReceiver.AllowUserToDeleteRows = false;
            this.dgwVirmanReceiver.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwVirmanReceiver.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwVirmanReceiver.Location = new System.Drawing.Point(6, 19);
            this.dgwVirmanReceiver.MultiSelect = false;
            this.dgwVirmanReceiver.Name = "dgwVirmanReceiver";
            this.dgwVirmanReceiver.ReadOnly = true;
            this.dgwVirmanReceiver.RowHeadersWidth = 15;
            this.dgwVirmanReceiver.Size = new System.Drawing.Size(321, 120);
            this.dgwVirmanReceiver.TabIndex = 2;
            this.dgwVirmanReceiver.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwVirmanReceiver_CellClick);
            // 
            // lblVirmanSenderAccountNoAdditionalNo
            // 
            this.lblVirmanSenderAccountNoAdditionalNo.AutoSize = true;
            this.lblVirmanSenderAccountNoAdditionalNo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblVirmanSenderAccountNoAdditionalNo.Location = new System.Drawing.Point(125, 193);
            this.lblVirmanSenderAccountNoAdditionalNo.Name = "lblVirmanSenderAccountNoAdditionalNo";
            this.lblVirmanSenderAccountNoAdditionalNo.Size = new System.Drawing.Size(50, 18);
            this.lblVirmanSenderAccountNoAdditionalNo.TabIndex = 2;
            this.lblVirmanSenderAccountNoAdditionalNo.Text = "label1";
            // 
            // lblVirmanReceiverAccountNoAdditionalNo
            // 
            this.lblVirmanReceiverAccountNoAdditionalNo.AutoSize = true;
            this.lblVirmanReceiverAccountNoAdditionalNo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblVirmanReceiverAccountNoAdditionalNo.Location = new System.Drawing.Point(485, 193);
            this.lblVirmanReceiverAccountNoAdditionalNo.Name = "lblVirmanReceiverAccountNoAdditionalNo";
            this.lblVirmanReceiverAccountNoAdditionalNo.Size = new System.Drawing.Size(50, 18);
            this.lblVirmanReceiverAccountNoAdditionalNo.TabIndex = 3;
            this.lblVirmanReceiverAccountNoAdditionalNo.Text = "label2";
            // 
            // lblVirmanSenderAmount
            // 
            this.lblVirmanSenderAmount.AutoSize = true;
            this.lblVirmanSenderAmount.Location = new System.Drawing.Point(31, 263);
            this.lblVirmanSenderAmount.Name = "lblVirmanSenderAmount";
            this.lblVirmanSenderAmount.Size = new System.Drawing.Size(88, 13);
            this.lblVirmanSenderAmount.TabIndex = 4;
            this.lblVirmanSenderAmount.Text = "Aktarılacak Tutar";
            // 
            // tbxVirmanSenderAmount
            // 
            this.tbxVirmanSenderAmount.Location = new System.Drawing.Point(128, 260);
            this.tbxVirmanSenderAmount.Name = "tbxVirmanSenderAmount";
            this.tbxVirmanSenderAmount.Size = new System.Drawing.Size(125, 20);
            this.tbxVirmanSenderAmount.TabIndex = 5;
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Location = new System.Drawing.Point(31, 229);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(39, 13);
            this.a.TabIndex = 6;
            this.a.Text = "Bakiye";
            // 
            // lblVirmanSenderBalance
            // 
            this.lblVirmanSenderBalance.AutoSize = true;
            this.lblVirmanSenderBalance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblVirmanSenderBalance.Location = new System.Drawing.Point(148, 224);
            this.lblVirmanSenderBalance.Name = "lblVirmanSenderBalance";
            this.lblVirmanSenderBalance.Size = new System.Drawing.Size(50, 18);
            this.lblVirmanSenderBalance.TabIndex = 7;
            this.lblVirmanSenderBalance.Text = "label5";
            // 
            // lblVirmanReceiverBalance
            // 
            this.lblVirmanReceiverBalance.AutoSize = true;
            this.lblVirmanReceiverBalance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblVirmanReceiverBalance.Location = new System.Drawing.Point(520, 224);
            this.lblVirmanReceiverBalance.Name = "lblVirmanReceiverBalance";
            this.lblVirmanReceiverBalance.Size = new System.Drawing.Size(50, 18);
            this.lblVirmanReceiverBalance.TabIndex = 9;
            this.lblVirmanReceiverBalance.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(403, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Bakiye";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgwHavaleSender);
            this.groupBox3.Location = new System.Drawing.Point(20, 36);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(316, 152);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Para Aktaracak Hesap";
            // 
            // dgwHavaleSender
            // 
            this.dgwHavaleSender.AllowUserToAddRows = false;
            this.dgwHavaleSender.AllowUserToDeleteRows = false;
            this.dgwHavaleSender.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwHavaleSender.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwHavaleSender.Location = new System.Drawing.Point(6, 23);
            this.dgwHavaleSender.MultiSelect = false;
            this.dgwHavaleSender.Name = "dgwHavaleSender";
            this.dgwHavaleSender.ReadOnly = true;
            this.dgwHavaleSender.RowHeadersWidth = 15;
            this.dgwHavaleSender.Size = new System.Drawing.Size(304, 120);
            this.dgwHavaleSender.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Hesap Numarası";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(46, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Ek Numara";
            // 
            // tbxHavaleReceiverAccountNo
            // 
            this.tbxHavaleReceiverAccountNo.Location = new System.Drawing.Point(158, 23);
            this.tbxHavaleReceiverAccountNo.MaxLength = 9;
            this.tbxHavaleReceiverAccountNo.Name = "tbxHavaleReceiverAccountNo";
            this.tbxHavaleReceiverAccountNo.Size = new System.Drawing.Size(125, 20);
            this.tbxHavaleReceiverAccountNo.TabIndex = 13;
            // 
            // tbxHavaleReceiverAdditionalNo
            // 
            this.tbxHavaleReceiverAdditionalNo.Location = new System.Drawing.Point(158, 54);
            this.tbxHavaleReceiverAdditionalNo.Name = "tbxHavaleReceiverAdditionalNo";
            this.tbxHavaleReceiverAdditionalNo.Size = new System.Drawing.Size(125, 20);
            this.tbxHavaleReceiverAdditionalNo.TabIndex = 14;
            // 
            // btnHavaleSend
            // 
            this.btnHavaleSend.Location = new System.Drawing.Point(102, 120);
            this.btnHavaleSend.Name = "btnHavaleSend";
            this.btnHavaleSend.Size = new System.Drawing.Size(128, 23);
            this.btnHavaleSend.TabIndex = 15;
            this.btnHavaleSend.Text = "Havale Gönder";
            this.btnHavaleSend.UseVisualStyleBackColor = true;
            this.btnHavaleSend.Click += new System.EventHandler(this.btnHavaleSend_Click);
            // 
            // btnVirman
            // 
            this.btnVirman.Location = new System.Drawing.Point(125, 302);
            this.btnVirman.Name = "btnVirman";
            this.btnVirman.Size = new System.Drawing.Size(128, 23);
            this.btnVirman.TabIndex = 16;
            this.btnVirman.Text = "Virman Gönder";
            this.btnVirman.UseVisualStyleBackColor = true;
            this.btnVirman.Click += new System.EventHandler(this.btnVirman_Click);
            // 
            // gbxVirman
            // 
            this.gbxVirman.BackColor = System.Drawing.Color.LightCyan;
            this.gbxVirman.Controls.Add(this.label3);
            this.gbxVirman.Controls.Add(this.label2);
            this.gbxVirman.Controls.Add(this.btnVirman);
            this.gbxVirman.Controls.Add(this.lblVirmanReceiverBalance);
            this.gbxVirman.Controls.Add(this.label7);
            this.gbxVirman.Controls.Add(this.lblVirmanSenderBalance);
            this.gbxVirman.Controls.Add(this.a);
            this.gbxVirman.Controls.Add(this.tbxVirmanSenderAmount);
            this.gbxVirman.Controls.Add(this.lblVirmanSenderAmount);
            this.gbxVirman.Controls.Add(this.lblVirmanReceiverAccountNoAdditionalNo);
            this.gbxVirman.Controls.Add(this.lblVirmanSenderAccountNoAdditionalNo);
            this.gbxVirman.Controls.Add(this.gbxTransferVirmanReceiver);
            this.gbxVirman.Controls.Add(this.gbxTransferVirmanSender);
            this.gbxVirman.Location = new System.Drawing.Point(13, 8);
            this.gbxVirman.Name = "gbxVirman";
            this.gbxVirman.Size = new System.Drawing.Size(717, 331);
            this.gbxVirman.TabIndex = 17;
            this.gbxVirman.TabStop = false;
            this.gbxVirman.Text = "Virman (Kendi Hesapların Arasında Transfer)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(403, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Hesap No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Hesap No";
            // 
            // gbxHavale
            // 
            this.gbxHavale.BackColor = System.Drawing.Color.Thistle;
            this.gbxHavale.Controls.Add(this.groupBox6);
            this.gbxHavale.Controls.Add(this.groupBox3);
            this.gbxHavale.Location = new System.Drawing.Point(13, 352);
            this.gbxHavale.Name = "gbxHavale";
            this.gbxHavale.Size = new System.Drawing.Size(716, 207);
            this.gbxHavale.TabIndex = 18;
            this.gbxHavale.TabStop = false;
            this.gbxHavale.Text = "Havale (Başka Kişiye Transfer)";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.tbxHavaleReceiverAmount);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Controls.Add(this.btnHavaleSend);
            this.groupBox6.Controls.Add(this.tbxHavaleReceiverAdditionalNo);
            this.groupBox6.Controls.Add(this.tbxHavaleReceiverAccountNo);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Location = new System.Drawing.Point(386, 36);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(313, 152);
            this.groupBox6.TabIndex = 16;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Alıcı Bilgileri";
            // 
            // tbxHavaleReceiverAmount
            // 
            this.tbxHavaleReceiverAmount.Location = new System.Drawing.Point(158, 83);
            this.tbxHavaleReceiverAmount.Name = "tbxHavaleReceiverAmount";
            this.tbxHavaleReceiverAmount.Size = new System.Drawing.Size(125, 20);
            this.tbxHavaleReceiverAmount.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Aktarılacak Tutar";
            // 
            // frmTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 566);
            this.Controls.Add(this.gbxHavale);
            this.Controls.Add(this.gbxVirman);
            this.MaximizeBox = false;
            this.Name = "frmTransfer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTransfer";
            this.Load += new System.EventHandler(this.frmTransfer_Load);
            this.gbxTransferVirmanSender.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwVirmanSender)).EndInit();
            this.gbxTransferVirmanReceiver.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwVirmanReceiver)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwHavaleSender)).EndInit();
            this.gbxVirman.ResumeLayout(false);
            this.gbxVirman.PerformLayout();
            this.gbxHavale.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxTransferVirmanSender;
        private System.Windows.Forms.GroupBox gbxTransferVirmanReceiver;
        private System.Windows.Forms.Label lblVirmanSenderAccountNoAdditionalNo;
        private System.Windows.Forms.Label lblVirmanReceiverAccountNoAdditionalNo;
        private System.Windows.Forms.Label lblVirmanSenderAmount;
        private System.Windows.Forms.TextBox tbxVirmanSenderAmount;
        private System.Windows.Forms.Label a;
        private System.Windows.Forms.Label lblVirmanSenderBalance;
        private System.Windows.Forms.Label lblVirmanReceiverBalance;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbxHavaleReceiverAccountNo;
        private System.Windows.Forms.TextBox tbxHavaleReceiverAdditionalNo;
        private System.Windows.Forms.Button btnHavaleSend;
        private System.Windows.Forms.Button btnVirman;
        private System.Windows.Forms.GroupBox gbxVirman;
        private System.Windows.Forms.GroupBox gbxHavale;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView dgwVirmanSender;
        private System.Windows.Forms.DataGridView dgwVirmanReceiver;
        private System.Windows.Forms.DataGridView dgwHavaleSender;
        private System.Windows.Forms.TextBox tbxHavaleReceiverAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}