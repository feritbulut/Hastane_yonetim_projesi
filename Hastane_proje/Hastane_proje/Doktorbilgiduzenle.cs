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
    public partial class Doktorbilgiduzenle : Form
    {
        public Doktorbilgiduzenle()
        {
            InitializeComponent();
        }
        sqlbaglantısı bgl = new sqlbaglantısı();
        public string TCNO;
        private void Doktorbilgiduzenle_Load(object sender, EventArgs e)
        {
            MskTC.Text = TCNO;

            SqlCommand komut = new SqlCommand("select * from Tbl_doktorlar where doktortc=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",MskTC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                Txtad.Text = dr[1].ToString();
                Txtsoyad.Text = dr[2].ToString();
                cmbbrans.Text = dr[3].ToString();
                Txtsifre.Text = dr[5].ToString();
            }
            bgl.baglanti().Close();
        }

        private void Btnbilgiguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Tbl_doktorlar set doktorad=@p1,doktorsoyad=@p2,doktorbrans=@p3,doktorsifre=@p4 where doktortc=@p5", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",Txtad.Text);
            komut.Parameters.AddWithValue("@p2",Txtsoyad.Text);
            komut.Parameters.AddWithValue("@p3",cmbbrans.Text);
            komut.Parameters.AddWithValue("@p4",Txtsifre.Text);
            komut.Parameters.AddWithValue("@p5",MskTC.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgileriniz güncellendi.","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Information);


        }
    }
}
