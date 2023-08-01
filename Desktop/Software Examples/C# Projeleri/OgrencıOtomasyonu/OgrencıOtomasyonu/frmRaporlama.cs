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
    public partial class frmRaporlama : Form
    {
        public frmRaporlama()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-IV50TOE3;Initial Catalog=OgrenciBilgiSistemi;Integrated Security=True");
        private void frmRaporlama_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Execute GetNotes", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Execute GetAvgNotes", baglanti);
            SqlDataReader dr = komut2.ExecuteReader();

            while (dr.Read())
            {
                chart1.Series["Ortalama"].Points.Add(Convert.ToDouble(dr[0]));
            }
            baglanti.Close();

        }
    }
}
