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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number, result;
            result = 1;
            number = Convert.ToInt32(textBox1.Text);
            for (int i = 1; i < number;i++)
            {
               
                listBox1.Items.Add(result);
                result += 1;
                result += i;
            }
        }
    }
}
