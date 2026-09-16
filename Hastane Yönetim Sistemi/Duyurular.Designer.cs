namespace Hastane_Yönetim_Sistemi
{
    partial class Duyurular
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
            dgvDuyurular = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvDuyurular).BeginInit();
            SuspendLayout();
            //
            // dgvDuyurular
            //
            dgvDuyurular.AllowUserToAddRows = false;
            dgvDuyurular.AllowUserToDeleteRows = false;
            dgvDuyurular.BackgroundColor = Color.White;
            dgvDuyurular.BorderStyle = BorderStyle.None;
            dgvDuyurular.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvDuyurular.ColumnHeadersHeight = 29;
            dgvDuyurular.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvDuyurular.Dock = DockStyle.Fill;
            dgvDuyurular.Location = new Point(0, 0);
            dgvDuyurular.Name = "dgvDuyurular";
            dgvDuyurular.ReadOnly = true;
            dgvDuyurular.RowHeadersWidth = 51;
            dgvDuyurular.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvDuyurular.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDuyurular.Size = new Size(800, 450);
            //
            // Duyurular
            //
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 247, 246);
            ClientSize = new Size(800, 450);
            Controls.Add(dgvDuyurular);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Duyurular";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Duyurular";
            ((System.ComponentModel.ISupportInitialize)dgvDuyurular).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public DataGridView dgvDuyurular;
    }
}