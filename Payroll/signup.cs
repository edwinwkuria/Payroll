using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Payroll
{
    public partial class signup : Form
    {
        public signup()
        {
            InitializeComponent();
        }

        private void signup_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            login showLogIn = new login();
            showLogIn.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                        SqlConnection sqlconnection = new SqlConnection("Data Source=EDWINPC\\SQLEXPRESS01;Initial Catalog=payrollDatabase;Persist Security Info=True;User ID=admin;Password=Addicted");
            sqlconnection.Open();
            SqlCommand sqlcommand = new SqlCommand("insert into Employees(firstName,secondName, lastName, phoneNumber, altPhoneNumber, dateJoined, idNumber, gender, kraPin, nhif, nssf, Password) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox7.Text + "','" + textBox9.Text + "','" + dateTimePicker1.Text + "','" + textBox4.Text + "','" + radioButton2.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox8.Text + "','" + textBox10.Text + "')", sqlconnection);
            int i = sqlcommand.ExecuteNonQuery();
            if (i!=0)
            {
                MessageBox.Show("Employee Created Successfully");
            }
            else
            {
                MessageBox.Show("Operation failed");
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
