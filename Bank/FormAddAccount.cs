using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Bank
{
    public partial class FormAddAccount : Form
    {
        private Form1 principalForm;

        // Enum: for type comboBox, ideal tool for worked as value
        enum TypeAccount
        {   
            // Index 0
            POUPANCA,

            // Index 1
            CORRENTE
        }        

        public FormAddAccount(Form1 principalForm)
        {
            // Instantiating an attribute
            this.principalForm = principalForm;
            
            InitializeComponent();
        }

        private void FormAddAccount_Load(object sender, EventArgs e)
        {
            // Showing off in text field the number account create
            this.textNumberOwnerAccount.Text = Convert.ToString(PersonalAccount.NextAccountNumber());

            // Populating comboBox type account
            comboBoxTypeAccount.Items.Add("Poupança");
            comboBoxTypeAccount.Items.Add("Corrente");
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            // New account variable declaring - dependece with type account at comboBox
            PersonalAccount newAccount;

            // Recovery a index selected at comboBox account type
            var typeIndex = comboBoxTypeAccount.SelectedIndex;

            switch (typeIndex)
            {
                case (int)TypeAccount.POUPANCA:                    
                    // Instantiating the new account as saving account
                    newAccount = new SavingAccount();

                    break;

                case (int)TypeAccount.CORRENTE:
                    // Instantiating the new account as personal account
                    newAccount = new PersonalAccount();

                    break;

                default:
                    newAccount = new PersonalAccount();

                    break;
            }

            // Creating a new client instance with name at form writing
            newAccount.OwnerAccount = new NewClient(textOwnerAccount.Text);

            // Adding a new create account at account vector in form1
            //this.principalForm.Add
        }

    }
}
