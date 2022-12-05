using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class FormCalculatorApp : Form
    {
        public FormCalculatorApp()
        {
            InitializeComponent();
            CalculatorInit();
        }

        private void CalculatorInit()
        {
            comboBoxOperasi.Items.Clear();
            comboBoxOperasi.Items.Add("Penjumlahan");
            comboBoxOperasi.Items.Add("Pengurangan");
            comboBoxOperasi.Items.Add("Perkalian");
            comboBoxOperasi.Items.Add("Pembagian");
            comboBoxOperasi.SelectedIndex= 0;
        }

        public delegate void Proses(int nilaiA, int nilaiB, string operasi,string operasiLabel, float hasil);

        public event Proses prosesEvent;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnProses_Click(object sender, EventArgs e)
        {
            int nilaiA = int.Parse(txtNilaiA.Text);
            int nilaiB = int.Parse(txtNilaiB.Text);
            string operasi = "";
            string operasiLabel = "";
            float hasil = 0;
            switch(comboBoxOperasi.SelectedIndex)
            {
                // Penjumlahan
                case 0:
                    hasil = Calculator.Penjumlahan(nilaiA, nilaiB);
                    operasiLabel = "Penjumlahan";
                    operasi = "+";
                    break;
                // Pengurangan
                case 1:
                    hasil = Calculator.Pengurangan(nilaiA, nilaiB);
                    operasiLabel = "Pengurangan";
                    operasi = "-";
                    break;
                // Perkalian
                case 2:
                    hasil = Calculator.Perkalian(nilaiA, nilaiB);
                    operasiLabel = "Perkalian";
                    operasi = "x";
                    break;
                // Pembagian
                case 3:
                    hasil = (float)Calculator.Pembagian(nilaiA, nilaiB);
                    operasiLabel = "Pembagian";
                    operasi = "/";
                    break;

            }
            prosesEvent(nilaiA, nilaiB, operasi, operasiLabel, hasil);
        }
    }
}
