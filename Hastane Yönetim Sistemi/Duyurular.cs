using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hastane_Yönetim_Sistemi
{
    public partial class Duyurular : Form
    {
        public Duyurular()
        {
            InitializeComponent();
            Load += Duyurular_Load;
        }

        SQLbaglanti bgl = new();

        private void Duyurular_Load(object? sender, EventArgs e)
        {
            StilUygula(dgvDuyurular);
            DuyurulariYukle();
        }

        private void StilUygula(DataGridView dgv)
        {
            dgv.AutoGenerateColumns = false;
            dgv.RowHeadersVisible = false;
            dgv.EnableHeadersVisualStyles = false;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.GridColor = Color.FromArgb(226, 232, 240);

            dgv.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.FromArgb(15, 23, 42),
                ForeColor = Color.White,
                Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold),
                Alignment = DataGridViewContentAlignment.MiddleCenter,
                Padding = new Padding(0, 5, 0, 5)
            };
            dgv.ColumnHeadersHeight = 40;

            dgv.DefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.White,
                ForeColor = Color.FromArgb(30, 41, 59),
                Font = new Font("Segoe UI", 9.5F),
                SelectionBackColor = Color.FromArgb(224, 242, 254),
                SelectionForeColor = Color.FromArgb(15, 23, 42),
                Alignment = DataGridViewContentAlignment.MiddleLeft,
                Padding = new Padding(6, 4, 6, 4)
            };
            dgv.RowTemplate.Height = 38;

            dgv.AlternatingRowsDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.FromArgb(248, 250, 252),
                ForeColor = Color.FromArgb(30, 41, 59),
                SelectionBackColor = Color.FromArgb(224, 242, 254),
                SelectionForeColor = Color.FromArgb(15, 23, 42)
            };

            dgv.Columns.Clear();
            dgv.Columns.AddRange(new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "duyuru_id", HeaderText = "ID", Width = 60 },
                new DataGridViewTextBoxColumn { DataPropertyName = "duyuru_tarih", HeaderText = "Tarih", Width = 120 },
                new DataGridViewTextBoxColumn { DataPropertyName = "duyuru_mesaj", HeaderText = "Duyuru Mesajı", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill }
            });
            dgv.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        public void DuyurulariYukle()
        {
            try
            {
                DataTable dt = new();
                using (SqlCommand cmd = new("SELECT duyuru_id, duyuru_tarih, duyuru_mesaj FROM Tbl_Duyurular ORDER BY duyuru_id DESC", bgl.Baglanti()))
                {
                    SqlDataAdapter da = new(cmd);
                    da.Fill(dt);
                }
                dgvDuyurular.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Duyurular yüklenirken hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                bgl.Baglanti().Close();
            }
        }
    }
}

