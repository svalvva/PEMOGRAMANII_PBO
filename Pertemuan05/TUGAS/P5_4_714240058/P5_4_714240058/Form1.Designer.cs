namespace P5_4_714240058
{
    partial class FormPendaftaran
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
            this.labelNama = new System.Windows.Forms.Label();
            this.labelJK = new System.Windows.Forms.Label();
            this.labelTL = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.cbJenisKelamin = new System.Windows.Forms.ComboBox();
            this.dtpTanggalLahir = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkPanahan = new System.Windows.Forms.CheckBox();
            this.chkVoli = new System.Windows.Forms.CheckBox();
            this.chkBuluTangkis = new System.Windows.Forms.CheckBox();
            this.chkBasket = new System.Windows.Forms.CheckBox();
            this.chkYoga = new System.Windows.Forms.CheckBox();
            this.chkTenis = new System.Windows.Forms.CheckBox();
            this.chkRenang = new System.Windows.Forms.CheckBox();
            this.chkSepakBola = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbMinggu = new System.Windows.Forms.RadioButton();
            this.rbSabtu = new System.Windows.Forms.RadioButton();
            this.rbSelasa = new System.Windows.Forms.RadioButton();
            this.rbSenin = new System.Windows.Forms.RadioButton();
            this.btnTampilkan = new System.Windows.Forms.Button();
            this.btnSelesai = new System.Windows.Forms.Button();
            this.labelFP = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNama
            // 
            this.labelNama.AutoSize = true;
            this.labelNama.Location = new System.Drawing.Point(216, 75);
            this.labelNama.Name = "labelNama";
            this.labelNama.Size = new System.Drawing.Size(51, 20);
            this.labelNama.TabIndex = 0;
            this.labelNama.Text = "Nama";
            // 
            // labelJK
            // 
            this.labelJK.AutoSize = true;
            this.labelJK.Location = new System.Drawing.Point(216, 121);
            this.labelJK.Name = "labelJK";
            this.labelJK.Size = new System.Drawing.Size(106, 20);
            this.labelJK.TabIndex = 1;
            this.labelJK.Text = "Jenis Kelamin";
            // 
            // labelTL
            // 
            this.labelTL.AutoSize = true;
            this.labelTL.Location = new System.Drawing.Point(216, 175);
            this.labelTL.Name = "labelTL";
            this.labelTL.Size = new System.Drawing.Size(105, 20);
            this.labelTL.TabIndex = 2;
            this.labelTL.Text = "Tanggal Lahir";
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(335, 72);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(281, 26);
            this.txtNama.TabIndex = 0;
            // 
            // cbJenisKelamin
            // 
            this.cbJenisKelamin.FormattingEnabled = true;
            this.cbJenisKelamin.Items.AddRange(new object[] {
            "Pria",
            "Wanita"});
            this.cbJenisKelamin.Location = new System.Drawing.Point(335, 118);
            this.cbJenisKelamin.Name = "cbJenisKelamin";
            this.cbJenisKelamin.Size = new System.Drawing.Size(281, 28);
            this.cbJenisKelamin.TabIndex = 3;
            this.cbJenisKelamin.Text = "---Pilih Jenis Kelamin---";
            // 
            // dtpTanggalLahir
            // 
            this.dtpTanggalLahir.Location = new System.Drawing.Point(335, 171);
            this.dtpTanggalLahir.Name = "dtpTanggalLahir";
            this.dtpTanggalLahir.Size = new System.Drawing.Size(281, 26);
            this.dtpTanggalLahir.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkPanahan);
            this.groupBox1.Controls.Add(this.chkVoli);
            this.groupBox1.Controls.Add(this.chkBuluTangkis);
            this.groupBox1.Controls.Add(this.chkBasket);
            this.groupBox1.Controls.Add(this.chkYoga);
            this.groupBox1.Controls.Add(this.chkTenis);
            this.groupBox1.Controls.Add(this.chkRenang);
            this.groupBox1.Controls.Add(this.chkSepakBola);
            this.groupBox1.Location = new System.Drawing.Point(55, 218);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 161);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pilihan Kelas";
            // 
            // chkPanahan
            // 
            this.chkPanahan.AutoSize = true;
            this.chkPanahan.Location = new System.Drawing.Point(179, 115);
            this.chkPanahan.Name = "chkPanahan";
            this.chkPanahan.Size = new System.Drawing.Size(99, 24);
            this.chkPanahan.TabIndex = 7;
            this.chkPanahan.Text = "Panahan";
            this.chkPanahan.UseVisualStyleBackColor = true;
            this.chkPanahan.CheckedChanged += new System.EventHandler(this.checkBox8_CheckedChanged);
            // 
            // chkVoli
            // 
            this.chkVoli.AutoSize = true;
            this.chkVoli.Location = new System.Drawing.Point(179, 85);
            this.chkVoli.Name = "chkVoli";
            this.chkVoli.Size = new System.Drawing.Size(61, 24);
            this.chkVoli.TabIndex = 6;
            this.chkVoli.Text = "Voli";
            this.chkVoli.UseVisualStyleBackColor = true;
            // 
            // chkBuluTangkis
            // 
            this.chkBuluTangkis.AutoSize = true;
            this.chkBuluTangkis.Location = new System.Drawing.Point(179, 55);
            this.chkBuluTangkis.Name = "chkBuluTangkis";
            this.chkBuluTangkis.Size = new System.Drawing.Size(117, 24);
            this.chkBuluTangkis.TabIndex = 5;
            this.chkBuluTangkis.Text = "Bulu Tagkis";
            this.chkBuluTangkis.UseVisualStyleBackColor = true;
            // 
            // chkBasket
            // 
            this.chkBasket.AutoSize = true;
            this.chkBasket.Location = new System.Drawing.Point(179, 25);
            this.chkBasket.Name = "chkBasket";
            this.chkBasket.Size = new System.Drawing.Size(85, 24);
            this.chkBasket.TabIndex = 4;
            this.chkBasket.Text = "Basket";
            this.chkBasket.UseVisualStyleBackColor = true;
            // 
            // chkYoga
            // 
            this.chkYoga.AutoSize = true;
            this.chkYoga.Location = new System.Drawing.Point(22, 115);
            this.chkYoga.Name = "chkYoga";
            this.chkYoga.Size = new System.Drawing.Size(73, 24);
            this.chkYoga.TabIndex = 3;
            this.chkYoga.Text = "Yoga";
            this.chkYoga.UseVisualStyleBackColor = true;
            // 
            // chkTenis
            // 
            this.chkTenis.AutoSize = true;
            this.chkTenis.Location = new System.Drawing.Point(22, 85);
            this.chkTenis.Name = "chkTenis";
            this.chkTenis.Size = new System.Drawing.Size(73, 24);
            this.chkTenis.TabIndex = 2;
            this.chkTenis.Text = "Tenis";
            this.chkTenis.UseVisualStyleBackColor = true;
            // 
            // chkRenang
            // 
            this.chkRenang.AutoSize = true;
            this.chkRenang.Location = new System.Drawing.Point(22, 55);
            this.chkRenang.Name = "chkRenang";
            this.chkRenang.Size = new System.Drawing.Size(92, 24);
            this.chkRenang.TabIndex = 1;
            this.chkRenang.Text = "Renang";
            this.chkRenang.UseVisualStyleBackColor = true;
            // 
            // chkSepakBola
            // 
            this.chkSepakBola.AutoSize = true;
            this.chkSepakBola.Location = new System.Drawing.Point(22, 25);
            this.chkSepakBola.Name = "chkSepakBola";
            this.chkSepakBola.Size = new System.Drawing.Size(117, 24);
            this.chkSepakBola.TabIndex = 0;
            this.chkSepakBola.Text = "Sepak Bola";
            this.chkSepakBola.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbMinggu);
            this.groupBox2.Controls.Add(this.rbSabtu);
            this.groupBox2.Controls.Add(this.rbSelasa);
            this.groupBox2.Controls.Add(this.rbSenin);
            this.groupBox2.Location = new System.Drawing.Point(406, 218);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(314, 161);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pilihan Jadwal";
            // 
            // rbMinggu
            // 
            this.rbMinggu.AutoSize = true;
            this.rbMinggu.Location = new System.Drawing.Point(23, 118);
            this.rbMinggu.Name = "rbMinggu";
            this.rbMinggu.Size = new System.Drawing.Size(187, 24);
            this.rbMinggu.TabIndex = 3;
            this.rbMinggu.TabStop = true;
            this.rbMinggu.Text = "Minggu, 13.00 - 20.00";
            this.rbMinggu.UseVisualStyleBackColor = true;
            // 
            // rbSabtu
            // 
            this.rbSabtu.AutoSize = true;
            this.rbSabtu.Location = new System.Drawing.Point(23, 88);
            this.rbSabtu.Name = "rbSabtu";
            this.rbSabtu.Size = new System.Drawing.Size(259, 24);
            this.rbSabtu.TabIndex = 2;
            this.rbSabtu.TabStop = true;
            this.rbSabtu.Text = "Sabtu s/d Minggu, 09.00 - 11.00";
            this.rbSabtu.UseVisualStyleBackColor = true;
            // 
            // rbSelasa
            // 
            this.rbSelasa.AutoSize = true;
            this.rbSelasa.Location = new System.Drawing.Point(23, 58);
            this.rbSelasa.Name = "rbSelasa";
            this.rbSelasa.Size = new System.Drawing.Size(256, 24);
            this.rbSelasa.TabIndex = 1;
            this.rbSelasa.TabStop = true;
            this.rbSelasa.Text = "Selasa s/d Kamis, 14.00 - 16.00";
            this.rbSelasa.UseVisualStyleBackColor = true;
            // 
            // rbSenin
            // 
            this.rbSenin.AutoSize = true;
            this.rbSenin.Location = new System.Drawing.Point(23, 28);
            this.rbSenin.Name = "rbSenin";
            this.rbSenin.Size = new System.Drawing.Size(244, 24);
            this.rbSenin.TabIndex = 0;
            this.rbSenin.TabStop = true;
            this.rbSenin.Text = "Senin s/d Rabu, 14.00 - 16.00";
            this.rbSenin.UseVisualStyleBackColor = true;
            // 
            // btnTampilkan
            // 
            this.btnTampilkan.Location = new System.Drawing.Point(254, 397);
            this.btnTampilkan.Name = "btnTampilkan";
            this.btnTampilkan.Size = new System.Drawing.Size(115, 47);
            this.btnTampilkan.TabIndex = 7;
            this.btnTampilkan.Text = "Tampilkan";
            this.btnTampilkan.UseVisualStyleBackColor = true;
            this.btnTampilkan.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSelesai
            // 
            this.btnSelesai.Location = new System.Drawing.Point(406, 397);
            this.btnSelesai.Name = "btnSelesai";
            this.btnSelesai.Size = new System.Drawing.Size(115, 47);
            this.btnSelesai.TabIndex = 8;
            this.btnSelesai.Text = "Selesai";
            this.btnSelesai.UseVisualStyleBackColor = true;
            this.btnSelesai.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelFP
            // 
            this.labelFP.AutoSize = true;
            this.labelFP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFP.Location = new System.Drawing.Point(291, 25);
            this.labelFP.Name = "labelFP";
            this.labelFP.Size = new System.Drawing.Size(239, 25);
            this.labelFP.TabIndex = 9;
            this.labelFP.Text = "FORM PENDAFTARAN";
            this.labelFP.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FormPendaftaran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(801, 462);
            this.Controls.Add(this.labelFP);
            this.Controls.Add(this.btnSelesai);
            this.Controls.Add(this.btnTampilkan);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtpTanggalLahir);
            this.Controls.Add(this.cbJenisKelamin);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.labelTL);
            this.Controls.Add(this.labelJK);
            this.Controls.Add(this.labelNama);
            this.Name = "FormPendaftaran";
            this.Text = "ULBI SPORT SCHOOL";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNama;
        private System.Windows.Forms.Label labelJK;
        private System.Windows.Forms.Label labelTL;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.ComboBox cbJenisKelamin;
        private System.Windows.Forms.DateTimePicker dtpTanggalLahir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbSelasa;
        private System.Windows.Forms.RadioButton rbSenin;
        private System.Windows.Forms.CheckBox chkPanahan;
        private System.Windows.Forms.CheckBox chkVoli;
        private System.Windows.Forms.CheckBox chkBuluTangkis;
        private System.Windows.Forms.CheckBox chkBasket;
        private System.Windows.Forms.CheckBox chkYoga;
        private System.Windows.Forms.CheckBox chkTenis;
        private System.Windows.Forms.CheckBox chkRenang;
        private System.Windows.Forms.CheckBox chkSepakBola;
        private System.Windows.Forms.RadioButton rbMinggu;
        private System.Windows.Forms.RadioButton rbSabtu;
        private System.Windows.Forms.Button btnTampilkan;
        private System.Windows.Forms.Button btnSelesai;
        private System.Windows.Forms.Label labelFP;
    }
}

