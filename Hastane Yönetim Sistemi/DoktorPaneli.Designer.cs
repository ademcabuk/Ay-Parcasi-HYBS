namespace Hastane_Yönetim_Sistemi
{
    partial class DoktorPaneli
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
            grpDoktorIslemleri = new GroupBox();
            pnlIslemAccent = new Panel();
            pnlIslemAlt = new Panel();
            btnGuncelle = new Button();
            btnSil = new Button();
            btnEkle = new Button();
            txtSifre = new TextBox();
            lblSifre = new Label();
            txtTC = new TextBox();
            lblTC = new Label();
            cmbBrans = new ComboBox();
            lblBrans = new Label();
            txtSoyad = new TextBox();
            lblSoyad = new Label();
            txtAd = new TextBox();
            lblAd = new Label();
            grpDoktorListe = new GroupBox();
            pnlListeAccent = new Panel();
            pnlListeAlt = new Panel();
            dgvDoktorlar = new DataGridView();
            grpDoktorIslemleri.SuspendLayout();
            grpDoktorListe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDoktorlar).BeginInit();
            SuspendLayout();
            // 
            // grpDoktorIslemleri
            // 
            grpDoktorIslemleri.BackColor = Color.White;
            grpDoktorIslemleri.Controls.Add(pnlIslemAccent);
            grpDoktorIslemleri.Controls.Add(pnlIslemAlt);
            grpDoktorIslemleri.Controls.Add(btnGuncelle);
            grpDoktorIslemleri.Controls.Add(btnSil);
            grpDoktorIslemleri.Controls.Add(btnEkle);
            grpDoktorIslemleri.Controls.Add(txtSifre);
            grpDoktorIslemleri.Controls.Add(lblSifre);
            grpDoktorIslemleri.Controls.Add(txtTC);
            grpDoktorIslemleri.Controls.Add(lblTC);
            grpDoktorIslemleri.Controls.Add(cmbBrans);
            grpDoktorIslemleri.Controls.Add(lblBrans);
            grpDoktorIslemleri.Controls.Add(txtSoyad);
            grpDoktorIslemleri.Controls.Add(lblSoyad);
            grpDoktorIslemleri.Controls.Add(txtAd);
            grpDoktorIslemleri.Controls.Add(lblAd);
            grpDoktorIslemleri.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            grpDoktorIslemleri.ForeColor = Color.FromArgb(17, 94, 89);
            grpDoktorIslemleri.Location = new Point(20, 20);
            grpDoktorIslemleri.Name = "grpDoktorIslemleri";
            grpDoktorIslemleri.Size = new Size(380, 391);
            grpDoktorIslemleri.TabIndex = 0;
            grpDoktorIslemleri.TabStop = false;
            grpDoktorIslemleri.Text = "  👨‍⚕️  Doktor İşlemleri";
            // 
            // pnlIslemAccent
            // 
            pnlIslemAccent.BackColor = Color.FromArgb(13, 148, 136);
            pnlIslemAccent.Dock = DockStyle.Top;
            pnlIslemAccent.Location = new Point(3, 26);
            pnlIslemAccent.Name = "pnlIslemAccent";
            pnlIslemAccent.Size = new Size(374, 3);
            pnlIslemAccent.TabIndex = 0;
            // 
            // pnlIslemAlt
            // 
            pnlIslemAlt.BackColor = Color.FromArgb(236, 253, 245);
            pnlIslemAlt.Dock = DockStyle.Bottom;
            pnlIslemAlt.Location = new Point(3, 363);
            pnlIslemAlt.Name = "pnlIslemAlt";
            pnlIslemAlt.Size = new Size(374, 25);
            pnlIslemAlt.TabIndex = 0;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.FromArgb(236, 253, 245);
            btnGuncelle.Cursor = Cursors.Hand;
            btnGuncelle.FlatAppearance.BorderColor = Color.FromArgb(167, 243, 208);
            btnGuncelle.FlatAppearance.MouseOverBackColor = Color.FromArgb(209, 250, 229);
            btnGuncelle.FlatStyle = FlatStyle.Flat;
            btnGuncelle.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnGuncelle.ForeColor = Color.FromArgb(17, 94, 89);
            btnGuncelle.Location = new Point(88, 316);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(225, 35);
            btnGuncelle.TabIndex = 12;
            btnGuncelle.Text = "✏️ Güncelle";
            btnGuncelle.UseVisualStyleBackColor = false;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.FromArgb(236, 253, 245);
            btnSil.Cursor = Cursors.Hand;
            btnSil.FlatAppearance.BorderColor = Color.FromArgb(167, 243, 208);
            btnSil.FlatAppearance.MouseOverBackColor = Color.FromArgb(209, 250, 229);
            btnSil.FlatStyle = FlatStyle.Flat;
            btnSil.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnSil.ForeColor = Color.FromArgb(17, 94, 89);
            btnSil.Location = new Point(208, 260);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(105, 35);
            btnSil.TabIndex = 11;
            btnSil.Text = "🗑️ Sil";
            btnSil.UseVisualStyleBackColor = false;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.FromArgb(13, 148, 136);
            btnEkle.Cursor = Cursors.Hand;
            btnEkle.FlatAppearance.BorderSize = 0;
            btnEkle.FlatAppearance.MouseDownBackColor = Color.FromArgb(17, 94, 89);
            btnEkle.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 184, 166);
            btnEkle.FlatStyle = FlatStyle.Flat;
            btnEkle.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnEkle.ForeColor = Color.White;
            btnEkle.Location = new Point(88, 260);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(105, 35);
            btnEkle.TabIndex = 10;
            btnEkle.Text = "➕ Ekle";
            btnEkle.UseVisualStyleBackColor = false;
            // 
            // txtSifre
            // 
            txtSifre.BorderStyle = BorderStyle.FixedSingle;
            txtSifre.Font = new Font("Segoe UI", 10F);
            txtSifre.Location = new Point(120, 207);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(230, 30);
            txtSifre.TabIndex = 9;
            txtSifre.UseSystemPasswordChar = true;
            // 
            // lblSifre
            // 
            lblSifre.AutoSize = true;
            lblSifre.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblSifre.ForeColor = Color.FromArgb(51, 65, 85);
            lblSifre.Location = new Point(20, 210);
            lblSifre.Name = "lblSifre";
            lblSifre.Size = new Size(48, 23);
            lblSifre.TabIndex = 8;
            lblSifre.Text = "Şifre:";
            // 
            // txtTC
            // 
            txtTC.BorderStyle = BorderStyle.FixedSingle;
            txtTC.Font = new Font("Segoe UI", 10F);
            txtTC.Location = new Point(120, 167);
            txtTC.Name = "txtTC";
            txtTC.Size = new Size(230, 30);
            txtTC.TabIndex = 7;
            // 
            // lblTC
            // 
            lblTC.AutoSize = true;
            lblTC.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblTC.ForeColor = Color.FromArgb(51, 65, 85);
            lblTC.Location = new Point(20, 170);
            lblTC.Name = "lblTC";
            lblTC.Size = new Size(33, 23);
            lblTC.TabIndex = 6;
            lblTC.Text = "TC:";
            // 
            // cmbBrans
            // 
            cmbBrans.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBrans.Font = new Font("Segoe UI", 10F);
            cmbBrans.FormattingEnabled = true;
            cmbBrans.Location = new Point(120, 127);
            cmbBrans.Name = "cmbBrans";
            cmbBrans.Size = new Size(230, 31);
            cmbBrans.TabIndex = 5;
            // 
            // lblBrans
            // 
            lblBrans.AutoSize = true;
            lblBrans.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblBrans.ForeColor = Color.FromArgb(51, 65, 85);
            lblBrans.Location = new Point(20, 130);
            lblBrans.Name = "lblBrans";
            lblBrans.Size = new Size(56, 23);
            lblBrans.TabIndex = 4;
            lblBrans.Text = "Branş:";
            // 
            // txtSoyad
            // 
            txtSoyad.BorderStyle = BorderStyle.FixedSingle;
            txtSoyad.Font = new Font("Segoe UI", 10F);
            txtSoyad.Location = new Point(120, 87);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(230, 30);
            txtSoyad.TabIndex = 3;
            // 
            // lblSoyad
            // 
            lblSoyad.AutoSize = true;
            lblSoyad.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblSoyad.ForeColor = Color.FromArgb(51, 65, 85);
            lblSoyad.Location = new Point(20, 90);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Size = new Size(61, 23);
            lblSoyad.TabIndex = 2;
            lblSoyad.Text = "Soyad:";
            // 
            // txtAd
            // 
            txtAd.BorderStyle = BorderStyle.FixedSingle;
            txtAd.Font = new Font("Segoe UI", 10F);
            txtAd.Location = new Point(120, 47);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(230, 30);
            txtAd.TabIndex = 1;
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblAd.ForeColor = Color.FromArgb(51, 65, 85);
            lblAd.Location = new Point(20, 50);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(35, 23);
            lblAd.TabIndex = 0;
            lblAd.Text = "Ad:";
            // 
            // grpDoktorListe
            // 
            grpDoktorListe.BackColor = Color.White;
            grpDoktorListe.Controls.Add(pnlListeAccent);
            grpDoktorListe.Controls.Add(pnlListeAlt);
            grpDoktorListe.Controls.Add(dgvDoktorlar);
            grpDoktorListe.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            grpDoktorListe.ForeColor = Color.FromArgb(17, 94, 89);
            grpDoktorListe.Location = new Point(410, 20);
            grpDoktorListe.Name = "grpDoktorListe";
            grpDoktorListe.Size = new Size(628, 391);
            grpDoktorListe.TabIndex = 1;
            grpDoktorListe.TabStop = false;
            grpDoktorListe.Text = "  📋  Doktor Listesi";
            // 
            // pnlListeAccent
            // 
            pnlListeAccent.BackColor = Color.FromArgb(13, 148, 136);
            pnlListeAccent.Dock = DockStyle.Top;
            pnlListeAccent.Location = new Point(3, 26);
            pnlListeAccent.Name = "pnlListeAccent";
            pnlListeAccent.Size = new Size(622, 3);
            pnlListeAccent.TabIndex = 0;
            // 
            // pnlListeAlt
            // 
            pnlListeAlt.BackColor = Color.FromArgb(236, 253, 245);
            pnlListeAlt.Dock = DockStyle.Bottom;
            pnlListeAlt.Location = new Point(3, 363);
            pnlListeAlt.Name = "pnlListeAlt";
            pnlListeAlt.Size = new Size(622, 25);
            pnlListeAlt.TabIndex = 0;
            // 
            // dgvDoktorlar
            // 
            dgvDoktorlar.AllowUserToAddRows = false;
            dgvDoktorlar.AllowUserToDeleteRows = false;
            dgvDoktorlar.BackgroundColor = Color.White;
            dgvDoktorlar.BorderStyle = BorderStyle.None;
            dgvDoktorlar.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvDoktorlar.ColumnHeadersHeight = 29;
            dgvDoktorlar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvDoktorlar.Dock = DockStyle.Fill;
            dgvDoktorlar.Location = new Point(3, 26);
            dgvDoktorlar.Margin = new Padding(0);
            dgvDoktorlar.Name = "dgvDoktorlar";
            dgvDoktorlar.ReadOnly = true;
            dgvDoktorlar.RowHeadersWidth = 51;
            dgvDoktorlar.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvDoktorlar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDoktorlar.Size = new Size(622, 362);
            dgvDoktorlar.TabIndex = 2;
            // 
            // DoktorPaneli
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 253, 245);
            ClientSize = new Size(1047, 421);
            Controls.Add(grpDoktorListe);
            Controls.Add(grpDoktorIslemleri);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "DoktorPaneli";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Doktor Paneli";
            grpDoktorIslemleri.ResumeLayout(false);
            grpDoktorIslemleri.PerformLayout();
            grpDoktorListe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDoktorlar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpDoktorIslemleri;
        private Panel pnlIslemAccent;
        private Panel pnlIslemAlt;
        private Label lblAd;
        private TextBox txtAd;
        private Label lblSoyad;
        private TextBox txtSoyad;
        private Label lblBrans;
        private ComboBox cmbBrans;
        private Label lblTC;
        private TextBox txtTC;
        private Label lblSifre;
        private TextBox txtSifre;
        private Button btnEkle;
        private Button btnSil;
        private Button btnGuncelle;
        private GroupBox grpDoktorListe;
        private Panel pnlListeAccent;
        private Panel pnlListeAlt;
        private DataGridView dgvDoktorlar;
    }
}