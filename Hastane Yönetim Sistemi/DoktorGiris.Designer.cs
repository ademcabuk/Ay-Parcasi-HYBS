namespace Hastane_Yönetim_Sistemi
{
    partial class DoktorGiris
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
            pnlUst = new Panel();
            pnlAccent = new Panel();
            lblBaslik = new Label();
            lblAltBaslik = new Label();
            grpGiris = new GroupBox();
            pnlGrpAccent = new Panel();
            lblTc = new Label();
            mskTc = new MaskedTextBox();
            lblSifre = new Label();
            txtSifre = new TextBox();
            btnGiris = new Button();
            grpGiris.SuspendLayout();
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
            pnlUst.Size = new Size(450, 100);
            pnlUst.TabIndex = 0;
            //
            // pnlAccent
            //
            pnlAccent.BackColor = Color.FromArgb(45, 212, 191);
            pnlAccent.Dock = DockStyle.Top;
            pnlAccent.Location = new Point(0, 100);
            pnlAccent.Name = "pnlAccent";
            pnlAccent.Size = new Size(450, 4);
            pnlAccent.TabIndex = 1;
            //
            // lblBaslik
            //
            lblBaslik.AutoSize = true;
            lblBaslik.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            lblBaslik.ForeColor = Color.White;
            lblBaslik.Location = new Point(25, 22);
            lblBaslik.Name = "lblBaslik";
            lblBaslik.Size = new Size(193, 37);
            lblBaslik.TabIndex = 0;
            lblBaslik.Text = "Doktor Girişi";
            //
            // lblAltBaslik
            //
            lblAltBaslik.AutoSize = true;
            lblAltBaslik.Font = new Font("Segoe UI", 9F);
            lblAltBaslik.ForeColor = Color.FromArgb(148, 163, 184);
            lblAltBaslik.Location = new Point(27, 65);
            lblAltBaslik.Name = "lblAltBaslik";
            lblAltBaslik.Size = new Size(196, 15);
            lblAltBaslik.TabIndex = 1;
            lblAltBaslik.Text = "Personel numaranız ile giriş yapın";
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
            grpGiris.Location = new Point(20, 130);
            grpGiris.Name = "grpGiris";
            grpGiris.Size = new Size(410, 240);
            grpGiris.TabIndex = 2;
            grpGiris.TabStop = false;
            grpGiris.Text = "  🩺  Doktor Girişi";
            //
            // pnlGrpAccent
            //
            pnlGrpAccent.BackColor = Color.FromArgb(13, 148, 136);
            pnlGrpAccent.Dock = DockStyle.Top;
            pnlGrpAccent.Location = new Point(3, 19);
            pnlGrpAccent.Name = "pnlGrpAccent";
            pnlGrpAccent.Size = new Size(404, 3);
            pnlGrpAccent.TabIndex = 0;
            //
            // lblTc
            //
            lblTc.AutoSize = true;
            lblTc.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblTc.ForeColor = Color.FromArgb(51, 65, 85);
            lblTc.Location = new Point(20, 70);
            lblTc.Name = "lblTc";
            lblTc.Size = new Size(104, 19);
            lblTc.TabIndex = 0;
            lblTc.Text = "Personel No:";
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
            // lblSifre
            //
            lblSifre.AutoSize = true;
            lblSifre.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblSifre.ForeColor = Color.FromArgb(51, 65, 85);
            lblSifre.Location = new Point(20, 125);
            lblSifre.Name = "lblSifre";
            lblSifre.Size = new Size(41, 19);
            lblSifre.TabIndex = 2;
            lblSifre.Text = "Şifre:";
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
            // DoktorGiris
            //
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 245, 249);
            ClientSize = new Size(450, 410);
            Controls.Add(grpGiris);
            Controls.Add(pnlAccent);
            Controls.Add(pnlUst);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "DoktorGiris";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Doktor Girişi";
            grpGiris.ResumeLayout(false);
            grpGiris.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        public Panel pnlUst;
        public Panel pnlAccent;
        public Label lblBaslik;
        public Label lblAltBaslik;
        public GroupBox grpGiris;
        public Panel pnlGrpAccent;
        public Label lblTc;
        public MaskedTextBox mskTc;
        public Label lblSifre;
        public TextBox txtSifre;
        public Button btnGiris;
    }
}