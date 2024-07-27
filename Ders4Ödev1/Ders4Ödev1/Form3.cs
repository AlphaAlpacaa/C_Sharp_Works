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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int number;
            number = Convert.ToInt32(textBox1.Text);
            listBox1.Items.Clear();
            textBox1.Text = "";
            for (int i = 0; i < number; i++)
            {
                listBox1.Items.Add(i.ToString());
            }

        }
    }
}
