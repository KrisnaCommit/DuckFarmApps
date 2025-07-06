using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Hitung_FCR : Form
    {
        public Hitung_FCR()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Membuka Hitung Bobot
            Form1 halaman2 = new Form1();
            halaman2.Show();  // Menampilkan Hitung Bobot

            // Opsional: Menutup Halaman1 (jika ingin form sebelumnya tertutup)
            this.Close();

            // Atau gunakan this.Hide() jika ingin menyembunyikan Halaman1 tanpa menutupnya
            // this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(label5.Text))
            {
                Clipboard.SetText(label5.Text);
                MessageBox.Show("Hasil telah disalin!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Tidak ada hasil untuk disalin.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void HitungTotalPakan_Click(object sender, EventArgs e)
        {
            double nilai1, nilai2, hasil;

            if (double.TryParse(textBox2.Text, out nilai1) && double.TryParse(textBox4.Text, out nilai2))
            {
                if (nilai2 != 0)
                {
                    hasil = nilai1 / nilai2;
                    label5.Text = hasil.ToString("N2"); // hasil dengan dua angka desimal
                }
                else
                {
                    MessageBox.Show("Pembagi tidak boleh nol.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Masukkan angka yang valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Hitung_FCR_Load(object sender, EventArgs e)
        {

        }
    }
}
