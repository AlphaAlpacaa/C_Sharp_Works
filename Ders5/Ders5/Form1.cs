using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] dizi = { 1, 2, 3, 4 };
            label1.Text = dizi[0].ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sayi;
            sayi = textBox1.Text;
            label2.Text = sayi[2].ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sayi = textBox2.Text;
            int rakamsayisi = sayi.Length;
            int tek = 0, cift = 0;
            for (int i = 0; i < rakamsayisi; i++)
            {
                int rakam = Convert.ToInt32(sayi[i].ToString());
                if (rakam % 2 == 0)
                {
                    cift += 1;
                }
                else
                {
                    tek += 1;
                }
            }
            label5.Text = tek.ToString();
            label6.Text = cift.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int rastgelesayi;
            Random rastgele = new Random();
            rastgelesayi = rastgele.Next(6,10);
            label7.Text = rastgelesayi.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox3.Text);
            MessageBox.Show("Kişi Eklendi");
            textBox3.Clear();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int kazanan;
            int sayi = listBox1.Items.Count;
            kazanan = random.Next(0, sayi);
            listBox2.Items.Add(listBox1.Items[kazanan].ToString());
            listBox1.Items.RemoveAt(kazanan);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text);

        }

        private void button8_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
        }
    }
}
