using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Schimb_Valutar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double suma = double.Parse(textBox1.Text);
            string valuta = listBox1.SelectedItem.ToString();
            string tranzactie = comboBox1.SelectedItem.ToString();

            StreamReader fin = new StreamReader("valuta.in");

            double pretCumparare = 0;
            double pretVanzare = 0;

            string linie;

            while ((linie = fin.ReadLine()) != null)
            {
                string[] v = linie.Split(' ');

                if (v[0] == valuta)
                {
                    pretCumparare = double.Parse(v[1]);
                    pretVanzare = double.Parse(v[2]);
                    break;
                }
            }

            fin.Close();

            double sumaFinala;

            if (tranzactie == "Cumparare")
                sumaFinala = suma * pretCumparare;
            else
                sumaFinala = suma * pretVanzare;

            textBox2.Text = sumaFinala.ToString("0.00");
        }
    }
}
