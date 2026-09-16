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
    public partial class SekreterDetay : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string SekreterTc { get; set; } = "";

        SQLbaglanti bgl = new();

        public SekreterDetay()
        {
            InitializeComponent();
            Load += SekreterDetay_Load;
            btnDuyuruOlustur.Click += btnDuyuruOlustur_Click;
            btnDoktorPaneli.Click += btnDoktorPaneli_Click;
            btnBransPaneli.Click += btnBransPaneli_Click;
            btnRandevuListesi.Click += btnRandevuListesi_Click;
            btnRandevuEkle.Click += btnRandevuEkle_Click;
            btnRandevuGuncelle.Click += btnRandevuGuncelle_Click;
            cmbBrans.SelectedIndexChanged += cmbBrans_SelectedIndexChanged;
        }

        private void SekreterDetay_Load(object? sender, EventArgs e)
        {
            rtxtDuyuru.MaxLength = 300;

            dtpSaat.Format = DateTimePickerFormat.Custom;
            dtpSaat.CustomFormat = "HH:mm";
            dtpSaat.ShowUpDown = true;

            StilUygula(dgvBranslar);
            StilUygula(dgvDoktorlar);

            BransKolonlariniAyarla();
            DoktorKolonlariniAyarla();

            SekreterBilgileriniYukle();
            BranslariYukle();
            DoktorlariYukle();
            RandevuBranslariniYukle();
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
                Alignment = DataGridViewContentAlignment.MiddleLeft,
                Padding = new Padding(6, 3, 6, 3)
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

        private void BransKolonlariniAyarla()
        {
            dgvBranslar.Columns.Clear();
            dgvBranslar.Columns.AddRange(new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "brs_id", HeaderText = "ID", Width = 60 },
                new DataGridViewTextBoxColumn { DataPropertyName = "brs_ad", HeaderText = "Branş Adı", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill }
            });
            dgvBranslar.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void DoktorKolonlariniAyarla()
        {
            dgvDoktorlar.Columns.Clear();
            dgvDoktorlar.Columns.AddRange(new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "DoktorAdSoyad", HeaderText = "Doktor Adı Soyadı", Width = 150, AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill },
                new DataGridViewTextBoxColumn { DataPropertyName = "dr_brans", HeaderText = "Branş", Width = 130 }
            });
        }

        private void SekreterBilgileriniYukle()
        {
            string tc = !string.IsNullOrEmpty(SekreterTc) ? SekreterTc : lblSekreterTcDeger.Text;
            if (string.IsNullOrWhiteSpace(tc) || tc == "----------")
                return;

            try
            {
                using (SqlCommand cmd = new("SELECT sek_tc, sek_AdSoyad FROM Tbl_Sekreterler WHERE sek_tc = @tc", bgl.Baglanti()))
                {
                    cmd.Parameters.AddWithValue("@tc", tc);
                    using (SqlDataReader read = cmd.ExecuteReader())
                    {
                        if (read.Read())
                        {
                            lblSekreterTcDeger.Text = read["sek_tc"].ToString();
                            lblSekreterAdSoyadDeger.Text = read["sek_AdSoyad"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sekreter bilgileri yüklenirken hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                bgl.Baglanti().Close();
            }
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

        private void DoktorlariYukle()
        {
            try
            {
                DataTable dt = new();
                string sorgu = @"SELECT (dr_ad + ' ' + dr_soyad) AS DoktorAdSoyad, ISNULL(dr_brans, 'Belirtilmedi') AS dr_brans 
                                 FROM Tbl_Doktorlar 
                                 ORDER BY dr_ad ASC";

                using (SqlCommand cmd = new(sorgu, bgl.Baglanti()))
                {
                    SqlDataAdapter da = new(cmd);
                    da.Fill(dt);
                }
                dgvDoktorlar.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Doktorlar yüklenirken hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                bgl.Baglanti().Close();
            }
        }

        private void RandevuBranslariniYukle()
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
                cmbBrans.ValueMember = "brs_id";

                if (cmbBrans.Items.Count > 0)
                {
                    cmbBrans.SelectedIndex = 0;
                    BransaGoreDoktorlariYukle(Convert.ToInt32(cmbBrans.SelectedValue), cmbBrans.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Randevu branşları yüklenirken hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                bgl.Baglanti().Close();
            }
        }

        private void cmbBrans_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (cmbBrans.SelectedValue != null && int.TryParse(cmbBrans.SelectedValue.ToString(), out int brsId))
            {
                BransaGoreDoktorlariYukle(brsId, cmbBrans.Text);
            }
        }

        private void BransaGoreDoktorlariYukle(int brsId, string brsAd)
        {
            try
            {
                DataTable dt = new();
                string sorgu = @"SELECT dr_id, (dr_ad + ' ' + dr_soyad) AS dr_adsoyad 
                                 FROM Tbl_Doktorlar 
                                 WHERE dr_brans = @brsAd OR dr_brans = @brsIdStr
                                 ORDER BY dr_ad ASC";

                using (SqlCommand cmd = new(sorgu, bgl.Baglanti()))
                {
                    cmd.Parameters.AddWithValue("@brsAd", brsAd);
                    cmd.Parameters.AddWithValue("@brsIdStr", brsId.ToString());
                    SqlDataAdapter da = new(cmd);
                    da.Fill(dt);
                }
                cmbDoktor.DataSource = dt;
                cmbDoktor.DisplayMember = "dr_adsoyad";
                cmbDoktor.ValueMember = "dr_id";
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

        private bool HastaVarMi(string tc)
        {
            try
            {
                using (SqlCommand cmd = new("SELECT COUNT(*) FROM Tbl_Hastalar WHERE hst_tc = @tc", bgl.Baglanti()))
                {
                    cmd.Parameters.AddWithValue("@tc", tc);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
            catch
            {
                return false;
            }
            finally
            {
                bgl.Baglanti().Close();
            }
        }

        private void btnRandevuEkle_Click(object? sender, EventArgs e)
        {
            if (cmbBrans.SelectedIndex == -1 || cmbDoktor.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen branş ve doktor seçimini yapın!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string hastaTc = txtHastaTC.Text.Trim();
            if (!string.IsNullOrEmpty(hastaTc) && !HastaVarMi(hastaTc))
            {
                MessageBox.Show("Girdiğiniz TC kimlik numarasına ait bir hasta bulunamadı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string sorgu = @"INSERT INTO Tbl_Randevular (Rd_tarih, Rd_saat, Rd_brans, Rd_doktor, Rd_durum, hasta_tc)
                                 VALUES (@tarih, @saat, @brans, @doktor, @durum, @tc)";

                using (SqlCommand cmd = new(sorgu, bgl.Baglanti()))
                {
                    cmd.Parameters.AddWithValue("@tarih", dtpTarih.Value.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@saat", dtpSaat.Value.ToString("HH:mm"));
                    cmd.Parameters.AddWithValue("@brans", cmbBrans.SelectedValue);
                    cmd.Parameters.AddWithValue("@doktor", cmbDoktor.SelectedValue);
                    cmd.Parameters.AddWithValue("@durum", chkDurum.Checked ? 1 : 0);
                    cmd.Parameters.AddWithValue("@tc", string.IsNullOrEmpty(hastaTc) ? (object)DBNull.Value : hastaTc);

                    int sonuc = cmd.ExecuteNonQuery();
                    if (sonuc > 0)
                    {
                        MessageBox.Show("Randevu başarıyla eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtRandevuId.Clear();
                        txtHastaTC.Clear();
                        chkDurum.Checked = false;
                    }
                    else
                    {
                        MessageBox.Show("Randevu eklenemedi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Randevu eklenirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                bgl.Baglanti().Close();
            }
        }

        private void btnRandevuGuncelle_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRandevuId.Text))
            {
                MessageBox.Show("Lütfen güncellenecek Randevu ID numarasını girin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbBrans.SelectedIndex == -1 || cmbDoktor.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen branş ve doktor seçimini yapın!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string hastaTc = txtHastaTC.Text.Trim();
            if (!string.IsNullOrEmpty(hastaTc) && !HastaVarMi(hastaTc))
            {
                MessageBox.Show("Girdiğiniz TC kimlik numarasına ait bir hasta bulunamadı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string sorgu = @"UPDATE Tbl_Randevular 
                                 SET Rd_tarih = @tarih, Rd_saat = @saat, Rd_brans = @brans, Rd_doktor = @doktor, Rd_durum = @durum, hasta_tc = @tc
                                 WHERE Rd_id = @id";

                using (SqlCommand cmd = new(sorgu, bgl.Baglanti()))
                {
                    cmd.Parameters.AddWithValue("@id", txtRandevuId.Text.Trim());
                    cmd.Parameters.AddWithValue("@tarih", dtpTarih.Value.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@saat", dtpSaat.Value.ToString("HH:mm"));
                    cmd.Parameters.AddWithValue("@brans", cmbBrans.SelectedValue);
                    cmd.Parameters.AddWithValue("@doktor", cmbDoktor.SelectedValue);
                    cmd.Parameters.AddWithValue("@durum", chkDurum.Checked ? 1 : 0);
                    cmd.Parameters.AddWithValue("@tc", string.IsNullOrEmpty(hastaTc) ? (object)DBNull.Value : hastaTc);

                    int sonuc = cmd.ExecuteNonQuery();
                    if (sonuc > 0)
                    {
                        MessageBox.Show("Randevu başarıyla güncellendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Belirtilen ID ile randevu bulunamadı veya güncellenemedi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Randevu güncellenirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                bgl.Baglanti().Close();
            }
        }

        private void btnDuyuruOlustur_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(rtxtDuyuru.Text))
            {
                MessageBox.Show("Lütfen bir duyuru metni yazın!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string tarih = DateTime.Now.ToString("dd.MM.yyyy");
                string sorgu = "INSERT INTO Tbl_Duyurular (duyuru_mesaj, duyuru_tarih) VALUES (@mesaj, @tarih)";

                using (SqlCommand cmd = new(sorgu, bgl.Baglanti()))
                {
                    cmd.Parameters.AddWithValue("@mesaj", rtxtDuyuru.Text.Trim());
                    cmd.Parameters.AddWithValue("@tarih", tarih);

                    int sonuc = cmd.ExecuteNonQuery();
                    if (sonuc > 0)
                    {
                        MessageBox.Show("Duyuru başarıyla yayınlandı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        rtxtDuyuru.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Duyuru yayınlanamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Duyuru kaydedilirken hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                bgl.Baglanti().Close();
            }
        }

        private void btnDoktorPaneli_Click(object? sender, EventArgs e)
        {
            DoktorPaneli drPaneli = new();
            drPaneli.ShowDialog();
            DoktorlariYukle();
            if (cmbBrans.SelectedValue != null && int.TryParse(cmbBrans.SelectedValue.ToString(), out int brsId))
            {
                BransaGoreDoktorlariYukle(brsId, cmbBrans.Text);
            }
        }

        private void btnBransPaneli_Click(object? sender, EventArgs e)
        {
            BransPaneli brsPaneli = new();
            brsPaneli.ShowDialog();
            BranslariYukle();
            RandevuBranslariniYukle();
        }

        private void btnRandevuListesi_Click(object? sender, EventArgs e)
        {
            RandevuListesi rndListesi = new();
            rndListesi.ShowDialog();
        }
    }
}

