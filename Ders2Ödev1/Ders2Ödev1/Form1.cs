using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders2Ödev1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(textBox2.Text);
            listBox3.Items.Add(textBox3.Text);
            listBox4.Items.Add(comboBox1.Text);
            listBox5.Items.Add(richTextBox1.Text);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            richTextBox1.Clear();
            comboBox1.SelectedIndex = -1;

            double boy, en, yükseklik, desi, ücret, desiücreti;
            boy = Convert.ToDouble(textBox4.Text);
            en = Convert.ToDouble(textBox5.Text);
            yükseklik = Convert.ToDouble(textBox6.Text);
            desi = (boy * en * yükseklik) / 3000;
            desiücreti = Convert.ToDouble(comboBox2.Text);
            ücret = desi * desiücreti;

            listBox6.Items.Add(desi.ToString());
            listBox7.Items.Add(ücret.ToString());

            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            comboBox2.SelectedIndex = -1;

            MessageBox.Show("Ekleme tamamlanmıştır", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
