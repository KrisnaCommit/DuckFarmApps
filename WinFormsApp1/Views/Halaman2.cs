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
    public partial class HitungBobot : Form
    {
        List<double> beratKarung = new List<double>(); // Menyimpan berat setiap karung
        float jumlahKarung = 0; // Variabel untuk menyimpan jumlah karung
        double totalBerat = 0; // Variabel untuk menyimpan total berat
        public HitungBobot()
        {
            InitializeComponent();
        }

        private void TombolBack_Click(object sender, EventArgs e)
        {
            // Membuka Hitung Bobot
            Form1 halaman2 = new Form1();
            halaman2.Show();  // Menampilkan Hitung Bobot

            // Opsional: Menutup Halaman1 (jika ingin form sebelumnya tertutup)
            this.Close();

            // Atau gunakan this.Hide() jika ingin menyembunyikan Halaman1 tanpa menutupnya
            // this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void SalinBobotPerKarung_Click(object sender, EventArgs e)
        {
            // Salin isi dari label4 ke clipboard
            Clipboard.SetText(label4.Text);

            // Opsional: Tampilkan pesan sukses
            MessageBox.Show("Total berat berhasil disalin ke clipboard!");
        }

        private void HitungBobotPerKarung_Click(object sender, EventArgs e)
        {

        }

        private void TombolTambahKarung_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text) && double.TryParse(textBox1.Text, out double berat))
            {
                jumlahKarung++;
                beratKarung.Add(berat); // Tambahkan berat ke daftar
                totalBerat += berat; // Tambahkan berat ke total berat
                label3.Text = "Karung ke: " + jumlahKarung.ToString();
                label4.Text = "Total Berat: " + totalBerat.ToString(); // Update label total berat
                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("Silakan masukkan berat per karung!");
            }
        }

        private void TombolKurangiKarung_Click(object sender, EventArgs e)
        {
            if (jumlahKarung > 0)
            {
                jumlahKarung--;
                if (beratKarung.Count > 0)
                {
                    double berat = beratKarung[beratKarung.Count - 1]; // Ambil berat terakhir
                    beratKarung.RemoveAt(beratKarung.Count - 1); // Hapus berat terakhir dari daftar
                    totalBerat -= berat; // Kurangi berat dari total berat
                }
                label3.Text = "Karung ke: " + jumlahKarung.ToString();
                label4.Text = "Total Berat: " + totalBerat.ToString(); // Update label total berat
            }
            else
            {
                MessageBox.Show("Tidak ada karung yang bisa dikurangi!");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Salin isi dari label4 ke clipboard
            Clipboard.SetText(label4.Text);
        }

        private void label3_Click(object sender, EventArgs e) //karung ke
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            // Anda dapat menampilkan total berat di sini
            MessageBox.Show("Total Berat: " + totalBerat.ToString());
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // URL yang ingin dibuka
            string url = "https://github.com/KrisnaCommit/DuckFarmApps";

            try
            {
                // Membuka URL di browser default
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true // Penting untuk membuka URL di browser default
                });
            }
            catch (Exception ex)
            {
                // Menampilkan pesan error jika gagal membuka URL
                MessageBox.Show("Gagal membuka URL: " + ex.Message);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}

