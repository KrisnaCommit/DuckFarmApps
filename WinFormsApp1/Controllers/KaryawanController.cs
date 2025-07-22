using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Database;
using WinFormsApp1.Models;

namespace WinFormsApp1.Controllers
{
    internal class KaryawanController
    {
        private DatabaseConnection db = new DatabaseConnection();

        public DataTable GetAll()
        {
            DataTable dt = new DataTable();
            using (var conn = db.GetNewConnection())
            {
                conn.Open();
                string query = "SELECT * FROM tbkaryawan";
                MySqlCommand command = new MySqlCommand(query, conn);
                MySqlDataReader reader = command.ExecuteReader();
                dt.Load(reader);
            }
            return dt;
        }

        public void Add(Karyawan karyawan)
        {
            using (var conn = db.GetNewConnection())
            {
                conn.Open();
                string query = "INSERT INTO tbkaryawan (nama, no_hp, alamat) VALUES (@nama, @no_hp, @alamat)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nama", karyawan.Nama);
                cmd.Parameters.AddWithValue("@no_hp", karyawan.NoHP);
                cmd.Parameters.AddWithValue("@alamat", karyawan.Alamat);
                cmd.ExecuteNonQuery();
            }
        }

        public void Update(Karyawan karyawan)
        {
            using (var conn = db.GetNewConnection())
            {
                conn.Open();
                string query = "UPDATE tbkaryawan SET nama = @nama, no_hp = @no_hp, alamat = @alamat WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", karyawan.Id);
                cmd.Parameters.AddWithValue("@nama", karyawan.Nama);
                cmd.Parameters.AddWithValue("@no_hp", karyawan.NoHP);
                cmd.Parameters.AddWithValue("@alamat", karyawan.Alamat);
                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (var conn = db.GetNewConnection())
            {
                conn.Open();
                string query = "DELETE FROM tbkaryawan WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
