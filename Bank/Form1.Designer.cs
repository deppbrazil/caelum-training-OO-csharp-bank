
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
            this.SuspendLayout();
            // 
            // textOwnerAccount
            // 
            this.textOwnerAccount.Location = new System.Drawing.Point(235, 74);
            this.textOwnerAccount.Name = "textOwnerAccount";
            this.textOwnerAccount.Size = new System.Drawing.Size(323, 23);
            this.textOwnerAccount.TabIndex = 0;
            // 
            // textAccountNumber
            // 
            this.textAccountNumber.Location = new System.Drawing.Point(235, 128);
            this.textAccountNumber.Name = "textAccountNumber";
            this.textAccountNumber.Size = new System.Drawing.Size(323, 23);
            this.textAccountNumber.TabIndex = 1;
            // 
            // textBalance
            // 
            this.textBalance.Location = new System.Drawing.Point(235, 181);
            this.textBalance.Name = "textBalance";
            this.textBalance.Size = new System.Drawing.Size(323, 23);
            this.textBalance.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(235, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Número da conta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(235, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Saldo";
            // 
            // btnGetValue
            // 
            this.btnGetValue.Location = new System.Drawing.Point(235, 317);
            this.btnGetValue.Name = "btnGetValue";
            this.btnGetValue.Size = new System.Drawing.Size(154, 23);
            this.btnGetValue.TabIndex = 6;
            this.btnGetValue.Text = "Sacar";
            this.btnGetValue.UseVisualStyleBackColor = true;
            this.btnGetValue.Click += new System.EventHandler(this.btnGetValue_Click);
            // 
            // btnSendValue
            // 
            this.btnSendValue.Location = new System.Drawing.Point(404, 317);
            this.btnSendValue.Name = "btnSendValue";
            this.btnSendValue.Size = new System.Drawing.Size(154, 23);
            this.btnSendValue.TabIndex = 7;
            this.btnSendValue.Text = "Depositar";
            this.btnSendValue.UseVisualStyleBackColor = true;
            this.btnSendValue.Click += new System.EventHandler(this.btnSendValue_Click);
            // 
            // textOpValue
            // 
            this.textOpValue.Location = new System.Drawing.Point(235, 278);
            this.textOpValue.Name = "textOpValue";
            this.textOpValue.Size = new System.Drawing.Size(323, 23);
            this.textOpValue.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(235, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Digite o valor da operação";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 455);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textOpValue);
            this.Controls.Add(this.btnSendValue);
            this.Controls.Add(this.btnGetValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBalance);
            this.Controls.Add(this.textAccountNumber);
            this.Controls.Add(this.textOwnerAccount);
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

