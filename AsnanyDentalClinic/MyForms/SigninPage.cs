using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsnanyDentalClinic.MyForms
{
    public partial class SigninPage : Form
    {
        public SigninPage()
        {
            InitializeComponent();
            //Retriving all users user names and passwords
            this.sqlConnection1.Open();
            this.sqlDataAdapter1.Fill(this.dataSet11);
            this.sqlConnection1.Close();
        }

        //When pressing on close button
        private void SigninPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            this.textBox2.Text = "";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = this.textBox1.Text;
            string passWord = this.textBox2.Text;
            var dRow = this.dataSet11.Tables[0].Rows;
            bool flag = false;
            foreach (DataRow item in dRow)
            {
                if (item["userName"].ToString() == userName && item["password"].ToString() == passWord)
                {
                    flag = true;
                }
            }
            if (flag)
            {
                MessageBox.Show("Welcome " + userName);
            }
            else
            {
                MessageBox.Show("Oops, Please register to sign in..");
                this.Hide();
                RegisterationForm regForm = new RegisterationForm();
                regForm.Show();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterationForm regForm = new RegisterationForm();
            regForm.Show();
        }
    }
}
