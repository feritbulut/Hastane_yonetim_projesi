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
using System.Security.Cryptography;

namespace Hastane_proje
{
    public partial class SekreterDetay : Form
    {
        public SekreterDetay()
        {
            InitializeComponent();
        }

        public string TC;
        sqlbaglantısı bgl = new sqlbaglantısı();

        private void SekreterDetay_Load(object sender, EventArgs e)
        {
            lbltc.Text = TC;

            SqlCommand komut1 = new SqlCommand("select sekreteradsoyad from Tbl_sekreter where sekretertc = @p1",bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1",lbltc.Text);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                lbladsoyad.Text = dr1[0].ToString();
            }
            bgl.baglanti().Close();


            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_branslar",bgl.baglanti());
            da.Fill(dt1);
            dataGridView1.DataSource= dt1;

            DataTable dt2 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("select (doktorad +' '+ doktorsoyad) as 'Doktorlar',doktorbrans from Tbl_doktorlar", bgl.baglanti());
            da1.Fill(dt2);
            dataGridView2.DataSource = dt2;


            SqlCommand komut2 = new SqlCommand("select bransad from Tbl_branslar",bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbbrans.Items.Add(dr2[0].ToString());
            }

           
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komutkaydet = new SqlCommand("insert into Tbl_randevular (randevutarih,randevusaat,randevubrans,randevudoktor) values(@r1,@r2,@r3,@r4)",bgl.baglanti());
            komutkaydet.Parameters.AddWithValue("@r1",msktarih.Text);
            komutkaydet.Parameters.AddWithValue("@r2",msksaat.Text);
            komutkaydet.Parameters.AddWithValue("@r3",cmbbrans.Text);
            komutkaydet.Parameters.AddWithValue("@r4",cmbdoktor.Text);
            komutkaydet.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Oluşturuldu.");
        }

        private void cmbbrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbdoktor.Items.Clear();
            SqlCommand komut3 = new SqlCommand("select (doktorad +' '+ doktorsoyad)  from Tbl_doktorlar where doktorbrans =@p1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", cmbbrans.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                cmbdoktor.Items.Add(dr3[0].ToString());
            }
            bgl.baglanti().Close();
        }

        private void btnolustur_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_duyurular (duyuru) values (@d1)",bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", richTextBox1.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Duyuru Oluşturuldu.");            
        }

        private void btndoktorpaneli_Click(object sender, EventArgs e)
        {
            doktorpaneli fr = new doktorpaneli();
            fr.Show();
        }

        private void btnbranspaneli_Click(object sender, EventArgs e)
        {
            BRans fr = new BRans();
            fr.Show();
        }

        private void btnrandevulistesi_Click(object sender, EventArgs e)
        {
            RandevuListesi fr = new RandevuListesi();
            fr.Show();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Tbl_randevular set ");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Duyurular fr = new Duyurular();
            fr.Show();
        }
    }
}
