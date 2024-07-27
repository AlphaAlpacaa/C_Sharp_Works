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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "" || comboBox1.Text == "" || comboBox2.Text == "" || comboBox3.Text == "" || comboBox4.Text == "")
            {
                MessageBox.Show("Lütfen eksik bilgi girmeyiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
               
                

                double mat, fiz, bio, kim, mat_kat, fiz_kat, kim_kat, bio_kat, not;
                mat = Convert.ToDouble(textBox7.Text);
                fiz = Convert.ToDouble(textBox4.Text);
                kim = Convert.ToDouble(textBox5.Text);
                bio = Convert.ToDouble(textBox6.Text);
                mat_kat = Convert.ToDouble(comboBox4.Text);
                fiz_kat = Convert.ToDouble(comboBox1.Text);
                kim_kat = Convert.ToDouble(comboBox2.Text);
                bio_kat = Convert.ToDouble(comboBox3.Text);
                if (fiz <= 100 && fiz >= 0 && kim <= 100 && kim >= 0 && mat <= 100 && mat >= 0 && bio <= 100 && bio >= 0 && fiz_kat > 0 && kim_kat > 0 && bio_kat > 0 && mat_kat > 0)
                {
                    listBox1.Items.Add(textBox1.Text);
                    listBox2.Items.Add(textBox2.Text);
                    listBox3.Items.Add(textBox3.Text);
                    not = ((mat * mat_kat) + (fiz * fiz_kat) + (kim * kim_kat) + (bio * bio_kat)) / (mat_kat + fiz_kat + kim_kat + bio_kat);

                    listBox4.Items.Add(not.ToString());
                    if (not >= 85)
                    {
                        listBox5.Items.Add("Pekiyi");
                    }
                    else if ((not >= 55) && (not < 85))
                    {
                        listBox5.Items.Add("Orta");
                    }
                    else if ((not >= 0) && (not < 55))
                    {
                        listBox5.Items.Add("Kötü");
                    }
                }
                else 
                {
                    MessageBox.Show("Hatalı değer aralığı girdiniz.");
                }
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            comboBox4.SelectedIndex = -1;

        }
    }
}
