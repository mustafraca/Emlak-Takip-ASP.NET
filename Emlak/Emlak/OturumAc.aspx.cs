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
    public partial class OturumAc : System.Web.UI.Page
    {
        static string baglanStr = ConfigurationManager.ConnectionStrings["VTBaglan"].ConnectionString;
        SqlConnection baglanti = new SqlConnection(baglanStr);
        SqlCommand komut;
        SqlDataReader reader;
        public static bool tf = false;
        public static string tabloadi1;
        public static string tabloadi2;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (tf)
            {
                TextBox1.Enabled = false;
                TextBox2.Enabled = false;
                Button1.Enabled = false;
                Label1.Text = "Zaten Oturum Açtınız.";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text != "" && TextBox2.Text != "")
            {
                try
                {
                    baglanti.Open();
                    string boslukal = TextBox1.Text.Trim();
                    boslukal = boslukal.Replace(" ", "");
                    string KullaniciAdi = "SELECT KullaniciAdi FROM " + boslukal + " WHERE KullaniciAdi='" + boslukal + "' AND Sifre='" + TextBox2.Text + "'";
                    komut = new SqlCommand(KullaniciAdi, baglanti);
                    reader = komut.ExecuteReader();
                    if (reader.Read())
                    {
                        tf = true;
                        tabloadi1 = TextBox1.Text + "Arsa";
                        tabloadi2 = TextBox1.Text + "Daire";
                        Response.Redirect("EmlakArama.aspx");
                    }
                    else
                    {
                        TextBox1.Text = "";
                        TextBox2.Text = "";
                        TextBox1.Focus();
                    }
                    baglanti.Close();
                }
                catch (Exception hata)
                {
                    Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "Bilgilendirme Mesajı", "<script>alert('" + hata.Message + "');</script>");
                }
            }
            else if (TextBox1.Text == "" && TextBox2.Text != "")
            {
                Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "Bilgilendirme Mesajı", "<script>alert('Kullanıcı Adı Alanı Boş Bırakılamaz!');</script>");
                TextBox1.Focus();
            }
            else if (TextBox2.Text == "" && TextBox1.Text != "")
            {
                Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "Bilgilendirme Mesajı", "<script>alert('Şifre Alanı Boş Bırakılamaz!');</script>");
                TextBox2.Focus();
            }
            else
            {
                Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "Bilgilendirme Mesajı", "<script>alert('Alanları Doldurunuz Lütfen!');</script>");
                TextBox1.Focus();
            }
        }
    }
}