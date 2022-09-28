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
    public partial class RegisterationForm : Form
    {
        public RegisterationForm()
        {
            InitializeComponent();
            this.sqlConnection1.Open();
            this.sqlDataAdapter1.Fill(registerationDataSet1);
            this.sqlConnection1.Close();
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            createNewPatient();
        }

        private void userName_Click(object sender, EventArgs e)
        {
            ((TextBox)sender).ForeColor = Color.Black;
            ((TextBox)sender).Text = "";

        }

        private bool checkUserName(string patientUserName , string patientEmail)
        {
            bool flag = true;
            foreach(DataRow row in this.registerationDataSet1.Tables["patient"].Rows)
            {
                if (row["userName"].ToString()==patientUserName || row["email"].ToString()== patientEmail)
                {
                    flag = false;
                }
            }
            return flag;
        }

        private void createNewPatient()
        {
            string patientuserName = this.userName.Text;
            string patientEmail = this.Email.Text;
            bool flag = checkUserName(patientuserName, patientEmail);
            if(flag)
            {
                DataRow dRow = this.registerationDataSet1.Tables["patient"].NewRow();
                int numberOfRows = this.registerationDataSet1.Tables[0].Rows.Count;
                dRow["patientId"] = numberOfRows + 1;
                dRow["firstName"] = this.FirstName.Text;
                dRow["lastName"] = this.lastName.Text;
                dRow["mobileNumber"] = int.Parse(this.mobileNum.Text);
                dRow["email"] = this.Email.Text;
                dRow["userName"] = this.userName.Text;
                dRow["password"] = this.password.Text;
                this.registerationDataSet1.Tables[0].Rows.Add(dRow);
                this.sqlConnection1.Open();
                this.sqlDataAdapter1.Update(this.registerationDataSet1);
                this.sqlConnection1.Close();
                MessageBox.Show("Welcome " + this.FirstName.Text);
            }
            else
            {
                MessageBox.Show("Invalid userName");
            }
            
        }

    }
}
