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
//INSERT INTO urundurum (urunIsım, gelisTarih, teslimTarih, teslimEdildimi,teslimUcret,odemeYapildimi) VALUES ('','','','','','');
namespace KuruTemizlemeOtomasyon
{
    public partial class MusteriEkle : Form
    {
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataReader dr;
        MySqlDataAdapter da;
        Button[] buttons = new Button[18];
        CheckBox[] chkbox = new CheckBox[18];
        int fiyatToplam = 0;


        public MusteriEkle()
        {
            InitializeComponent();
            con = new MySqlConnection("Server=localhost;Database=ktemizleme;user=root;Pwd=furkanemre2000;SslMode=none");

        }

        private void MusteriEkle_Load(object sender, EventArgs e)
        {

            con.Open();
            cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM urun";

            //PictureBox[] pics = new PictureBox[18];
            //int satir = 0;
            //int sayac = 1;
            //int x = 50;
            //int y = 25;
            //string pic_yol = "";
            //string pict_name = "";
            //string pic_fiyat = "";
            //string pic_name = "pictureBox";
            //for (int i = 0; i < pics.Length / 6; i++)
            //{

            //    for (int j = 0; j < pics.Length / 3; j++)
            //    {

            //        da = new MySqlDataAdapter(cmd);
            //        DataSet ds = new DataSet();
            //        da.Fill(ds);
            //        if (ds.Tables[0].Rows.Count > 0)
            //        {
            //            var pic_yol_db = ds.Tables[0].Rows[satir][3];
            //            var pic_name_db = ds.Tables[0].Rows[satir][1];
            //            var pic_fiyat_db = ds.Tables[0].Rows[satir][2];
            //            pic_yol = pic_yol_db.ToString();
            //            pict_name = pic_name_db.ToString();
            //            pic_fiyat = pic_fiyat_db.ToString();
            //        }

            //        //Button btn = new Button();
            //        //btn.SetBounds(x, y + 40, 65, 35);
            //        //btn.Text = pict_name;
            //        //btn.Name = pic_fiyat;
            //        //this.Controls.Add(btn);
            //        //buttons[satir] = btn;



            //        PictureBox pbox = new PictureBox();
            //        pbox.Name = pic_name + sayac;
            //        sayac++;
            //        pbox.BackColor = System.Drawing.Color.Red;
            //        pbox.Image = Image.FromFile(pic_yol);
            //        pbox.SizeMode = PictureBoxSizeMode.StretchImage;
            //        pbox.SetBounds(x, y, 85, 85);
            //        x += 130;
            //        this.Controls.Add(pbox);
            //        pics[satir] = pbox;


            //        //x + 350, y + 350, 100, 100

            //        CheckBox cb = new CheckBox();
            //        cb.SetBounds(x-125, y+ 77, 95, 60);
            //        cb.Name = pic_fiyat;
            //        cb.Text = pict_name;
            //        this.Controls.Add(cb);
            //        chkbox[satir] = cb;

            //        satir++;



            //    }
            //    x = 50;
            //    y += 150;

            //}

            cmd.CommandText = "SELECT * FROM musteri WHERE durum = 'A'";

            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cbMusteriler.Items.Add(dr.GetString(1) + "-" + dr.GetString(2) + "-" + dr.GetString(3));
            }
            cbMusteriler.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbMusteriler.AutoCompleteSource = AutoCompleteSource.ListItems;
            dr.Close();
            cmd.CommandText = "SELECT * FROM urun";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cboxUrun.Items.Add(dr.GetString(1) + "-" + dr.GetString(2));
            }
            cboxUrun.AutoCompleteMode = AutoCompleteMode.Suggest;
            cboxUrun.AutoCompleteSource = AutoCompleteSource.ListItems;
        }
        int toplam = 0;
        private void btnListeyeEkle_Click(object sender, EventArgs e)
        {
            bool secim = true;
            string[] cboxslct = new string[18];
            if (cboxUrun.SelectedItem == null)
            {
                MessageBox.Show("Lütfen Ürün Seçiniz");
            }
            else
            {
                for (int i = 0; i < cboxslct.Length; i++)
                {
                    cboxslct[i] = cboxUrun.SelectedItem.ToString();
                }
                for (int i = 0; i < cboxslct.Length; i++)
                {
                    if (cboxUrun.SelectedItem.ToString() == cboxslct[i])
                    {
                        secim = true;
                    }
                    else
                    {
                        secim = false;
                    }
                }
                if (secim)
                {
                    cboxUrun.SelectedItem.ToString();
                    int adet = Convert.ToInt32(nudAdet.Value);
                    string urun = cboxUrun.SelectedItem.ToString();
                    string[] urunf = urun.Split('-');
                    int urunfiyat = Convert.ToInt32(urunf[1]);
                    toplam += urunfiyat * adet;
                    lblToplamFiyat.Text = toplam.ToString();
                    listboxUrunler.Items.Add(urun + "*" + adet.ToString());

                }
                else
                {
                    MessageBox.Show("Lütfen Ürün Seçiniz");

                }
            }


        }
        string urunlerinFiyati()
        {
            string veriler = "";
            string[] veriler1 = new string[listboxUrunler.Items.Count];
            for (int i = 0; i < listboxUrunler.Items.Count; i++)
            {
                veriler1[i] = listboxUrunler.Items[i].ToString();
                veriler += veriler1[i] + "-";
            }
            return veriler;
        }
        private void btnMstrEkle_Click(object sender, EventArgs e)
        {
            //if (txtMstrAd.Text == "" && txtMstrSoyad.Text == "")
            //{
            //    MessageBox.Show("Lütfen Ad ve Soyad Giriniz");
            //}
            //else
            //{
            //    cmd = new MySqlCommand();
            //    cmd.Connection = con;

            //    if (cbMstrKayitli.Checked && cbOdemeYapildi.Checked)
            //    {
            //        string mstrId = "";
            //        cmd.CommandText = "select * from musteri where musteriIsim='" + txtMstrAd.Text + "' and musteriSoyIsim='" + txtMstrSoyad.Text + "'";
            //        dr = cmd.ExecuteReader();
            //        if (dr.Read())
            //        {
            //            mstrId = dr.GetString(0);
            //        }
            //        dr.Close();
            //        cmd.CommandText = "INSERT INTO urunlerdurum (musteriNo, urunIsim, gelisTarih, teslimTarih, teslimEdildimi,teslimUcret,odemeYapildimi) " +
            //            "VALUES ('" + Convert.ToInt32(mstrId) + "','" + urunlerinFiyati() + "','" + DateTime.Now.ToString("MM/dd/yyyy") + "','" + dateTimePicker1.Text + "','" + "H" + "','" + Convert.ToInt32(lblToplamFiyat.Text) + "','" + "E" + "')";
            //        if (cmd.ExecuteNonQuery() == 1)
            //        {
            //            MessageBox.Show("başarılı");
            //        }
            //        else
            //        {
            //            MessageBox.Show("Başarısız");
            //        }
            //        MessageBox.Show("Müsteri Kayitli ve Odeme Yapildi");
            //    }
            //    else if (cbOdemeYapildi.Checked)
            //    {
            //        cmd.CommandText = "INSERT INTO musteri (musteriIsim,musteriSoyIsim,musteriTel,musteriAdres) VALUES ('" + txtMstrAd.Text + "','" + txtMstrSoyad.Text + "','" + txtMstrTel.Text + "','" + txtMstrAdres.Text + "')";
            //        if (cmd.ExecuteNonQuery() == 1)
            //        {
            //            MessageBox.Show("başarılı");
            //        }
            //        else
            //        {
            //            MessageBox.Show("Başarısız");
            //        }

            //        string mstrId = "";
            //        cmd.CommandText = "select * from musteri where musteriIsim='" + txtMstrAd.Text + "' and musteriSoyIsim='" + txtMstrSoyad.Text + "'";

            //        dr = cmd.ExecuteReader();
            //        if (dr.Read())
            //        {
            //            mstrId = dr.GetString(0);
            //        }
            //        dr.Close();
            //        cmd.CommandText = "INSERT INTO urunlerdurum (musteriNo, urunIsim, gelisTarih, teslimTarih, teslimEdildimi,teslimUcret,odemeYapildimi) " +
            //            "VALUES ('" + Convert.ToInt32(mstrId) + "','" + urunlerinFiyati() + "','" + DateTime.Now.ToString("MM/dd/yyyy") + "','" + dateTimePicker1.Text + "','" + "H" + "','" + Convert.ToInt32(lblToplamFiyat.Text) + "','" + "E" + "')";
            //        if (cmd.ExecuteNonQuery() == 1)
            //        {
            //            MessageBox.Show("başarılı");
            //        }
            //        else
            //        {
            //            MessageBox.Show("Başarısız");
            //        }
            //    }
            //    else if (cbMstrKayitli.Checked)
            //    {


            //        string mstrId = "";
            //        cmd.CommandText = "select * from musteri where musteriIsim='" + txtMstrAd.Text + "' and musteriSoyIsim='" + txtMstrSoyad.Text + "'";
            //        dr = cmd.ExecuteReader();
            //        if (dr.Read())
            //        {
            //            mstrId = dr.GetString(0);
            //        }
            //        dr.Close();
            //        cmd.CommandText = "INSERT INTO urunlerdurum (musteriNo, urunIsim, gelisTarih, teslimTarih, teslimEdildimi,teslimUcret,odemeYapildimi) " +
            //            "VALUES ('" + Convert.ToInt32(mstrId) + "','" + urunlerinFiyati() + "','" + DateTime.Now.ToString("MM/dd/yyyy") + "','" + dateTimePicker1.Text + "','" + "H" + "','" + Convert.ToInt32(lblToplamFiyat.Text) + "','" + "H" + "')";

            //        if (cmd.ExecuteNonQuery() == 1)
            //        {
            //            MessageBox.Show("başarılı");
            //        }
            //        else
            //        {
            //            MessageBox.Show("Başarısız");
            //        }


            //        MessageBox.Show("Müşteri Kayıtlı");
            //    }
            //    else
            //    {
            //        cmd.CommandText = "INSERT INTO musteri (musteriIsim,musteriSoyIsim,musteriTel,musteriAdres) VALUES ('" + txtMstrAd.Text + "','" + txtMstrSoyad.Text + "','" + txtMstrTel.Text + "','" + txtMstrAdres.Text + "')";
            //        if (cmd.ExecuteNonQuery() == 1)
            //        {
            //            MessageBox.Show("başarılı");
            //        }
            //        else
            //        {
            //            MessageBox.Show("Başarısız");
            //        }
            //        dr.Close();
            //        string mstrId = "";
            //        cmd.CommandText = "select * from musteri where musteriIsim='" + txtMstrAd.Text + "' and musteriSoyIsim='" + txtMstrSoyad.Text + "'";
            //        dr = cmd.ExecuteReader();
            //        if (dr.Read())
            //        {
            //            mstrId = dr.GetString(0);
            //        }
            //        dr.Close();
            //        cmd.CommandText = "INSERT INTO urunlerdurum (musteriNo, urunIsim, gelisTarih, teslimTarih, teslimEdildimi,teslimUcret,odemeYapildimi) " +
            //            "VALUES ('" + Convert.ToInt32(mstrId) + "','" + urunlerinFiyati() + "','" + DateTime.Now.ToString("MM/dd/yyyy") + "','" + dateTimePicker1.Text + "','" + "H" + "','" + Convert.ToInt32(lblToplamFiyat.Text) + "','" + "H" + "')";
            //        if (cmd.ExecuteNonQuery() == 1)
            //        {
            //            MessageBox.Show("başarılı");
            //        }
            //        else
            //        {
            //            MessageBox.Show("Başarısız");
            //        }
            //        dr.Close();
            //    }


            //    con.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            //string cboxmstr = cbMusteriler.SelectedItem.ToString();
            //MessageBox.Show(cboxmstr);
            if (listboxUrunler.Items.Count == 0)
            {
                MessageBox.Show("Listede Eleman Yok");
            }
            else
            {
                string urun = listboxUrunler.SelectedItem.ToString();
                string[] urunf = urun.Split('-');
                string[] urunf2 = urunf[1].Split('*');
                int urunfiyat = Convert.ToInt32(urunf2[0]);
                //int yeniDeger = Convert.ToInt32(lblToplamFiyat.Text);
                int adetDeger = Convert.ToInt32(urunf2[1]);
                toplam -= urunfiyat * adetDeger;
                lblToplamFiyat.Text = toplam.ToString();
                listboxUrunler.Items.RemoveAt(listboxUrunler.SelectedIndex);
                if (listboxUrunler.Items == null)
                {
                    lblToplamFiyat.Text = "0";
                }
            }


        }

        private void cbMusteriler_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            if (listboxUrunler.Items==null)
            {
                MessageBox.Show("Ürün Olmadan Siparis Girilemez");
            }
            else
            {
                dr.Close();
                bool msecim = true;
                bool secim = true;
                string[] mcboxslct = new string[18];
                string[] cboxslct = new string[18];
                if (cbMusteriler.SelectedItem == null)
                {
                    MessageBox.Show("Lütfen Müşteri Seçiniz");
                }
                else
                {
                    string[] musteriler = cbMusteriler.SelectedItem.ToString().Split('-');
                    string mstrId = "";
                    cmd.CommandText = "select * from musteri where musteriIsim='" + musteriler[0] + "' and musteriSoyIsim='" + musteriler[1] + "' and musteriTel='" + musteriler[2] + "'";
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        mstrId = dr.GetString(0);
                    }
                    dr.Close();
                    for (int i = 0; i < cboxslct.Length; i++)
                    {
                        cboxslct[i] = cbMusteriler.SelectedItem.ToString();
                    }
                    for (int i = 0; i < cboxslct.Length; i++)
                    {
                        if (cbMusteriler.SelectedItem.ToString() == cboxslct[i])
                        {
                            secim = true;
                        }
                        else
                        {
                            secim = false;
                        }
                    }
                    if (secim)
                    {

                        if (cboxUrun.SelectedItem == null)
                        {
                            MessageBox.Show("Lütfen Ürün Seçiniz");
                        }
                        else
                        {
                            for (int i = 0; i < mcboxslct.Length; i++)
                            {
                                mcboxslct[i] = cboxUrun.SelectedItem.ToString();
                            }
                            for (int i = 0; i < mcboxslct.Length; i++)
                            {
                                if (cboxUrun.SelectedItem.ToString() == mcboxslct[i])
                                {
                                    msecim = true;
                                }
                                else
                                {
                                    msecim = false;
                                }
                            }
                            if (secim)
                            {
                                if (cbOdemeYapildi.Checked)
                                {
                                    cmd.CommandText = "INSERT INTO urunlerdurum (musteriNo,urunIsim, gelisTarih, teslimTarih, teslimEdildimi,teslimUcret,odemeYapildimi,hazirMi) VALUES ('" + mstrId + "','" + urunlerinFiyati() + "','" + DateTime.Now.ToString("MM/dd/yyyy") + "','" + dateTimePicker1.Text + "','H','" + lblToplamFiyat.Text + "','E','H')";
                                    if (cmd.ExecuteNonQuery() == 1)
                                    {
                                        MessageBox.Show("başarılı");
                                        MusteriEkle muek = new MusteriEkle();
                                        muek.Show();
                                        this.Close();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Başarısız");
                                    }
                                    dr.Close();
                                }
                                else
                                {
                                    cmd.CommandText = "INSERT INTO urunlerdurum (musteriNo,urunIsim, gelisTarih, teslimTarih, teslimEdildimi,teslimUcret,odemeYapildimi,hazirMi) VALUES ('" + mstrId + "','" + urunlerinFiyati() + "','" + DateTime.Now.ToString("MM/dd/yyyy") + "','" + dateTimePicker1.Text + "','H','" + lblToplamFiyat.Text + "','H','H')";
                                    if (cmd.ExecuteNonQuery() == 1)
                                    {
                                        MessageBox.Show("başarılı");
                                        MusteriEkle muek = new MusteriEkle();
                                        muek.Show();
                                        this.Close();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Başarısız");
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Lütfen Müşteri Seçiniz");
                    }
                }
            }
        }
    }
}








