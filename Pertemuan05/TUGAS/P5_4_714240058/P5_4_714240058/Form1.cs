using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5_4_714240058
{
    public partial class FormPendaftaran : Form
    {
        public FormPendaftaran()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Validasi Pilihan Kelas (CheckBox)
            if (!chkSepakBola.Checked && !chkBasket.Checked && !chkRenang.Checked &&
                !chkBuluTangkis.Checked && !chkTenis.Checked && !chkVoli.Checked &&
                !chkYoga.Checked && !chkPanahan.Checked)
            {
                MessageBox.Show("Harus memilih salah satu dari pilihan kelas", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validasi Pilihan Jadwal (RadioButton)
            if (!rbSenin.Checked && !rbSelasa.Checked && !rbSabtu.Checked && !rbMinggu.Checked)
            {
                MessageBox.Show("Harus memilih salah satu dari pilihan jadwal", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Mengumpulkan data Pilihan Kelas
            string kelas = "";
            if (chkSepakBola.Checked) kelas += "Sepak Bola, ";
            if (chkBasket.Checked) kelas += "Basket, ";
            if (chkRenang.Checked) kelas += "Renang, ";
            if (chkBuluTangkis.Checked) kelas += "Bulu Tangkis, ";
            if (chkTenis.Checked) kelas += "Tenis, ";
            if (chkVoli.Checked) kelas += "Voli, ";
            if (chkYoga.Checked) kelas += "Yoga, ";
            if (chkPanahan.Checked) kelas += "Panahan, ";
            kelas = kelas.TrimEnd(' ', ',');

            // Mengumpulkan data Pilihan Jadwal
            string jadwal = "";
            if (rbSenin.Checked) jadwal = rbSenin.Text;
            else if (rbSelasa.Checked) jadwal = rbSelasa.Text;
            else if (rbSabtu.Checked) jadwal = rbSabtu.Text;
            else if (rbMinggu.Checked) jadwal = rbMinggu.Text;

            // Mengumpulkan data lainnya
            string nama = txtNama.Text;
            string jenisKelamin = cbJenisKelamin.Text;
            string tanggalLahir = dtpTanggalLahir.Text;

            // Menampilkan semua hasil di MessageBox
            string hasil = "Nama: " + nama + "\n" +
                           "Jenis Kelamin: " + jenisKelamin + "\n" +
                           "Tanggal Lahir: " + tanggalLahir + "\n" +
                           "Pilihan Kelas: " + kelas + "\n" +
                           "Pilihan Jadwal: " + jadwal;

            MessageBox.Show(hasil, "Informasi Pendaftaran",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
