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
    public partial class frmKayitlariListele : Form
    {
        public frmKayitlariListele()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-IV50TOE3;Initial Catalog=OgrenciBilgiSistemi;Integrated Security=True");
        private void frmKayitlariListele_Load(object sender, EventArgs e)
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
    }
}
