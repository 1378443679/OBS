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
    public partial class frmKayitDuzenleme : Form
    {
        public frmKayitDuzenleme()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-IV50TOE3;Initial Catalog=OgrenciBilgiSistemi;Integrated Security=True");
        DataSet dt = new DataSet();

        public void VerileriListele()
        {
            conn.Open();

            SqlDataAdapter adt = new SqlDataAdapter("SELECT * FROM OgrenciBilgiler", conn);
            adt.Fill(dt, "OgrenciBilgiler");

            dataGridView1.DataMember = "OgrenciBilgiler";
            dataGridView1.DataSource = dt;

            adt.Dispose();
            conn.Close();
        }
        private void frmKayitDuzenleme_Load(object sender, EventArgs e)
        {
            VerileriListele();

            msktxtTCKimlikNo.DataBindings.Add("Text", dt, "OgrenciBilgiler.TCKIMLIKNO");
            txtAdSoyad.DataBindings.Add("Text", dt, "OgrenciBilgiler.AdSoyad");
            msktxtTelefon.DataBindings.Add("Text", dt, "OgrenciBilgiler.Telefon");
            cmbBolum.DataBindings.Add("Text", dt, "OgrenciBilgiler.Bolum");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("UPDATE OgrenciBilgiler SET AdSoyad ='" + txtAdSoyad.Text + "', Telefon= '" + msktxtTelefon.Text + "', Bolum = '" + cmbBolum.Text + "' WHERE TCKIMLIK = '" + msktxtTCKimlikNo.Text + "'", conn);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Veri güncelleme işlemi tamamlanmıştır", "Veri Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);

            cmd.Dispose();
            conn.Close();

            dt.Clear();
            VerileriListele();
        }
    }
}
