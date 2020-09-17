using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab1_ConnectedMode2.BLL;

namespace Lab1_ConnectedMode2.GUI
{
    public partial class FormTest : Form
    {
        Employee emp = new Employee();
        List<Employee> employeeList = new List<Employee>();
        public FormTest()
        {
            InitializeComponent();
        }

        private void writeData_Click(object sender, EventArgs e)
        {
            emp.EmployeeId = 9889;
            emp.FirstName = "andres";
            emp.LastName = "ardila";
            emp.JobTitle = "junior developer"; 
        }

        private void readData_Click(object sender, EventArgs e)
        {
            string msg = emp.EmployeeId + "\n" +
                         emp.FirstName + "\n" +
                         emp.LastName + "\n" +
                         emp.JobTitle + "\n";
            MessageBox.Show(msg, "My name", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void create_Click(object sender, EventArgs e)
        {
            Employee emp1 = new Employee();
            emp1.EmployeeId = 9889;
            emp1.FirstName = "andres";
            emp1.LastName = "ardila";
            emp1.JobTitle = "junior developer";
            employeeList.Add(emp1);

            Employee emp2 = new Employee();
            emp2.EmployeeId = 9889;
            emp2.FirstName = "andres";
            emp2.LastName = "ardila";
            emp2.JobTitle = "junior developer";
            employeeList.Add(emp2);

            Employee emp3 = new Employee();
            emp3.EmployeeId = 9889;
            emp3.FirstName = "andres";
            emp3.LastName = "ardila";
            emp3.JobTitle = "junior developer";
            employeeList.Add(emp3);

            Employee emp4 = new Employee();
            emp4.EmployeeId = 9889;
            emp4.FirstName = "andres";
            emp4.LastName = "ardila";
            emp4.JobTitle = "junior developer";
            employeeList.Add(emp4);

        }

        private void display_Click(object sender, EventArgs e)
        {
            string show = "";
            foreach (var anEmp in employeeList)
            {
                show += $"{anEmp.EmployeeId}, {anEmp.FirstName}, {anEmp.LastName}, {anEmp.JobTitle} \n";
            }

            MessageBox.Show(show, "EMPLOYEE LIST");
        }

        private void FormTest_Load(object sender, EventArgs e)
        {

        }

        private void openDB_Click(object sender, EventArgs e)
        {
            Employee andres = new Employee();

            andres.FirstName = "andres";
            andres.LastName = "ardila";
            andres.JobTitle = "Developer";
            
            andres.SaveEmployee(andres);
            MessageBox.Show("its time to test the database");
        }
    }
}
