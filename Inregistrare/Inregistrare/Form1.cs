using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inregistrare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null || textBox1.Text == "" || comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Completati toate campurile!");
                return;
            }

            string gen = listBox1.SelectedItem.ToString();
            string nume = textBox1.Text;
            string tara = comboBox1.SelectedItem.ToString();

            MessageBox.Show("Gen: " + gen + "\nNume: " + nume + "\nTara: " + tara);
        }
    }
}
