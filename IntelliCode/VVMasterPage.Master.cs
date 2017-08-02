using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IntelliCode
{
    public partial class VVMasterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((Session["UserNameSession"] != null) && (Session["UserAuthentication"].ToString() == "admin"))
            {
                Add.Visible = true;
                Delete.Visible = true;
                Edit.Visible = true;
            }
            if (Session["Cart"] == null)
            {
                cartMenu.InnerHtml = "<h2 style='color:white;  text-shadow:3px 0px blue; '>Shopping Cart: <b>0 items <a href=ShoppingCart.aspx>(Show Cart)</a></b><h2>";
            }
            else
            {
                List<cProductCart> list =  new List<cProductCart>() ;

                cartMenu.InnerHtml = "<h3 style='color:white'>Shopping Cart: <b>" + list.Count + " Items Added <a href=ShoppingCart.aspx>(Show Products Cart)</a></b></h3>";
            }


            if ((Session["UserNameSession"] == null))
            {
                Rout.InnerHtml = "<h2 style='color:white;  text-shadow:3px 0px blue; ' ><a color= black href =Login.aspx><b>SignIn </b></a> / <a href = Register.aspx><b> Register</b></a></h2>";
            }
            else
            {
                Rout.InnerHtml = "<h2 style='color:white;  text-shadow:3px 0px blue; '>Welcome :  Mr/Miss/Mrs " + Session["UserNameSession"] + "<br> <a href=Logout.aspx>SignOut</a></h2>";
            }
        }
    }
}