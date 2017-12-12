using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice7
{
    public partial class Form1 : Form
    {
        Employee aEmployee = new Employee();
        Salary aSalary = new Salary();
        double medical;
        double conveyance;
        double newincrease;
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void idTextBox_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            aEmployee.Id = idTextBox.Text;
            aEmployee.Name = nameTextBox.Text;
            aEmployee.Email = emailTextBox.Text;
            aEmployee.EmployeeSalary.Basic= Convert.ToDouble(basicTextBox.Text);
            aEmployee.EmployeeSalary.Medical =Convert.ToDouble(medicalTextBox.Text);
            aEmployee.EmployeeSalary.Conveyance =Convert.ToDouble(conveyenceTextBox.Text);
            medical= aEmployee.EmployeeSalary.GetMedicalAllowance(aEmployee.EmployeeSalary.Medical);
            conveyance= aEmployee.EmployeeSalary.GetConveyance(aEmployee.EmployeeSalary.Conveyance);
            MessageBox.Show(aEmployee.Name+"  Information Saved Successfully");
            
        }
        private void showButton_Click(object sender, EventArgs e)
        {
            salaryBasicTextBox.Text = (aEmployee.EmployeeSalary.GetBasic().ToString());
            salaryConveyanceTextBox.Text = aEmployee.EmployeeSalary.GetMedicalAllowance(Convert.ToDouble(medicalTextBox.Text)).ToString();
            salaryMedicalTextBox.Text = aEmployee.EmployeeSalary.GetConveyance(Convert.ToDouble(conveyenceTextBox.Text)).ToString();
            salaryTotalTextBox.Text = aEmployee.EmployeeSalary.GetTotal().ToString();
            noOfIncrementTextBox.Text = aEmployee.EmployeeSalary.noOfIncrements.ToString();
            salaryTotalTextBox.Enabled = false;
            salaryBasicTextBox.Enabled = false;
            salaryConveyanceTextBox.Enabled = false;
            salaryMedicalTextBox.Enabled = false;
            noOfIncrementTextBox.Enabled = false;

        }
        private void incrementButton_Click(object sender, EventArgs e)
        {
            double increase =Convert.ToDouble(increaseTextBox.Text);
           newincrease= aEmployee.EmployeeSalary.GetIncreaseAmount(increase);
           MessageBox.Show("Increment Successfully");
        }
    }
}
