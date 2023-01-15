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
    public partial class Urunler : Form
    {

        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataReader dr;
        MySqlDataAdapter da;


        public Urunler()
        {
            InitializeComponent();
        }

        private void Urunler_Load(object sender, EventArgs e)
        {
            con = new MySqlConnection("Server=localhost;Database=ktemizleme;user=root;Pwd=furkanemre2000;SslMode=none");
            con.Open();
            cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM urun";

            PictureBox[] pics = new PictureBox[18];
            
            int satir = 0;
            int sayac = 1;
            int x = 100;
            int y = 75;
            string pic_yol = "";
            string pict_name = "";
            string pic_fiyat = "";
            string pic_name = "pictureBox";
            string pic_utuFiyat = "";
            for (int i = 0; i < pics.Length / 6; i++)
            {

                for (int j = 0; j < pics.Length / 3; j++)
                {

                    da = new MySqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        var pic_yol_db = ds.Tables[0].Rows[satir][3];
                        var pic_name_db = ds.Tables[0].Rows[satir][1];
                        var pic_fiyat_db = ds.Tables[0].Rows[satir][2];
                        var pic_utuFiyat_db= ds.Tables[0].Rows[satir][4];
                        pic_yol = pic_yol_db.ToString();
                        pict_name = pic_name_db.ToString();
                        pic_fiyat = pic_fiyat_db.ToString();
                        pic_utuFiyat = pic_utuFiyat_db.ToString();
                    }
                    PictureBox pbox = new PictureBox();
                    pbox.Name = pic_name + sayac;
                    sayac++;
                    pbox.BackColor = System.Drawing.Color.Red;
                    pbox.Image = Image.FromFile(pic_yol);
                    pbox.SizeMode = PictureBoxSizeMode.StretchImage;
                    pbox.SetBounds(x, y, 85, 85);
                    x += 130;
                    this.Controls.Add(pbox);
                    pics[satir] = pbox;
                    satir++;

                    Label lbl = new Label();
                    lbl.Text = pict_name;
                    //lbl.BackColor = System.Drawing.Color.Blue;
                    lbl.SetBounds(x - 135, y + 88, 100, 50);
                    this.Controls.Add(lbl);

                    Label lbl2 = new Label();
                    //lbl2.Text = "abc";
                    
                    lbl2.Text = "Fiyat: "+pic_fiyat ;
                    //lbl2.BackColor = System.Drawing.Color.Red;
                    lbl2.SetBounds(x - 135, y + 138, 100, 50);
                    this.Controls.Add((lbl2));
                    

                }
                x = 100;
                y += 175;
            }
            

        }
    }
}
            
