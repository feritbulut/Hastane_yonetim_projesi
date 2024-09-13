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

namespace Hastane_proje
{
    public partial class BilgiDuzenle : Form
    {
        public BilgiDuzenle()
        {
            InitializeComponent();
        }

        public string TCno;

        sqlbaglantısı bgl = new sqlbaglantısı();

        private void Btnbilgiguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("update Tbl_hastalar set HastaAd=@p1,HastaSoyad=@p2,HastaTelefon=@p3,Hastasifre=@p4,HastaCinsiyet=@p5 where HastaTc=@p6",bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", Txtad.Text);
            komut2.Parameters.AddWithValue("@p2", Txtsoyad.Text);
            komut2.Parameters.AddWithValue("@p3", Msktelefon.Text);
            komut2.Parameters.AddWithValue("@p4", Txtsifre.Text);
            komut2.Parameters.AddWithValue("@p5", Cmbcinsiyet.Text);
            komut2.Parameters.AddWithValue("@p6", MskTC.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgileriniz Güncellendi.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }

        private void BilgiDuzenle_Load(object sender, EventArgs e)
        {
            MskTC.Text = TCno;
            SqlCommand komut = new SqlCommand("select * from Tbl_hastalar where HastaTC=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MskTC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read()) 
            {
                Txtad.Text = dr[1].ToString();
                Txtsoyad.Text = dr[2].ToString();
                Msktelefon.Text = dr[4].ToString();
                Txtsifre.Text = dr[5].ToString();
                Cmbcinsiyet.Text = dr[6].ToString();
            }
            bgl.baglanti().Close();
        }
    }
}
