using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            ListViewItem item = new ListViewItem("2222");
            item.SubItems.Add("Mary");
            item.SubItems.Add("Brown");
            item.SubItems.Add("Programer");
            listView1.Items.Add(item);
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

        }
    }
}
