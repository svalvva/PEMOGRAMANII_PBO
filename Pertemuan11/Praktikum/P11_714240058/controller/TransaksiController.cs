using MySql.Data.MySqlClient;
using P11_714240058.model;

namespace P11_714240058.controller
{
    internal class TransaksiController
    {
        Koneksi koneksi = new Koneksi();

        // ===============================
        // CEK BARANG SUDAH ADA / BELUM
        // ===============================
        public bool CekBarang(string id_barang)
        {
            bool ada = false;
            koneksi.OpenConnection();

            MySqlCommand cmd = new MySqlCommand(
                "SELECT * FROM t_transaksi WHERE id_barang=@id",
                koneksi.GetConnection()
            );
            cmd.Parameters.AddWithValue("@id", id_barang);

            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                ada = true;
            }

            dr.Close();
            koneksi.CloseConnection();
            return ada;
        }

        // ===============================
        // INSERT
        // ===============================
        public void Insert(M_transaksi tr)
        {
            koneksi.OpenConnection();

            MySqlCommand cmd = new MySqlCommand(
                "INSERT INTO t_transaksi (id_barang, qty, total) VALUES (@id, @qty, @total)",
                koneksi.GetConnection()
            );
            cmd.Parameters.AddWithValue("@id", tr.Id_barang);
            cmd.Parameters.AddWithValue("@qty", tr.Qty);
            cmd.Parameters.AddWithValue("@total", tr.Total);

            cmd.ExecuteNonQuery();
            koneksi.CloseConnection();
        }

        // ===============================
        // UPDATE
        // ===============================
        public void Update(M_transaksi tr, string id_transaksi)
        {
            koneksi.OpenConnection();

            MySqlCommand cmd = new MySqlCommand(
                "UPDATE t_transaksi SET qty=@qty, total=@total WHERE id_transaksi=@id",
                koneksi.GetConnection()
            );
            cmd.Parameters.AddWithValue("@qty", tr.Qty);
            cmd.Parameters.AddWithValue("@total", tr.Total);
            cmd.Parameters.AddWithValue("@id", id_transaksi);

            cmd.ExecuteNonQuery();
            koneksi.CloseConnection();
        }

        // ===============================
        // DELETE
        // ===============================
        public void Delete(string id_transaksi)
        {
            koneksi.OpenConnection();

            MySqlCommand cmd = new MySqlCommand(
                "DELETE FROM t_transaksi WHERE id_transaksi=@id",
                koneksi.GetConnection()
            );
            cmd.Parameters.AddWithValue("@id", id_transaksi);

            cmd.ExecuteNonQuery();
            koneksi.CloseConnection();
        }
        public object GetAll()
        {
            return koneksi.ShowData(
                "SELECT t_transaksi.id_transaksi, t_barang.id_barang, nama_barang, harga, qty, total " +
                "FROM t_transaksi JOIN t_barang ON t_barang.id_barang = t_transaksi.id_barang"
            );
        }

    }
}
