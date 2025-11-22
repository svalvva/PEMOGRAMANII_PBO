using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P6_4_714240058
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SetErrorMessages(TextBox textBox, string warning, string wrong, string correct)
        {
            epWarning.SetError(textBox, warning);
            epWrong.SetError(textBox, wrong);
            epCorrect.SetError(textBox, correct);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtNPM_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNPM.Text))
            {
                SetErrorMessages(txtNPM, "NPM wajib diisi!", "", "");
            }
            else if (txtNPM.Text.All(char.IsNumber)) // Validasi Numeric
            {
                SetErrorMessages(txtNPM, "", "", "Betul!");
            }
            else
            {
                SetErrorMessages(txtNPM, "", "NPM harus berupa angka!", "");
            }
        }

        private void txtNama_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNama.Text))
            {
                SetErrorMessages(txtNama, "Nama wajib diisi!", "", "");
            }
            // Validasi Char (Huruf dan Spasi diperbolehkan)
            else if (txtNama.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
            {
                SetErrorMessages(txtNama, "", "", "Betul!");
            }
            else
            {
                SetErrorMessages(txtNama, "", "Nama hanya boleh mengandung huruf!", "");
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                SetErrorMessages(txtEmail, "Email wajib diisi!", "", "");
                return;
            }

            // Validasi Regex Email Standar
            if (Regex.IsMatch(txtEmail.Text, @"^[^@\s]+@[^@\s]+(\.[^@\s]+)+$"))
            {
                SetErrorMessages(txtEmail, "", "", "Betul!");
            }
            else
            {
                SetErrorMessages(txtEmail, "", "Format email salah! (Contoh: nama@ulbi.ac.id)", "");
            }
        }

        private void txtCekEmail_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCekEmail.Text))
            {
                SetErrorMessages(txtCekEmail, "Konfirmasi email wajib diisi!", "", "");
                return;
            }

            // Membandingkan isi txtCekEmail dengan txtEmail
            if (txtCekEmail.Text == txtEmail.Text)
            {
                SetErrorMessages(txtCekEmail, "", "", "Betul!");
            }
            else
            {
                SetErrorMessages(txtCekEmail, "", "Email tidak cocok!", "");
            }
        }

        private void txtKodeDosen_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKodeDosen.Text))
            {
                SetErrorMessages(txtKodeDosen, "Kode Dosen wajib diisi!", "", "");
                return;
            }

            // Validasi tambahan (Format: 2 Huruf + 3 Angka, Misal: KB001)
            if (Regex.IsMatch(txtKodeDosen.Text, @"^[A-Z]{2}\d{3}$"))
            {
                SetErrorMessages(txtKodeDosen, "", "", "Betul!");
            }
            else
            {
                SetErrorMessages(txtKodeDosen, "Format: 2 Huruf + 3 Angka (Cth: KB001)", "", "");
            }
        }

        private void txtJudul_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtJudul.Text))
            {
                // Menampilkan ErrorWarning jika kosong
                SetErrorMessages(txtJudul, "Judul Skripsi tidak boleh kosong!", "", "");
            }
            else
            {
                SetErrorMessages(txtJudul, "", "", "Betul!");
            }
        }

        private void txtDeskripsi_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDeskripsi.Text))
            {
                SetErrorMessages(txtDeskripsi, "Deskripsi wajib diisi!", "", "");
            }
            else if (txtDeskripsi.Text.Length >= 20) // Minimal 20 karakter
            {
                SetErrorMessages(txtDeskripsi, "", "", "Betul!");
            }
            else
            {
                SetErrorMessages(txtDeskripsi, "", "Deskripsi terlalu pendek! Minimal 20 karakter.", "");
            }
        }

        private void txtLink_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLink.Text))
            {
                SetErrorMessages(txtLink, "Link jurnal wajib diisi!", "", "");
                return;
            }

            // Validasi format URL sederhana
            if (Uri.IsWellFormedUriString(txtLink.Text, UriKind.RelativeOrAbsolute))
            {
                SetErrorMessages(txtLink, "", "", "Betul!");
            }
            else
            {
                SetErrorMessages(txtLink, "Format link sepertinya salah.", "", "");
            }
        }

        private void btnAjukan_Click(object sender, EventArgs e)
        {
            // Validasi akhir: Pastikan tidak ada field yang kosong atau salah
            // (Disini kita cek sederhana apakah ada text kosong)
            if (txtNPM.Text == "" || txtNama.Text == "" || txtEmail.Text == "" ||
                txtKodeDosen.Text == "" || txtJudul.Text == "" || txtDeskripsi.Text == "" ||
                txtCekEmail.Text != txtEmail.Text)
            {
                MessageBox.Show("Harap lengkapi semua data dengan benar sebelum mengajukan!", "Validasi Gagal",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Menampilkan MessageBox berisi data form
            string info = $"Konfirmasi Pengajuan Skripsi:\n\n" +
                          $"NPM: {txtNPM.Text}\n" +
                          $"Nama: {txtNama.Text}\n" +
                          $"Email: {txtEmail.Text}\n" +
                          $"Kode Dosen: {txtKodeDosen.Text}\n" +
                          $"Judul: {txtJudul.Text}\n" +
                          $"Deskripsi: {txtDeskripsi.Text}\n" +
                          $"Link Ref: {txtLink.Text}";

            MessageBox.Show(info, "Berhasil Disubmit", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
