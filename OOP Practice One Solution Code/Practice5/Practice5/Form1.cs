using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice5
{
    public partial class Form1 : Form
    {
         Calculator aCalculator = new Calculator();
            
        public Form1()
        {
            InitializeComponent();
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            aCalculator.FirstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            aCalculator.SecondNumber = Convert.ToDouble(secondNumberTextBox.Text);
            aCalculator.Result = aCalculator.Add(aCalculator.FirstNumber, aCalculator.SecondNumber);
            resultTextBox.Text = aCalculator.Result.ToString();
            firstNumberTextBox.Clear();
            secondNumberTextBox.Clear();
        }
        private void subtractButton_Click(object sender, EventArgs e)
        {
          
            aCalculator.FirstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            aCalculator.SecondNumber = Convert.ToDouble(secondNumberTextBox.Text);
            aCalculator.Result = aCalculator.Subtract(aCalculator.FirstNumber, aCalculator.SecondNumber);
            resultTextBox.Text = aCalculator.Result.ToString();
            firstNumberTextBox.Clear();
            secondNumberTextBox.Clear();
        }
        private void multiplyButton_Click(object sender, EventArgs e)
        {
            aCalculator.FirstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            aCalculator.SecondNumber = Convert.ToDouble(secondNumberTextBox.Text);
            aCalculator.Result = aCalculator.Multiply(aCalculator.FirstNumber, aCalculator.SecondNumber);
            resultTextBox.Text = aCalculator.Result.ToString();
            firstNumberTextBox.Clear();
            secondNumberTextBox.Clear();
        }
        private void divisionButton_Click(object sender, EventArgs e)
        {
            Calculator aCalculator = new Calculator();
            aCalculator.FirstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            aCalculator.SecondNumber = Convert.ToDouble(secondNumberTextBox.Text);
            aCalculator.Result = aCalculator.Division(aCalculator.FirstNumber, aCalculator.SecondNumber);
            resultTextBox.Text = aCalculator.Result.ToString();
            firstNumberTextBox.Clear();
            secondNumberTextBox.Clear();
        }
    }
}
