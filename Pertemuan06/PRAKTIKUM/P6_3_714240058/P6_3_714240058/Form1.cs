using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace P6_3_714240058
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void SetErrorMessages(TextBox textBox, string warningMessage, string wrongMessage, string correctMessage)
        {
            epWarning.SetError(textBox, warningMessage);
            epWrong.SetError(textBox, wrongMessage);
            epCorrect.SetError(textBox, correctMessage);
        }

        private void txtHuruf_Leave(object sender, EventArgs e)
        {
            if (txtHuruf.Text == "")
            {
                SetErrorMessages(txtHuruf, "Textbox Huruf tidak boleh kosong!", "", "");
            }
            else if (txtHuruf.Text.All(Char.IsLetter))
            {
                SetErrorMessages(txtHuruf, "", "", "Betul!");
            }
            else
            {
                SetErrorMessages(txtHuruf, "", "Inputan hanya boleh huruf!", "");
            }
        }

        private void txtAngka_TextChanged(object sender, EventArgs e)
        {
            if (txtAngka.Text == "")
            {
                SetErrorMessages(txtAngka, "Textbox Angka tidak boleh kosong!", "", "");
            }
            else if (txtAngka.Text.All(Char.IsNumber))
            {
                SetErrorMessages(txtAngka, "", "", "Betul!");
            }
            else
            {
                SetErrorMessages(txtAngka, "", "Inputan hanya boleh angka!", "");
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                SetErrorMessages(txtEmail, "Textbox Email tidak boleh kosong!", "", "");
            }
            else if (Regex.IsMatch(txtEmail.Text, @"^[^@\s]+@[^@\s]+(\.[^@\s]+)+$"))
            {
                SetErrorMessages(txtEmail, "", "", "Betul!");
            }
            else
            {
                SetErrorMessages(txtEmail, "", "Format email salah!\nContoh: a@b.c", "");
            }
        }

        private void BandingkanAngka()
        {
            if (txtAngka1.Text.All(Char.IsNumber) && txtAngka1.Text != "" &&
                txtAngka2.Text.All(Char.IsNumber) && txtAngka2.Text != "")
            {
                int angka1 = int.Parse(txtAngka1.Text);
                int angka2 = int.Parse(txtAngka2.Text);

                if (angka1 > angka2)
                {
                    SetErrorMessages(txtAngka1, "", "", "Betul!");
                    SetErrorMessages(txtAngka2, "", "", "Betul!");
                }
                else
                {
                    SetErrorMessages(txtAngka1, "", "Angka 1 harus lebih besar dari Angka 2", "");
                    SetErrorMessages(txtAngka2, "", "Angka 1 harus lebih besar dari Angka 2", "");
                }
            }
        }

        private void txtAngka1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAngka1.Text))
            {
                SetErrorMessages(txtAngka1, "Textbox Angka 1 tidak boleh kosong!", "", "");
                return;
            }

            if (!txtAngka1.Text.All(Char.IsNumber))
            {
                SetErrorMessages(txtAngka1, "", "Inputan hanya boleh angka!", "");
                return;
            }

            // Jika lolos validasi dasar, tampilkan ikon betul sementara
            SetErrorMessages(txtAngka1, "", "", "Betul!");

            // Jika Angka 2 juga sudah terisi, kita perlu cek ulang perbandingannya
            // (Mencegah kasus user mengisi Angka 2 duluan, lalu balik ke Angka 1)
            if (!string.IsNullOrEmpty(txtAngka2.Text) && txtAngka2.Text.All(Char.IsNumber))
            {
                BandingkanAngka();
            }
        }

        private void txtAngka2_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAngka2.Text))
            {
                SetErrorMessages(txtAngka2, "Textbox Angka 2 tidak boleh kosong!", "", "");
                return;
            }

            if (!txtAngka2.Text.All(Char.IsNumber))
            {
                SetErrorMessages(txtAngka2, "", "Inputan hanya boleh angka!", "");
                return;
            }

            // Panggil fungsi pembanding
            BandingkanAngka();
        }
    }
}
