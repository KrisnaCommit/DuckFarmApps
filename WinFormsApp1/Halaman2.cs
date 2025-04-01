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
    }
}
