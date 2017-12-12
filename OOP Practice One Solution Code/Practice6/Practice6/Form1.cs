using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void showMeSalaryButton_Click(object sender, EventArgs e)
        {
            
            SalaryCalculator aCalculator = new SalaryCalculator();
            aCalculator.EmployeeName = employeeNameTextBox.Text;
            aCalculator.BasicAmount =Convert.ToDouble(basicAmountTextBox.Text);
            aCalculator.HouseRent = Convert.ToDouble(houseRentTextBox.Text);
            aCalculator.MedicalAllowance = Convert.ToDouble(medicalAllowanceTextBox.Text);
            double totalSalary=aCalculator.GetTotalSalary(aCalculator.HouseRent,aCalculator.MedicalAllowance);
            string information = aCalculator.GetAllInformation();
            messageLabel.Text =aCalculator.EmployeeName+information;
            employeeNameTextBox.Clear();
            basicAmountTextBox.Clear();
            houseRentTextBox.Clear();
        }
    }
}
