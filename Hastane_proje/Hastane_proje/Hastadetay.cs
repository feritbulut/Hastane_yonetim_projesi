﻿using System;
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
    public partial class Hastadetay : Form
    {
        public Hastadetay()
        {
            InitializeComponent();
        }
        public string tc;
        sqlbaglantısı bgl = new sqlbaglantısı();

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Hastadetay_Load(object sender, EventArgs e)
        {
            Lbltc.Text = tc;

            SqlCommand komut = new SqlCommand("Select HastaAd,HastaSoyad from Tbl_Hastalar where HastaTC=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", Lbltc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                Lbladsoyad.Text = dr[0] +" "+ dr[1];
            }
            bgl.baglanti().Close();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Randevular where HastaTc=" + tc, bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            SqlCommand komut2 = new SqlCommand("select bransad from tbl_branslar ", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                Cmbbrans.Items.Add(dr2[0]);
            }
        }

        private void Cmbbrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cmbdoktor.Items.Clear();
            SqlCommand komut3 = new SqlCommand("select Doktorad,Doktorsoyad from Tbl_doktorlar where Doktorbrans= @p1",bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", Cmbbrans.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                Cmbdoktor.Items.Add(dr3[0] +" "+ dr3[1]);
                bgl.baglanti().Close();
            }
        }

        private void Cmbdoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_randevular where randevuBrans='" +Cmbbrans.Text + "'" + " and randevudoktor='" + Cmbdoktor.Text + "' and randevudurum=0",bgl.baglanti());
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void Lnkbilgidüzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            BilgiDuzenle fr = new BilgiDuzenle();
            fr.TCno = Lbltc.Text;
            fr.Show();

        }

        private void BtnRandevusal_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Tbl_randevular set randevudurum=1 ,hastatc=@p1,hastasikayet=@p2 where randevuid=@p3",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", Lbltc.Text);
            komut.Parameters.AddWithValue("@p2",Rtxtsikayet.Text);
            komut.Parameters.AddWithValue("@p3", txtid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu alındı.","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            txtid.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();

        }
    }
}
