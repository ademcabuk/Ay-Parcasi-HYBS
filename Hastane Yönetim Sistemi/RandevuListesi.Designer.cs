namespace Hastane_Yönetim_Sistemi
{
    partial class RandevuListesi
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
            grpRandevuListe = new GroupBox();
            pnlListeAccent = new Panel();
            pnlListeAlt = new Panel();
            dgvRandevular = new DataGridView();
            grpRandevuListe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRandevular).BeginInit();
            SuspendLayout();
            // 
            // grpRandevuListe
            // 
            grpRandevuListe.BackColor = Color.White;
            grpRandevuListe.Controls.Add(pnlListeAccent);
            grpRandevuListe.Controls.Add(pnlListeAlt);
            grpRandevuListe.Controls.Add(dgvRandevular);
            grpRandevuListe.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            grpRandevuListe.ForeColor = Color.FromArgb(17, 94, 89);
            grpRandevuListe.Location = new Point(20, 20);
            grpRandevuListe.Name = "grpRandevuListe";
            grpRandevuListe.Size = new Size(1070, 560);
            grpRandevuListe.TabIndex = 0;
            grpRandevuListe.TabStop = false;
            grpRandevuListe.Text = "  📅  Randevu Listesi";
            // 
            // pnlListeAccent
            // 
            pnlListeAccent.BackColor = Color.FromArgb(13, 148, 136);
            pnlListeAccent.Dock = DockStyle.Top;
            pnlListeAccent.Location = new Point(3, 26);
            pnlListeAccent.Name = "pnlListeAccent";
            pnlListeAccent.Size = new Size(1064, 3);
            pnlListeAccent.TabIndex = 0;
            // 
            // pnlListeAlt
            // 
            pnlListeAlt.BackColor = Color.FromArgb(236, 253, 245);
            pnlListeAlt.Dock = DockStyle.Bottom;
            pnlListeAlt.Location = new Point(3, 532);
            pnlListeAlt.Name = "pnlListeAlt";
            pnlListeAlt.Size = new Size(1064, 25);
            pnlListeAlt.TabIndex = 0;
            // 
            // dgvRandevular
            // 
            dgvRandevular.AllowUserToAddRows = false;
            dgvRandevular.AllowUserToDeleteRows = false;
            dgvRandevular.BackgroundColor = Color.White;
            dgvRandevular.BorderStyle = BorderStyle.None;
            dgvRandevular.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvRandevular.ColumnHeadersHeight = 29;
            dgvRandevular.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvRandevular.Dock = DockStyle.Fill;
            dgvRandevular.Location = new Point(3, 26);
            dgvRandevular.Margin = new Padding(0);
            dgvRandevular.Name = "dgvRandevular";
            dgvRandevular.ReadOnly = true;
            dgvRandevular.RowHeadersWidth = 51;
            dgvRandevular.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvRandevular.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRandevular.Size = new Size(1064, 531);
            dgvRandevular.TabIndex = 2;
            // 
            // RandevuListesi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 253, 245);
            ClientSize = new Size(1110, 610);
            Controls.Add(grpRandevuListe);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "RandevuListesi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Randevu Listesi";
            grpRandevuListe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRandevular).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpRandevuListe;
        private Panel pnlListeAccent;
        private Panel pnlListeAlt;
        private Label lblListeBaslik;
        private DataGridView dgvRandevular;
    }
}