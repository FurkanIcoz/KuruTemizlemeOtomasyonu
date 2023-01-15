using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace KuruTemizlemeOtomasyon
{
    public partial class TeslimEdilecekUrunler : Form
    {
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataReader dr;
        MySqlDataAdapter da;
        public TeslimEdilecekUrunler()
        {
            InitializeComponent();
            con = new MySqlConnection("Server=localhost;Database=ktemizleme;user=root;Pwd=furkanemre2000;SslMode=none");

        }
        DataTable dgwDoldur()
        {
            string kullanicilar = "SELECT urunlerdurum.fisId,musteri.musteriIsim,musteri.musteriSoyIsim,musteri.musteriTel,musteri.musteriAdres,urunlerdurum.urunIsim,urunlerdurum.gelisTarih,urunlerdurum.teslimTarih,urunlerdurum.teslimUcret,urunlerdurum.teslimEdildimi,urunlerdurum.odemeYapildimi,urunlerdurum.hazirMi FROM urunlerdurum INNER JOIN musteri ON musteri.musteriId = urunlerdurum.musteriNo Where teslimEdildimi='H'";
            cmd = new MySqlCommand(kullanicilar, con);
            da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
            //dgwTeslimEu.DataSource = dt;
            
            con.Close();
        }
        private void TeslimEdilecekUrunler_Load(object sender, EventArgs e)
        {
            dgwTeslimEu.DataSource=dgwDoldur();
        }
        private void btnOku_Click(object sender, EventArgs e)
        {
            con.Open();
            DataGridViewRow row = dgwTeslimEu.CurrentRow;
            string fisDeger= dgwTeslimEu.CurrentRow.Cells["fisId"].Value.ToString();
            string urunHazirMi = dgwTeslimEu.CurrentRow.Cells["hazirMi"].Value.ToString();
            string ucretOdendiMi = dgwTeslimEu.CurrentRow.Cells["odemeYapildimi"].Value.ToString();
            cmd.CommandText = "UPDATE urunlerdurum SET teslimEdildimi='E' WHERE fisId ='"+fisDeger+"'";
            if (urunHazirMi=="H")
            {
                MessageBox.Show("ÜRÜN HAZIR DEĞİL TESLİM EDİLEMEZ!");
                con.Close();
            }
            else if (ucretOdendiMi == "H")
            {
                MessageBox.Show("LÜTFEN ÜCRETİ ÖDEYİN!");
                con.Close();
            }
            else
            {
                if (cmd.ExecuteNonQuery() == 1)
                {
                    dgwTeslimEu.DataSource = dgwDoldur();
                    MessageBox.Show("başarılı");
                    MessageBox.Show(fisDeger + " Numaralı fis teslim edildi");
                }
                else
                {
                    MessageBox.Show("Başarısız");
                }
                con.Close();
            }
            
        }

        private void btnHazir_Click(object sender, EventArgs e)
        {
            con.Open();
            DataGridViewRow row = dgwTeslimEu.CurrentRow;
            string fisDeger = dgwTeslimEu.CurrentRow.Cells["fisId"].Value.ToString();
            cmd.CommandText = "UPDATE urunlerdurum SET hazirMi='E' WHERE fisId ='" + fisDeger + "'";
            if (cmd.ExecuteNonQuery() == 1)
            {
                dgwTeslimEu.DataSource = dgwDoldur();
                MessageBox.Show("başarılı");
                MessageBox.Show(fisDeger + " Fiş Numarasına Ait Sipariş Hazır");
                con.Close();
            }
            else
            {
                MessageBox.Show("Başarısız");
            }
            con.Close();

        }

        private void btnOdemeAl_Click(object sender, EventArgs e)
        {
            con.Open();
            DataGridViewRow row = dgwTeslimEu.CurrentRow;
            string fisDeger = dgwTeslimEu.CurrentRow.Cells["fisId"].Value.ToString();
            cmd.CommandText = "UPDATE urunlerdurum SET odemeYapildimi='E' WHERE fisId ='" + fisDeger + "'";
            if (cmd.ExecuteNonQuery() == 1)
            {
                dgwTeslimEu.DataSource = dgwDoldur();
                MessageBox.Show("başarılı");
                MessageBox.Show(fisDeger + " Fiş Numarasına Ait Siparişin Ücreti Ödendi");
                con.Close();
            }
            else
            {
                MessageBox.Show("Başarısız");
            }
            con.Close();
        }
    }
}
