using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KuruTemizlemeOtomasyon
{
    public partial class AnaEkran : Form
    {
        public AnaEkran()
        {
            InitializeComponent();
        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            MusteriEkle me = new MusteriEkle();
            me.Show();
        }

        private void btnUrunler_Click(object sender, EventArgs e)
        {
            Urunler me = new Urunler();
            me.Show();
        }

        private void btnMusteriler_Click(object sender, EventArgs e)
        {
            Musteriler musteriler = new Musteriler();
            musteriler.Show();
        }

        private void btnKullanicilar_Click(object sender, EventArgs e)
        {
            Kullanicilar kullanici = new Kullanicilar();
            kullanici.Show();
        }

        private void AnaEkran_Load(object sender, EventArgs e)
        {

        }

        private void btnTeslimEdilecekUrunler_Click(object sender, EventArgs e)
        {
            TeslimEdilecekUrunler teu = new TeslimEdilecekUrunler();
            teu.Show();
        }

        private void btnTeslimEdilenUrunler_Click(object sender, EventArgs e)
        {
            TeslimEdilenÜrünler tseu = new TeslimEdilenÜrünler();
            tseu.Show();
        }

        private void btnIstatistik_Click(object sender, EventArgs e)
        {
            Istatistik istatistik = new Istatistik();   
            istatistik.Show();
        }
    }
}
