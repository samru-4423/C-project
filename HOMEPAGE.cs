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
    public partial class HOMEPAGE : Form
    {
        public HOMEPAGE()
        {
            InitializeComponent();
        }

        private void transaction_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
          

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            DESKTOPHOME deskhome = new DESKTOPHOME();
            deskhome.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.Hide();
            cart CART = new cart();
            CART.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.Hide();
            Asusrog asusrog = new Asusrog();
            asusrog.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.Hide();
            MSIMON msiMON = new MSIMON();
            msiMON.Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            this.Hide();
            RAZERHUNT rraz = new RAZERHUNT();
            rraz.Show();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            this.Hide();
            GIgabyte GI = new GIgabyte();   
            GI.Show();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            this.Hide();
            DESKTOPINT deskint = new DESKTOPINT();
            deskint.Show();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            this.Hide();
            RAZERNAGA raznaga = new RAZERNAGA();    
            raznaga.Show();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            this.Hide();
            RAPTURE raap = new RAPTURE();
            raap.Show();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            this.Hide();
            UPS ups = new UPS(); 
            ups.Show();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            this.Hide();
            HARDDISK harddisk = new HARDDISK();   
            harddisk.Show();    
        }

        private void button25_Click(object sender, EventArgs e)
        {
            this.Hide();
            lexer LEXAR = new lexer();  
              LEXAR.Show();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            this.Hide();
            ADAPTER adapter = new ADAPTER();    
                adapter.Show();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            this.Hide();
            webcam WEBcam = new webcam();
            WEBcam.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LAPTOP laptop = new LAPTOP();   
            laptop.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            MONITORHOME MONHOME = new MONITORHOME();
            MONHOME.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            KEYBOARDHOME keybordhom = new KEYBOARDHOME();
            keybordhom.Show();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            this.Hide();
            TRANSACTION tRANSACTION = new TRANSACTION();
            tRANSACTION.Show();
        }
    }
}
