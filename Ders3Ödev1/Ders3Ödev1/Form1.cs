using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders3Ödev1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "alperm2000" && textBox2.Text == "alpalp2000")
               
                {
                    Form2 yeniform = new Form2();
                    yeniform.Show();
                    this.Hide();
                    yeniform.label1.Text = textBox1.Text;
                }
            else if (textBox1.Text == "sarperem" && textBox2.Text == "sarperem2006")
                   
                {
                    Form2 yeniform = new Form2();
                    yeniform.Show();
                    this.Hide();
                    yeniform.label1.Text = textBox1.Text;
                }
            else
                {
                        MessageBox.Show("Hatalı Giriş");
                }
        }
    }
}
