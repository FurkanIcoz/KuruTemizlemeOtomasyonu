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
    public partial class MusteriiEkle : Form
    {
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataReader dr;
        MySqlDataAdapter da;
        public MusteriiEkle()
        {
            InitializeComponent();
            con = new MySqlConnection("Server=localhost;Database=ktemizleme;user=root;Pwd=furkanemre2000;SslMode=none");

        }

        private void MusteriiEkle_Load(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtMstrAd.Text == "" || txtMstrSoyad.Text == "" || txtMstrTel.Text == "" || txtMstrAdres.Text == "")
            {
                MessageBox.Show("Lütfen İlgili Alanların Tümünü Doldurunuz");
            }
            else
            {
                con.Open();
                cmd = new MySqlCommand();
                cmd.Connection = con;

                string ad = "";
                string soyad = "";
                string tel = "";
                string durum = "";
                cmd.CommandText = "SELECT * FROM musteri WHERE musteriIsim='" + txtMstrAd.Text + "' and musteriSoyIsim='" + txtMstrSoyad.Text + "' and musteriTel='" + txtMstrTel.Text + "'";

                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        durum = dr.GetString(5);

                        if (durum == "A")
                        {
                            MessageBox.Show("Müşteri Kayitli");
                        }
                        
                        else
                        {
                            dr.Close();
                            cmd.CommandText = " UPDATE musteri SET durum = 'A' WHERE musteriIsim='" + txtMstrAd.Text + "' and musteriSoyIsim='" + txtMstrSoyad.Text + "' and musteriTel='" + txtMstrTel.Text + "'";
                            if (cmd.ExecuteNonQuery() == 1)
                            {
                                MessageBox.Show("başarılı");
                                break;
                            }
                            else
                            {
                                MessageBox.Show("Başarısız");
                            }
                        }
                    }
                }
                else
                {
                    dr.Close();
                    cmd.CommandText = "INSERT INTO musteri (musteriIsim,musteriSoyIsim,musteriTel,musteriAdres,durum) VALUES ('" + txtMstrAd.Text.ToUpper() + "','" + txtMstrSoyad.Text.ToUpper() + "','" + txtMstrTel.Text.Replace(" ", String.Empty) + "','" + txtMstrAdres.Text + "','A')";
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("başarılı");
                    }
                    else
                    {
                        MessageBox.Show("Başarısız");
                    }
                }

                con.Close();
            }
        }


        private void txtMstrTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if(!char.IsDigit(e.KeyChar)&& !char.IsDigit(e.KeyChar)&&(e.KeyChar == '.'))
            //{
            //    e.Handled = true;
            //}

            //if (e.KeyChar =='.' && ((sender as TextBox).Text.IndexOf('.')>-1))
            //{
            //    e.Handled = true;
            //}
            if (!Char.IsDigit(e.KeyChar) && (e.KeyChar != (char)(Keys.Back)))
            {
                e.Handled = true;
            }
            else
            {
                if (Char.IsDigit(e.KeyChar))
                {
                    if (txtMstrTel.Text.Length > 9)
                    {
                        e.Handled = true;
                    }
                }
            }
        }
    }
}