//INSERT INTO kazanc (kazancMiktar, kazancTarih) VALUES ("","")
/*INSERT INTO urundurum (urunIsım, gelisTarih, teslimTarih, teslimEdildimi,teslimUcret,odemeYapildimi) VALUES ('"++"','"++"','"++"','"++"','"++"','"++"');*/



























//            CREATE TABLE `urunler` (
//  `urunId` int NOT NULL AUTO_INCREMENT,
//  `urunAdi` varchar(50) NOT NULL,
//  `urunFiyati` int NOT NULL,
//  `urunResmi` varchar(100) NOT NULL,
//  `urunUtuFiyat` int NOT NULL,
//  PRIMARY KEY (`urunId`)
//) ENGINE=InnoDB AUTO_INCREMENT=19 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci


//`musteriId` int DEFAULT NULL,



//            CREATE TABLE `urunler` (
//  `urunId` int NOT NULL AUTO_INCREMENT,
//  `urunAdi` varchar(50) NOT NULL,
//  `urunFiyati` int NOT NULL,
//  `urunResmi` varchar(100) NOT NULL,
//  `urunUtuFiyat` int NOT NULL,
//  PRIMARY KEY (`urunId`)
//) ENGINE=InnoDB AUTO_INCREMENT=19 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci


//`musteriId` int DEFAULT NULL,