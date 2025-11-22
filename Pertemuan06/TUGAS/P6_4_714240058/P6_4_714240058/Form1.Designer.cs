namespace P6_4_714240058
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.epWarning = new System.Windows.Forms.ErrorProvider(this.components);
            this.epWrong = new System.Windows.Forms.ErrorProvider(this.components);
            this.epCorrect = new System.Windows.Forms.ErrorProvider(this.components);
            this.NPM = new System.Windows.Forms.Label();
            this.namaMhs = new System.Windows.Forms.Label();
            this.emailKampus = new System.Windows.Forms.Label();
            this.konfirmasiEmail = new System.Windows.Forms.Label();
            this.kodeDosen = new System.Windows.Forms.Label();
            this.judul = new System.Windows.Forms.Label();
            this.deskripsi = new System.Windows.Forms.Label();
            this.link = new System.Windows.Forms.Label();
            this.txtNPM = new System.Windows.Forms.TextBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCekEmail = new System.Windows.Forms.TextBox();
            this.txtKodeDosen = new System.Windows.Forms.TextBox();
            this.txtJudul = new System.Windows.Forms.TextBox();
            this.txtDeskripsi = new System.Windows.Forms.TextBox();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.btnAjukan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWrong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).BeginInit();
            this.SuspendLayout();
            // 
            // epWarning
            // 
            this.epWarning.ContainerControl = this;
            this.epWarning.Icon = ((System.Drawing.Icon)(resources.GetObject("epWarning.Icon")));
            // 
            // epWrong
            // 
            this.epWrong.ContainerControl = this;
            this.epWrong.Icon = ((System.Drawing.Icon)(resources.GetObject("epWrong.Icon")));
            // 
            // epCorrect
            // 
            this.epCorrect.ContainerControl = this;
            this.epCorrect.Icon = ((System.Drawing.Icon)(resources.GetObject("epCorrect.Icon")));
            // 
            // NPM
            // 
            this.NPM.AutoSize = true;
            this.NPM.Location = new System.Drawing.Point(21, 33);
            this.NPM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NPM.Name = "NPM";
            this.NPM.Size = new System.Drawing.Size(48, 22);
            this.NPM.TabIndex = 0;
            this.NPM.Text = "NPM";
            // 
            // namaMhs
            // 
            this.namaMhs.AutoSize = true;
            this.namaMhs.Location = new System.Drawing.Point(21, 76);
            this.namaMhs.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.namaMhs.Name = "namaMhs";
            this.namaMhs.Size = new System.Drawing.Size(143, 22);
            this.namaMhs.TabIndex = 1;
            this.namaMhs.Text = "Nama Mahasiswa";
            // 
            // emailKampus
            // 
            this.emailKampus.AutoSize = true;
            this.emailKampus.Location = new System.Drawing.Point(21, 125);
            this.emailKampus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.emailKampus.Name = "emailKampus";
            this.emailKampus.Size = new System.Drawing.Size(116, 22);
            this.emailKampus.TabIndex = 2;
            this.emailKampus.Text = "Email Kampus";
            // 
            // konfirmasiEmail
            // 
            this.konfirmasiEmail.AutoSize = true;
            this.konfirmasiEmail.Location = new System.Drawing.Point(21, 170);
            this.konfirmasiEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.konfirmasiEmail.Name = "konfirmasiEmail";
            this.konfirmasiEmail.Size = new System.Drawing.Size(136, 22);
            this.konfirmasiEmail.TabIndex = 3;
            this.konfirmasiEmail.Text = "Konfirmasi Email";
            // 
            // kodeDosen
            // 
            this.kodeDosen.AutoSize = true;
            this.kodeDosen.Location = new System.Drawing.Point(21, 218);
            this.kodeDosen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.kodeDosen.Name = "kodeDosen";
            this.kodeDosen.Size = new System.Drawing.Size(200, 22);
            this.kodeDosen.TabIndex = 4;
            this.kodeDosen.Text = "Kode Dosen Pembimbing";
            // 
            // judul
            // 
            this.judul.AutoSize = true;
            this.judul.Location = new System.Drawing.Point(21, 265);
            this.judul.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.judul.Name = "judul";
            this.judul.Size = new System.Drawing.Size(120, 22);
            this.judul.TabIndex = 5;
            this.judul.Text = "Judul Proyek 2";
            // 
            // deskripsi
            // 
            this.deskripsi.AutoSize = true;
            this.deskripsi.Location = new System.Drawing.Point(21, 353);
            this.deskripsi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.deskripsi.Name = "deskripsi";
            this.deskripsi.Size = new System.Drawing.Size(137, 22);
            this.deskripsi.TabIndex = 6;
            this.deskripsi.Text = "Deskripsi Singkat";
            // 
            // link
            // 
            this.link.AutoSize = true;
            this.link.Location = new System.Drawing.Point(21, 311);
            this.link.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.link.Name = "link";
            this.link.Size = new System.Drawing.Size(151, 22);
            this.link.TabIndex = 7;
            this.link.Text = "Link Docs Proposal";
            // 
            // txtNPM
            // 
            this.txtNPM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNPM.Location = new System.Drawing.Point(228, 30);
            this.txtNPM.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtNPM.Name = "txtNPM";
            this.txtNPM.Size = new System.Drawing.Size(494, 29);
            this.txtNPM.TabIndex = 8;
            this.txtNPM.Leave += new System.EventHandler(this.txtNPM_Leave);
            // 
            // txtNama
            // 
            this.txtNama.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNama.Location = new System.Drawing.Point(228, 76);
            this.txtNama.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(494, 29);
            this.txtNama.TabIndex = 9;
            this.txtNama.Leave += new System.EventHandler(this.txtNama_Leave);
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.Location = new System.Drawing.Point(228, 121);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(494, 29);
            this.txtEmail.TabIndex = 10;
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // txtCekEmail
            // 
            this.txtCekEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCekEmail.Location = new System.Drawing.Point(228, 166);
            this.txtCekEmail.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtCekEmail.Name = "txtCekEmail";
            this.txtCekEmail.Size = new System.Drawing.Size(494, 29);
            this.txtCekEmail.TabIndex = 11;
            this.txtCekEmail.Leave += new System.EventHandler(this.txtCekEmail_Leave);
            // 
            // txtKodeDosen
            // 
            this.txtKodeDosen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKodeDosen.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtKodeDosen.Location = new System.Drawing.Point(228, 213);
            this.txtKodeDosen.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtKodeDosen.Name = "txtKodeDosen";
            this.txtKodeDosen.Size = new System.Drawing.Size(494, 29);
            this.txtKodeDosen.TabIndex = 12;
            this.txtKodeDosen.Leave += new System.EventHandler(this.txtKodeDosen_Leave);
            // 
            // txtJudul
            // 
            this.txtJudul.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtJudul.Location = new System.Drawing.Point(228, 260);
            this.txtJudul.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtJudul.Name = "txtJudul";
            this.txtJudul.Size = new System.Drawing.Size(494, 29);
            this.txtJudul.TabIndex = 13;
            this.txtJudul.Leave += new System.EventHandler(this.txtJudul_Leave);
            // 
            // txtDeskripsi
            // 
            this.txtDeskripsi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDeskripsi.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtDeskripsi.Location = new System.Drawing.Point(228, 355);
            this.txtDeskripsi.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtDeskripsi.Multiline = true;
            this.txtDeskripsi.Name = "txtDeskripsi";
            this.txtDeskripsi.Size = new System.Drawing.Size(494, 65);
            this.txtDeskripsi.TabIndex = 14;
            this.txtDeskripsi.Leave += new System.EventHandler(this.txtDeskripsi_Leave);
            // 
            // txtLink
            // 
            this.txtLink.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLink.Location = new System.Drawing.Point(228, 310);
            this.txtLink.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(494, 29);
            this.txtLink.TabIndex = 15;
            this.txtLink.Leave += new System.EventHandler(this.txtLink_Leave);
            // 
            // btnAjukan
            // 
            this.btnAjukan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAjukan.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAjukan.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnAjukan.Location = new System.Drawing.Point(228, 437);
            this.btnAjukan.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAjukan.Name = "btnAjukan";
            this.btnAjukan.Size = new System.Drawing.Size(493, 40);
            this.btnAjukan.TabIndex = 16;
            this.btnAjukan.Text = "Ajukan Judul";
            this.btnAjukan.UseVisualStyleBackColor = false;
            this.btnAjukan.Click += new System.EventHandler(this.btnAjukan_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(778, 489);
            this.Controls.Add(this.btnAjukan);
            this.Controls.Add(this.txtLink);
            this.Controls.Add(this.txtDeskripsi);
            this.Controls.Add(this.txtJudul);
            this.Controls.Add(this.txtKodeDosen);
            this.Controls.Add(this.txtCekEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.txtNPM);
            this.Controls.Add(this.link);
            this.Controls.Add(this.deskripsi);
            this.Controls.Add(this.judul);
            this.Controls.Add(this.kodeDosen);
            this.Controls.Add(this.konfirmasiEmail);
            this.Controls.Add(this.emailKampus);
            this.Controls.Add(this.namaMhs);
            this.Controls.Add(this.NPM);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Form1";
            this.Text = "Form Pengajuan Judul Proyek 2";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWrong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider epWarning;
        private System.Windows.Forms.ErrorProvider epWrong;
        private System.Windows.Forms.ErrorProvider epCorrect;
        private System.Windows.Forms.Label NPM;
        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.TextBox txtDeskripsi;
        private System.Windows.Forms.TextBox txtJudul;
        private System.Windows.Forms.TextBox txtKodeDosen;
        private System.Windows.Forms.TextBox txtCekEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtNPM;
        private System.Windows.Forms.Label link;
        private System.Windows.Forms.Label deskripsi;
        private System.Windows.Forms.Label judul;
        private System.Windows.Forms.Label kodeDosen;
        private System.Windows.Forms.Label konfirmasiEmail;
        private System.Windows.Forms.Label emailKampus;
        private System.Windows.Forms.Label namaMhs;
        private System.Windows.Forms.Button btnAjukan;
    }
}

