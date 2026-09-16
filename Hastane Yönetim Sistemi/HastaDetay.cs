using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Hastane_Yönetim_Sistemi
{
    public partial class HastaDetay : Form
    {
        public HastaDetay()
        {
            InitializeComponent();
        }

        SQLbaglanti bgl = new();

        private void HastaDetay_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dtBrans = new();
                using (SqlCommand cmd = new("SELECT brs_id, brs_ad FROM Tbl_Brans", bgl.Baglanti()))
                {
                    SqlDataAdapter da = new(cmd);
                    da.Fill(dtBrans);
                }
                cmbBrans.DataSource = dtBrans;
                cmbBrans.DisplayMember = "brs_ad";
                cmbBrans.ValueMember = "brs_id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Branş hatası: " + ex.Message);
            }
            finally
            {
                bgl.Baglanti().Close();
            }

            try
            {
                DataTable dtDoktor = new();
                using (SqlCommand cmd2 = new("SELECT dr_id, dr_ad + ' ' + dr_soyad AS dr_adsoyad FROM Tbl_Doktorlar", bgl.Baglanti()))
                {
                    SqlDataAdapter da2 = new(cmd2);
                    da2.Fill(dtDoktor);
                }
                cmbDoktor.DataSource = dtDoktor;
                cmbDoktor.DisplayMember = "dr_adsoyad";
                cmbDoktor.ValueMember = "dr_id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Doktor hatası: " + ex.Message);
            }
            finally
            {
                bgl.Baglanti().Close();
            }

            if (cmbBrans.Items.Count > 0)
            {
                cmbBrans.SelectedIndex = 0;
            }
            if (cmbDoktor.Items.Count > 0)
            {
                cmbDoktor.SelectedIndex = 0;
            }

            txtSikayet.MaxLength = 250;

            StilUygula(dgvAktifRandevular);
            StilUygula(dgvRandevuGecmisi);

            RandevuYukle(dgvAktifRandevular, 1);

            RandevuYukle(dgvRandevuGecmisi, 0);
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
                BackColor = Color.FromArgb(30, 58, 138),
                ForeColor = Color.White,
                Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold),
                Alignment = DataGridViewContentAlignment.MiddleCenter,
                Padding = new Padding(0, 4, 0, 4)
            };
            dgv.ColumnHeadersHeight = 38;

            dgv.DefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.White,
                ForeColor = Color.FromArgb(30, 41, 59),
                Font = new Font("Segoe UI", 9.5F),
                SelectionBackColor = Color.FromArgb(219, 234, 254),
                SelectionForeColor = Color.FromArgb(30, 41, 59),
                Alignment = DataGridViewContentAlignment.MiddleCenter,
                Padding = new Padding(4, 3, 4, 3)
            };
            dgv.RowTemplate.Height = 36;

            dgv.AlternatingRowsDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.FromArgb(248, 250, 252),
                ForeColor = Color.FromArgb(30, 41, 59),
                SelectionBackColor = Color.FromArgb(219, 234, 254),
                SelectionForeColor = Color.FromArgb(30, 41, 59)
            };

            dgv.Columns.Clear();
            dgv.Columns.AddRange(new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "Rd_id",   HeaderText = "ID",     Width = 55  },
                new DataGridViewTextBoxColumn { DataPropertyName = "Tarih",   HeaderText = "Tarih",  Width = 120 },
                new DataGridViewTextBoxColumn { DataPropertyName = "Saat",    HeaderText = "Saat",   Width = 80  },
                new DataGridViewTextBoxColumn { DataPropertyName = "Brans",   HeaderText = "Branş",  Width = 130 },
                new DataGridViewTextBoxColumn { DataPropertyName = "Doktor",  HeaderText = "Doktor", Width = 100, AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill },
                new DataGridViewTextBoxColumn { DataPropertyName = "Durum",   HeaderText = "Durum",  Width = 90  }
            });
        }

        private void RandevuYukle(DataGridView dgv, int durumDeger)
        {
            try
            {
                string sorgu =
                    @"SELECT 
                        r.Rd_id,
                        r.Rd_tarih   AS Tarih,
                        r.Rd_saat    AS Saat,
                        ISNULL(b.brs_ad, '') AS Brans,
                        ISNULL(d.dr_ad + ' ' + d.dr_soyad, '') AS Doktor,
                        CASE WHEN r.Rd_durum = 1 THEN 'Aktif' ELSE 'Tamamlandı' END AS Durum
                      FROM Tbl_Randevular r
                      LEFT JOIN Tbl_Brans b ON r.Rd_brans = b.brs_id
                      LEFT JOIN Tbl_Doktorlar d ON r.Rd_doktor = d.dr_id
                      WHERE r.hasta_tc = @tc AND r.Rd_durum = @durum
                      ORDER BY r.Rd_tarih DESC";

                using (SqlCommand cmd = new(sorgu, bgl.Baglanti()))
                {
                    cmd.Parameters.AddWithValue("@tc", lblKisiTcDeger.Text);
                    cmd.Parameters.AddWithValue("@durum", durumDeger);
                    DataTable dt = new();
                    SqlDataAdapter da = new(cmd);
                    da.Fill(dt);
                    dgv.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Randevu yükleme hatası: " + ex.Message);
            }
            finally
            {
                bgl.Baglanti().Close();
            }
        }

        private void btnRandevuAl_Click(object sender, EventArgs e)
        {
            if (cmbBrans.SelectedIndex == -1 || cmbDoktor.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen branş ve doktor seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string sorgu =
                    @"INSERT INTO Tbl_Randevular (Rd_tarih, Rd_saat, Rd_brans, Rd_doktor, Rd_durum, hasta_tc, hasta_sikayet)
                      VALUES (@tarih, @saat, @brans, @doktor, @durum, @tc, @sikayet)";

                using (SqlCommand cmd = new(sorgu, bgl.Baglanti()))
                {
                    cmd.Parameters.AddWithValue("@tarih", DateTime.Now.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@saat", DateTime.Now.ToString("HH:mm"));
                    cmd.Parameters.AddWithValue("@brans", cmbBrans.SelectedValue);
                    cmd.Parameters.AddWithValue("@doktor", cmbDoktor.SelectedValue);
                    cmd.Parameters.AddWithValue("@durum", 1);
                    cmd.Parameters.AddWithValue("@tc", lblKisiTcDeger.Text);
                    cmd.Parameters.AddWithValue("@sikayet", txtSikayet.Text.Trim());

                    int sonuc = cmd.ExecuteNonQuery();

                    if (sonuc > 0)
                    {
                        MessageBox.Show("Randevunuz başarıyla oluşturuldu!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtSikayet.Clear();

                        RandevuYukle(dgvAktifRandevular, 1);
                        RandevuYukle(dgvRandevuGecmisi, 0);
                    }
                    else
                    {
                        MessageBox.Show("Randevu oluşturulamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Randevu hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                bgl.Baglanti().Close();
            }
        }

        private void dgvRandevuGecmisi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lnkBilgilerimiGuncelle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HastaGuncelle hstg = new();
            hstg.mskTc.Text = lblKisiTcDeger.Text;
            hstg.FormClosed += (s, args) => KisiBilgileriniYenile();
            hstg.Show();
        }

        private void KisiBilgileriniYenile()
        {
            try
            {
                using (SqlCommand cmd = new(
                    "SELECT hst_ad, hst_soyad, hst_telefon FROM Tbl_Hastalar WHERE hst_tc = @tc",
                    bgl.Baglanti()))
                {
                    cmd.Parameters.AddWithValue("@tc", lblKisiTcDeger.Text);
                    using (SqlDataReader read = cmd.ExecuteReader())
                    {
                        if (read.Read())
                        {
                            lblKisiAdSoyadDeger.Text = read["hst_ad"].ToString() + " " + read["hst_soyad"].ToString();
                            lblKisiTelDeger.Text = read["hst_telefon"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bilgi yenileme hatası: " + ex.Message);
            }
            finally
            {
                bgl.Baglanti().Close();
            }
        }

        private void btnSikayetKaydet_Click(object sender, EventArgs e)
        {

        }
    }
}

