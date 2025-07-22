using MySql.Data.MySqlClient;
using WinFormsApp1.Database;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Membuka Hitung FCR
            Hitung_FCR halaman2 = new Hitung_FCR();
            halaman2.Show();  // Menampilkan Hitung Bobot

            // Opsional: Menutup Halaman1 (jika ingin form sebelumnya tertutup)
            //this.Close();

            // Atau gunakan this.Hide() jika ingin menyembunyikan Halaman1 tanpa menutupnya
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            // Membuka Hitung Bobot
            HitungBobot halaman2 = new HitungBobot();
            halaman2.Show();  // Menampilkan Hitung Bobot

            // Opsional: Menutup Halaman1 (jika ingin form sebelumnya tertutup)
            //this.Close();

            // Atau gunakan this.Hide() jika ingin menyembunyikan Halaman1 tanpa menutupnya
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e) //SQLConnect
        {
            CekKoneksiDatabase();
        }
        private void CekKoneksiDatabase()
        {
            try
            {
                // Gunakan class DatabaseConnection
                DatabaseConnection db = new DatabaseConnection();
                using (var connection = db.GetNewConnection())
                {
                    connection.Open();
                    // Query untuk mengambil data
                    string query = "SELECT * FROM tbuser"; // Ganti 'nama_tabel' dengan nama tabel Anda
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    using (var reader = cmd.ExecuteReader())
                    {

                        // Tampilkan data di console atau MessageBox
                        while (reader.Read())
                        {
                            MessageBox.Show($"Data: {reader["username"]}"); // Ganti 'kolom1' dengan nama kolom di tabel Anda
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Membuka Halaman4 (CRUD Data Karyawan)
            FormDataKaryawan halaman4 = new FormDataKaryawan();
            halaman4.Show(); // Menampilkan Halaman4

            // Opsional: Menutup atau menyembunyikan Halaman1
            this.Hide();
        }
    }
}
