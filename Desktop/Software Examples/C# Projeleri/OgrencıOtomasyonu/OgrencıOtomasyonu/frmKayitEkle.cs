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
    public partial class frmKayitEkleme : Form
    {
        public frmKayitEkleme()
        {
            InitializeComponent();
        }

        //private void Form1_Load(object sender, EventArgs e)
        //{
        //    // Ürünlerin Durum Seviyesi
        //    SqlCommand komut = new SqlCommand("Execute Test4", baglanti);
        //    SqlDataAdapter da = new SqlDataAdapter(komut);
        //    DataTable dt = new DataTable();
        //    da.Fill(dt);
        //    dataGridView1.DataSource = dt;

        //    // Grafiğe Veri Çekme İşlemi

        //    //chart1.Series["Akdeniz"].Points.AddXY("Adana", 24);
        //    //chart1.Series["Akdeniz"].Points.AddXY("Isparta", 21);

        //    baglanti.Open();
        //    SqlCommand komut2 = new SqlCommand("Select KATEGORIAD, COUNT(*) FROM TBLKATEGORI INNER JOIN TBLURUNLER ON TBLKATEGORI.KATEGORIID = TBLURUNLER.KATEGORI GROUP BY KATEGORIAD", baglanti);
        //    SqlDataReader dr = komut2.ExecuteReader();
            private void btnEkle_Click(object sender, EventArgs e)
        {
            if (msktxtTCKimlikNo.Text != "")
            {
                SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-IV50TOE3;Initial Catalog=OgrenciBilgiSistemi;Integrated Security=True; MultipleActiveResultSets = True");
                conn.Open();
                
                SqlCommand TCKimlikVarmiYokmu = new SqlCommand("SELECT * FROM OgrenciBilgiler WHERE TCKIMLIK=" + "'" + msktxtTCKimlikNo.Text + "'", conn);
                SqlDataReader dr = TCKimlikVarmiYokmu.ExecuteReader();
                

                if (dr.Read())
                {
                    MessageBox.Show("Daha önce kaydedilmiş TC Kimlik numarası girdiniz.", "Öğrenci Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtAdSoyad.Text = "";
                    msktxtTCKimlikNo.Text = "";
                }
                else
                {
                    var sqlFormattedDate = Convert.ToString("yyyy-MM-dd HH:mm:ss");
                    SqlCommand OgrenciKayitEkle = new SqlCommand("INSERT INTO OgrenciBilgiler (TCKIMLIK, ADSOYAD, DOGUMTARIHI, TELEFON, BOLUM) VALUES("+msktxtTCKimlikNo.Text + ",'" + txtAdSoyad.Text + "','" + dtpDogumTarihi.Value + "','" + msktxtTelefonNo.Text + "','" + cmbBolum.Text + "')", conn);
                    OgrenciKayitEkle.ExecuteNonQuery();

                    MessageBox.Show("Kayıt işlemi gerçekleştirilmiştir.","Öğrenci Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    OgrenciKayitEkle.Dispose();
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Lütfen TC Kimlik numarası giriniz", "TC Kimlik Numarası Alanı Boş!!",MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
    }
}
