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
    public partial class HastaGuncelle : Form
    {
        public HastaGuncelle()
        {
            InitializeComponent();
        }

        SQLbaglanti bgl = new();

        private void HastaGuncelle_Load(object sender, EventArgs e)
        {
            mskTc.ReadOnly = true;
            mskTc.BackColor = Color.FromArgb(241, 245, 249);
            mskTc.TabStop = false;

            cmbCinsiyet.Items.Clear();
            cmbCinsiyet.Items.Add("Erkek");
            cmbCinsiyet.Items.Add("Kadın");

            try
            {
                using (SqlCommand cmd = new(
                    "SELECT hst_ad, hst_soyad, hst_telefon, hst_sifre, hst_cinsiyet FROM Tbl_Hastalar WHERE hst_tc = @tc",
                    bgl.Baglanti()))
                {
                    cmd.Parameters.AddWithValue("@tc", mskTc.Text);
                    using (SqlDataReader read = cmd.ExecuteReader())
                    {
                        if (read.Read())
                        {
                            txtAd.Text = read["hst_ad"].ToString();
                            txtSoyad.Text = read["hst_soyad"].ToString();
                            mskTelefon.Text = read["hst_telefon"].ToString();
                            txtSifre.Text = read["hst_sifre"].ToString();

                            string cinsiyet = read["hst_cinsiyet"].ToString()?.Trim() ?? "";
                            if (cinsiyet == "Erkek")
                                cmbCinsiyet.SelectedIndex = 0;
                            else if (cinsiyet == "Kadın")
                                cmbCinsiyet.SelectedIndex = 1;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bilgi yükleme hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                bgl.Baglanti().Close();
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAd.Text) ||
                string.IsNullOrWhiteSpace(txtSoyad.Text) ||
                string.IsNullOrWhiteSpace(mskTelefon.Text) ||
                string.IsNullOrWhiteSpace(txtSifre.Text) ||
                cmbCinsiyet.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen tüm alanları doldurun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlCommand cmd = new(
                    "UPDATE Tbl_Hastalar SET hst_ad=@ad, hst_soyad=@soyad, hst_telefon=@telefon, hst_sifre=@sifre, hst_cinsiyet=@cinsiyet WHERE hst_tc=@tc",
                    bgl.Baglanti()))
                {
                    cmd.Parameters.AddWithValue("@ad", txtAd.Text.Trim());
                    cmd.Parameters.AddWithValue("@soyad", txtSoyad.Text.Trim());
                    cmd.Parameters.AddWithValue("@telefon", mskTelefon.Text.Trim());
                    cmd.Parameters.AddWithValue("@sifre", txtSifre.Text);
                    cmd.Parameters.AddWithValue("@cinsiyet", cmbCinsiyet.SelectedItem.ToString());
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
                MessageBox.Show("Güncelleme hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                bgl.Baglanti().Close();
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
