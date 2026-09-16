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
    public partial class DoktorGuncelle : Form
    {
        public DoktorGuncelle()
        {
            InitializeComponent();
            Load += DoktorGuncelle_Load;
            btnGuncelle.Click += btnGuncelle_Click;
            btnIptal.Click += btnIptal_Click;
        }

        SQLbaglanti bgl = new();

        private void DoktorGuncelle_Load(object? sender, EventArgs e)
        {
            mskTc.ReadOnly = true;
            mskTc.BackColor = Color.FromArgb(241, 245, 249);
            mskTc.TabStop = false;

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
                cmbBrans.ValueMember = "brs_ad";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Branşlar yüklenirken hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                bgl.Baglanti().Close();
            }

            if (!string.IsNullOrWhiteSpace(mskTc.Text))
            {
                try
                {
                    using (SqlCommand cmd = new("SELECT dr_ad, dr_soyad, dr_sifre, dr_brans, dr_tel FROM Tbl_Doktorlar WHERE dr_tc = @tc", bgl.Baglanti()))
                    {
                        cmd.Parameters.AddWithValue("@tc", mskTc.Text);
                        using (SqlDataReader read = cmd.ExecuteReader())
                        {
                            if (read.Read())
                            {
                                txtAd.Text = read["dr_ad"].ToString();
                                txtSoyad.Text = read["dr_soyad"].ToString();
                                txtSifre.Text = read["dr_sifre"].ToString();
                                mskTelefon.Text = read["dr_tel"] != DBNull.Value ? read["dr_tel"].ToString() : "";
                                
                                if (read["dr_brans"] != DBNull.Value)
                                {
                                    cmbBrans.SelectedValue = read["dr_brans"].ToString();
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Doktor bilgileri çekilirken hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    bgl.Baglanti().Close();
                }
            }
        }

        private void btnGuncelle_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAd.Text) || 
                string.IsNullOrWhiteSpace(txtSoyad.Text) || 
                string.IsNullOrWhiteSpace(txtSifre.Text) ||
                cmbBrans.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen tüm zorunlu alanları doldurun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string sorgu = @"UPDATE Tbl_Doktorlar 
                                 SET dr_ad = @ad, dr_soyad = @soyad, dr_sifre = @sifre, dr_brans = @brans, dr_tel = @tel 
                                 WHERE dr_tc = @tc";

                using (SqlCommand cmd = new(sorgu, bgl.Baglanti()))
                {
                    cmd.Parameters.AddWithValue("@ad", txtAd.Text.Trim());
                    cmd.Parameters.AddWithValue("@soyad", txtSoyad.Text.Trim());
                    cmd.Parameters.AddWithValue("@sifre", txtSifre.Text);
                    cmd.Parameters.AddWithValue("@brans", cmbBrans.Text);
                    cmd.Parameters.AddWithValue("@tel", mskTelefon.Text.Trim());
                    cmd.Parameters.AddWithValue("@tc", mskTc.Text);

                    int sonuc = cmd.ExecuteNonQuery();
                    if (sonuc > 0)
                    {
                        MessageBox.Show("Bilgileriniz başarıyla güncellendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Güncelleme yapılamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme sırasında hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                bgl.Baglanti().Close();
            }
        }

        private void btnIptal_Click(object? sender, EventArgs e)
        {
            this.Close();
        }
    }
}
