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
using WinFormsApp1.Controllers;
using WinFormsApp1.Models;

namespace WinFormsApp1
{

    

    public partial class FormDataKaryawan : Form
    {
        private KaryawanController controller = new KaryawanController();

        public FormDataKaryawan()
        {
            InitializeComponent();
        }

        //Menampilkan atau Mengisi data dari (tbkaryawan) ke DataGridView
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

        //Memanggil table karyawan (tbkaryawan) dari database duckfarmapps MySQL

        private void fillDataKaryawan()
        {
            dataGridViewABK.Columns.Clear();
            dataGridViewABK.DataSource = controller.GetAll();

            DataGridViewButtonColumn editData = new DataGridViewButtonColumn();
            editData.UseColumnTextForButtonValue = true;
            editData.Text = "Edit";
            editData.Name = "Edit";
            dataGridViewABK.Columns.Add(editData);

            DataGridViewButtonColumn hapusData = new DataGridViewButtonColumn();
            hapusData.UseColumnTextForButtonValue = true;
            hapusData.Text = "Delete";
            hapusData.Name = "Delete";
            dataGridViewABK.Columns.Add(hapusData);
        }

        private void btnSimpan_Click(object sender, EventArgs e) //Add Data
        {
            try
            {
                var k = new Karyawan
                {
                    Nama = textBoxNamaAdd.Text,
                    NoHP = textBoxNoHPAdd.Text,
                    Alamat = textBoxAlamatAdd.Text
                };
                controller.Add(k);
                fillDataKaryawan();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}");
            }

        }
        private void dataGridViewABK_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewABK.Columns["Edit"].Index)
            {
                int rowIndex = e.RowIndex;
                textBoxidUpdate.Text = dataGridViewABK.Rows[rowIndex].Cells[0].Value.ToString();
                textBoxNamaUpdate.Text = dataGridViewABK.Rows[rowIndex].Cells[1].Value.ToString();
                textBoxNoHPUpdate.Text = dataGridViewABK.Rows[rowIndex].Cells[2].Value.ToString();
                textBoxAlamatUpdate.Text = dataGridViewABK.Rows[rowIndex].Cells[3].Value.ToString();

                textBoxNamaUpdate.Enabled = true;
                textBoxNoHPUpdate.Enabled = true;
                textBoxAlamatUpdate.Enabled = true;
            }

            if (e.ColumnIndex == dataGridViewABK.Columns["Delete"].Index)
            {
                int rowIndex = e.RowIndex;
                int id = Convert.ToInt32(dataGridViewABK.Rows[rowIndex].Cells[0].Value);
                controller.Delete(id);
                fillDataKaryawan();
            }
        }

        private void TombolBack_Click(object sender, EventArgs e)
        {
            // Membuka Home Form1
            Form1 halaman2 = new Form1();
            halaman2.Show();  // Menampilkan Hitung Bobot

            // Opsional: Menutup Halaman1 (jika ingin form sebelumnya tertutup)
            this.Close();

            // Atau gunakan this.Hide() jika ingin menyembunyikan Halaman1 tanpa menutupnya
            // this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e) //UPDATE Data
        {
            try
            {
                var k = new Karyawan
                {
                    Id = Convert.ToInt32(textBoxidUpdate.Text),
                    Nama = textBoxNamaUpdate.Text,
                    NoHP = textBoxNoHPUpdate.Text,
                    Alamat = textBoxAlamatUpdate.Text
                };
                controller.Update(k);
                fillDataKaryawan();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
    }
}
