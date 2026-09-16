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
    public partial class HastaKayit : Form
    {
        public HastaKayit()
        {
            InitializeComponent();
        }
        SQLbaglanti bgl = new();
        private void HastaKayit_Load(object sender, EventArgs e)
        {

        }

        private void btnUyeOl_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAd.Text) ||
                string.IsNullOrWhiteSpace(txtSoyad.Text) ||
                string.IsNullOrWhiteSpace(mskTC.Text) ||
                string.IsNullOrWhiteSpace(mskTelefon.Text) ||
                string.IsNullOrWhiteSpace(txtSifre.Text) ||
                cmbCinsiyet.SelectedItem == null)
            {
                MessageBox.Show("Lütfen tüm alanları eksiksiz doldurun!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            SqlCommand cmd = new("insert into Tbl_Hastalar(hst_ad,hst_soyad,hst_tc,hst_telefon,hst_sifre,hst_cinsiyet) values(@ad,@soyad,@tc,@telefon,@sifre,@cinsiyet)", bgl.Baglanti());
            cmd.Parameters.AddWithValue("@ad", txtAd.Text);
            cmd.Parameters.AddWithValue("@soyad", txtSoyad.Text);
            cmd.Parameters.AddWithValue("@tc", mskTC.Text);
            cmd.Parameters.AddWithValue("@telefon", mskTelefon.Text);
            cmd.Parameters.AddWithValue("@sifre", txtSifre.Text);
            cmd.Parameters.AddWithValue("@cinsiyet", cmbCinsiyet.SelectedItem.ToString());

            cmd.ExecuteNonQuery();
            bgl.Baglanti().Close();

            MessageBox.Show("Kayıt Başarılı! \nTC'niz: " + mskTC.Text + "\nŞifreniz: " + txtSifre.Text, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
