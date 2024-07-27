using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders4Ödev1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int deger;
            int i = 0;
            deger = Convert.ToInt32(textBox2.Text);
            
            while (i < deger)
            {
                listBox1.Items.Add(textBox1.Text);
                i++;
            }
        }
    }
}
