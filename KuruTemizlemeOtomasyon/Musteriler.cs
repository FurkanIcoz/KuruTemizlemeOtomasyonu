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
    public partial class Musteriler : Form
    {
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataReader dr;
        MySqlDataAdapter da;
        public Musteriler()
        {
            InitializeComponent();
        }
        DataTable musteriGetir()
        {
            con = new MySqlConnection("Server=localhost;Database=ktemizleme;user=root;Pwd=furkanemre2000;SslMode=none");
            string musteriler = "SELECT * FROM musteri";
            cmd = new MySqlCommand(musteriler, con);
            da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            //dgwMusteriler.DataSource = dt;
            con.Close();
            
            return dt;
        }
        private void Musteriler_Load(object sender, EventArgs e)
        {
            
            dgwMusteriler.DataSource = musteriGetir();
            int musteriSayisi = dgwMusteriler.RowCount - 1;
            lblMusteriSayi.Text = musteriSayisi.ToString();
        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            MusteriiEkle me = new MusteriiEkle();
            me.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgwMusteriler.DataSource = musteriGetir();
            int musteriSayisi = dgwMusteriler.RowCount - 1;
            lblMusteriSayi.Text = musteriSayisi.ToString();
        }
    }
}
