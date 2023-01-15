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
    public partial class TeslimEdilenÜrünler : Form
    {
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataReader dr;
        MySqlDataAdapter da;
        public TeslimEdilenÜrünler()
        {
            InitializeComponent();
        }

        private void TeslimEdilenÜrünler_Load(object sender, EventArgs e)
        {
            con = new MySqlConnection("Server=localhost;Database=ktemizleme;user=root;Pwd=furkanemre2000;SslMode=none");
            string kullanicilar = "SELECT musteri.musteriIsim,musteri.musteriSoyIsim,musteri.musteriTel,musteri.musteriAdres,urunlerdurum.urunIsim,urunlerdurum.gelisTarih,urunlerdurum.teslimTarih,urunlerdurum.teslimUcret,urunlerdurum.teslimEdildimi,urunlerdurum.odemeYapildimi,urunlerdurum.hazirMi FROM urunlerdurum INNER JOIN musteri ON musteri.musteriId = urunlerdurum.musteriNo Where teslimEdildimi='E'";
            cmd = new MySqlCommand(kullanicilar, con);
            da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgwTesEdilenU.DataSource = dt;
            con.Close();
            

        }
    }
}
