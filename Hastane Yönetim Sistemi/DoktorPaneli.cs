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
    public partial class DoktorPaneli : Form
    {
        public DoktorPaneli()
        {
            InitializeComponent();
            Load += DoktorPaneli_Load;
            btnEkle.Click += btnEkle_Click;
            btnSil.Click += btnSil_Click;
            btnGuncelle.Click += btnGuncelle_Click;
            dgvDoktorlar.CellClick += dgvDoktorlar_CellClick;
        }

        SQLbaglanti bgl = new();

        private void DoktorPaneli_Load(object? sender, EventArgs e)
        {
            StilUygula(dgvDoktorlar);
            KolonlariAyarla();
            BranslariYukle();
            DoktorlariYukle();
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
            dgvDoktorlar.Columns.Clear();
            dgvDoktorlar.Columns.AddRange(new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "dr_id", HeaderText = "ID", Width = 50 },
                new DataGridViewTextBoxColumn { DataPropertyName = "dr_ad", HeaderText = "Ad", Width = 110 },
                new DataGridViewTextBoxColumn { DataPropertyName = "dr_soyad", HeaderText = "Soyad", Width = 110 },
                new DataGridViewTextBoxColumn { DataPropertyName = "dr_brans", HeaderText = "Branş", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill },
                new DataGridViewTextBoxColumn { DataPropertyName = "dr_tc", HeaderText = "TC No", Width = 110 },
                new DataGridViewTextBoxColumn { DataPropertyName = "dr_sifre", HeaderText = "Şifre", Width = 90 }
            });
        }

        private void BranslariYukle()
        {
            try
            {
                DataTable dt = new();
                using (SqlCommand cmd = new("SELECT brs_id, brs_ad FROM Tbl_Brans ORDER BY brs_ad ASC", bgl.Baglanti()))
                {
                    SqlDataAdapter da = new(cmd);
                    da.Fill(dt);
                }
                cmbBrans.DataSource = dt;
                cmbBrans.DisplayMember = "brs_ad";
                cmbBrans.ValueMember = "brs_ad";

                if (cmbBrans.Items.Count > 0)
                    cmbBrans.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Branşlar listelenirken hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                bgl.Baglanti().Close();
            }
        }

        private void DoktorlariYukle()
        {
            try
            {
                DataTable dt = new();
                string sorgu = "SELECT dr_id, dr_ad, dr_soyad, ISNULL(dr_brans, '') AS dr_brans, dr_tc, dr_sifre FROM Tbl_Doktorlar ORDER BY dr_id DESC";
                using (SqlCommand cmd = new(sorgu, bgl.Baglanti()))
                {
                    SqlDataAdapter da = new(cmd);
                    da.Fill(dt);
                }
                dgvDoktorlar.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Doktorlar listelenirken hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                bgl.Baglanti().Close();
            }
        }

        private void dgvDoktorlar_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvDoktorlar.Rows[e.RowIndex].DataBoundItem is DataRowView drv)
            {
                txtAd.Text = drv["dr_ad"].ToString();
                txtSoyad.Text = drv["dr_soyad"].ToString();
                txtTC.Text = drv["dr_tc"].ToString();
                txtSifre.Text = drv["dr_sifre"].ToString();

                string brans = drv["dr_brans"].ToString() ?? "";
                if (!string.IsNullOrEmpty(brans))
                {
                    cmbBrans.SelectedValue = brans;
                }
            }
        }

        private void Temizle()
        {
            txtAd.Clear();
            txtSoyad.Clear();
            txtTC.Clear();
            txtSifre.Clear();
            if (cmbBrans.Items.Count > 0)
                cmbBrans.SelectedIndex = 0;
        }

        private void btnEkle_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAd.Text) ||
                string.IsNullOrWhiteSpace(txtSoyad.Text) ||
                string.IsNullOrWhiteSpace(txtTC.Text) ||
                string.IsNullOrWhiteSpace(txtSifre.Text) ||
                cmbBrans.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen tüm alanları doldurun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string sorgu = "INSERT INTO Tbl_Doktorlar (dr_ad, dr_soyad, dr_brans, dr_tc, dr_sifre) VALUES (@ad, @soyad, @brans, @tc, @sifre)";
                using (SqlCommand cmd = new(sorgu, bgl.Baglanti()))
                {
                    cmd.Parameters.AddWithValue("@ad", txtAd.Text.Trim());
                    cmd.Parameters.AddWithValue("@soyad", txtSoyad.Text.Trim());
                    cmd.Parameters.AddWithValue("@brans", cmbBrans.Text);
                    cmd.Parameters.AddWithValue("@tc", txtTC.Text.Trim());
                    cmd.Parameters.AddWithValue("@sifre", txtSifre.Text);

                    int sonuc = cmd.ExecuteNonQuery();
                    if (sonuc > 0)
                    {
                        MessageBox.Show("Doktor başarıyla eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DoktorlariYukle();
                        Temizle();
                    }
                    else
                    {
                        MessageBox.Show("Doktor eklenemedi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Doktor eklenirken hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                bgl.Baglanti().Close();
            }
        }

        private void btnSil_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTC.Text))
            {
                MessageBox.Show("Lütfen tablodan silinecek doktoru seçin veya TC numarasını girin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult onay = MessageBox.Show("Bu doktoru silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (onay != DialogResult.Yes)
                return;

            try
            {
                using (SqlCommand cmd = new("DELETE FROM Tbl_Doktorlar WHERE dr_tc = @tc", bgl.Baglanti()))
                {
                    cmd.Parameters.AddWithValue("@tc", txtTC.Text.Trim());
                    int sonuc = cmd.ExecuteNonQuery();
                    if (sonuc > 0)
                    {
                        MessageBox.Show("Doktor başarıyla silindi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DoktorlariYukle();
                        Temizle();
                    }
                    else
                    {
                        MessageBox.Show("Belirtilen TC ile doktor bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Doktor silinirken hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                bgl.Baglanti().Close();
            }
        }

        private void btnGuncelle_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTC.Text) ||
                string.IsNullOrWhiteSpace(txtAd.Text) ||
                string.IsNullOrWhiteSpace(txtSoyad.Text) ||
                string.IsNullOrWhiteSpace(txtSifre.Text) ||
                cmbBrans.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen güncellenecek doktorun tüm alanlarını doldurun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string sorgu = @"UPDATE Tbl_Doktorlar 
                                 SET dr_ad = @ad, dr_soyad = @soyad, dr_brans = @brans, dr_sifre = @sifre 
                                 WHERE dr_tc = @tc";

                using (SqlCommand cmd = new(sorgu, bgl.Baglanti()))
                {
                    cmd.Parameters.AddWithValue("@ad", txtAd.Text.Trim());
                    cmd.Parameters.AddWithValue("@soyad", txtSoyad.Text.Trim());
                    cmd.Parameters.AddWithValue("@brans", cmbBrans.Text);
                    cmd.Parameters.AddWithValue("@sifre", txtSifre.Text);
                    cmd.Parameters.AddWithValue("@tc", txtTC.Text.Trim());

                    int sonuc = cmd.ExecuteNonQuery();
                    if (sonuc > 0)
                    {
                        MessageBox.Show("Doktor bilgileri başarıyla güncellendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DoktorlariYukle();
                        Temizle();
                    }
                    else
                    {
                        MessageBox.Show("Belirtilen TC ile doktor bulunamadı veya güncellenemedi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Doktor güncellenirken hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                bgl.Baglanti().Close();
            }
        }
    }
}

