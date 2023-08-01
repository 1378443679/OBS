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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-IV50TOE3;Initial Catalog=OgrenciBilgiSistemi;Integrated Security=True");
        

        private void btnKayitEkle_Click(object sender, EventArgs e)
        {
            frmKayitEkleme yeniform = new frmKayitEkleme();
            yeniform.Show();
        }

        private void btnNotGir_Click(object sender, EventArgs e)
        {
            frmNotGirisi NotGirisForm = new frmNotGirisi();
            NotGirisForm.ShowDialog();
        }

        private void btnKayitListele_Click(object sender, EventArgs e)
        {
            frmKayitlariListele frm = new frmKayitlariListele();
            frm.Show();
        }

        private void btnKayitGuncelle_Click(object sender, EventArgs e)
        {
            frmKayitDuzenleme frm = new frmKayitDuzenleme();
            frm.Show();
        }

        private void btnKayitSil_Click(object sender, EventArgs e)
        {
            frmKayitSilme frm = new frmKayitSilme();
            frm.Show();
        }

        private void btnRaporAl_Click(object sender, EventArgs e)
        {
            frmRaporlama frm = new frmRaporlama();
            frm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnKayitAra_Click(object sender, EventArgs e)
        {
            frmKayitArama frm = new frmKayitArama();
            frm.Show();
        }
    }
}
