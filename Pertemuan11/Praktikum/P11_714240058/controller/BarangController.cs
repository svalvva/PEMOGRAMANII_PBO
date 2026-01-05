using MySql.Data.MySqlClient;
using P11_714240058.model;

namespace P11_714240058.controller
{
    internal class BarangController
    {
        Koneksi koneksi = new Koneksi();

        public void InsertBarang(string nama, int harga)
        {
            koneksi.OpenConnection();
            MySqlCommand cmd = new MySqlCommand(
                "INSERT INTO t_barang (nama_barang, harga) VALUES (@nama, @harga)"
            );
            cmd.Parameters.AddWithValue("@nama", nama);
            cmd.Parameters.AddWithValue("@harga", harga);
            koneksi.ExecuteQuery(cmd);
            koneksi.CloseConnection();
        }

        public void UpdateBarang(int id, string nama, int harga)
        {
            koneksi.OpenConnection();
            MySqlCommand cmd = new MySqlCommand(
                "UPDATE t_barang SET nama_barang=@nama, harga=@harga WHERE id_barang=@id"
            );
            cmd.Parameters.AddWithValue("@nama", nama);
            cmd.Parameters.AddWithValue("@harga", harga);
            cmd.Parameters.AddWithValue("@id", id);
            koneksi.ExecuteQuery(cmd);
            koneksi.CloseConnection();
        }

        public void DeleteBarang(int id)
        {
            koneksi.OpenConnection();
            MySqlCommand cmd = new MySqlCommand(
                "DELETE FROM t_barang WHERE id_barang=@id"
            );
            cmd.Parameters.AddWithValue("@id", id);
            koneksi.ExecuteQuery(cmd);
            koneksi.CloseConnection();
        }

        public object GetAllBarang()
        {
            return koneksi.ShowData("SELECT * FROM t_barang");
        }
    }
}
