using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IntelliCode
{
    public partial class Logout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        Response.Cookies.Remove("UserName");
        Response.Cookies.Remove("Time Logged In");

        Session["UserNameSession"] = null;
        Session["Level"] = null;

        Response.Redirect("index.aspx");

        }
    }
}