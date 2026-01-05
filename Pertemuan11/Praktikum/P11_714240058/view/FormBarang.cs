using P11_714240058.controller;
using System;
using System.Windows.Forms;

namespace P11_714240058.view
{
    public partial class FormBarang : Form
    {
        BarangController barangCtrl = new BarangController();
        int idBarang = 0;

        public FormBarang()
        {
            InitializeComponent();
        }

        private void FormBarang_Load(object sender, EventArgs e)
        {
            TampilData();
        }

        private void TampilData()
        {
            DataBarang.DataSource = barangCtrl.GetAllBarang();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            barangCtrl.InsertBarang(
                txtNamaBarang.Text,
                int.Parse(txtHarga.Text)
            );
            Bersih();
            TampilData();
        }

        private void Bersih()
        {
            txtNamaBarang.Clear();
            txtHarga.Clear();
            idBarang = 0;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Bersih();
            TampilData();
        }

        private void btnHapus_Click_1(object sender, EventArgs e)
        {
            barangCtrl.DeleteBarang(idBarang);
            Bersih();
            TampilData();
        }

        private void DataBarang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // ⬅️ WAJIB

            idBarang = Convert.ToInt32(
                DataBarang.Rows[e.RowIndex].Cells["id_barang"].Value
            );

            txtNamaBarang.Text =
                DataBarang.Rows[e.RowIndex].Cells["nama_barang"].Value.ToString();

            txtHarga.Text =
                DataBarang.Rows[e.RowIndex].Cells["harga"].Value.ToString();
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (idBarang == 0)
            {
                MessageBox.Show("Pilih data terlebih dahulu!");
                return;
            }

            barangCtrl.UpdateBarang(
                idBarang,
                txtNamaBarang.Text,
                int.Parse(txtHarga.Text)
            );

            MessageBox.Show("Data berhasil diubah");
            Bersih();
            TampilData();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (idBarang == 0)
            {
                MessageBox.Show("Pilih data terlebih dahulu!");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Yakin ingin menghapus data ini?",
                "Konfirmasi",
                MessageBoxButtons.YesNo
            );

            if (result == DialogResult.Yes)
            {
                barangCtrl.DeleteBarang(idBarang);
                MessageBox.Show("Data berhasil dihapus");
                Bersih();
                TampilData();
            }
        }

    }
}
