using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Emlak
{
    public partial class KayitOl : System.Web.UI.Page
    {
        static string baglanStr = ConfigurationManager.ConnectionStrings["VTBaglan"].ConnectionString;
        SqlConnection baglanti = new SqlConnection(baglanStr);
        SqlCommand komut;
        SqlCommand tabloolustur;
        SqlCommand tabloolustur2;
        SqlCommand tabloolustur3;
        public static string tabloadi2;
        public static string tabloadi3;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text != "" && TextBox2.Text != "")
            {
                try
                {
                    baglanti.Open();
                    string tabloadi = TextBox1.Text.Trim();
                    tabloadi = tabloadi.Replace(" ", "");
                    tabloadi2 = tabloadi + "Arsa";
                    tabloadi3 = tabloadi + "Daire";
                    string olustur = "CREATE TABLE " + tabloadi + "(KullaniciAdi varchar(20), Sifre varchar(20))";
                    string olustur2 = "CREATE TABLE " + tabloadi2 + "(Metrekare varchar(10), AdiSoyadi varchar(20), TelefonNo varchar(11), KiralikSatilik varchar(7), Ucret varchar(30))";
                    string olustur3 = "CREATE TABLE " + tabloadi3 + "(Metrekare varchar(10), AdiSoyadi varchar(20), TelefonNo varchar(11), KiralikSatilik varchar(7), Ucret varchar(30), SalonSayisi varchar(10), OdaSayisi varchar(10), BalkonSayisi varchar(10))";
                    tabloolustur = new SqlCommand(olustur, baglanti);
                    tabloolustur.ExecuteNonQuery();
                    tabloolustur2 = new SqlCommand(olustur2, baglanti);
                    tabloolustur2.ExecuteNonQuery();
                    tabloolustur3 = new SqlCommand(olustur3, baglanti);
                    tabloolustur3.ExecuteNonQuery();
                    string ekle = "INSERT INTO " + tabloadi + "(KullaniciAdi, Sifre) VALUES (@KullaniciAdi, @Sifre)";
                    komut = new SqlCommand(ekle, baglanti);
                    komut.Parameters.AddWithValue("@KullaniciAdi", tabloadi);
                    komut.Parameters.AddWithValue("@Sifre", TextBox2.Text);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "Bilgilendirme Mesajı", "<script>alert('Kaydınız Yapıldı.');</script>");
                    TextBox1.Text = "";
                    TextBox2.Text = "";
                    TextBox1.Focus();
                }
                catch (Exception hata)
                {
                    Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "Bilgilendirme Mesajı", "<script>alert('" + hata.Message + "');</script>");
                }
            }
            else
            {
                Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "Bilgilendirme Mesajı", "<script>alert('Boş Alan Bırakılamaz!');</script>");
            }
        }
    }
}