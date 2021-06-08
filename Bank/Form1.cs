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

        // 1 - Transform a variable as array
        private PersonalAccount[] accounts;

        private void Form1_Load(object sender, EventArgs e)
        {   
            // 2 - Create accounts
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

            // 3 - Create an array accounts
            this.accounts = new PersonalAccount[3];

            // 4 - Add the accounts at array
            accounts[0] = account1;
            accounts[1] = account2;
            accounts[2] = account3;

            // 5 - Add the accounts at comboBox
            foreach (var account in accounts)
            {
                comboBoxAccounts.Items.Add(account.OwnerAccount.Name);
            }
        }

        private void btnSendValue_Click(object sender, EventArgs e)
        {
            // 1 - Selected index recovery
            int index = comboBoxAccounts.SelectedIndex;

            // 2 - Find account through index (array)
            PersonalAccount accountSelected = accounts[index];

            // 3 - Execute calculation
            var inputValue = textOpValue.Text;
            double opValue = Convert.ToDouble(inputValue);
            accountSelected.SendOpValue(opValue);

            //4 - Update balance field
            textBalance.Text = Convert.ToString(accountSelected.Balance);
            MessageBox.Show("Depósito realizado com sucesso!");
        }

        private void btnGetValue_Click(object sender, EventArgs e)
        {
            // 1 - Selected index recovery
            int index = comboBoxAccounts.SelectedIndex;

            // 2 - Find account through index (array)
            PersonalAccount accountSelected = accounts[index];

            // 3 - Execute calculation
            string inputValue = textOpValue.Text;
            double opValue = Convert.ToDouble(inputValue);

            // Validate for negative value
            if (opValue <= accountSelected.Balance)
            {
                accountSelected.GetOpValue(opValue);
                MessageBox.Show("Saque realizado com sucesso!");
            }
            else
            {
                MessageBox.Show("Saque não realizado, saldo insuficiente!");
            }

            //4 - Update balance field
            textBalance.Text = Convert.ToString(accountSelected.Balance);
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

        private void comboBoxAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 1 - Selected index recovery
            int index = comboBoxAccounts.SelectedIndex;

            // 2 - Find account through index (array)
            PersonalAccount accountSelected = accounts[index];

            // 3 - Update fields with account data
            textOwnerAccount.Text = accountSelected.OwnerAccount.Name;
            textAccountNumber.Text = Convert.ToString(accountSelected.AccountNumber);
            textBalance.Text = Convert.ToString(accountSelected.Balance);
        }
    }
}
