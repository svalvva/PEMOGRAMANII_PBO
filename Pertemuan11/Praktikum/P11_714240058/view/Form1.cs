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

namespace P11_714240058
{
    public partial class Form1 : Form
    {
        Koneksi koneksi = new Koneksi();
        M_mahasiswa m_mhs = new M_mahasiswa();

        public void Tampil()
        { 
            koneksi.OpenConnection();
            DataMahasiswa.DataSource = koneksi.ShowData("SELECT * FROM t_mahasiswa");
            koneksi.CloseConnection();

            DataMahasiswa.Columns[0].HeaderText = "NPM";
            DataMahasiswa.Columns[1].HeaderText = "Nama";
            DataMahasiswa.Columns[2].HeaderText = "Angkatan";
            DataMahasiswa.Columns[3].HeaderText = "Alamat";
            DataMahasiswa.Columns[4].HeaderText = "Email";
            DataMahasiswa.Columns[5].HeaderText = "No HP";

        }

        public void ResetForm()
        {
            textboxNpm.Text = "";
            textboxNama.Text = "";
            comboBoxAngkatan.SelectedIndex = -1;
            textboxAlamat.Text = "";
            textboxEmail.Text = "";
            textboxNohp.Text = "";
            textBoxCariData.Text = "";
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void textboxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Tampil();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (textboxNpm.Text == "" || textboxNama.Text == "" || comboBoxAngkatan.SelectedIndex == -1 || textboxAlamat.Text == "" || textboxEmail.Text == "" || textboxNohp.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            { 
                Mahasiswa mhs = new Mahasiswa();
                m_mhs.Npm = textboxNpm.Text;
                m_mhs.Nama = textboxNama.Text;
                m_mhs.Angkatan = comboBoxAngkatan.Text;
                m_mhs.Alamat = textboxAlamat.Text;
                m_mhs.Email = textboxEmail.Text;
                m_mhs.Nohp = textboxNohp.Text;

                mhs.Insert(m_mhs);
                Tampil();
                ResetForm();
            }
        }

        private void DataMahasiswa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textboxNpm.Text = DataMahasiswa.Rows[e.RowIndex].Cells[0].Value.ToString();
            textboxAlamat.Text = DataMahasiswa.Rows[e.RowIndex].Cells[3].Value.ToString();
            textboxEmail.Text = DataMahasiswa.Rows[e.RowIndex].Cells[4].Value.ToString();
            textboxNama.Text = DataMahasiswa.Rows[e.RowIndex].Cells[1].Value.ToString();
            comboBoxAngkatan.Text = DataMahasiswa.Rows[e.RowIndex].Cells[2].Value.ToString();
            textboxNohp.Text = DataMahasiswa.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (textboxNpm.Text == "" || textboxNama.Text == "" || comboBoxAngkatan.Text == "" || textboxAlamat.Text == "" || textboxEmail.Text == "" || textboxNohp.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Mahasiswa mhs = new Mahasiswa();
                m_mhs.Npm = textboxNpm.Text;
                m_mhs.Nama = textboxNama.Text;
                m_mhs.Angkatan = comboBoxAngkatan.Text;
                m_mhs.Alamat = textboxAlamat.Text;
                m_mhs.Email = textboxEmail.Text;
                m_mhs.Nohp = textboxNohp.Text;

                mhs.Update(m_mhs, textboxNpm.Text);
                Tampil();
                ResetForm();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Tampil();
            ResetForm();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            DialogResult pesan = MessageBox.Show(
                "Apakah yakin akan menghapus data ini?",
                "Perhatian",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (pesan == DialogResult.Yes)
            { 
                Mahasiswa mhs = new Mahasiswa();
                mhs.Delete(textboxNpm.Text);
                Tampil();
                ResetForm();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBoxCariData_TextChanged(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM t_mahasiswa WHERE npm LIKE @param OR nama LIKE @param";
            DataMahasiswa.DataSource = koneksi.ShowDataParam(
                sql,
                new MySqlParameter("@param", "%" + textBoxCariData.Text + "%")
);
        }
    }
}
