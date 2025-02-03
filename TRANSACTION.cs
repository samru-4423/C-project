using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOMEPAGE
{
    public partial class TRANSACTION : Form
    {
        public TRANSACTION()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            transactionhistory Transactionhistory = new transactionhistory();
            Transactionhistory.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            OTP oTP = new OTP();    
            oTP.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            HOMEPAGE homepage = new HOMEPAGE();
            homepage.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            HOMEPAGE hOMEPAGE = new HOMEPAGE();
            hOMEPAGE.Show();
        }
    }
}
