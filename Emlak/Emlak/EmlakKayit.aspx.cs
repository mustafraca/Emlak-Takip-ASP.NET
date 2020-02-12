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
    public partial class EmlakKayit : System.Web.UI.Page
    {
        static string baglanStr = ConfigurationManager.ConnectionStrings["VTBaglan"].ConnectionString;
        SqlConnection baglanti = new SqlConnection(baglanStr);
        SqlCommand komut;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (OturumAc.tf == false)
                    Response.Redirect("OturumAc.aspx");
                Button3_Click(Button3, new EventArgs());
            }
        }

        public static string kiraliksatilik;
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (RadioButtonList1.SelectedIndex == 0) { kiraliksatilik = "Kiralık"; }
            else if (RadioButtonList1.SelectedIndex == 1) { kiraliksatilik = "Satılık"; }
            if (Button3.Enabled == false)
            {
                if (TextBox1.Text != "" && TextBox5.Text != "" && TextBox6.Text != "" && TextBox7.Text != "")
                {
                    try
                    {
                        baglanti.Open();
                        komut = new SqlCommand("INSERT INTO " + OturumAc.tabloadi1 + " (Metrekare, AdiSoyadi, TelefonNo, KiralikSatilik, Ucret) VALUES (@Metrekare, @AdiSoyadi, @TelefonNo, @KiralikSatilik, @Ucret)", baglanti);

                        komut.Parameters.AddWithValue("@Metrekare", TextBox1.Text);
                        komut.Parameters.AddWithValue("@AdiSoyadi", TextBox5.Text);
                        komut.Parameters.AddWithValue("@TelefonNo", TextBox6.Text);
                        komut.Parameters.AddWithValue("@KiralikSatilik", kiraliksatilik);
                        komut.Parameters.AddWithValue("@Ucret", TextBox7.Text);
                        komut.ExecuteNonQuery();

                        Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "Bilgilendirme Mesajı", "<script>alert('Arsa Kaydı Yapıldı.');</script>");
                        TextBox1.Text = "";
                        TextBox2.Text = "";
                        TextBox3.Text = "";
                        TextBox4.Text = "";
                        TextBox5.Text = "";
                        TextBox6.Text = "";
                        TextBox7.Text = "";
                        RadioButtonList1.SelectedIndex = 0;
                        baglanti.Close();
                    }
                    catch (Exception)
                    {
                        Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "Bilgilendirme Mesajı", "<script>alert('Arsa Eklenirken Hata Oluştu.');</script>");
                    }
                }
            }
            else if (Button4.Enabled == false)
            {
                if (TextBox1.Text != "" && TextBox5.Text != "" && TextBox6.Text != "" && TextBox7.Text != "" && TextBox2.Text != "" && TextBox3.Text != "" && TextBox4.Text != "")
                {
                    try
                    {
                        baglanti.Open();
                        komut = new SqlCommand("INSERT INTO " + OturumAc.tabloadi2 + " (Metrekare, AdiSoyadi, TelefonNo, KiralikSatilik, Ucret, SalonSayisi, OdaSayisi, BalkonSayisi) VALUES (@Metrekare, @AdiSoyadi, @TelefonNo, @KiralikSatilik, @Ucret, @SalonSayisi, @OdaSayisi, @BalkonSayisi)", baglanti);

                        komut.Parameters.AddWithValue("@Metrekare", TextBox1.Text);
                        komut.Parameters.AddWithValue("@AdiSoyadi", TextBox5.Text);
                        komut.Parameters.AddWithValue("@TelefonNo", TextBox6.Text);
                        komut.Parameters.AddWithValue("@KiralikSatilik", kiraliksatilik);
                        komut.Parameters.AddWithValue("@Ucret", TextBox7.Text);
                        komut.Parameters.AddWithValue("@SalonSayisi", TextBox2.Text);
                        komut.Parameters.AddWithValue("@OdaSayisi", TextBox3.Text);
                        komut.Parameters.AddWithValue("@BalkonSayisi", TextBox4.Text);
                        komut.ExecuteNonQuery();

                        Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "Bilgilendirme Mesajı", "<script>alert('Daire Kaydı Yapıldı.');</script>");
                        TextBox1.Text = "";
                        TextBox2.Text = "";
                        TextBox3.Text = "";
                        TextBox4.Text = "";
                        TextBox5.Text = "";
                        TextBox6.Text = "";
                        TextBox7.Text = "";
                        RadioButtonList1.SelectedIndex = 0;
                        baglanti.Close();
                    }
                    catch (Exception)
                    {
                        Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "Bilgilendirme Mesajı", "<script>alert('Kişi Eklenirken Hata Oluştu.');</script>");
                    }
                }
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Button3.Enabled = false;
            Button4.Enabled = true;
            TextBox2.Enabled = false;
            TextBox3.Enabled = false;
            TextBox4.Enabled = false;
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Button3.Enabled = true;
            Button4.Enabled = false;
            TextBox2.Enabled = true;
            TextBox3.Enabled = true;
            TextBox4.Enabled = true;
        }
    }
}