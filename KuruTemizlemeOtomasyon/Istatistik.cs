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
    public partial class Istatistik : Form
    {

        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataReader dr;
        MySqlDataAdapter da;
        public Istatistik()
        {
            InitializeComponent();
            con = new MySqlConnection("Server=localhost;Database=ktemizleme;user=root;Pwd=furkanemre2000;SslMode=none");

        }

        private void Istatistik_Load(object sender, EventArgs e)
        {
            con.Open();
            string Bakiye="SELECT SUM(teslimUcret) FROM urunlerdurum WHERE odemeYapildimi = 'E'";
            int bakiye = 0;
            cmd = new MySqlCommand(Bakiye,con);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                bakiye=dr.GetInt32(0);
            }
            label2.Text = bakiye.ToString();

        }
    }
}
