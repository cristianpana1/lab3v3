using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex7p60
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = (double)numericUpDown1.Value;
            double b = (double)numericUpDown2.Value;
            double c = (double)numericUpDown3.Value;

            if (a + b <= c || a + c <= b || b + c <= a)
            {
                MessageBox.Show("Triunghiul nu este valid!");
                return;
            }

            double p = (a + b + c) / 2;
            double aria = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            double perimetru = a + b + c;

            label6.Text = aria.ToString("0.00");
            label7.Text = perimetru.ToString("0.00");

        }
    }
}
