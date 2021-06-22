
namespace Bank
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textOwnerAccount = new System.Windows.Forms.TextBox();
            this.textAccountNumber = new System.Windows.Forms.TextBox();
            this.textBalance = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGetValue = new System.Windows.Forms.Button();
            this.btnSendValue = new System.Windows.Forms.Button();
            this.textOpValue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBalanceReport = new System.Windows.Forms.Button();
            this.comboBoxAccounts = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textOwnerAccount
            // 
            this.textOwnerAccount.Location = new System.Drawing.Point(32, 66);
            this.textOwnerAccount.Multiline = true;
            this.textOwnerAccount.Name = "textOwnerAccount";
            this.textOwnerAccount.Size = new System.Drawing.Size(323, 30);
            this.textOwnerAccount.TabIndex = 0;
            // 
            // textAccountNumber
            // 
            this.textAccountNumber.Location = new System.Drawing.Point(32, 130);
            this.textAccountNumber.Multiline = true;
            this.textAccountNumber.Name = "textAccountNumber";
            this.textAccountNumber.Size = new System.Drawing.Size(323, 30);
            this.textAccountNumber.TabIndex = 1;
            // 
            // textBalance
            // 
            this.textBalance.Location = new System.Drawing.Point(32, 196);
            this.textBalance.Multiline = true;
            this.textBalance.Name = "textBalance";
            this.textBalance.Size = new System.Drawing.Size(323, 30);
            this.textBalance.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(32, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(32, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Número da conta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(32, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Saldo";
            // 
            // btnGetValue
            // 
            this.btnGetValue.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnGetValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGetValue.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGetValue.Location = new System.Drawing.Point(32, 334);
            this.btnGetValue.Name = "btnGetValue";
            this.btnGetValue.Size = new System.Drawing.Size(154, 40);
            this.btnGetValue.TabIndex = 6;
            this.btnGetValue.Text = "Sacar";
            this.btnGetValue.UseVisualStyleBackColor = false;
            this.btnGetValue.Click += new System.EventHandler(this.btnGetValue_Click);
            // 
            // btnSendValue
            // 
            this.btnSendValue.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSendValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSendValue.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSendValue.Location = new System.Drawing.Point(201, 334);
            this.btnSendValue.Name = "btnSendValue";
            this.btnSendValue.Size = new System.Drawing.Size(154, 40);
            this.btnSendValue.TabIndex = 7;
            this.btnSendValue.Text = "Depositar";
            this.btnSendValue.UseVisualStyleBackColor = false;
            this.btnSendValue.Click += new System.EventHandler(this.btnSendValue_Click);
            // 
            // textOpValue
            // 
            this.textOpValue.Location = new System.Drawing.Point(32, 270);
            this.textOpValue.Multiline = true;
            this.textOpValue.Name = "textOpValue";
            this.textOpValue.Size = new System.Drawing.Size(323, 30);
            this.textOpValue.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(32, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Digite o valor da operação";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textOwnerAccount);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textAccountNumber);
            this.groupBox1.Controls.Add(this.textOpValue);
            this.groupBox1.Controls.Add(this.textBalance);
            this.groupBox1.Controls.Add(this.btnSendValue);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnGetValue);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(22, 163);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 394);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conta";
            // 
            // btnBalanceReport
            // 
            this.btnBalanceReport.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnBalanceReport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBalanceReport.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBalanceReport.Location = new System.Drawing.Point(22, 589);
            this.btnBalanceReport.Name = "btnBalanceReport";
            this.btnBalanceReport.Size = new System.Drawing.Size(176, 40);
            this.btnBalanceReport.TabIndex = 11;
            this.btnBalanceReport.Text = "Relatório";
            this.btnBalanceReport.UseVisualStyleBackColor = false;
            this.btnBalanceReport.Click += new System.EventHandler(this.btnBalanceReport_Click);
            // 
            // comboBoxAccounts
            // 
            this.comboBoxAccounts.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxAccounts.FormattingEnabled = true;
            this.comboBoxAccounts.Location = new System.Drawing.Point(32, 48);
            this.comboBoxAccounts.Name = "comboBoxAccounts";
            this.comboBoxAccounts.Size = new System.Drawing.Size(323, 33);
            this.comboBoxAccounts.TabIndex = 12;
            this.comboBoxAccounts.SelectedIndexChanged += new System.EventHandler(this.comboBoxAccounts_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.comboBoxAccounts);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(22, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(387, 100);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar Conta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(32, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "Titular";
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAddAccount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddAccount.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddAccount.Location = new System.Drawing.Point(233, 589);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(176, 40);
            this.btnAddAccount.TabIndex = 14;
            this.btnAddAccount.Text = "Adicionar Conta";
            this.btnAddAccount.UseVisualStyleBackColor = false;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 670);
            this.Controls.Add(this.btnAddAccount);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnBalanceReport);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textOwnerAccount;
        private System.Windows.Forms.TextBox textAccountNumber;
        private System.Windows.Forms.TextBox textBalance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGetValue;
        private System.Windows.Forms.Button btnSendValue;
        private System.Windows.Forms.TextBox textOpValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBalanceReport;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox comboBoxAccounts;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddAccount;
    }
}

