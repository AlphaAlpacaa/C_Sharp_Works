using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sınır,basamak;
            sınır = Convert.ToInt32(textBox1.Text);
            basamak = Convert.ToInt32(textBox2.Text);
            for(int i = 0;i <= sınır;i=i+basamak)
            {
                listBox1.Items.Add(i.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sonuc = 0;
            for(int i=0;i<=10;i++)
            {
                sonuc = sonuc + i;
                listBox2.Items.Add(sonuc.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sayi;
            int i = 1;
            sayi = Convert.ToInt32(textBox3.Text);
            while (i<6)
            {
                sayi = sayi * i;
                i++;
            }
            label1.Text = sayi.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int i = 1;
            do
            {
                listBox2.Items.Add("Merhaba");
                i++;
            }
            while (i < 5);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(textBox5.Text, textBox6.Text);
        }
    }
}
