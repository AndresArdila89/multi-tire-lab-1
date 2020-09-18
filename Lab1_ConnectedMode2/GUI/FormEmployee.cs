using Lab1_ConnectedMode2.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab1_ConnectedMode2.VALIDATION;

namespace Lab1_ConnectedMode2.GUI
{
    public partial class FormEmployee : Form
    {
        public FormEmployee()
        {
            InitializeComponent();

            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            List<Employee> empslist = new List<Employee>();
            Employee records = new Employee();

            empslist =  records.LoadAllEmployees();
            
            foreach (Employee em in empslist)
            {

                ListViewItem item = new ListViewItem(em.EmployeeId.ToString());
                item.SubItems.Add(em.FirstName);
                item.SubItems.Add(em.LastName);
                item.SubItems.Add(em.JobTitle);
                listView1.Items.Add(item);

            }

            
            

            
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBoxSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectIndex = comboBoxSearch.SelectedIndex;

            switch (selectIndex)
            {
                case 0:
                    lblSearch.Text = "Enter Employee ID";
                    textBoxSearch.Clear();
                    textBoxSearch.Focus();
                    break;
                case 1:
                    lblSearch.Text = "Enter Employee First Name";
                    textBoxSearch.Clear();
                    textBoxSearch.Focus();
                    break;
                case 2:
                    lblSearch.Text = "Enter Employee Last Name";
                    textBoxSearch.Clear();
                    textBoxSearch.Focus();
                    break;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {


            //step 2: Store data in the object of type Employee

            Employee emp = new Employee();
            if (!Validator.IsValidId(textBoxEmployeeID.Text)){
                MessageBox.Show("invalida Employee ID");
                textBoxEmployeeID.Clear();
                textBoxEmployeeID.Focus();
            }
            else if(!Validator.IsEmpty(textBoxFirstName.Text) || !Validator.IsValidName(textBoxFirstName.Text))
            {
                    MessageBox.Show("First Name is empty or is invalid");
                    textBoxFirstName.Clear();
                    textBoxFirstName.Focus();
            }
            else if(!Validator.IsEmpty(textBoxLastName.Text) || !Validator.IsValidName(textBoxLastName.Text))
            {
                MessageBox.Show("Last Name is empty or is invalid");
                textBoxLastName.Clear();
                textBoxLastName.Focus();
            }
            else if(!Validator.IsEmpty(textBoxjobTitle.Text) || !Validator.IsValidName(textBoxjobTitle.Text))
            {
                MessageBox.Show("Job title is empty or is invalid");
                textBoxjobTitle.Clear();
                textBoxjobTitle.Focus();
            }
            else
            {
                emp.EmployeeId = Convert.ToInt32(textBoxEmployeeID.Text);
                emp.FirstName = textBoxFirstName.Text;
                emp.LastName = textBoxLastName.Text;
                emp.JobTitle = textBoxjobTitle.Text;

                emp.SaveEmployee(emp);
                
            }
                
            

            

        }
    }
}
