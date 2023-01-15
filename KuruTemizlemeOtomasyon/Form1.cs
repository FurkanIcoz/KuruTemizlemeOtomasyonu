namespace KuruTemizlemeOtomasyon;
using MySql.Data;
using MySql.Data.MySqlClient;

public partial class formAnaEkran : Form
{
    MySqlConnection con;
    MySqlCommand cmd;
    MySqlDataReader dr;
    public formAnaEkran()
    {
        InitializeComponent();
    }
    private void Form1_Load(object sender, EventArgs e)
    {   
        con = new MySqlConnection("Server=localhost;Database=ktemizleme;user=root;Pwd=furkanemre2000;SslMode=none");
    }
    private void btnGiris_Click(object sender, EventArgs e)
    {
        cmd = new MySqlCommand();
        con.Open();
        cmd.Connection = con;
        cmd.CommandText = "SELECT * FROM kullanici WHERE kllncGiris = '" + txtKullaniciGiris.Text + "' AND kllncSifre = '" + txtKullaniciSifre.Text + "'";
        dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            MessageBox.Show("Hoþgeldiniz " + dr.GetString(2));
            AnaEkran ae1 = new AnaEkran();
            ae1.Show();
            this.Hide();
        }
        else
        {
            MessageBox.Show("Baþarýsýz");
        }
        con.Close();
    }
}
