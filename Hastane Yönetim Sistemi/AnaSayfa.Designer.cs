namespace Hastane_Yönetim_Sistemi
{
    partial class AnaMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlUst = new Panel();
            lblAltBaslik = new Label();
            lblBaslik = new Label();
            pnlAccent = new Panel();
            pnlHasta = new Panel();
            lblHastaAlt = new Label();
            lblHastaBaslik = new Label();
            pnlHastaAccent = new Panel();
            pnlDoktor = new Panel();
            lblDoktorAlt = new Label();
            lblDoktorBaslik = new Label();
            pnlDoktorAccent = new Panel();
            pnlSekreter = new Panel();
            lblSekreterAlt = new Label();
            lblSekreterBaslik = new Label();
            pnlSekreterAccent = new Panel();
            lblFooter = new Label();
            pnlUst.SuspendLayout();
            pnlHasta.SuspendLayout();
            pnlDoktor.SuspendLayout();
            pnlSekreter.SuspendLayout();
            SuspendLayout();
            // 
            // pnlUst
            // 
            pnlUst.BackColor = Color.FromArgb(15, 23, 42);
            pnlUst.Controls.Add(lblAltBaslik);
            pnlUst.Controls.Add(lblBaslik);
            pnlUst.Dock = DockStyle.Top;
            pnlUst.Location = new Point(0, 0);
            pnlUst.Name = "pnlUst";
            pnlUst.Size = new Size(900, 110);
            pnlUst.TabIndex = 0;
            // 
            // lblAltBaslik
            // 
            lblAltBaslik.AutoSize = true;
            lblAltBaslik.Font = new Font("Segoe UI", 10F);
            lblAltBaslik.ForeColor = Color.FromArgb(148, 163, 184);
            lblAltBaslik.Location = new Point(32, 72);
            lblAltBaslik.Name = "lblAltBaslik";
            lblAltBaslik.Size = new Size(328, 23);
            lblAltBaslik.TabIndex = 1;
            lblAltBaslik.Text = "Hastane Yönetim Bilgi Sistemi · Ana Menü";
            // 
            // lblBaslik
            // 
            lblBaslik.AutoSize = true;
            lblBaslik.Font = new Font("Segoe UI Semibold", 22F, FontStyle.Bold);
            lblBaslik.ForeColor = Color.White;
            lblBaslik.Location = new Point(30, 25);
            lblBaslik.Name = "lblBaslik";
            lblBaslik.Size = new Size(181, 50);
            lblBaslik.TabIndex = 0;
            lblBaslik.Text = "AyParçası";
            // 
            // pnlAccent
            // 
            pnlAccent.BackColor = Color.FromArgb(56, 189, 248);
            pnlAccent.Dock = DockStyle.Top;
            pnlAccent.Location = new Point(0, 110);
            pnlAccent.Name = "pnlAccent";
            pnlAccent.Size = new Size(900, 4);
            pnlAccent.TabIndex = 1;
            // 
            // pnlHasta
            // 
            pnlHasta.BackColor = Color.White;
            pnlHasta.BorderStyle = BorderStyle.FixedSingle;
            pnlHasta.Controls.Add(lblHastaAlt);
            pnlHasta.Controls.Add(lblHastaBaslik);
            pnlHasta.Controls.Add(pnlHastaAccent);
            pnlHasta.Cursor = Cursors.Hand;
            pnlHasta.Location = new Point(60, 170);
            pnlHasta.Name = "pnlHasta";
            pnlHasta.Size = new Size(240, 200);
            pnlHasta.TabIndex = 2;
            pnlHasta.Click += pnlHasta_Click;
            // 
            // lblHastaAlt
            // 
            lblHastaAlt.AutoSize = true;
            lblHastaAlt.Font = new Font("Segoe UI", 9F);
            lblHastaAlt.ForeColor = Color.FromArgb(100, 116, 139);
            lblHastaAlt.Location = new Point(20, 100);
            lblHastaAlt.Name = "lblHastaAlt";
            lblHastaAlt.Size = new Size(179, 20);
            lblHastaAlt.TabIndex = 2;
            lblHastaAlt.Text = "Randevu al, geçmişini gör";
            // 
            // lblHastaBaslik
            // 
            lblHastaBaslik.AutoSize = true;
            lblHastaBaslik.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            lblHastaBaslik.ForeColor = Color.FromArgb(30, 58, 138);
            lblHastaBaslik.Location = new Point(20, 50);
            lblHastaBaslik.Name = "lblHastaBaslik";
            lblHastaBaslik.Size = new Size(96, 41);
            lblHastaBaslik.TabIndex = 1;
            lblHastaBaslik.Text = "Hasta";
            // 
            // pnlHastaAccent
            // 
            pnlHastaAccent.BackColor = Color.FromArgb(2, 132, 199);
            pnlHastaAccent.Dock = DockStyle.Top;
            pnlHastaAccent.Location = new Point(0, 0);
            pnlHastaAccent.Name = "pnlHastaAccent";
            pnlHastaAccent.Size = new Size(238, 5);
            pnlHastaAccent.TabIndex = 0;
            // 
            // pnlDoktor
            // 
            pnlDoktor.BackColor = Color.White;
            pnlDoktor.BorderStyle = BorderStyle.FixedSingle;
            pnlDoktor.Controls.Add(lblDoktorAlt);
            pnlDoktor.Controls.Add(lblDoktorBaslik);
            pnlDoktor.Controls.Add(pnlDoktorAccent);
            pnlDoktor.Cursor = Cursors.Hand;
            pnlDoktor.Location = new Point(330, 170);
            pnlDoktor.Name = "pnlDoktor";
            pnlDoktor.Size = new Size(240, 200);
            pnlDoktor.TabIndex = 3;
            pnlDoktor.Click += pnlDoktor_Click;
          //  pnlDoktor.Paint += pnlDoktor_Paint;
            // 
            // lblDoktorAlt
            // 
            lblDoktorAlt.AutoSize = true;
            lblDoktorAlt.Font = new Font("Segoe UI", 9F);
            lblDoktorAlt.ForeColor = Color.FromArgb(100, 116, 139);
            lblDoktorAlt.Location = new Point(20, 100);
            lblDoktorAlt.Name = "lblDoktorAlt";
            lblDoktorAlt.Size = new Size(206, 20);
            lblDoktorAlt.TabIndex = 2;
            lblDoktorAlt.Text = "Hastaları ve randevuları yönet";
            // 
            // lblDoktorBaslik
            // 
            lblDoktorBaslik.AutoSize = true;
            lblDoktorBaslik.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            lblDoktorBaslik.ForeColor = Color.FromArgb(17, 94, 89);
            lblDoktorBaslik.Location = new Point(20, 50);
            lblDoktorBaslik.Name = "lblDoktorBaslik";
            lblDoktorBaslik.Size = new Size(114, 41);
            lblDoktorBaslik.TabIndex = 1;
            lblDoktorBaslik.Text = "Doktor";
            // 
            // pnlDoktorAccent
            // 
            pnlDoktorAccent.BackColor = Color.FromArgb(13, 148, 136);
            pnlDoktorAccent.Dock = DockStyle.Top;
            pnlDoktorAccent.Location = new Point(0, 0);
            pnlDoktorAccent.Name = "pnlDoktorAccent";
            pnlDoktorAccent.Size = new Size(238, 5);
            pnlDoktorAccent.TabIndex = 0;
            // 
            // pnlSekreter
            // 
            pnlSekreter.BackColor = Color.White;
            pnlSekreter.BorderStyle = BorderStyle.FixedSingle;
            pnlSekreter.Controls.Add(lblSekreterAlt);
            pnlSekreter.Controls.Add(lblSekreterBaslik);
            pnlSekreter.Controls.Add(pnlSekreterAccent);
            pnlSekreter.Cursor = Cursors.Hand;
            pnlSekreter.Location = new Point(600, 170);
            pnlSekreter.Name = "pnlSekreter";
            pnlSekreter.Size = new Size(240, 200);
            pnlSekreter.TabIndex = 4;
            pnlSekreter.Click += pnlSekreter_Click;
            // 
            // lblSekreterAlt
            // 
            lblSekreterAlt.AutoSize = true;
            lblSekreterAlt.Font = new Font("Segoe UI", 9F);
            lblSekreterAlt.ForeColor = Color.FromArgb(100, 116, 139);
            lblSekreterAlt.Location = new Point(20, 100);
            lblSekreterAlt.Name = "lblSekreterAlt";
            lblSekreterAlt.Size = new Size(180, 20);
            lblSekreterAlt.TabIndex = 2;
            lblSekreterAlt.Text = "Randevu ve kayıt işlemleri";
            // 
            // lblSekreterBaslik
            // 
            lblSekreterBaslik.AutoSize = true;
            lblSekreterBaslik.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            lblSekreterBaslik.ForeColor = Color.FromArgb(146, 64, 14);
            lblSekreterBaslik.Location = new Point(20, 50);
            lblSekreterBaslik.Name = "lblSekreterBaslik";
            lblSekreterBaslik.Size = new Size(131, 41);
            lblSekreterBaslik.TabIndex = 1;
            lblSekreterBaslik.Text = "Sekreter";
            // 
            // pnlSekreterAccent
            // 
            pnlSekreterAccent.BackColor = Color.FromArgb(217, 119, 6);
            pnlSekreterAccent.Dock = DockStyle.Top;
            pnlSekreterAccent.Location = new Point(0, 0);
            pnlSekreterAccent.Name = "pnlSekreterAccent";
            pnlSekreterAccent.Size = new Size(238, 5);
            pnlSekreterAccent.TabIndex = 0;
            // 
            // lblFooter
            // 
            lblFooter.AutoSize = true;
            lblFooter.Font = new Font("Segoe UI", 8.5F);
            lblFooter.ForeColor = Color.FromArgb(100, 116, 139);
            lblFooter.Location = new Point(310, 410);
            lblFooter.Name = "lblFooter";
            lblFooter.Size = new Size(213, 20);
            lblFooter.TabIndex = 5;
            lblFooter.Text = "© 2026  AyParçası HYBS  ·  v1.0";
            // 
            // AnaMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 245, 249);
            ClientSize = new Size(900, 440);
            Controls.Add(lblFooter);
            Controls.Add(pnlSekreter);
            Controls.Add(pnlDoktor);
            Controls.Add(pnlHasta);
            Controls.Add(pnlAccent);
            Controls.Add(pnlUst);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "AnaMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AyParçası HYBS · Ana Menü";
            pnlUst.ResumeLayout(false);
            pnlUst.PerformLayout();
            pnlHasta.ResumeLayout(false);
            pnlHasta.PerformLayout();
            pnlDoktor.ResumeLayout(false);
            pnlDoktor.PerformLayout();
            pnlSekreter.ResumeLayout(false);
            pnlSekreter.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlUst;
        private Panel pnlAccent;
        private Label lblBaslik;
        private Label lblAltBaslik;
        private Panel pnlHasta;
        private Label lblHastaBaslik;
        private Label lblHastaAlt;
        private Panel pnlHastaAccent;
        private Panel pnlDoktor;
        private Label lblDoktorBaslik;
        private Label lblDoktorAlt;
        private Panel pnlDoktorAccent;
        private Panel pnlSekreter;
        private Label lblSekreterBaslik;
        private Label lblSekreterAlt;
        private Panel pnlSekreterAccent;
        private Label lblFooter;
    }
}