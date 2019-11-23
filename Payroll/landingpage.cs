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
    public partial class landingpage : Form
    {
        public landingpage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            signup newSignUp = new signup();
            newSignUp.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconnection = new SqlConnection("Data Source=EDWINPC\\SQLEXPRESS01;Initial Catalog=payrollDatabase;Persist Security Info=True;User ID=admin;Password=Addicted");
            sqlconnection.Open();
            SqlCommand sqlcommand = new SqlCommand("insert into employee_date(employeeId,dateWorked) values('" + textBox1.Text + "','" + dateTimePicker1.Text + "')", sqlconnection);
            int i = sqlcommand.ExecuteNonQuery();
            if (i != 0)
            {
                MessageBox.Show("Employee Logged Successfully");
            }
            else
            {
                MessageBox.Show("Operation failed");
            }
        }

        private void landingpage_Load(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            reports showReports = new reports();
            showReports.Show();
            this.Hide();

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.employeesTableAdapter.FillBy(this.payrollDatabaseDataSet.Employees);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void employeesBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
