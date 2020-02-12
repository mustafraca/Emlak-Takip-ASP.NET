using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Emlak
{
    public partial class OturumKapat : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            OturumAc.tf = false;
            Response.Redirect("Default.aspx");
        }
    }
}