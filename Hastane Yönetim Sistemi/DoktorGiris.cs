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
    public partial class DoktorGiris : Form
    {
        public DoktorGiris()
        {
            InitializeComponent();
            btnGiris.Click += btnGiris_Click;
        }

        SQLbaglanti bgl = new();

        private void btnGiris_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(mskTc.Text) || string.IsNullOrWhiteSpace(txtSifre.Text))
            {
                MessageBox.Show("Lütfen Personel No (TC) ve şifrenizi girin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlCommand cmd = new("SELECT COUNT(*) FROM Tbl_Doktorlar WHERE dr_tc = @tc AND dr_sifre = @sifre", bgl.Baglanti()))
                {
                    cmd.Parameters.AddWithValue("@tc", mskTc.Text);
                    cmd.Parameters.AddWithValue("@sifre", txtSifre.Text);

                    int sonuc = Convert.ToInt32(cmd.ExecuteScalar());

                    if (sonuc > 0)
                    {
                        DoktorDetay drDetay = new();
                        drDetay.DoktorTc = mskTc.Text;
                        drDetay.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Personel No (TC) veya Şifre hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Giriş sırasında hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                bgl.Baglanti().Close();
            }
        }
    }
}

