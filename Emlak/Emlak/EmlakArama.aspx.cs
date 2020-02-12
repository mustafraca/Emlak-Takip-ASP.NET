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
    public partial class EmlakArama : System.Web.UI.Page
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

        protected void Button1_Click(object sender, EventArgs e)
        {     
            if (TextBox1.Text != "")
            {
                baglanti.Open();
                if (Button3.Enabled == false)
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM " + OturumAc.tabloadi1 + " WHERE Metrekare LIKE '%" + TextBox1.Text.ToString() + "%'", baglanti);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    GridView1.DataSource = ds;
                    GridView1.DataBind();
                }
                else if (Button4.Enabled == false)
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM " + OturumAc.tabloadi2 + " WHERE Metrekare LIKE '%" + TextBox1.Text.ToString() + "%'", baglanti);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    GridView1.DataSource = ds;
                    GridView1.DataBind();
                }
                baglanti.Close();
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
    }
}