using AsnanyDentalClinic.MyForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsnanyDentalClinic
{
    public partial class BufferingPage : Form
    {
        public BufferingPage()
        {
            InitializeComponent();
            this.timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.panel2.Width += 10;
            if(this.panel2.Width >=this.Width)
            {
                this.timer1.Stop();
                this.Hide();
                SigninPage sg = new SigninPage();
                sg.Show();
            }
        }
    }
}
