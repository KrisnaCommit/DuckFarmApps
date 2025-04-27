using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WinFormsApp1
{


    public partial class FormDataKaryawan : Form
    {
        MySqlConnection connection = new MySqlConnection("Server=localhost;Database=duckfarmapps;User ID=root;Password=;");
        DataTable dt = new DataTable();

        public FormDataKaryawan()
        {
            InitializeComponent();
        }

        private void FormDataKaryawan_Load(object sender, EventArgs e)
        {
            fillDataKaryawan();

            textBoxidUpdate.Enabled = false;
            textBoxNamaUpdate.Enabled = false;
            textBoxNoHPUpdate.Enabled = false;
            textBoxAlamatUpdate.Enabled = false;
        }

        private void textBoxAlamat_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNama_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNoHP_TextChanged(object sender, EventArgs e)
        {

        }

        public DataTable getDataKaryawan()
        {
            dt.Reset();
            dt = new DataTable();

            using (MySqlCommand command = new MySqlCommand("SELECT * FROM tbkaryawan", connection))
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                dt.Load(reader);
            }
            return dt;
        }

        private void fillDataKaryawan()
        {
            dataGridViewABK.DataSource = getDataKaryawan();

            DataGridViewButtonColumn editData = new DataGridViewButtonColumn();
            editData.UseColumnTextForButtonValue = true;
            editData.Text = "Edit";
            editData.Name = "";
            dataGridViewABK.Columns.Add(editData);

            DataGridViewButtonColumn hapusData = new DataGridViewButtonColumn();
            hapusData.UseColumnTextForButtonValue = true;
            hapusData.Text = "Delete";
            hapusData.Name = "";
            dataGridViewABK.Columns.Add(hapusData);

            connection.Close();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd;

            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                cmd = connection.CreateCommand();
                cmd.CommandText = "INSERT INTO tbkaryawan (nama, no_hp, alamat) VALUES (@nama, @no_hp, @alamat)";
                cmd.Parameters.AddWithValue("@nama", textBoxNamaAdd.Text);
                cmd.Parameters.AddWithValue("@no_hp", textBoxNoHPAdd.Text);
                cmd.Parameters.AddWithValue("@alamat", textBoxAlamatAdd.Text);
                cmd.ExecuteNonQuery();
                connection.Close();
                dataGridViewABK.Columns.Clear();
                dt.Clear();
                fillDataKaryawan();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }

        }
        private void dataGridViewABK_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                int id = e.RowIndex;
                textBoxNamaUpdate.Text = dataGridViewABK.Rows[id].Cells[1].Value.ToString();
                textBoxNoHPUpdate.Text = dataGridViewABK.Rows[id].Cells[2].Value.ToString();
                textBoxAlamatUpdate.Text = dataGridViewABK.Rows[id].Cells[3].Value.ToString();

                textBoxNamaUpdate.Enabled = true;
                textBoxNoHPUpdate.Enabled = true;
                textBoxAlamatUpdate.Enabled = true;
            }

            if (e.ColumnIndex == 5)
            {
                // Handle delete logic here
            }
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd;

            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                cmd = connection.CreateCommand();
                cmd.CommandText = "UPDATE tbkaryawan SET nama = @nama, no_hp = @no_hp, alamat = @alamat WHERE id = @id";
                cmd.Parameters.AddWithValue("@id", textBoxidUpdate.Text);
                cmd.Parameters.AddWithValue("@nama", textBoxNamaUpdate.Text);
                cmd.Parameters.AddWithValue("@no_hp", textBoxNoHPUpdate.Text);
                cmd.Parameters.AddWithValue("@alamat", textBoxAlamatUpdate.Text);
                cmd.ExecuteNonQuery();
                connection.Close();
                dataGridViewABK.Columns.Clear();
                dt.Clear();
                fillDataKaryawan();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
    }
}
