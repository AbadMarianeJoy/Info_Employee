using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;  

namespace Info
{
    public partial class Form1 : Form
    {
        private BindingList<Employee> employees;  

        public Form1()
        {
            InitializeComponent();

            employees = new BindingList<Employee>();
            dataGridView1.DataSource = employees;

           
            dataGridView1.DefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Regular);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);

            
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.DefaultCellStyle.BackColor = Color.White;
        }

        private void textBox_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Submit_Click(object sender, EventArgs e)
        {
            Employee newEmployee = new Employee
            {
                ID = textBox_ID.Text,
                FirstName = textBox_FIRSTNAME.Text,
                LastName = textBox_LASTNAME.Text,
                Position = textBox_Position.Text,
            };

            employees.Add(newEmployee);  
            ClearInputFields();
        }

        private void ClearInputFields()
        {
            textBox_ID.Clear();
            textBox_FIRSTNAME.Clear();
            textBox_LASTNAME.Clear();
            textBox_Position.Clear();
        }
    }

    public class Employee
    {

        private string id;
        private string firstName;
        private string lastName;
        private string position;

        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Position
        {
            get { return position; }
            set { position = value; }
        }

        
        public Employee(string id, string firstName, string lastName, string position)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.position = position;
        }


        public Employee() { }
    }
}
