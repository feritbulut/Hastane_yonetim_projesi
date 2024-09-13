using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane_proje
{
    public partial class Girisler : Form
    {
        public Girisler()
        {
            InitializeComponent();
        }

        private void hastagiris_Click(object sender, EventArgs e)
        {
            HastaGiris fr = new HastaGiris();
            fr.Show();
            this.Hide();
        }

        private void doktorgiris_Click(object sender, EventArgs e)
        {
            DoktorGİris fr = new DoktorGİris();
            fr.Show();
            this.Hide();

        }

        private void sekretergiris_Click(object sender, EventArgs e)
        {
            Sekretergiris fr = new Sekretergiris();
            fr.Show();
            this.Hide();
        }
    }
}
