using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppEssai
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button b2 = sender as Button;
            if (b2 != null)
            {
            }
            MessageBox.Show("bouton1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.button1.Click += new System.EventHandler(this.button1_Click);
            MessageBox.Show("bouton2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("bouton3");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {

        }
    }
}
