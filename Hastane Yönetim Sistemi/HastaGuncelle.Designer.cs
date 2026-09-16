namespace Hastane_Yönetim_Sistemi
{
    partial class HastaGuncelle
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
            grpGuncelle = new GroupBox();
            pnlGuncelleAccent = new Panel();
            btnIptal = new Button();
            btnGuncelle = new Button();
            cmbCinsiyet = new ComboBox();
            lblCinsiyet = new Label();
            txtSifre = new TextBox();
            lblSifre = new Label();
            mskTelefon = new MaskedTextBox();
            lblTelefon = new Label();
            txtSoyad = new TextBox();
            lblSoyad = new Label();
            txtAd = new TextBox();
            lblAd = new Label();
            mskTc = new MaskedTextBox();
            lblTc = new Label();
            lblGuncelleBaslik = new Label();
            pnlGuncelleAlt = new Panel();
            grpGuncelle.SuspendLayout();
            SuspendLayout();
            // 
            // grpGuncelle
            // 
            grpGuncelle.BackColor = Color.White;
            grpGuncelle.Controls.Add(pnlGuncelleAccent);
            grpGuncelle.Controls.Add(btnIptal);
            grpGuncelle.Controls.Add(btnGuncelle);
            grpGuncelle.Controls.Add(cmbCinsiyet);
            grpGuncelle.Controls.Add(lblCinsiyet);
            grpGuncelle.Controls.Add(txtSifre);
            grpGuncelle.Controls.Add(lblSifre);
            grpGuncelle.Controls.Add(mskTelefon);
            grpGuncelle.Controls.Add(lblTelefon);
            grpGuncelle.Controls.Add(txtSoyad);
            grpGuncelle.Controls.Add(lblSoyad);
            grpGuncelle.Controls.Add(txtAd);
            grpGuncelle.Controls.Add(lblAd);
            grpGuncelle.Controls.Add(mskTc);
            grpGuncelle.Controls.Add(lblTc);
            grpGuncelle.Controls.Add(lblGuncelleBaslik);
            grpGuncelle.Controls.Add(pnlGuncelleAlt);
            grpGuncelle.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            grpGuncelle.ForeColor = Color.FromArgb(30, 58, 138);
            grpGuncelle.Location = new Point(20, 20);
            grpGuncelle.Name = "grpGuncelle";
            grpGuncelle.Size = new Size(410, 468);
            grpGuncelle.TabIndex = 0;
            grpGuncelle.TabStop = false;
            grpGuncelle.Text = "  ✏️  Bilgilerimi Güncelle";
            // 
            // pnlGuncelleAccent
            // 
            pnlGuncelleAccent.BackColor = Color.FromArgb(2, 132, 199);
            pnlGuncelleAccent.Dock = DockStyle.Top;
            pnlGuncelleAccent.Location = new Point(3, 26);
            pnlGuncelleAccent.Name = "pnlGuncelleAccent";
            pnlGuncelleAccent.Size = new Size(404, 3);
            pnlGuncelleAccent.TabIndex = 0;
            // 
            // btnIptal
            // 
            btnIptal.BackColor = Color.FromArgb(241, 245, 249);
            btnIptal.Cursor = Cursors.Hand;
            btnIptal.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnIptal.FlatAppearance.MouseOverBackColor = Color.FromArgb(226, 232, 240);
            btnIptal.FlatStyle = FlatStyle.Flat;
            btnIptal.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnIptal.ForeColor = Color.FromArgb(100, 116, 139);
            btnIptal.Location = new Point(25, 385);
            btnIptal.Name = "btnIptal";
            btnIptal.Size = new Size(112, 40);
            btnIptal.TabIndex = 8;
            btnIptal.Text = "✕";
            btnIptal.UseVisualStyleBackColor = false;
            btnIptal.Click += btnIptal_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.FromArgb(2, 132, 199);
            btnGuncelle.Cursor = Cursors.Hand;
            btnGuncelle.FlatAppearance.BorderSize = 0;
            btnGuncelle.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 58, 138);
            btnGuncelle.FlatAppearance.MouseOverBackColor = Color.FromArgb(3, 105, 161);
            btnGuncelle.FlatStyle = FlatStyle.Flat;
            btnGuncelle.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnGuncelle.ForeColor = Color.White;
            btnGuncelle.Location = new Point(150, 385);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(230, 40);
            btnGuncelle.TabIndex = 7;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // cmbCinsiyet
            // 
            cmbCinsiyet.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCinsiyet.FlatStyle = FlatStyle.Flat;
            cmbCinsiyet.Font = new Font("Segoe UI", 10F);
            cmbCinsiyet.FormattingEnabled = true;
            cmbCinsiyet.Location = new Point(150, 337);
            cmbCinsiyet.Name = "cmbCinsiyet";
            cmbCinsiyet.Size = new Size(230, 31);
            cmbCinsiyet.TabIndex = 6;
            // 
            // lblCinsiyet
            // 
            lblCinsiyet.AutoSize = true;
            lblCinsiyet.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblCinsiyet.ForeColor = Color.FromArgb(51, 65, 85);
            lblCinsiyet.Location = new Point(25, 340);
            lblCinsiyet.Name = "lblCinsiyet";
            lblCinsiyet.Size = new Size(74, 23);
            lblCinsiyet.TabIndex = 9;
            lblCinsiyet.Text = "Cinsiyet:";
            // 
            // txtSifre
            // 
            txtSifre.BorderStyle = BorderStyle.FixedSingle;
            txtSifre.Font = new Font("Segoe UI", 10F);
            txtSifre.Location = new Point(150, 287);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(230, 30);
            txtSifre.TabIndex = 5;
            txtSifre.UseSystemPasswordChar = true;
            // 
            // lblSifre
            // 
            lblSifre.AutoSize = true;
            lblSifre.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblSifre.ForeColor = Color.FromArgb(51, 65, 85);
            lblSifre.Location = new Point(25, 290);
            lblSifre.Name = "lblSifre";
            lblSifre.Size = new Size(48, 23);
            lblSifre.TabIndex = 10;
            lblSifre.Text = "Şifre:";
            // 
            // mskTelefon
            // 
            mskTelefon.BorderStyle = BorderStyle.FixedSingle;
            mskTelefon.Font = new Font("Segoe UI", 10F);
            mskTelefon.Location = new Point(150, 237);
            mskTelefon.Mask = "(999) 000-0000";
            mskTelefon.Name = "mskTelefon";
            mskTelefon.Size = new Size(230, 30);
            mskTelefon.TabIndex = 4;
            // 
            // lblTelefon
            // 
            lblTelefon.AutoSize = true;
            lblTelefon.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblTelefon.ForeColor = Color.FromArgb(51, 65, 85);
            lblTelefon.Location = new Point(25, 240);
            lblTelefon.Name = "lblTelefon";
            lblTelefon.Size = new Size(69, 23);
            lblTelefon.TabIndex = 11;
            lblTelefon.Text = "Telefon:";
            // 
            // txtSoyad
            // 
            txtSoyad.BorderStyle = BorderStyle.FixedSingle;
            txtSoyad.Font = new Font("Segoe UI", 10F);
            txtSoyad.Location = new Point(150, 187);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(230, 30);
            txtSoyad.TabIndex = 3;
            // 
            // lblSoyad
            // 
            lblSoyad.AutoSize = true;
            lblSoyad.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblSoyad.ForeColor = Color.FromArgb(51, 65, 85);
            lblSoyad.Location = new Point(25, 190);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Size = new Size(61, 23);
            lblSoyad.TabIndex = 12;
            lblSoyad.Text = "Soyad:";
            // 
            // txtAd
            // 
            txtAd.BorderStyle = BorderStyle.FixedSingle;
            txtAd.Font = new Font("Segoe UI", 10F);
            txtAd.Location = new Point(150, 137);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(230, 30);
            txtAd.TabIndex = 2;
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblAd.ForeColor = Color.FromArgb(51, 65, 85);
            lblAd.Location = new Point(25, 140);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(35, 23);
            lblAd.TabIndex = 13;
            lblAd.Text = "Ad:";
            // 
            // mskTc
            // 
            mskTc.BorderStyle = BorderStyle.FixedSingle;
            mskTc.Font = new Font("Segoe UI", 10F);
            mskTc.Location = new Point(150, 87);
            mskTc.Mask = "00000000000";
            mskTc.Name = "mskTc";
            mskTc.Size = new Size(230, 30);
            mskTc.TabIndex = 1;
            mskTc.ValidatingType = typeof(int);
            // 
            // lblTc
            // 
            lblTc.AutoSize = true;
            lblTc.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblTc.ForeColor = Color.FromArgb(51, 65, 85);
            lblTc.Location = new Point(25, 90);
            lblTc.Name = "lblTc";
            lblTc.Size = new Size(112, 23);
            lblTc.TabIndex = 14;
            lblTc.Text = "TC Kimlik No:";
            // 
            // lblGuncelleBaslik
            // 
            lblGuncelleBaslik.AutoSize = true;
            lblGuncelleBaslik.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblGuncelleBaslik.ForeColor = Color.FromArgb(100, 116, 139);
            lblGuncelleBaslik.Location = new Point(20, 45);
            lblGuncelleBaslik.Name = "lblGuncelleBaslik";
            lblGuncelleBaslik.Size = new Size(227, 20);
            lblGuncelleBaslik.TabIndex = 15;
            lblGuncelleBaslik.Text = "Bilgilerinizi güncelleyip kaydedin";
            // 
            // pnlGuncelleAlt
            // 
            pnlGuncelleAlt.BackColor = Color.FromArgb(241, 245, 249);
            pnlGuncelleAlt.Dock = DockStyle.Bottom;
            pnlGuncelleAlt.Location = new Point(3, 440);
            pnlGuncelleAlt.Name = "pnlGuncelleAlt";
            pnlGuncelleAlt.Size = new Size(404, 25);
            pnlGuncelleAlt.TabIndex = 0;
            // 
            // HastaGuncelle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 247, 246);
            ClientSize = new Size(450, 500);
            Controls.Add(grpGuncelle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "HastaGuncelle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bilgilerimi Güncelle";
            Load += HastaGuncelle_Load;
            grpGuncelle.ResumeLayout(false);
            grpGuncelle.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        public GroupBox grpGuncelle;
        public Panel pnlGuncelleAccent;
        public Panel pnlGuncelleAlt;
        public Label lblGuncelleBaslik;
        public Label lblTc;
        public MaskedTextBox mskTc;
        public Label lblAd;
        public TextBox txtAd;
        public Label lblSoyad;
        public TextBox txtSoyad;
        public Label lblTelefon;
        public MaskedTextBox mskTelefon;
        public Label lblSifre;
        public TextBox txtSifre;
        public Label lblCinsiyet;
        public ComboBox cmbCinsiyet;
        public Button btnGuncelle;
        public Button btnIptal;
    }
}
