namespace Hastane_Yönetim_Sistemi
{
    partial class HastaDetay
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
            grpKisiBilgileri = new GroupBox();
            pnlKisiAccent = new Panel();
            lnkBilgilerimiGuncelle = new LinkLabel();
            lblKisiTelDeger = new Label();
            lblKisiTel = new Label();
            lblKisiAdSoyadDeger = new Label();
            lblKisiAdSoyad = new Label();
            lblKisiTcDeger = new Label();
            lblKisiTc = new Label();
            lblKisiBaslik = new Label();
            pnlKisiAlt = new Panel();
            grpAktifRandevular = new GroupBox();
            pnlAktifAlt = new Panel();
            pnlAktifAccent = new Panel();
            dgvAktifRandevular = new DataGridView();
            grpRandevuGecmisi = new GroupBox();
            pnlGecmisAlt = new Panel();
            pnlGecmisAccent = new Panel();
            dgvRandevuGecmisi = new DataGridView();
            grpRandevuAl = new GroupBox();
            pnlRandevuAlt = new Panel();
            pnlRandevuAccent = new Panel();
            lblRandevuBaslik = new Label();
            lblBrans = new Label();
            cmbBrans = new ComboBox();
            lblDoktor = new Label();
            cmbDoktor = new ComboBox();
            lblSikayet = new Label();
            txtSikayet = new TextBox();
            btnRandevuAl = new Button();
            grpKisiBilgileri.SuspendLayout();
            grpAktifRandevular.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAktifRandevular).BeginInit();
            grpRandevuGecmisi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRandevuGecmisi).BeginInit();
            grpRandevuAl.SuspendLayout();
            SuspendLayout();
            // 
            // grpKisiBilgileri
            // 
            grpKisiBilgileri.BackColor = Color.White;
            grpKisiBilgileri.Controls.Add(pnlKisiAccent);
            grpKisiBilgileri.Controls.Add(lnkBilgilerimiGuncelle);
            grpKisiBilgileri.Controls.Add(lblKisiTelDeger);
            grpKisiBilgileri.Controls.Add(lblKisiTel);
            grpKisiBilgileri.Controls.Add(lblKisiAdSoyadDeger);
            grpKisiBilgileri.Controls.Add(lblKisiAdSoyad);
            grpKisiBilgileri.Controls.Add(lblKisiTcDeger);
            grpKisiBilgileri.Controls.Add(lblKisiTc);
            grpKisiBilgileri.Controls.Add(lblKisiBaslik);
            grpKisiBilgileri.Controls.Add(pnlKisiAlt);
            grpKisiBilgileri.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            grpKisiBilgileri.ForeColor = Color.FromArgb(30, 58, 138);
            grpKisiBilgileri.Location = new Point(20, 20);
            grpKisiBilgileri.Name = "grpKisiBilgileri";
            grpKisiBilgileri.Size = new Size(360, 220);
            grpKisiBilgileri.TabIndex = 0;
            grpKisiBilgileri.TabStop = false;
            grpKisiBilgileri.Text = "  👤  Kişi Bilgileri";
            // 
            // pnlKisiAccent
            // 
            pnlKisiAccent.BackColor = Color.FromArgb(2, 132, 199);
            pnlKisiAccent.Dock = DockStyle.Top;
            pnlKisiAccent.Location = new Point(3, 26);
            pnlKisiAccent.Name = "pnlKisiAccent";
            pnlKisiAccent.Size = new Size(354, 3);
            pnlKisiAccent.TabIndex = 0;
            // 
            // lnkBilgilerimiGuncelle
            // 
            lnkBilgilerimiGuncelle.ActiveLinkColor = Color.FromArgb(3, 105, 161);
            lnkBilgilerimiGuncelle.AutoSize = true;
            lnkBilgilerimiGuncelle.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 162);
            lnkBilgilerimiGuncelle.LinkBehavior = LinkBehavior.HoverUnderline;
            lnkBilgilerimiGuncelle.LinkColor = Color.FromArgb(2, 132, 199);
            lnkBilgilerimiGuncelle.Location = new Point(223, 45);
            lnkBilgilerimiGuncelle.Name = "lnkBilgilerimiGuncelle";
            lnkBilgilerimiGuncelle.Size = new Size(134, 20);
            lnkBilgilerimiGuncelle.TabIndex = 9;
            lnkBilgilerimiGuncelle.TabStop = true;
            lnkBilgilerimiGuncelle.Text = "Bilgilerimi Güncelle";
            lnkBilgilerimiGuncelle.LinkClicked += lnkBilgilerimiGuncelle_LinkClicked;
            // 
            // lblKisiTelDeger
            // 
            lblKisiTelDeger.AutoSize = true;
            lblKisiTelDeger.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblKisiTelDeger.ForeColor = Color.FromArgb(15, 23, 42);
            lblKisiTelDeger.Location = new Point(120, 162);
            lblKisiTelDeger.Name = "lblKisiTelDeger";
            lblKisiTelDeger.Size = new Size(124, 25);
            lblKisiTelDeger.TabIndex = 10;
            lblKisiTelDeger.Text = "(----) --- ----";
            // 
            // lblKisiTel
            // 
            lblKisiTel.AutoSize = true;
            lblKisiTel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblKisiTel.ForeColor = Color.FromArgb(100, 116, 139);
            lblKisiTel.Location = new Point(20, 165);
            lblKisiTel.Name = "lblKisiTel";
            lblKisiTel.Size = new Size(75, 20);
            lblKisiTel.TabIndex = 11;
            lblKisiTel.Text = "TELEFON:";
            // 
            // lblKisiAdSoyadDeger
            // 
            lblKisiAdSoyadDeger.AutoSize = true;
            lblKisiAdSoyadDeger.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblKisiAdSoyadDeger.ForeColor = Color.FromArgb(15, 23, 42);
            lblKisiAdSoyadDeger.Location = new Point(120, 122);
            lblKisiAdSoyadDeger.Name = "lblKisiAdSoyadDeger";
            lblKisiAdSoyadDeger.Size = new Size(124, 25);
            lblKisiAdSoyadDeger.TabIndex = 12;
            lblKisiAdSoyadDeger.Text = "--------------";
            // 
            // lblKisiAdSoyad
            // 
            lblKisiAdSoyad.AutoSize = true;
            lblKisiAdSoyad.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblKisiAdSoyad.ForeColor = Color.FromArgb(100, 116, 139);
            lblKisiAdSoyad.Location = new Point(20, 125);
            lblKisiAdSoyad.Name = "lblKisiAdSoyad";
            lblKisiAdSoyad.Size = new Size(86, 20);
            lblKisiAdSoyad.TabIndex = 13;
            lblKisiAdSoyad.Text = "AD SOYAD:";
            // 
            // lblKisiTcDeger
            // 
            lblKisiTcDeger.AutoSize = true;
            lblKisiTcDeger.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblKisiTcDeger.ForeColor = Color.FromArgb(15, 23, 42);
            lblKisiTcDeger.Location = new Point(120, 82);
            lblKisiTcDeger.Name = "lblKisiTcDeger";
            lblKisiTcDeger.Size = new Size(92, 25);
            lblKisiTcDeger.TabIndex = 14;
            lblKisiTcDeger.Text = "----------";
            // 
            // lblKisiTc
            // 
            lblKisiTc.AutoSize = true;
            lblKisiTc.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblKisiTc.ForeColor = Color.FromArgb(100, 116, 139);
            lblKisiTc.Location = new Point(20, 85);
            lblKisiTc.Name = "lblKisiTc";
            lblKisiTc.Size = new Size(80, 20);
            lblKisiTc.TabIndex = 15;
            lblKisiTc.Text = "TC KİMLİK:";
            // 
            // lblKisiBaslik
            // 
            lblKisiBaslik.AutoSize = true;
            lblKisiBaslik.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblKisiBaslik.ForeColor = Color.FromArgb(100, 116, 139);
            lblKisiBaslik.Location = new Point(20, 45);
            lblKisiBaslik.Name = "lblKisiBaslik";
            lblKisiBaslik.Size = new Size(195, 20);
            lblKisiBaslik.TabIndex = 16;
            lblKisiBaslik.Text = "Giriş yapan kullanıcı bilgileri";
            // 
            // pnlKisiAlt
            // 
            pnlKisiAlt.BackColor = Color.FromArgb(241, 245, 249);
            pnlKisiAlt.Dock = DockStyle.Bottom;
            pnlKisiAlt.Location = new Point(3, 192);
            pnlKisiAlt.Name = "pnlKisiAlt";
            pnlKisiAlt.Size = new Size(354, 25);
            pnlKisiAlt.TabIndex = 8;
            // 
            // grpAktifRandevular
            // 
            grpAktifRandevular.BackColor = Color.White;
            grpAktifRandevular.Controls.Add(pnlAktifAlt);
            grpAktifRandevular.Controls.Add(pnlAktifAccent);
            grpAktifRandevular.Controls.Add(dgvAktifRandevular);
            grpAktifRandevular.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            grpAktifRandevular.ForeColor = Color.FromArgb(30, 58, 138);
            grpAktifRandevular.Location = new Point(400, 20);
            grpAktifRandevular.Name = "grpAktifRandevular";
            grpAktifRandevular.Size = new Size(670, 220);
            grpAktifRandevular.TabIndex = 2;
            grpAktifRandevular.TabStop = false;
            grpAktifRandevular.Text = "  📋  Aktif Randevular";
            // 
            // pnlAktifAlt
            // 
            pnlAktifAlt.BackColor = Color.FromArgb(241, 245, 249);
            pnlAktifAlt.Dock = DockStyle.Bottom;
            pnlAktifAlt.Location = new Point(3, 192);
            pnlAktifAlt.Name = "pnlAktifAlt";
            pnlAktifAlt.Size = new Size(664, 25);
            pnlAktifAlt.TabIndex = 1;
            // 
            // pnlAktifAccent
            // 
            pnlAktifAccent.BackColor = Color.FromArgb(2, 132, 199);
            pnlAktifAccent.Dock = DockStyle.Top;
            pnlAktifAccent.Location = new Point(3, 26);
            pnlAktifAccent.Name = "pnlAktifAccent";
            pnlAktifAccent.Size = new Size(664, 3);
            pnlAktifAccent.TabIndex = 0;
            // 
            // dgvAktifRandevular
            // 
            dgvAktifRandevular.AllowUserToAddRows = false;
            dgvAktifRandevular.AllowUserToDeleteRows = false;
            dgvAktifRandevular.BackgroundColor = Color.White;
            dgvAktifRandevular.BorderStyle = BorderStyle.None;
            dgvAktifRandevular.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvAktifRandevular.ColumnHeadersHeight = 29;
            dgvAktifRandevular.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvAktifRandevular.Dock = DockStyle.Fill;
            dgvAktifRandevular.Location = new Point(3, 26);
            dgvAktifRandevular.Margin = new Padding(0);
            dgvAktifRandevular.Name = "dgvAktifRandevular";
            dgvAktifRandevular.ReadOnly = true;
            dgvAktifRandevular.RowHeadersWidth = 51;
            dgvAktifRandevular.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvAktifRandevular.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAktifRandevular.Size = new Size(664, 191);
            dgvAktifRandevular.TabIndex = 2;
            // 
            // grpRandevuGecmisi
            // 
            grpRandevuGecmisi.BackColor = Color.White;
            grpRandevuGecmisi.Controls.Add(pnlGecmisAlt);
            grpRandevuGecmisi.Controls.Add(pnlGecmisAccent);
            grpRandevuGecmisi.Controls.Add(dgvRandevuGecmisi);
            grpRandevuGecmisi.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            grpRandevuGecmisi.ForeColor = Color.FromArgb(30, 58, 138);
            grpRandevuGecmisi.Location = new Point(400, 260);
            grpRandevuGecmisi.Name = "grpRandevuGecmisi";
            grpRandevuGecmisi.Size = new Size(670, 420);
            grpRandevuGecmisi.TabIndex = 3;
            grpRandevuGecmisi.TabStop = false;
            grpRandevuGecmisi.Text = "  📜  Randevu Geçmişi";
            // 
            // pnlGecmisAlt
            // 
            pnlGecmisAlt.BackColor = Color.FromArgb(241, 245, 249);
            pnlGecmisAlt.Dock = DockStyle.Bottom;
            pnlGecmisAlt.Location = new Point(3, 392);
            pnlGecmisAlt.Name = "pnlGecmisAlt";
            pnlGecmisAlt.Size = new Size(664, 25);
            pnlGecmisAlt.TabIndex = 1;
            // 
            // pnlGecmisAccent
            // 
            pnlGecmisAccent.BackColor = Color.FromArgb(2, 132, 199);
            pnlGecmisAccent.Dock = DockStyle.Top;
            pnlGecmisAccent.Location = new Point(3, 26);
            pnlGecmisAccent.Name = "pnlGecmisAccent";
            pnlGecmisAccent.Size = new Size(664, 3);
            pnlGecmisAccent.TabIndex = 0;
            // 
            // dgvRandevuGecmisi
            // 
            dgvRandevuGecmisi.AllowUserToAddRows = false;
            dgvRandevuGecmisi.AllowUserToDeleteRows = false;
            dgvRandevuGecmisi.BackgroundColor = Color.White;
            dgvRandevuGecmisi.BorderStyle = BorderStyle.None;
            dgvRandevuGecmisi.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvRandevuGecmisi.ColumnHeadersHeight = 29;
            dgvRandevuGecmisi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvRandevuGecmisi.Dock = DockStyle.Fill;
            dgvRandevuGecmisi.Location = new Point(3, 26);
            dgvRandevuGecmisi.Margin = new Padding(0);
            dgvRandevuGecmisi.Name = "dgvRandevuGecmisi";
            dgvRandevuGecmisi.ReadOnly = true;
            dgvRandevuGecmisi.RowHeadersWidth = 51;
            dgvRandevuGecmisi.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvRandevuGecmisi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRandevuGecmisi.Size = new Size(664, 391);
            dgvRandevuGecmisi.TabIndex = 2;
            // 
            // grpRandevuAl
            // 
            grpRandevuAl.BackColor = Color.White;
            grpRandevuAl.Controls.Add(pnlRandevuAlt);
            grpRandevuAl.Controls.Add(pnlRandevuAccent);
            grpRandevuAl.Controls.Add(lblRandevuBaslik);
            grpRandevuAl.Controls.Add(lblBrans);
            grpRandevuAl.Controls.Add(cmbBrans);
            grpRandevuAl.Controls.Add(lblDoktor);
            grpRandevuAl.Controls.Add(cmbDoktor);
            grpRandevuAl.Controls.Add(lblSikayet);
            grpRandevuAl.Controls.Add(txtSikayet);
            grpRandevuAl.Controls.Add(btnRandevuAl);
            grpRandevuAl.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            grpRandevuAl.ForeColor = Color.FromArgb(30, 58, 138);
            grpRandevuAl.Location = new Point(20, 260);
            grpRandevuAl.Name = "grpRandevuAl";
            grpRandevuAl.Size = new Size(360, 420);
            grpRandevuAl.TabIndex = 1;
            grpRandevuAl.TabStop = false;
            grpRandevuAl.Text = "  📅  Randevu Al";
            // 
            // pnlRandevuAlt
            // 
            pnlRandevuAlt.BackColor = Color.FromArgb(241, 245, 249);
            pnlRandevuAlt.Dock = DockStyle.Bottom;
            pnlRandevuAlt.Location = new Point(3, 392);
            pnlRandevuAlt.Name = "pnlRandevuAlt";
            pnlRandevuAlt.Size = new Size(354, 25);
            pnlRandevuAlt.TabIndex = 0;
            // 
            // pnlRandevuAccent
            // 
            pnlRandevuAccent.BackColor = Color.FromArgb(2, 132, 199);
            pnlRandevuAccent.Dock = DockStyle.Top;
            pnlRandevuAccent.Location = new Point(3, 26);
            pnlRandevuAccent.Name = "pnlRandevuAccent";
            pnlRandevuAccent.Size = new Size(354, 3);
            pnlRandevuAccent.TabIndex = 0;
            // 
            // lblRandevuBaslik
            // 
            lblRandevuBaslik.AutoSize = true;
            lblRandevuBaslik.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblRandevuBaslik.ForeColor = Color.FromArgb(100, 116, 139);
            lblRandevuBaslik.Location = new Point(20, 45);
            lblRandevuBaslik.Name = "lblRandevuBaslik";
            lblRandevuBaslik.Size = new Size(210, 20);
            lblRandevuBaslik.TabIndex = 1;
            lblRandevuBaslik.Text = "Branş seçimi, doktor ve şikayet";
            // 
            // lblBrans
            // 
            lblBrans.AutoSize = true;
            lblBrans.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblBrans.ForeColor = Color.FromArgb(51, 65, 85);
            lblBrans.Location = new Point(20, 85);
            lblBrans.Name = "lblBrans";
            lblBrans.Size = new Size(56, 23);
            lblBrans.TabIndex = 2;
            lblBrans.Text = "Branş:";
            // 
            // cmbBrans
            // 
            cmbBrans.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBrans.FlatStyle = FlatStyle.Flat;
            cmbBrans.Font = new Font("Segoe UI", 10F);
            cmbBrans.FormattingEnabled = true;
            cmbBrans.Location = new Point(110, 82);
            cmbBrans.Name = "cmbBrans";
            cmbBrans.Size = new Size(230, 31);
            cmbBrans.TabIndex = 1;
            // 
            // lblDoktor
            // 
            lblDoktor.AutoSize = true;
            lblDoktor.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblDoktor.ForeColor = Color.FromArgb(51, 65, 85);
            lblDoktor.Location = new Point(20, 135);
            lblDoktor.Name = "lblDoktor";
            lblDoktor.Size = new Size(68, 23);
            lblDoktor.TabIndex = 3;
            lblDoktor.Text = "Doktor:";
            // 
            // cmbDoktor
            // 
            cmbDoktor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDoktor.FlatStyle = FlatStyle.Flat;
            cmbDoktor.Font = new Font("Segoe UI", 10F);
            cmbDoktor.FormattingEnabled = true;
            cmbDoktor.Location = new Point(110, 132);
            cmbDoktor.Name = "cmbDoktor";
            cmbDoktor.Size = new Size(230, 31);
            cmbDoktor.TabIndex = 2;
            // 
            // lblSikayet
            // 
            lblSikayet.AutoSize = true;
            lblSikayet.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblSikayet.ForeColor = Color.FromArgb(51, 65, 85);
            lblSikayet.Location = new Point(20, 185);
            lblSikayet.Name = "lblSikayet";
            lblSikayet.Size = new Size(69, 23);
            lblSikayet.TabIndex = 4;
            lblSikayet.Text = "Şikayet:";
            // 
            // txtSikayet
            // 
            txtSikayet.BorderStyle = BorderStyle.FixedSingle;
            txtSikayet.Font = new Font("Segoe UI", 10F);
            txtSikayet.Location = new Point(20, 215);
            txtSikayet.Multiline = true;
            txtSikayet.Name = "txtSikayet";
            txtSikayet.ScrollBars = ScrollBars.Vertical;
            txtSikayet.Size = new Size(320, 110);
            txtSikayet.TabIndex = 3;
            // 
            // btnRandevuAl
            // 
            btnRandevuAl.BackColor = Color.FromArgb(2, 132, 199);
            btnRandevuAl.Cursor = Cursors.Hand;
            btnRandevuAl.FlatAppearance.BorderSize = 0;
            btnRandevuAl.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 58, 138);
            btnRandevuAl.FlatAppearance.MouseOverBackColor = Color.FromArgb(3, 105, 161);
            btnRandevuAl.FlatStyle = FlatStyle.Flat;
            btnRandevuAl.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnRandevuAl.ForeColor = Color.White;
            btnRandevuAl.Location = new Point(20, 331);
            btnRandevuAl.Name = "btnRandevuAl";
            btnRandevuAl.Size = new Size(320, 44);
            btnRandevuAl.TabIndex = 5;
            btnRandevuAl.Text = "Randevu Al";
            btnRandevuAl.UseVisualStyleBackColor = false;
            btnRandevuAl.Click += btnRandevuAl_Click;
            // 
            // HastaDetay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 247, 246);
            ClientSize = new Size(1100, 700);
            Controls.Add(grpAktifRandevular);
            Controls.Add(grpRandevuGecmisi);
            Controls.Add(grpRandevuAl);
            Controls.Add(grpKisiBilgileri);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "HastaDetay";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hasta Detay Paneli";
            Load += HastaDetay_Load;
            grpKisiBilgileri.ResumeLayout(false);
            grpKisiBilgileri.PerformLayout();
            grpAktifRandevular.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAktifRandevular).EndInit();
            grpRandevuGecmisi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRandevuGecmisi).EndInit();
            grpRandevuAl.ResumeLayout(false);
            grpRandevuAl.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        public GroupBox grpKisiBilgileri;
        public Panel pnlKisiAccent;
        public Panel pnlKisiAlt;
        public Label lblKisiBaslik;
        public Label lblKisiTc;
        public Label lblKisiTcDeger;
        public Label lblKisiAdSoyad;
        public Label lblKisiAdSoyadDeger;
        public Label lblKisiTel;
        public Label lblKisiTelDeger;
        public LinkLabel lnkBilgilerimiGuncelle;
        public GroupBox grpRandevuAl;
        public Panel pnlRandevuAccent;
        public Panel pnlRandevuAlt;
        public Label lblRandevuBaslik;
        public Label lblBrans;
        public ComboBox cmbBrans;
        public Label lblDoktor;
        public ComboBox cmbDoktor;
        public Label lblSikayet;
        public TextBox txtSikayet;
        public Button btnRandevuAl;
        public GroupBox grpAktifRandevular;
        public Panel pnlAktifAccent;
        public Panel pnlAktifAlt;
        public Label lblAktifBaslik;
        public DataGridView dgvAktifRandevular;
        public GroupBox grpRandevuGecmisi;
        public Panel pnlGecmisAccent;
        public Panel pnlGecmisAlt;
        public Label lblGecmisBaslik;
        public DataGridView dgvRandevuGecmisi;
    }
}