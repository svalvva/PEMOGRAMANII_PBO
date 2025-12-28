using MySql.Data.MySqlClient;
using P11_714240058.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P11_714240058.controller
{
    internal class Nilai
    {
        Koneksi koneksi = new Koneksi();
        // Method insert
        public bool Insert(M_nilai nilai)
        {
            bool status = false;
            try
            {
                koneksi.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(
                "INSERT INTO t_nilai (matkul, kategori, npm, nilai) VALUES (@matkul, @kategori, @npm, @nilai)"
                );
                cmd.Parameters.AddWithValue("@matkul", nilai.Matkul);
                cmd.Parameters.AddWithValue("@kategori", nilai.Kategori);
                cmd.Parameters.AddWithValue("@npm", nilai.Npm);
                cmd.Parameters.AddWithValue("@nilai", nilai.Nilai);
                koneksi.ExecuteQuery(cmd);
                status = true;
                MessageBox.Show("Data berhasil ditambahkan", "Informasi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.CloseConnection();
            }
            catch (Exception e)
            {
                // pastikan koneksi tertutup kalau error
                koneksi.CloseConnection();
                MessageBox.Show(e.Message, "Gagal", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            return status;
        }
        // Method update
        public bool Update(M_nilai nilai, string id)
        {
            bool status = false;
            try
            {
                koneksi.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(
                "UPDATE t_nilai SET matkul=@matkul, kategori=@kategori, npm=@npm, nilai = @nilai WHERE id_nilai = @id"
                );
                cmd.Parameters.AddWithValue("@matkul", nilai.Matkul);
                cmd.Parameters.AddWithValue("@kategori", nilai.Kategori);
                cmd.Parameters.AddWithValue("@npm", nilai.Npm);
                cmd.Parameters.AddWithValue("@nilai", nilai.Nilai);
                cmd.Parameters.AddWithValue("@id", id);
                koneksi.ExecuteQuery(cmd);

                status = true;
                MessageBox.Show("Data berhasil diubah", "Informasi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.CloseConnection();
            }
            catch (Exception e)
            {
                koneksi.CloseConnection();
                MessageBox.Show(e.Message, "Gagal", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            return status;
        }
        // Method delete
        public bool Delete(string id)
        {
            bool status = false;
            try
            {
                koneksi.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(
                "DELETE FROM t_nilai WHERE id_nilai=@id"
                );
                cmd.Parameters.AddWithValue("@id", id);
                koneksi.ExecuteQuery(cmd);
                status = true;
                MessageBox.Show("Data berhasil dihapus", "Informasi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.CloseConnection();
            }
            catch (Exception e)
            {
                koneksi.CloseConnection();
                MessageBox.Show(e.Message, "Gagal", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            return status;
        }
    }
}
