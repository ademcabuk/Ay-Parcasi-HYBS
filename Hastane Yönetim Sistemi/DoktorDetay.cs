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
    public partial class DoktorDetay : Form
    {
        private Duyurular _duyurularForm;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string DoktorTc { get; set; } = "";
        private int _doktorId = 0;

        SQLbaglanti bgl = new();

        public DoktorDetay()
        {
            InitializeComponent();
            _duyurularForm = new Duyurular();
            btnDuyurular.Click += BtnDuyurular_Click;
            btnBilgilerimiGuncelle.Click += BtnBilgilerimiGuncelle_Click;
            Load += DoktorDetay_Load;
            dgvDoktorRandevular.CellClick += DgvDoktorRandevular_CellClick;
        }

        private void BtnDuyurular_Click(object? sender, EventArgs e)
        {
            _duyurularForm.ShowDialog();
        }

        private void BtnBilgilerimiGuncelle_Click(object? sender, EventArgs e)
        {
            DoktorGuncelle drGuncelle = new();
            drGuncelle.mskTc.Text = lblDoktorTcDeger.Text;
            drGuncelle.FormClosed += (s, args) => DoktorBilgileriniYukle();
            drGuncelle.Show();
        }

        private void DoktorDetay_Load(object? sender, EventArgs e)
        {
            StilUygula(dgvDoktorRandevular);
            DoktorBilgileriniYukle();
        }

        private void StilUygula(DataGridView dgv)
        {
            dgv.AutoGenerateColumns = false;
            dgv.RowHeadersVisible = false;
            dgv.EnableHeadersVisualStyles = false;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.GridColor = Color.FromArgb(204, 251, 241);

            // Başlık stili (Doktor paneli temasına uygun Teal/Yeşil tonu)
            dgv.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.FromArgb(17, 94, 89),
                ForeColor = Color.White,
                Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold),
                Alignment = DataGridViewContentAlignment.MiddleCenter,
                Padding = new Padding(0, 4, 0, 4)
            };
            dgv.ColumnHeadersHeight = 38;

            // Satır stili
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
            dgv.RowTemplate.Height = 36;

            // Alternatif satır rengi (zebra efekti)
            dgv.AlternatingRowsDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.FromArgb(240, 253, 250),
                ForeColor = Color.FromArgb(30, 41, 59),
                SelectionBackColor = Color.FromArgb(204, 251, 241),
                SelectionForeColor = Color.FromArgb(17, 94, 89)
            };

            // Kolonlar
            dgv.Columns.Clear();
            dgv.Columns.AddRange(new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "Rd_id", HeaderText = "ID", Width = 55 },
                new DataGridViewTextBoxColumn { DataPropertyName = "HastaAdSoyad", HeaderText = "Hasta Adı Soyadı", Width = 170, AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill },
                new DataGridViewTextBoxColumn { DataPropertyName = "Rd_tarih", HeaderText = "Tarih", Width = 120 },
                new DataGridViewTextBoxColumn { DataPropertyName = "Rd_saat", HeaderText = "Saat", Width = 85 },
                new DataGridViewTextBoxColumn { DataPropertyName = "Durum", HeaderText = "Durum", Width = 100 },
                new DataGridViewTextBoxColumn { DataPropertyName = "hasta_sikayet", HeaderText = "Şikayet", Visible = false }
            });
        }

        private void DoktorBilgileriniYukle()
        {
            string tc = !string.IsNullOrEmpty(DoktorTc) ? DoktorTc : lblDoktorTcDeger.Text;
            if (string.IsNullOrWhiteSpace(tc) || tc == "----------")
                return;

            try
            {
                string sorgu = @"SELECT dr_id, dr_ad, dr_soyad, dr_tc, dr_tel, ISNULL(dr_brans, 'Belirtilmedi') AS dr_brans
                                 FROM Tbl_Doktorlar
                                 WHERE dr_tc = @tc";

                using (SqlCommand cmd = new(sorgu, bgl.Baglanti()))
                {
                    cmd.Parameters.AddWithValue("@tc", tc);
                    using (SqlDataReader read = cmd.ExecuteReader())
                    {
                        if (read.Read())
                        {
                            _doktorId = Convert.ToInt32(read["dr_id"]);
                            lblDoktorTcDeger.Text = read["dr_tc"].ToString();
                            lblDoktorAdSoyadDeger.Text = read["dr_ad"].ToString() + " " + read["dr_soyad"].ToString();
                            lblDoktorBransDeger.Text = read["dr_brans"].ToString();
                            lblDoktorTelDeger.Text = read["dr_tel"] != DBNull.Value ? read["dr_tel"].ToString() : "Belirtilmedi";
                        }
                    }
                }

                if (_doktorId > 0)
                {
                    AktifRandevulariYukle(_doktorId);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Doktor bilgileri yüklenirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                bgl.Baglanti().Close();
            }
        }

        private void AktifRandevulariYukle(int doktorId)
        {
            try
            {
                string sorgu = @"SELECT 
                                    r.Rd_id,
                                    ISNULL(h.hst_ad + ' ' + h.hst_soyad, 'Kayıtsız Hasta') AS HastaAdSoyad,
                                    r.Rd_tarih,
                                    r.Rd_saat,
                                    CASE WHEN r.Rd_durum = 1 THEN 'Aktif' ELSE 'Pasif' END AS Durum,
                                    r.hasta_sikayet
                                 FROM Tbl_Randevular r
                                 LEFT JOIN Tbl_Hastalar h ON r.hasta_tc = h.hst_tc
                                 WHERE r.Rd_doktor = @doktorId AND r.Rd_durum = 1
                                 ORDER BY r.Rd_tarih DESC, r.Rd_saat DESC";

                using (SqlCommand cmd = new(sorgu, bgl.Baglanti()))
                {
                    cmd.Parameters.AddWithValue("@doktorId", doktorId);
                    DataTable dt = new();
                    SqlDataAdapter da = new(cmd);
                    da.Fill(dt);
                    dgvDoktorRandevular.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Randevular yüklenirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                bgl.Baglanti().Close();
            }
        }

        private void DgvDoktorRandevular_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvDoktorRandevular.Rows[e.RowIndex].DataBoundItem is DataRowView drv)
            {
                txtSikayet.Text = drv["hasta_sikayet"] != DBNull.Value ? drv["hasta_sikayet"].ToString() : "";
            }
        }

        private void DoktorDetay_Load_1(object sender, EventArgs e)
        {

        }
    }
}