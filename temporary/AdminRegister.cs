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
    public partial class AdminRegister : Form
    {
        public AdminRegister()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // Dashboard
        {
            this.Hide();
            AdminHomepage adminhp = new AdminHomepage();
            adminhp.Show();
        }

        private void button2_Click(object sender, EventArgs e) // Products
        {

        }

        private void button3_Click(object sender, EventArgs e) // Manager List
        {
            this.Hide();
            AdminManagerList adminml = new AdminManagerList();
            adminml.Show();
        }

        private void button4_Click(object sender, EventArgs e) // Employee List
        {
            this.Hide();
            AdminEmployyeList adminel = new AdminEmployyeList();
            adminel.Show();
        }

        private void button6_Click(object sender, EventArgs e) // Log out
        {
            MessageBox.Show("Log out successfully");
            this.Hide();
            Loginadmin loginadmin = new Loginadmin();
            loginadmin.Show();
        }
    }
}
