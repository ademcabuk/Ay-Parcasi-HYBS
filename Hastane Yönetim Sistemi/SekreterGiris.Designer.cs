namespace Hastane_Yönetim_Sistemi
{
    partial class SekreterGiris
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
            grpGiris = new GroupBox();
            pnlGrpAccent = new Panel();
            btnGiris = new Button();
            txtSifre = new TextBox();
            lblSifre = new Label();
            mskTc = new MaskedTextBox();
            lblTc = new Label();
            pnlAccent = new Panel();
            pnlUst = new Panel();
            lblAltBaslik = new Label();
            lblBaslik = new Label();
            grpGiris.SuspendLayout();
            pnlUst.SuspendLayout();
            SuspendLayout();
            // 
            // grpGiris
            // 
            grpGiris.BackColor = Color.White;
            grpGiris.Controls.Add(pnlGrpAccent);
            grpGiris.Controls.Add(btnGiris);
            grpGiris.Controls.Add(txtSifre);
            grpGiris.Controls.Add(lblSifre);
            grpGiris.Controls.Add(mskTc);
            grpGiris.Controls.Add(lblTc);
            grpGiris.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            grpGiris.ForeColor = Color.FromArgb(17, 94, 89);
            grpGiris.Location = new Point(25, 126);
            grpGiris.Name = "grpGiris";
            grpGiris.Size = new Size(410, 240);
            grpGiris.TabIndex = 5;
            grpGiris.TabStop = false;
            grpGiris.Text = "  \U0001fa7a  Sekreter Girişi";
            // 
            // pnlGrpAccent
            // 
            pnlGrpAccent.BackColor = Color.FromArgb(13, 148, 136);
            pnlGrpAccent.Dock = DockStyle.Top;
            pnlGrpAccent.Location = new Point(3, 26);
            pnlGrpAccent.Name = "pnlGrpAccent";
            pnlGrpAccent.Size = new Size(404, 3);
            pnlGrpAccent.TabIndex = 0;
            // 
            // btnGiris
            // 
            btnGiris.BackColor = Color.FromArgb(13, 148, 136);
            btnGiris.Cursor = Cursors.Hand;
            btnGiris.FlatAppearance.BorderSize = 0;
            btnGiris.FlatAppearance.MouseDownBackColor = Color.FromArgb(17, 94, 89);
            btnGiris.FlatAppearance.MouseOverBackColor = Color.FromArgb(17, 94, 89);
            btnGiris.FlatStyle = FlatStyle.Flat;
            btnGiris.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnGiris.ForeColor = Color.White;
            btnGiris.Location = new Point(140, 175);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(240, 46);
            btnGiris.TabIndex = 3;
            btnGiris.Text = "Giriş Yap";
            btnGiris.UseVisualStyleBackColor = false;
            // 
            // txtSifre
            // 
            txtSifre.BorderStyle = BorderStyle.FixedSingle;
            txtSifre.Font = new Font("Segoe UI", 10F);
            txtSifre.Location = new Point(140, 122);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(240, 30);
            txtSifre.TabIndex = 2;
            txtSifre.UseSystemPasswordChar = true;
            // 
            // lblSifre
            // 
            lblSifre.AutoSize = true;
            lblSifre.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblSifre.ForeColor = Color.FromArgb(51, 65, 85);
            lblSifre.Location = new Point(20, 125);
            lblSifre.Name = "lblSifre";
            lblSifre.Size = new Size(48, 23);
            lblSifre.TabIndex = 2;
            lblSifre.Text = "Şifre:";
            // 
            // mskTc
            // 
            mskTc.BorderStyle = BorderStyle.FixedSingle;
            mskTc.Font = new Font("Segoe UI", 10F);
            mskTc.Location = new Point(140, 67);
            mskTc.Mask = "00000000000";
            mskTc.Name = "mskTc";
            mskTc.Size = new Size(240, 30);
            mskTc.TabIndex = 1;
            mskTc.ValidatingType = typeof(int);
            // 
            // lblTc
            // 
            lblTc.AutoSize = true;
            lblTc.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblTc.ForeColor = Color.FromArgb(51, 65, 85);
            lblTc.Location = new Point(20, 70);
            lblTc.Name = "lblTc";
            lblTc.Size = new Size(106, 23);
            lblTc.TabIndex = 0;
            lblTc.Text = "Personel No:";
            // 
            // pnlAccent
            // 
            pnlAccent.BackColor = Color.FromArgb(45, 212, 191);
            pnlAccent.Dock = DockStyle.Top;
            pnlAccent.Location = new Point(0, 100);
            pnlAccent.Name = "pnlAccent";
            pnlAccent.Size = new Size(456, 4);
            pnlAccent.TabIndex = 4;
            // 
            // pnlUst
            // 
            pnlUst.BackColor = Color.FromArgb(15, 23, 42);
            pnlUst.Controls.Add(lblAltBaslik);
            pnlUst.Controls.Add(lblBaslik);
            pnlUst.Dock = DockStyle.Top;
            pnlUst.Location = new Point(0, 0);
            pnlUst.Name = "pnlUst";
            pnlUst.Size = new Size(456, 100);
            pnlUst.TabIndex = 3;
            // 
            // lblAltBaslik
            // 
            lblAltBaslik.AutoSize = true;
            lblAltBaslik.Font = new Font("Segoe UI", 9F);
            lblAltBaslik.ForeColor = Color.FromArgb(148, 163, 184);
            lblAltBaslik.Location = new Point(27, 65);
            lblAltBaslik.Name = "lblAltBaslik";
            lblAltBaslik.Size = new Size(229, 20);
            lblAltBaslik.TabIndex = 1;
            lblAltBaslik.Text = "Personel numaranız ile giriş yapın";
            // 
            // lblBaslik
            // 
            lblBaslik.AutoSize = true;
            lblBaslik.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            lblBaslik.ForeColor = Color.White;
            lblBaslik.Location = new Point(25, 22);
            lblBaslik.Name = "lblBaslik";
            lblBaslik.Size = new Size(237, 46);
            lblBaslik.TabIndex = 0;
            lblBaslik.Text = "Sekreter Girişi";
            // 
            // SekreterGiris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(456, 396);
            Controls.Add(grpGiris);
            Controls.Add(pnlAccent);
            Controls.Add(pnlUst);
            Name = "SekreterGiris";
            Text = "SekreterGiris";
            grpGiris.ResumeLayout(false);
            grpGiris.PerformLayout();
            pnlUst.ResumeLayout(false);
            pnlUst.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        public GroupBox grpGiris;
        public Panel pnlGrpAccent;
        public Button btnGiris;
        public TextBox txtSifre;
        public Label lblSifre;
        public MaskedTextBox mskTc;
        public Label lblTc;
        public Panel pnlAccent;
        public Panel pnlUst;
        public Label lblAltBaslik;
        public Label lblBaslik;
    }
}