using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1WindowsFormsApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double a, b, c, d, v, x1, x2;
            a = Double.Parse(textBox1.Text);
            b = Double.Parse(textBox2.Text);
            c = Double.Parse(textBox3.Text);
            d = b * b - 4 * a * c;
            if (d > 0)
            {
                x1 = (b * (-1) - Math.Sqrt(d)) / (2 * a);
                x2 = (b * (-1) + Math.Sqrt(d)) / (2 * a);
                label4.Text = ("D=" + d + "\nx1=" + x1 + "\nx2=" + x2);
            }
            else
                if (d == 0)
                {
                    x1 = (b * (-1)) / (2 * a);
                    label1.Text = ("D=" + d + "\nx1=" + x1);
                }
                else
                {
                    label1.Text = ("Немає розв'язків");
                }
        }
    }
}
