namespace Hastane_Yönetim_Sistemi
{
    partial class HastaGiris
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
            lblAltBaslik = new Label();
            lblBaslik = new Label();
            pnlAccent = new Panel();
            grpGiris = new GroupBox();
            pnlGrpAccent = new Panel();
            lnkUyeOl = new LinkLabel();
            btnGiris = new Button();
            txtSifre = new TextBox();
            lblSifre = new Label();
            mskTc = new MaskedTextBox();
            lblTc = new Label();
            pnlUst.SuspendLayout();
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
            // lblAltBaslik
            // 
            lblAltBaslik.AutoSize = true;
            lblAltBaslik.Font = new Font("Segoe UI", 9F);
            lblAltBaslik.ForeColor = Color.FromArgb(148, 163, 184);
            lblAltBaslik.Location = new Point(27, 65);
            lblAltBaslik.Name = "lblAltBaslik";
            lblAltBaslik.Size = new Size(233, 20);
            lblAltBaslik.TabIndex = 1;
            lblAltBaslik.Text = "TC kimlik numaranız ile giriş yapın";
            // 
            // lblBaslik
            // 
            lblBaslik.AutoSize = true;
            lblBaslik.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            lblBaslik.ForeColor = Color.White;
            lblBaslik.Location = new Point(25, 22);
            lblBaslik.Name = "lblBaslik";
            lblBaslik.Size = new Size(196, 46);
            lblBaslik.TabIndex = 0;
            lblBaslik.Text = "Hasta Girişi";
            // 
            // pnlAccent
            // 
            pnlAccent.BackColor = Color.FromArgb(56, 189, 248);
            pnlAccent.Dock = DockStyle.Top;
            pnlAccent.Location = new Point(0, 100);
            pnlAccent.Name = "pnlAccent";
            pnlAccent.Size = new Size(450, 4);
            pnlAccent.TabIndex = 1;
            // 
            // grpGiris
            // 
            grpGiris.BackColor = Color.White;
            grpGiris.Controls.Add(pnlGrpAccent);
            grpGiris.Controls.Add(lnkUyeOl);
            grpGiris.Controls.Add(btnGiris);
            grpGiris.Controls.Add(txtSifre);
            grpGiris.Controls.Add(lblSifre);
            grpGiris.Controls.Add(mskTc);
            grpGiris.Controls.Add(lblTc);
            grpGiris.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            grpGiris.ForeColor = Color.FromArgb(30, 58, 138);
            grpGiris.Location = new Point(20, 130);
            grpGiris.Name = "grpGiris";
            grpGiris.Size = new Size(410, 260);
            grpGiris.TabIndex = 2;
            grpGiris.TabStop = false;
            grpGiris.Text = "  🔐  Giriş Yap";
            // 
            // pnlGrpAccent
            // 
            pnlGrpAccent.BackColor = Color.FromArgb(2, 132, 199);
            pnlGrpAccent.Dock = DockStyle.Top;
            pnlGrpAccent.Location = new Point(3, 26);
            pnlGrpAccent.Name = "pnlGrpAccent";
            pnlGrpAccent.Size = new Size(404, 3);
            pnlGrpAccent.TabIndex = 0;
            // 
            // lnkUyeOl
            // 
            lnkUyeOl.ActiveLinkColor = Color.FromArgb(3, 105, 161);
            lnkUyeOl.AutoSize = true;
            lnkUyeOl.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 162);
            lnkUyeOl.LinkBehavior = LinkBehavior.HoverUnderline;
            lnkUyeOl.LinkColor = Color.FromArgb(2, 132, 199);
            lnkUyeOl.Location = new Point(260, 232);
            lnkUyeOl.Name = "lnkUyeOl";
            lnkUyeOl.Size = new Size(137, 20);
            lnkUyeOl.TabIndex = 4;
            lnkUyeOl.TabStop = true;
            lnkUyeOl.Text = "Hesabım yok, üye ol";
            lnkUyeOl.LinkClicked += lnkUyeOl_LinkClicked;
            // 
            // btnGiris
            // 
            btnGiris.BackColor = Color.FromArgb(2, 132, 199);
            btnGiris.Cursor = Cursors.Hand;
            btnGiris.FlatAppearance.BorderSize = 0;
            btnGiris.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 58, 138);
            btnGiris.FlatAppearance.MouseOverBackColor = Color.FromArgb(3, 105, 161);
            btnGiris.FlatStyle = FlatStyle.Flat;
            btnGiris.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnGiris.ForeColor = Color.White;
            btnGiris.Location = new Point(130, 180);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(250, 46);
            btnGiris.TabIndex = 3;
            btnGiris.Text = "Giriş Yap";
            btnGiris.UseVisualStyleBackColor = false;
            btnGiris.Click += btnGiris_Click;
            // 
            // txtSifre
            // 
            txtSifre.BorderStyle = BorderStyle.FixedSingle;
            txtSifre.Font = new Font("Segoe UI", 10F);
            txtSifre.Location = new Point(130, 122);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(250, 30);
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
            mskTc.Location = new Point(130, 67);
            mskTc.Mask = "00000000000";
            mskTc.Name = "mskTc";
            mskTc.Size = new Size(250, 30);
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
            lblTc.Size = new Size(112, 23);
            lblTc.TabIndex = 0;
            lblTc.Text = "TC Kimlik No:";
            // 
            // HastaGiris
            // 
            AcceptButton = btnGiris;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 245, 249);
            ClientSize = new Size(450, 430);
            Controls.Add(grpGiris);
            Controls.Add(pnlAccent);
            Controls.Add(pnlUst);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "HastaGiris";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hasta Girişi";
            Load += HastaGiris_Load;
            pnlUst.ResumeLayout(false);
            pnlUst.PerformLayout();
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
        public LinkLabel lnkUyeOl;
    }
}