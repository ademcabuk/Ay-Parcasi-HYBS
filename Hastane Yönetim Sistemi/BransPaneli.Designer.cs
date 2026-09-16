namespace Hastane_Yönetim_Sistemi
{
    partial class BransPaneli
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
            grpBransIslemleri = new GroupBox();
            pnlIslemAccent = new Panel();
            pnlIslemAlt = new Panel();
            btnGuncelle = new Button();
            btnSil = new Button();
            btnEkle = new Button();
            txtBransAd = new TextBox();
            lblBransAd = new Label();
            txtID = new TextBox();
            lblID = new Label();
            grpBransListe = new GroupBox();
            pnlListeAccent = new Panel();
            pnlListeAlt = new Panel();
            dgvBranslar = new DataGridView();
            grpBransIslemleri.SuspendLayout();
            grpBransListe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBranslar).BeginInit();
            SuspendLayout();
            // 
            // grpBransIslemleri
            // 
            grpBransIslemleri.BackColor = Color.White;
            grpBransIslemleri.Controls.Add(pnlIslemAccent);
            grpBransIslemleri.Controls.Add(pnlIslemAlt);
            grpBransIslemleri.Controls.Add(btnGuncelle);
            grpBransIslemleri.Controls.Add(btnSil);
            grpBransIslemleri.Controls.Add(btnEkle);
            grpBransIslemleri.Controls.Add(txtBransAd);
            grpBransIslemleri.Controls.Add(lblBransAd);
            grpBransIslemleri.Controls.Add(txtID);
            grpBransIslemleri.Controls.Add(lblID);
            grpBransIslemleri.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            grpBransIslemleri.ForeColor = Color.FromArgb(17, 94, 89);
            grpBransIslemleri.Location = new Point(20, 20);
            grpBransIslemleri.Name = "grpBransIslemleri";
            grpBransIslemleri.Size = new Size(329, 307);
            grpBransIslemleri.TabIndex = 0;
            grpBransIslemleri.TabStop = false;
            grpBransIslemleri.Text = "  🏥  Branş İşlemleri";
            // 
            // pnlIslemAccent
            // 
            pnlIslemAccent.BackColor = Color.FromArgb(13, 148, 136);
            pnlIslemAccent.Dock = DockStyle.Top;
            pnlIslemAccent.Location = new Point(3, 26);
            pnlIslemAccent.Name = "pnlIslemAccent";
            pnlIslemAccent.Size = new Size(323, 3);
            pnlIslemAccent.TabIndex = 0;
            // 
            // pnlIslemAlt
            // 
            pnlIslemAlt.BackColor = Color.FromArgb(236, 253, 245);
            pnlIslemAlt.Dock = DockStyle.Bottom;
            pnlIslemAlt.Location = new Point(3, 279);
            pnlIslemAlt.Name = "pnlIslemAlt";
            pnlIslemAlt.Size = new Size(323, 25);
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
            btnGuncelle.Location = new Point(43, 219);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(239, 35);
            btnGuncelle.TabIndex = 6;
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
            btnSil.Location = new Point(163, 163);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(119, 35);
            btnSil.TabIndex = 5;
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
            btnEkle.Location = new Point(43, 163);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(119, 35);
            btnEkle.TabIndex = 4;
            btnEkle.Text = "➕ Ekle";
            btnEkle.UseVisualStyleBackColor = false;
            // 
            // txtBransAd
            // 
            txtBransAd.BorderStyle = BorderStyle.FixedSingle;
            txtBransAd.Font = new Font("Segoe UI", 10F);
            txtBransAd.Location = new Point(120, 107);
            txtBransAd.Name = "txtBransAd";
            txtBransAd.Size = new Size(179, 30);
            txtBransAd.TabIndex = 3;
            // 
            // lblBransAd
            // 
            lblBransAd.AutoSize = true;
            lblBransAd.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblBransAd.ForeColor = Color.FromArgb(51, 65, 85);
            lblBransAd.Location = new Point(20, 110);
            lblBransAd.Name = "lblBransAd";
            lblBransAd.Size = new Size(82, 23);
            lblBransAd.TabIndex = 2;
            lblBransAd.Text = "Branş Ad:";
            // 
            // txtID
            // 
            txtID.BorderStyle = BorderStyle.FixedSingle;
            txtID.Font = new Font("Segoe UI", 10F);
            txtID.Location = new Point(120, 57);
            txtID.Name = "txtID";
            txtID.Size = new Size(179, 30);
            txtID.TabIndex = 1;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblID.ForeColor = Color.FromArgb(51, 65, 85);
            lblID.Location = new Point(20, 60);
            lblID.Name = "lblID";
            lblID.Size = new Size(31, 23);
            lblID.TabIndex = 0;
            lblID.Text = "ID:";
            // 
            // grpBransListe
            // 
            grpBransListe.BackColor = Color.White;
            grpBransListe.Controls.Add(pnlListeAccent);
            grpBransListe.Controls.Add(pnlListeAlt);
            grpBransListe.Controls.Add(dgvBranslar);
            grpBransListe.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            grpBransListe.ForeColor = Color.FromArgb(17, 94, 89);
            grpBransListe.Location = new Point(368, 20);
            grpBransListe.Name = "grpBransListe";
            grpBransListe.Size = new Size(519, 307);
            grpBransListe.TabIndex = 1;
            grpBransListe.TabStop = false;
            grpBransListe.Text = "  📋  Branş Listesi";
            // 
            // pnlListeAccent
            // 
            pnlListeAccent.BackColor = Color.FromArgb(13, 148, 136);
            pnlListeAccent.Dock = DockStyle.Top;
            pnlListeAccent.Location = new Point(3, 26);
            pnlListeAccent.Name = "pnlListeAccent";
            pnlListeAccent.Size = new Size(513, 3);
            pnlListeAccent.TabIndex = 0;
            // 
            // pnlListeAlt
            // 
            pnlListeAlt.BackColor = Color.FromArgb(236, 253, 245);
            pnlListeAlt.Dock = DockStyle.Bottom;
            pnlListeAlt.Location = new Point(3, 279);
            pnlListeAlt.Name = "pnlListeAlt";
            pnlListeAlt.Size = new Size(513, 25);
            pnlListeAlt.TabIndex = 0;
            // 
            // dgvBranslar
            // 
            dgvBranslar.AllowUserToAddRows = false;
            dgvBranslar.AllowUserToDeleteRows = false;
            dgvBranslar.BackgroundColor = Color.White;
            dgvBranslar.BorderStyle = BorderStyle.None;
            dgvBranslar.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvBranslar.ColumnHeadersHeight = 29;
            dgvBranslar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvBranslar.Dock = DockStyle.Fill;
            dgvBranslar.Location = new Point(3, 26);
            dgvBranslar.Margin = new Padding(0);
            dgvBranslar.Name = "dgvBranslar";
            dgvBranslar.ReadOnly = true;
            dgvBranslar.RowHeadersWidth = 51;
            dgvBranslar.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvBranslar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBranslar.Size = new Size(513, 253);
            dgvBranslar.TabIndex = 2;
            // 
            // BransPaneli
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 253, 245);
            ClientSize = new Size(911, 348);
            Controls.Add(grpBransListe);
            Controls.Add(grpBransIslemleri);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "BransPaneli";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Branş Paneli";
            grpBransIslemleri.ResumeLayout(false);
            grpBransIslemleri.PerformLayout();
            grpBransListe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBranslar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpBransIslemleri;
        private Panel pnlIslemAccent;
        private Panel pnlIslemAlt;
        private Label lblID;
        private TextBox txtID;
        private Label lblBransAd;
        private TextBox txtBransAd;
        private Button btnEkle;
        private Button btnSil;
        private Button btnGuncelle;
        private GroupBox grpBransListe;
        private Panel pnlListeAccent;
        private Panel pnlListeAlt;
        private DataGridView dgvBranslar;
    }
}

