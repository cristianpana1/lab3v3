using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            radioButton7.Checked = false;
            radioButton8.Checked = false;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int n = (int)numericUpDown1.Value;

            radioButton1.Visible = n >= 1;
            radioButton2.Visible = n >= 2;
            radioButton3.Visible = n >= 3;
            radioButton4.Visible = n >= 4;
            radioButton5.Visible = n >= 5;
            radioButton6.Visible = n >= 6;
            radioButton7.Visible = n >= 7;
            radioButton8.Visible = n >= 8;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                MessageBox.Show("Raspuns gresit!");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
                MessageBox.Show("Raspuns corect!");
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
                MessageBox.Show("Raspuns gresit!");
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
                MessageBox.Show("Raspuns gresit!");
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
                MessageBox.Show("Raspuns gresit!");
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked)
                MessageBox.Show("Raspuns gresit!");

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked)
                MessageBox.Show("Raspuns gresit!");
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton8.Checked)
                MessageBox.Show("Raspuns gresit!");
        }
    }
}
