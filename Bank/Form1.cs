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

        private PersonalAccount[] newAccount;

        private void Form1_Load(object sender, EventArgs e)
        {
            PersonalAccount account1 = new PersonalAccount()
            {
                OwnerAccount = new NewClient("John"),
                AccountNumber = 1
            };

            PersonalAccount account2 = new PersonalAccount()
            {
                OwnerAccount = new NewClient("Kendra"),
                AccountNumber = 2
            };

            PersonalAccount account3 = new PersonalAccount()
            {
                OwnerAccount = new NewClient("Maike"),
                AccountNumber = 3
            };

            this.newAccount = new PersonalAccount[3];

            newAccount[0] = account1;
            newAccount[1] = account2;
            newAccount[2] = account3;

            //NewClient newClient = new NewClient("John");

            //this.newAccount = new SavingAccount();
            //newAccount.AccountNumber = 1;
            //newAccount.Balance = 100;
            //newAccount.OwnerAccount = newClient;

            //textOwnerAccount.Text = newAccount.OwnerAccount.Name;
            //textAccountNumber.Text = Convert.ToString(newAccount.AccountNumber);
            //textBalance.Text = Convert.ToString(newAccount.Balance);
        }

        private void btnGetValue_Click(object sender, EventArgs e)
        {
            string inputValue = textOpValue.Text;
            double opValue = Convert.ToDouble(inputValue);
            
            //if(opValue <= newAccount.Balance)
            //{
            //    newAccount.GetOpValue(opValue);
            //    MessageBox.Show("Saque realizado com sucesso!");

            //} else
            //{
            //    MessageBox.Show("Saque não realizado, saldo insuficiente!");
            //}
            
            //textBalance.Text = Convert.ToString(newAccount.Balance);
        }

        private void btnSendValue_Click(object sender, EventArgs e)
        {
            var inputValue = textOpValue.Text;
            double opValue = Convert.ToDouble(inputValue);
            //newAccount.SendOpValue(opValue);

            //textBalance.Text = Convert.ToString(newAccount.Balance);
            MessageBox.Show("Depósito realizado com sucesso!");
        }

        private void btnBalanceReport_Click(object sender, EventArgs e)
        {
            PersonalAccount c1 = new PersonalAccount();
            c1.AccountNumber = 1;
            c1.SendOpValue(100);

            PersonalAccount c2 = new PersonalAccount();
            c2.SendOpValue(200);

            PersonalAccount cp1 = new SavingAccount();
            c1.AccountNumber = 1;
            cp1.SendOpValue(200);

            AccountBalanceTotalizer tc = new AccountBalanceTotalizer();
            tc.SumValue(c1);
            tc.SumValue(c2);
            tc.SumValue(cp1);

            MessageBox.Show($"Saldo total: {tc.TotalValue}");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(textIndex.Text);

            PersonalAccount selectedAccount = newAccount[index];

            textOwnerAccount.Text = selectedAccount.OwnerAccount.Name;
            textAccountNumber.Text = Convert.ToString(selectedAccount.AccountNumber);
            textBalance.Text = Convert.ToString(selectedAccount.Balance);


            //int[] numeros = new int[3];
            //numeros[0] = 10;
            //numeros[1] = 20;
            //numeros[2] = 30;

            //for (int i = 0; i < numeros.Length; i++)
            //{
            //    MessageBox.Show($"{numeros[i]}");
            //}
        }
    }
}
