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
    public partial class EmlakSil : System.Web.UI.Page
    {
        static string baglanStr = ConfigurationManager.ConnectionStrings["VTBaglan"].ConnectionString;
        SqlConnection baglanti = new SqlConnection(baglanStr);
        SqlCommand komut;
        SqlDataReader reader;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (OturumAc.tf == false)
                    Response.Redirect("OturumAc.aspx");
                Button3_Click(Button3, new EventArgs());
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Button3.Enabled = false;
            Button4.Enabled = true;
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM " + OturumAc.tabloadi1 + "", baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
            baglanti.Close();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Button3.Enabled = true;
            Button4.Enabled = false;
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM " + OturumAc.tabloadi2 + "", baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
            baglanti.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (GridView1.SelectedIndex != 0)
            {
                baglanti.Open();
                if (Button3.Enabled == false)
                {

                    komut = new SqlCommand("DELETE FROM " + OturumAc.tabloadi1 + " WHERE Metrekare=@Metrekare", baglanti);
                    komut.Parameters.AddWithValue("@Metrekare", GridView1.SelectedRow.Cells[1].Text.ToString());
                    try
                    {
                        komut.ExecuteNonQuery();

                        Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "Bilgilendirme Mesajı", "<script>alert('Emlak Silindi.');</script>");
                        //
                        SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM " + OturumAc.tabloadi1 + "", baglanti);
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        GridView1.DataSource = ds;
                        GridView1.DataBind();
                    }
                    catch (Exception)
                    {
                        Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "Bilgilendirme Mesajı", "<script>alert('Emlak Silinirken Hata Oluştu.');</script>");
                    }
                }
                else if (Button4.Enabled == false)
                {
                    komut = new SqlCommand("DELETE FROM " + OturumAc.tabloadi2 + " WHERE Metrekare=@Metrekare", baglanti);
                    komut.Parameters.AddWithValue("@Metrekare", GridView1.SelectedRow.Cells[1].Text.ToString());
                    try
                    {
                        komut.ExecuteNonQuery();

                        Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "Bilgilendirme Mesajı", "<script>alert('Emlak Silindi.');</script>");
                        //
                        SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM " + OturumAc.tabloadi2 + "", baglanti);
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        GridView1.DataSource = ds;
                        GridView1.DataBind();
                    }
                    catch (Exception)
                    {
                        Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "Bilgilendirme Mesajı", "<script>alert('Emlak Silinirken Hata Oluştu.');</script>");
                    }
                }
                baglanti.Close();
            }
        }
    }
}