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
    public partial class RandevuListesi : Form
    {
        public RandevuListesi()
        {
            InitializeComponent();
            Load += RandevuListesi_Load;
        }

        SQLbaglanti bgl = new();

        private void RandevuListesi_Load(object? sender, EventArgs e)
        {
            StilUygula(dgvRandevular);
            KolonlariAyarla();
            RandevulariYukle();
        }

        private void StilUygula(DataGridView dgv)
        {
            dgv.AutoGenerateColumns = false;
            dgv.RowHeadersVisible = false;
            dgv.EnableHeadersVisualStyles = false;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.GridColor = Color.FromArgb(204, 251, 241);

            dgv.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.FromArgb(17, 94, 89),
                ForeColor = Color.White,
                Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold),
                Alignment = DataGridViewContentAlignment.MiddleCenter,
                Padding = new Padding(0, 4, 0, 4)
            };
            dgv.ColumnHeadersHeight = 38;

            dgv.DefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.White,
                ForeColor = Color.FromArgb(30, 41, 59),
                Font = new Font("Segoe UI", 9.5F),
                SelectionBackColor = Color.FromArgb(204, 251, 241),
                SelectionForeColor = Color.FromArgb(17, 94, 89),
                Alignment = DataGridViewContentAlignment.MiddleCenter,
                Padding = new Padding(4, 3, 4, 3)
            };
            dgv.RowTemplate.Height = 34;

            dgv.AlternatingRowsDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.FromArgb(240, 253, 250),
                ForeColor = Color.FromArgb(30, 41, 59),
                SelectionBackColor = Color.FromArgb(204, 251, 241),
                SelectionForeColor = Color.FromArgb(17, 94, 89)
            };
        }

        private void KolonlariAyarla()
        {
            dgvRandevular.Columns.Clear();
            dgvRandevular.Columns.AddRange(new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "Rd_id", HeaderText = "ID", Width = 60 },
                new DataGridViewTextBoxColumn { DataPropertyName = "Rd_tarih", HeaderText = "Tarih", Width = 110 },
                new DataGridViewTextBoxColumn { DataPropertyName = "Rd_saat", HeaderText = "Saat", Width = 80 },
                new DataGridViewTextBoxColumn { DataPropertyName = "Brans", HeaderText = "Branş", Width = 140 },
                new DataGridViewTextBoxColumn { DataPropertyName = "Doktor", HeaderText = "Doktor", Width = 170 },
                new DataGridViewTextBoxColumn { DataPropertyName = "Hasta", HeaderText = "Hasta Adı Soyadı", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill },
                new DataGridViewTextBoxColumn { DataPropertyName = "hasta_tc", HeaderText = "Hasta TC", Width = 130 },
                new DataGridViewTextBoxColumn { DataPropertyName = "Durum", HeaderText = "Durum", Width = 90 }
            });
        }

        private void RandevulariYukle()
        {
            try
            {
                string sorgu = @"SELECT 
                                    r.Rd_id,
                                    r.Rd_tarih,
                                    r.Rd_saat,
                                    ISNULL(b.brs_ad, '') AS Brans,
                                    ISNULL(d.dr_ad + ' ' + d.dr_soyad, '') AS Doktor,
                                    ISNULL(h.hst_ad + ' ' + h.hst_soyad, 'Kayıtsız') AS Hasta,
                                    ISNULL(r.hasta_tc, '') AS hasta_tc,
                                    CASE WHEN r.Rd_durum = 1 THEN 'Dolu' ELSE 'Boş' END AS Durum
                                 FROM Tbl_Randevular r
                                 LEFT JOIN Tbl_Brans b ON r.Rd_brans = b.brs_id
                                 LEFT JOIN Tbl_Doktorlar d ON r.Rd_doktor = d.dr_id
                                 LEFT JOIN Tbl_Hastalar h ON r.hasta_tc = h.hst_tc
                                 ORDER BY r.Rd_id DESC";

                DataTable dt = new();
                using (SqlCommand cmd = new(sorgu, bgl.Baglanti()))
                {
                    SqlDataAdapter da = new(cmd);
                    da.Fill(dt);
                }
                dgvRandevular.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Randevular yüklenirken hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                bgl.Baglanti().Close();
            }
        }
    }
}

