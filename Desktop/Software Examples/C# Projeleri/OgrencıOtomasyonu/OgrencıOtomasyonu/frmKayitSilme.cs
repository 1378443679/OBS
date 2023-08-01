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
    public partial class frmKayitSilme : Form
    {
        public frmKayitSilme()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-IV50TOE3;Initial Catalog=OgrenciBilgiSistemi;Integrated Security=True");
        void VeriListele()
        {
            DataSet dt = new DataSet();
            conn.Open();

            SqlDataAdapter adt = new SqlDataAdapter("SELECT OgrenciBilgiler.TCKIMLIK, OgrenciBilgiler.AdSoyad, OgrenciNotlar.VIZE, OgrenciNotlar.FINAL, OgrenciNotlar.Ortalama FROM OgrenciBilgiler, OgrenciNotlar WHERE OgrenciBilgiler.TCKIMLIK = OgrenciNotlar.TC_KIMLIK_NO", conn);
            adt.Fill(dt, "OgrenciBilgiler");

            dataGridView1.DataMember = "OgrenciBilgiler";
            dataGridView1.DataSource = dt;

            adt.Dispose();
            conn.Close();
        }
        private void frmKayitSilme_Load(object sender, EventArgs e)
        {
            VeriListele();
            
        }

        private void btnKayitSil_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand komut = new SqlCommand("DELETE FROM OgrenciBilgiler WHERE TCKIMLIK = @P1", conn);
            komut.Parameters.AddWithValue("@P1", msktxtTCKimlikNo.Text);
            komut.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Müşteri Silindi");
            VeriListele();
        }
    }
}
