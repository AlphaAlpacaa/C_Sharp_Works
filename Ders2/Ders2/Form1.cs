using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders2
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
            listBox4.Items.Add(textBox4.Text);
            listBox5.Items.Add(comboBox1.Text);
            
            double boy, kilo, bmi;
            boy = Convert.ToDouble(textBox6.Text);
            kilo = Convert.ToDouble(textBox5.Text);
            bmi = kilo / (boy * boy);
            listBox6.Items.Add(bmi.ToString());

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            comboBox1.Text = "";
        }
    }
}
