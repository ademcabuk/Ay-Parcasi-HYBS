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
    public partial class BransPaneli : Form
    {
        public BransPaneli()
        {
            InitializeComponent();
            Load += BransPaneli_Load;
            btnEkle.Click += btnEkle_Click;
            btnSil.Click += btnSil_Click;
            btnGuncelle.Click += btnGuncelle_Click;
            dgvBranslar.CellClick += dgvBranslar_CellClick;
        }

        SQLbaglanti bgl = new();

        private void BransPaneli_Load(object? sender, EventArgs e)
        {
            txtID.ReadOnly = true;
            txtID.BackColor = Color.FromArgb(241, 245, 249);
            txtID.TabStop = false;

            StilUygula(dgvBranslar);
            KolonlariAyarla();
            BranslariYukle();
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
                Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold),
                Alignment = DataGridViewContentAlignment.MiddleCenter,
                Padding = new Padding(0, 4, 0, 4)
            };
            dgv.ColumnHeadersHeight = 36;

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
            dgvBranslar.Columns.Clear();
            dgvBranslar.Columns.AddRange(new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "brs_id", HeaderText = "Branş ID", Width = 90 },
                new DataGridViewTextBoxColumn { DataPropertyName = "brs_ad", HeaderText = "Branş Adı", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill }
            });
            dgvBranslar.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        }

        private void BranslariYukle()
        {
            try
            {
                DataTable dt = new();
                using (SqlCommand cmd = new("SELECT brs_id, brs_ad FROM Tbl_Brans ORDER BY brs_id ASC", bgl.Baglanti()))
                {
                    SqlDataAdapter da = new(cmd);
                    da.Fill(dt);
                }
                dgvBranslar.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Branşlar yüklenirken hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                bgl.Baglanti().Close();
            }
        }

        private void dgvBranslar_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvBranslar.Rows[e.RowIndex].DataBoundItem is DataRowView drv)
            {
                txtID.Text = drv["brs_id"].ToString();
                txtBransAd.Text = drv["brs_ad"].ToString();
            }
        }

        private void Temizle()
        {
            txtID.Clear();
            txtBransAd.Clear();
        }

        private void btnEkle_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBransAd.Text))
            {
                MessageBox.Show("Lütfen branş adını girin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlCommand cmd = new("INSERT INTO Tbl_Brans (brs_ad) VALUES (@ad)", bgl.Baglanti()))
                {
                    cmd.Parameters.AddWithValue("@ad", txtBransAd.Text.Trim());
                    int sonuc = cmd.ExecuteNonQuery();
                    if (sonuc > 0)
                    {
                        MessageBox.Show("Branş başarıyla eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BranslariYukle();
                        Temizle();
                    }
                    else
                    {
                        MessageBox.Show("Branş eklenemedi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Branş eklenirken hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                bgl.Baglanti().Close();
            }
        }

        private void btnSil_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("Lütfen tablodan silinecek branşı seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult onay = MessageBox.Show("Bu branşı silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (onay != DialogResult.Yes)
                return;

            try
            {
                using (SqlCommand cmd = new("DELETE FROM Tbl_Brans WHERE brs_id = @id", bgl.Baglanti()))
                {
                    cmd.Parameters.AddWithValue("@id", txtID.Text.Trim());
                    int sonuc = cmd.ExecuteNonQuery();
                    if (sonuc > 0)
                    {
                        MessageBox.Show("Branş başarıyla silindi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BranslariYukle();
                        Temizle();
                    }
                    else
                    {
                        MessageBox.Show("Branş bulunamadı veya silinemedi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Branş silinirken hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                bgl.Baglanti().Close();
            }
        }

        private void btnGuncelle_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text) || string.IsNullOrWhiteSpace(txtBransAd.Text))
            {
                MessageBox.Show("Lütfen güncellenecek branşı tablodan seçin ve yeni adını girin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlCommand cmd = new("UPDATE Tbl_Brans SET brs_ad = @ad WHERE brs_id = @id", bgl.Baglanti()))
                {
                    cmd.Parameters.AddWithValue("@ad", txtBransAd.Text.Trim());
                    cmd.Parameters.AddWithValue("@id", txtID.Text.Trim());

                    int sonuc = cmd.ExecuteNonQuery();
                    if (sonuc > 0)
                    {
                        MessageBox.Show("Branş başarıyla güncellendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BranslariYukle();
                        Temizle();
                    }
                    else
                    {
                        MessageBox.Show("Branş bulunamadı veya güncellenemedi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Branş güncellenirken hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                bgl.Baglanti().Close();
            }
        }
    }
}

