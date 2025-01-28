using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StartPage
{
    public partial class Loginadmin : Form
    {
        public Loginadmin()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e) //Back button
        {
            this.Hide();
            Startpage stpage = new Startpage();
            stpage.Show();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string tbaduname = tbadminuname.Text;
            string tbadpass = tbadminpass.Text;

            if (tbaduname=="" && tbadpass == "") 
            {
                MessageBox.Show("Please enter username and password");
            }
            else
            {
                MessageBox.Show("Welcome admin");
                this.Hide();
                AdminHomepage adminhp = new AdminHomepage();
                adminhp.Show();
            }
            
        }
    }
}
