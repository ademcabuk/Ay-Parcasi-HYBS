using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.Intrinsics.X86;

namespace Hastane_Yönetim_Sistemi
{
    public partial class HastaGiris : Form
    {
        public HastaGiris()
        {
            InitializeComponent();
        }
        SQLbaglanti bgl = new();
        private void lnkUyeOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HastaKayit kayit = new();
            kayit.Show();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(mskTc.Text) || string.IsNullOrWhiteSpace(txtSifre.Text))
            {
                MessageBox.Show("Lütfen TC ve şifrenizi girin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Tbl_Hastalar WHERE hst_tc = @tc AND hst_sifre = @sifre", bgl.Baglanti()))
                {
                    cmd.Parameters.AddWithValue("@tc", mskTc.Text);
                    cmd.Parameters.AddWithValue("@sifre", txtSifre.Text);

                    int sonuc = Convert.ToInt32(cmd.ExecuteScalar());

                    if (sonuc > 0)
                    {
                        MessageBox.Show("Giriş Başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        HastaDetay hst = new();

                        // Önce hasta bilgilerini çek
                        string adsoyad = "";
                        string telefon = "";
                        using (SqlCommand cmd2 = new SqlCommand("SELECT hst_ad, hst_soyad, hst_telefon FROM Tbl_Hastalar WHERE hst_tc = @tc", bgl.Baglanti()))
                        {
                            cmd2.Parameters.AddWithValue("@tc", mskTc.Text);
                            using (SqlDataReader read = cmd2.ExecuteReader())
                            {
                                if (read.Read())
                                {
                                    adsoyad = read["hst_ad"].ToString() + " " + read["hst_soyad"].ToString();
                                    telefon = read["hst_telefon"].ToString();
                                }
                            }
                        }

                        // Label'lara değerleri Show()'dan ÖNCE ata
                        // böylece HastaDetay_Load içindeki randevu sorgusu doğru TC ile çalışır
                        hst.lblKisiTcDeger.Text = mskTc.Text;
                        hst.lblKisiAdSoyadDeger.Text = adsoyad;
                        hst.lblKisiTelDeger.Text = telefon;

                        hst.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("TC Kimlik Numarası veya Şifre hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (bgl.Baglanti().State == System.Data.ConnectionState.Open)
                {
                    bgl.Baglanti().Close();
                }
            }
        }

        private void HastaGiris_Load(object sender, EventArgs e)
        {
            
        }
    }
}
