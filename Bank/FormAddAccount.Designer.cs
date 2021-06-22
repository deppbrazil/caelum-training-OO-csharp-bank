
namespace Bank
{
    partial class FormAddAccount
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
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textOwnerAccount = new System.Windows.Forms.TextBox();
            this.textNumberOwnerAccount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxTypeAccount = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Location = new System.Drawing.Point(108, 361);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(204, 23);
            this.btnAddAccount.TabIndex = 0;
            this.btnAddAccount.Text = "Cadastrar";
            this.btnAddAccount.UseVisualStyleBackColor = true;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // textOwnerAccount
            // 
            this.textOwnerAccount.Location = new System.Drawing.Point(108, 168);
            this.textOwnerAccount.Name = "textOwnerAccount";
            this.textOwnerAccount.Size = new System.Drawing.Size(204, 23);
            this.textOwnerAccount.TabIndex = 2;
            // 
            // textNumberOwnerAccount
            // 
            this.textNumberOwnerAccount.Location = new System.Drawing.Point(108, 279);
            this.textNumberOwnerAccount.Name = "textNumberOwnerAccount";
            this.textNumberOwnerAccount.Size = new System.Drawing.Size(204, 23);
            this.textNumberOwnerAccount.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Número";
            // 
            // comboBoxTypeAccount
            // 
            this.comboBoxTypeAccount.FormattingEnabled = true;
            this.comboBoxTypeAccount.Location = new System.Drawing.Point(119, 64);
            this.comboBoxTypeAccount.Name = "comboBoxTypeAccount";
            this.comboBoxTypeAccount.Size = new System.Drawing.Size(121, 23);
            this.comboBoxTypeAccount.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Selecione o tipo de conta";
            // 
            // FormAddAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 549);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxTypeAccount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textNumberOwnerAccount);
            this.Controls.Add(this.textOwnerAccount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddAccount);
            this.Name = "FormAddAccount";
            this.Text = "FormAddAccount";
            this.Load += new System.EventHandler(this.FormAddAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddAccount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textOwnerAccount;
        private System.Windows.Forms.TextBox textNumberOwnerAccount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxTypeAccount;
        private System.Windows.Forms.Label label3;
    }
}