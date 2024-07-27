using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ödev1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label9.Text = textBox1.Text;
            label10.Text = textBox2.Text;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label11.Text = textBox3.Text;
            label12.Text = textBox4.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label9.Text = "-";
            label10.Text = "-";
            label11.Text = "-";
            label12.Text = "-";
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }
    }
}
