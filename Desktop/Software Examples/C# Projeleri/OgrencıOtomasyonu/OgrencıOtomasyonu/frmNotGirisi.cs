using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OgrencıOtomasyonu
{
    public partial class frmNotGirisi : Form
    {
        public frmNotGirisi()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-IV50TOE3;Initial Catalog=OgrenciBilgiSistemi;Integrated Security=True");
        private void cmbBolumListe_TextChanged(object sender, EventArgs e)
        {
            conn.Open();

            SqlCommand query = new SqlCommand("SELECT TCKIMLIK, Bolum FROM OgrenciBilgiler WHERE TCKIMLIK NOT IN (SELECT TCKIMLIK FROM OgrenciNotlar) AND Bolum = " + "'" + cmbBolumListe.Text + "'", conn);
            SqlDataReader dr = query.ExecuteReader();

            while (dr.Read())
            {
                cmbTCKimlikNoListe.Items.Add(dr["TCKIMLIK"]);
            }
            dr.Close();
            query.Dispose();
            
            conn.Close();
        }

        private void cmbTCKimlikNoListe_TextChanged(object sender, EventArgs e)
        {
            conn.Open();

            SqlCommand query = new SqlCommand("SELECT AdSoyad FROM OgrenciBilgiler WHERE TCKIMLIK = " + "'" + cmbTCKimlikNoListe.Text + "'", conn);
            SqlDataReader dr = query.ExecuteReader();
            
            if (dr.Read())
            {
                lblAdSoyad.Text = dr["AdSoyad"].ToString();
            }
            query.Dispose();
            conn.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            int VizeNotu, FinalNotu;
            float Ortalama;

            if (msktxtVize.Text == "" || msktxtFinal.Text == "")
            {
                MessageBox.Show("Vize notu ve/veya final notu alanları boş geçilemez! Lütfen ilgili alanları doldurunuz.");
            }
            else
            {
                VizeNotu = Convert.ToInt32(msktxtVize.Text);
                FinalNotu = Convert.ToInt32(msktxtFinal.Text);

                if (VizeNotu > 100 || FinalNotu > 100)
                {
                    MessageBox.Show("Vize notu ve/veya final notu 100'den fazla olamaz! Gerekli düzenlemeyi yapınız");
                }
                else
                {
                    Ortalama = (VizeNotu * 0.3f) + (FinalNotu * 0.7f);
                    lblOrtalama.Text = Ortalama.ToString();

                    conn.Open();
                    SqlCommand NotKaydet = new SqlCommand("INSERT INTO OgrenciNotlar (TC_KIMLIK_NO, VIZE, FINAL, ORTALAMA) VALUES ('" + cmbTCKimlikNoListe.Text + "','" + msktxtVize.Text + "','" + msktxtFinal.Text + "','" + lblOrtalama.Text + "')", conn);
                    NotKaydet.ExecuteNonQuery();

                    MessageBox.Show("Notlar veritabanına aktarılmıştır", "Not Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    NotKaydet.Dispose();
                    conn.Close();

                    cmbTCKimlikNoListe.Items.RemoveAt(cmbTCKimlikNoListe.SelectedIndex);
                    msktxtFinal.Text = "";
                    msktxtVize.Text = "";
                    lblOrtalama.Text = "";
                    lblAdSoyad.Text = "";
                }
            }
        }
    }
}
