using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            signup showSignUp = new signup();
            showSignUp.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=EDWINPC\\SQLEXPRESS01;Initial Catalog=payrollDatabase;Persist Security Info=True;User ID=admin;Password=Addicted");
            connection.Open();
            SqlCommand fetchdata = new SqlCommand("select Password from Employees where idNumber = '"+textBox1.Text+"'", connection);
            //int Password = fetchdata.ExecuteNonQuery();
            SqlDataReader storedPass = fetchdata.ExecuteReader();
            storedPass.Read();
            String Password = storedPass["Password"].ToString();
            String Upassword = textBox2.Text.ToString();
            if (Password == Upassword)
            {
                landingpage land = new landingpage();
                land.Show();
                this.Hide();
            }
            else if (Password != Upassword)
            {
                MessageBox.Show("You have entered the wrong Password");
            }
            else {
                MessageBox.Show("User Does not exist");
            }
        }

        private void connect_Click(object sender, EventArgs e)
        {
        }
    }
}
