using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorWindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            operasi.Items.Add("Penambahan");
            operasi.Items.Add("Pengurangan");
            operasi.Items.Add("Perkalian");
            operasi.Items.Add("Pembagian");
          
        }

        static int Penambahan(int a, int b)
        {
            return a + b;
        }

        static int Pengurangan(int a, int b)
        {
            return a - b;
        }

        static int Perkalian(int a, int b)
        {
            return a * b;
        }

        static int Pembagian(int a, int b)
        {
            return a / b;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNilaiB_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnHasil_Click(object sender, EventArgs e)
        {
            var a = Convert.ToInt32(txtNilaiA.Text);
            var b = Convert.ToInt32(txtNilaiB.Text);
            string ambilOperasi = operasi.Text;

            if (ambilOperasi == "Penambahan")
            {
                hasil.Text = Convert.ToString(Penambahan(a, b));
            }

            if (ambilOperasi == "Pengurangan")
            {
                hasil.Text = Convert.ToString(Pengurangan(a, b));
            }

            if (ambilOperasi == "Perkalian")
            {
                hasil.Text = Convert.ToString(Perkalian(a, b));
            }

            if (ambilOperasi == "Pembagian")
            {
                hasil.Text = Convert.ToString(Pembagian(a, b));
            }


        }
    }
}
