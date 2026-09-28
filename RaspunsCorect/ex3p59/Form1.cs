using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex3p59
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int corecte = 0;

            if (radioButton2.Checked)
                corecte++;

            if (radioButton7.Checked)
                corecte++;

            if (radioButton10.Checked)
                corecte++;

            if (radioButton15.Checked)
                corecte++;

            if (radioButton18.Checked)
                corecte++;

            MessageBox.Show("Ai raspuns corect la " + corecte + " din 5 intrebari.");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
