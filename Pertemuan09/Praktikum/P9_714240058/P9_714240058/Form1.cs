using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P9_714240058
{
    public partial class Form1 : Form
    {
        // Instansiasi class Koneksi
        Koneksi koneksi = new Koneksi();

        public Form1()
        {
            InitializeComponent();
        }

        // Method untuk mengambil data dari DB dan menampilkannya di Grid
        public void Tampil()
        {
            // Mengambil semua data dari tabel t_mahasiswa
            DataMahasiswa.DataSource = koneksi.ShowData("SELECT * FROM t_mahasiswa");

            // Mengubah judul header kolom agar lebih rapi (bukan nama field database)
            // Pastikan urutan index [0] s/d [5] sesuai urutan kolom di database
            DataMahasiswa.Columns[0].HeaderText = "NPM";
            DataMahasiswa.Columns[1].HeaderText = "Nama";
            DataMahasiswa.Columns[2].HeaderText = "Angkatan";
            DataMahasiswa.Columns[3].HeaderText = "Alamat";
            DataMahasiswa.Columns[4].HeaderText = "Email";
            DataMahasiswa.Columns[5].HeaderText = "No HP";

            // Opsional: Agar kolom menyesuaikan lebar otomatis
            // DataMahasiswa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Wajib dipanggil disini agar data muncul saat aplikasi baru dibuka
            Tampil();
        }
    }
}
