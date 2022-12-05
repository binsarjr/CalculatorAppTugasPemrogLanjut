using System.Security.Policy;

namespace CalculatorApp
{
    public partial class FormHasilPerhitungan : Form
    {
        public FormHasilPerhitungan()
        {
            InitializeComponent();
        }

        private void proses(int nilaiA, int nilaiB, string operasi,string operasiLabel, float hasil)
        {
            listBox.Items.Add(
                String.Format($"Hasil {operasiLabel} dari {nilaiA} {operasi} {nilaiB} = ") + 
                String.Format(hasil % 1 == 0 ? "{0:0}" : "{0:0.00}", hasil)
            );
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCalculatorApp formCalculator = new FormCalculatorApp();
            formCalculator.prosesEvent += proses;
            formCalculator.ShowDialog();
        }
    }
}