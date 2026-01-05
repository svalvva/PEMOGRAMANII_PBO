using MySql.Data.MySqlClient;
using P11_714240058.controller;
using P11_714240058.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P11_714240058.view
{
    public partial class FormTransaksi : Form
    {
        Koneksi koneksi = new Koneksi();
        TransaksiController trCtrl = new TransaksiController();
        string idTransaksi = "";
        public FormTransaksi()
        {
            InitializeComponent();
        }

        public void Tampil()
        {
            DataTransaksi.DataSource = koneksi.ShowData(
                "SELECT t_transaksi.id_transaksi, t_barang.id_barang, nama_barang, harga, qty, total " +
                "FROM t_transaksi JOIN t_barang ON t_barang.id_barang = t_transaksi.id_barang"
            );
        }


        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textboxNama_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void TampilData()
        {
            DataTransaksi.DataSource = trCtrl.GetAll();
        }

        // ===============================
        // ISI COMBOBOX ID BARANG
        // ===============================
        private void GetBarang()
        {
            cbIdBarang.Items.Clear();
            koneksi.OpenConnection();

            MySqlDataReader dr = koneksi.reader(
                "SELECT id_barang FROM t_barang"
            );

            while (dr.Read())
            {
                cbIdBarang.Items.Add(dr["id_barang"].ToString());
            }

            dr.Close();
            koneksi.CloseConnection();
        }

        private void FormTransaksi_Load(object sender, EventArgs e)
        {
            TampilData();
            GetBarang();
        }

        // ===============================
        // SAAT ID BARANG DIPILIH
        // ===============================
        private void cbIdBarang_SelectedIndexChanged(object sender, EventArgs e)
        {
            // JIKA BELUM ADA YANG DIPILIH → STOP
            if (cbIdBarang.SelectedIndex == -1)
                return;

            string sql = "SELECT nama_barang, harga FROM t_barang WHERE id_barang = @id";

            DataTable dt = (DataTable)koneksi.ShowDataParam(
                sql,
                new MySqlParameter("@id", cbIdBarang.Text)
            );

            // JIKA DATA TIDAK ADA → STOP
            if (dt.Rows.Count == 0)
                return;

            txtNamaBarang.Text = dt.Rows[0]["nama_barang"].ToString();
            txtHarga.Text = dt.Rows[0]["harga"].ToString();
        }

        // ===============================
        // HITUNG TOTAL OTOMATIS
        // ===============================
        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            if (txtQty.Text == "") return;

            int harga = int.Parse(txtHarga.Text);
            int qty = int.Parse(txtQty.Text);

            txtTotal.Text = (harga * qty).ToString();
        }


        // ===============================
        // BUTTON UBAH
        // ===============================
        private void btnUbah_Click(object sender, EventArgs e)
        {
            M_transaksi tr = new M_transaksi(
                cbIdBarang.Text,
                txtQty.Text,
                txtTotal.Text
            );

            trCtrl.Update(tr, idTransaksi);
            Bersih();
            TampilData();
        }

        // ===============================
        // BUTTON HAPUS
        // ===============================
        private void btnHapus_Click(object sender, EventArgs e)
        {
            trCtrl.Delete(idTransaksi);
            Bersih();
            TampilData();
        }

        private void DataTransaksi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idTransaksi =
                DataTransaksi.Rows[e.RowIndex].Cells["id_transaksi"].Value.ToString();

            cbIdBarang.Text =
                DataTransaksi.Rows[e.RowIndex].Cells["id_barang"].Value.ToString();

            txtQty.Text =
                DataTransaksi.Rows[e.RowIndex].Cells["qty"].Value.ToString();

            txtTotal.Text =
                DataTransaksi.Rows[e.RowIndex].Cells["total"].Value.ToString();
        }
        // ===============================
        // RESET FORM
        // ===============================
        private void Bersih()
        {
            cbIdBarang.SelectedIndexChanged -= cbIdBarang_SelectedIndexChanged;

            cbIdBarang.SelectedIndex = -1;
            txtNamaBarang.Clear();
            txtHarga.Clear();
            txtQty.Clear();
            txtTotal.Clear();
            idTransaksi = "";

            cbIdBarang.SelectedIndexChanged += cbIdBarang_SelectedIndexChanged;
        }

        private void btnSimpan_Click_1(object sender, EventArgs e)
        {
            if (cbIdBarang.SelectedIndex == -1 || txtQty.Text == "")
            {
                MessageBox.Show("Lengkapi data terlebih dahulu!");
                return;
            }

            if (trCtrl.CekBarang(cbIdBarang.Text))
            {
                MessageBox.Show("Barang sudah ada, silakan Update!");
                return;
            }

            M_transaksi tr = new M_transaksi(
                cbIdBarang.Text,
                txtQty.Text,
                txtTotal.Text
            );

            trCtrl.Insert(tr);
            MessageBox.Show("Data transaksi berhasil disimpan");

            Bersih();
            TampilData();
        }
    }
}
