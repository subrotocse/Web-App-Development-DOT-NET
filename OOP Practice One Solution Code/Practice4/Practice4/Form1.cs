using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice4
{
    public partial class Form1 : Form
    {
        string accountNumber;
        string customerName;
        BankAccount aBankAccount;
        public Form1()
        {
            InitializeComponent();
        }
        private void createButton_Click(object sender, EventArgs e)
        {
            accountNumber = accountNumberTextBox.Text;
            customerName = customarNameTextBox.Text;
            aBankAccount = new BankAccount(accountNumber, customerName);
            aBankAccount.CreateAccount();
            MessageBox.Show("Account Created Successfully");
            accountNumberTextBox.Clear();
            customarNameTextBox.Clear();
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            double depositAmount = Convert.ToDouble(amountTextBox.Text);
            aBankAccount.Deposit(depositAmount);
            MessageBox.Show("Deposit Successfully ");
            amountTextBox.Clear();
        }
        private void withdrawButton_Click(object sender, EventArgs e)
        {
            double withdrowAmount = Convert.ToDouble(amountTextBox.Text);
            aBankAccount.Withdrow(withdrowAmount);
            MessageBox.Show("Successfully Withdraw");
            amountTextBox.Clear();
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            messageLabel.Text = aBankAccount.CreateAccount();
        }
    }
}
