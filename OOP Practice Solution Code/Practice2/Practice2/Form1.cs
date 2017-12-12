using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice2
{
    public partial class Form1 : Form
    {
        Department aDepartment = new Department();
        List<Student> studentList;
        public Form1()
        {
            InitializeComponent();
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
           aDepartment.DepartmentCode= codeTextBox.Text;
           aDepartment.DepartmentName = departmentNameTextBox.Text;
           aDepartment.GetDepartmentFullInformation();
           MessageBox.Show("Department Saved Successfully");
           departmentNameTextBox.Enabled = false;
           codeTextBox.Enabled = false;
        }
        private void saveButton2_Click(object sender, EventArgs e)
        {
            Student aStudent = new Student();
            aStudent.Name = studentNameTextBox.Text;
            aStudent.RegNo = regNoTextBox.Text;
            aStudent.Email = emailTextBox.Text;
            aStudent.GetStudentFullInformation();
            aDepartment.StudentList.Add(aStudent);
            studentNameTextBox.Clear();
            regNoTextBox.Clear();
            emailTextBox.Clear();    
        }
        private void showDetailsButton_Click(object sender, EventArgs e)
        {
            string student="";
            string department = "";
            studentList = new List<Student>();
            foreach (Student bStudent in aDepartment.StudentList)
            {
             student += bStudent.GetStudentFullInformation();
             department = aDepartment.GetDepartmentFullInformation();
            }
            MessageBox.Show("Department Code:       Department Name:\n"+department+"\n"+"Reg No          Name          Email \n"+student);
        }
    }
}
