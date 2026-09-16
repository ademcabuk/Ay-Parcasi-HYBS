namespace Hastane_Yönetim_Sistemi
{
    partial class HastaKayit
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
            lblBaslik = new Label();
            lblAd = new Label();
            txtAd = new TextBox();
            lblSoyad = new Label();
            txtSoyad = new TextBox();
            lblTC = new Label();
            mskTC = new MaskedTextBox();
            lblTelefon = new Label();
            mskTelefon = new MaskedTextBox();
            lblSifre = new Label();
            txtSifre = new TextBox();
            lblCinsiyet = new Label();
            cmbCinsiyet = new ComboBox();
            btnUyeOl = new Button();
            SuspendLayout();
            // 
            // lblBaslik
            // 
            lblBaslik.AutoSize = true;
            lblBaslik.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblBaslik.ForeColor = Color.FromArgb(30, 58, 138);
            lblBaslik.Location = new Point(100, 25);
            lblBaslik.Name = "lblBaslik";
            lblBaslik.Size = new Size(250, 37);
            lblBaslik.TabIndex = 0;
            lblBaslik.Text = "Hasta Kayıt Paneli";
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblAd.ForeColor = Color.FromArgb(51, 65, 85);
            lblAd.Location = new Point(45, 90);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(38, 23);
            lblAd.TabIndex = 1;
            lblAd.Text = "Ad:";
            // 
            // txtAd
            // 
            txtAd.BorderStyle = BorderStyle.FixedSingle;
            txtAd.Font = new Font("Segoe UI", 10F);
            txtAd.Location = new Point(170, 88);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(220, 30);
            txtAd.TabIndex = 1;
            // 
            // lblSoyad
            // 
            lblSoyad.AutoSize = true;
            lblSoyad.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSoyad.ForeColor = Color.FromArgb(51, 65, 85);
            lblSoyad.Location = new Point(45, 140);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Size = new Size(64, 23);
            lblSoyad.TabIndex = 3;
            lblSoyad.Text = "Soyad:";
            // 
            // txtSoyad
            // 
            txtSoyad.BorderStyle = BorderStyle.FixedSingle;
            txtSoyad.Font = new Font("Segoe UI", 10F);
            txtSoyad.Location = new Point(170, 138);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(220, 30);
            txtSoyad.TabIndex = 2;
            // 
            // lblTC
            // 
            lblTC.AutoSize = true;
            lblTC.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTC.ForeColor = Color.FromArgb(51, 65, 85);
            lblTC.Location = new Point(45, 190);
            lblTC.Name = "lblTC";
            lblTC.Size = new Size(120, 23);
            lblTC.TabIndex = 5;
            lblTC.Text = "TC Kimlik No:";
            // 
            // mskTC
            // 
            mskTC.BorderStyle = BorderStyle.FixedSingle;
            mskTC.Font = new Font("Segoe UI", 10F);
            mskTC.Location = new Point(170, 188);
            mskTC.Mask = "00000000000";
            mskTC.Name = "mskTC";
            mskTC.Size = new Size(220, 30);
            mskTC.TabIndex = 3;
            mskTC.ValidatingType = typeof(int);
            // 
            // lblTelefon
            // 
            lblTelefon.AutoSize = true;
            lblTelefon.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTelefon.ForeColor = Color.FromArgb(51, 65, 85);
            lblTelefon.Location = new Point(45, 240);
            lblTelefon.Name = "lblTelefon";
            lblTelefon.Size = new Size(73, 23);
            lblTelefon.TabIndex = 7;
            lblTelefon.Text = "Telefon:";
            // 
            // mskTelefon
            // 
            mskTelefon.BorderStyle = BorderStyle.FixedSingle;
            mskTelefon.Font = new Font("Segoe UI", 10F);
            mskTelefon.Location = new Point(170, 238);
            mskTelefon.Mask = "(999) 000-0000";
            mskTelefon.Name = "mskTelefon";
            mskTelefon.Size = new Size(220, 30);
            mskTelefon.TabIndex = 4;
            // 
            // lblSifre
            // 
            lblSifre.AutoSize = true;
            lblSifre.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSifre.ForeColor = Color.FromArgb(51, 65, 85);
            lblSifre.Location = new Point(45, 290);
            lblSifre.Name = "lblSifre";
            lblSifre.Size = new Size(53, 23);
            lblSifre.TabIndex = 9;
            lblSifre.Text = "Şifre:";
            // 
            // txtSifre
            // 
            txtSifre.BorderStyle = BorderStyle.FixedSingle;
            txtSifre.Font = new Font("Segoe UI", 10F);
            txtSifre.Location = new Point(170, 288);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(220, 30);
            txtSifre.TabIndex = 5;
            txtSifre.UseSystemPasswordChar = true;
            // 
            // lblCinsiyet
            // 
            lblCinsiyet.AutoSize = true;
            lblCinsiyet.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCinsiyet.ForeColor = Color.FromArgb(51, 65, 85);
            lblCinsiyet.Location = new Point(45, 340);
            lblCinsiyet.Name = "lblCinsiyet";
            lblCinsiyet.Size = new Size(78, 23);
            lblCinsiyet.TabIndex = 11;
            lblCinsiyet.Text = "Cinsiyet:";
            // 
            // cmbCinsiyet
            // 
            cmbCinsiyet.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCinsiyet.FlatStyle = FlatStyle.Flat;
            cmbCinsiyet.Font = new Font("Segoe UI", 10F);
            cmbCinsiyet.FormattingEnabled = true;
            cmbCinsiyet.Items.AddRange(new object[] { "Erkek", "Kadın" });
            cmbCinsiyet.Location = new Point(170, 338);
            cmbCinsiyet.Name = "cmbCinsiyet";
            cmbCinsiyet.Size = new Size(220, 31);
            cmbCinsiyet.TabIndex = 6;
            // 
            // btnUyeOl
            // 
            btnUyeOl.BackColor = Color.FromArgb(2, 132, 199);
            btnUyeOl.Cursor = Cursors.Hand;
            btnUyeOl.FlatAppearance.BorderSize = 0;
            btnUyeOl.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 58, 138);
            btnUyeOl.FlatAppearance.MouseOverBackColor = Color.FromArgb(3, 105, 161);
            btnUyeOl.FlatStyle = FlatStyle.Flat;
            btnUyeOl.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnUyeOl.ForeColor = Color.White;
            btnUyeOl.Location = new Point(160, 395);
            btnUyeOl.Name = "btnUyeOl";
            btnUyeOl.Size = new Size(220, 44);
            btnUyeOl.TabIndex = 7;
            btnUyeOl.Text = "Kayıt Ol";
            btnUyeOl.UseVisualStyleBackColor = false;
            btnUyeOl.Click += btnUyeOl_Click;
            // 
            // HastaKayit
            // 
            AcceptButton = btnUyeOl;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 247, 246);
            ClientSize = new Size(434, 481);
            Controls.Add(lblBaslik);
            Controls.Add(lblAd);
            Controls.Add(txtAd);
            Controls.Add(lblSoyad);
            Controls.Add(txtSoyad);
            Controls.Add(lblTC);
            Controls.Add(mskTC);
            Controls.Add(lblTelefon);
            Controls.Add(mskTelefon);
            Controls.Add(lblSifre);
            Controls.Add(txtSifre);
            Controls.Add(lblCinsiyet);
            Controls.Add(cmbCinsiyet);
            Controls.Add(btnUyeOl);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "HastaKayit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hasta Kayıt";
            Load += HastaKayit_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label lblBaslik;
        public Label lblAd;
        public TextBox txtAd;
        public Label lblSoyad;
        public TextBox txtSoyad;
        public Label lblTC;
        public MaskedTextBox mskTC;
        public Label lblTelefon;
        public MaskedTextBox mskTelefon;
        public Label lblSifre;
        public TextBox txtSifre;
        public Label lblCinsiyet;
        public ComboBox cmbCinsiyet;
        public Button btnUyeOl;
    }
}