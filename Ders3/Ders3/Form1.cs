using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, sonuc, dogrusonuc;
            sayi1 = Convert.ToInt32(textBox1.Text);
            sayi2 = Convert.ToInt32(textBox3.Text);
            sonuc = Convert.ToInt32(textBox4.Text);

            if (textBox2.Text == "+") 
            {
                dogrusonuc = sayi1 + sayi2;
                if (dogrusonuc == sonuc)
                {
                    label1.Text = "Doğru";
                }
                else
                {
                    label1.Text = "Yanlış";
                }
            }
            else if (textBox2.Text == "-") 
            {
                dogrusonuc = sayi1 - sayi2;
                if (dogrusonuc == sonuc)
                {
                    label1.Text = "Doğru";
                }
                else
                {
                    label1.Text = "Yanlış";
                }
            }
            else if (textBox2.Text == "*") 
            {
                dogrusonuc = sayi1 * sayi2;
                if (dogrusonuc == sonuc)
                {
                    label1.Text = "Doğru";
                }
                else
                {
                    label1.Text = "Yanlış";
                }
            }
            else if (textBox2.Text == "/") 
            {
                dogrusonuc = sayi1 / sayi2;
                if (dogrusonuc == sonuc)
                {
                    label1.Text = "Doğru";
                }
                else
                {
                    label1.Text = "Yanlış";
                }
            }
            else
            {
                MessageBox.Show("Hatalı operatör girdiniz.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox5.Text == "admin")
            {
                Form3 yeniform = new Form3();
                yeniform.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Hatalı Giriş");
            }
        }
    }
}
