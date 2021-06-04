using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private PersonalAccount newAccount;

        private void Form1_Load(object sender, EventArgs e)
        {
            NewClient newClient = new NewClient("John");

            this.newAccount = new SavingAccount();
            newAccount.AccountNumber = 1;
            newAccount.Balance = 100;
            newAccount.OwnerAccount = newClient;

            textOwnerAccount.Text = newAccount.OwnerAccount.Name;
            textAccountNumber.Text = Convert.ToString(newAccount.AccountNumber);
            textBalance.Text = Convert.ToString(newAccount.Balance);
        }

        private void btnGetValue_Click(object sender, EventArgs e)
        {
            string inputValue = textOpValue.Text;
            double opValue = Convert.ToDouble(inputValue);
            
            if(opValue <= newAccount.Balance)
            {
                newAccount.GetOpValue(opValue);
                MessageBox.Show("Saque realizado com sucesso!");

            } else
            {
                MessageBox.Show("Saque não realizado, saldo insuficiente!");
            }
            
            textBalance.Text = Convert.ToString(newAccount.Balance);
        }

        private void btnSendValue_Click(object sender, EventArgs e)
        {
            var inputValue = textOpValue.Text;
            double opValue = Convert.ToDouble(inputValue);
            newAccount.SendOpValue(opValue);

            textBalance.Text = Convert.ToString(newAccount.Balance);
            MessageBox.Show("Depósito realizado com sucesso!");
        }
    }
}
