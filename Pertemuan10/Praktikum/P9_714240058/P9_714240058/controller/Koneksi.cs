using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P9_714240058
{
    internal class Koneksi
    {
        // Connection String standard XAMPP (User: root, Pass: kosong)
        string conectionstring = "Server=localhost; Database=pemrog2ulbi; Uid=root; Pwd=;";
        MySqlConnection kon;

        public void OpenConnection()
        {
            kon = new MySqlConnection(conectionstring);
            kon.Open();
        }

        public void CloseConnection()
        {
            kon.Close();
        }

        // Mengembalikan DataTable, bukan object, agar lebih strict
        public DataTable ShowData(string query)
        {
            OpenConnection();

            MySqlDataAdapter adapter = new MySqlDataAdapter(query, kon);
            DataTable table = new DataTable();
            adapter.Fill(table);

            CloseConnection();
            return table;
        }

        public void ExecuteQuery(MySqlCommand command)
        {
            command.Connection = kon;
            command.ExecuteNonQuery();
        }
    }
}
