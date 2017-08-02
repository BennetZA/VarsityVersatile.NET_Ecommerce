using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IntelliCode
{
    public partial class ShoppingCart : System.Web.UI.Page
    {

        //    private List<cProductCart> list;

        //    protected void Page_Load(object sender, EventArgs e)
        //    {
        //        if (Session["UserNameSession"] == null)
        //        {
        //            Response.Redirect("Login.aspx");
        //        }

        //        //if user wants to remove from cart


        //        if (!(Request.QueryString["RemoveId"] == null))
        //        {

        //            String Category = Request.QueryString["Category"].ToString();
        //            String SelectItems = "Select * from Stationary where StationaryCategory = @C ";

        //            RemoveFromCart(Request.QueryString["RemoveId"].ToInt);

        //            RemoveFromCart()

        //            RemoveFromCart();
        //            //invoke method with the id as a parameter
        //            Response.Redirect("ShoppingCart.aspx");
        //            //redirect the page
        //        }



        //        //if user wants to add product to the cart
        //        if (!(Request.QueryString["AddProdId"] == null))
        //        {
        //            // If (Session("Cart") Is Nothing) Then
        //            int Id = Request.QueryString["AddProdId"];

        //            //get id
        //            list = Session["Cart"];
        //            //get the list

        //            cProductCart shoppingCart = new cProductCart(Id);
        //            //instantiate the class
        //            //set up basic connection
        //            SqlConnection connection;
        //            SqlCommand command;
        //            SqlDataReader Reader;

        //            //set up the connection string
        //            connection = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename=|DataDirectory|Product_Record.mdf;Integrated Security=True");
        //            //sql command
        //            string commandString = "SELECT * FROM Products WHERE ProductID=" + Id;
        //            command = new SqlCommand(commandString);
        //            //execute the command
        //            command.CommandType = CommandType.Text;
        //            command.Connection = connection;
        //            command.Connection.Open();
        //            command.ExecuteNonQuery();

        //            //execute reader
        //            Reader = command.ExecuteReader(CommandBehavior.CloseConnection);

        //            if ((Reader.HasRows))
        //            {

        //                while (Reader.Read)
        //                {
        //                    //Display all the products that the user wants to buy
        //                    shoppingCart.ImagePath = Reader("Item");
        //                    shoppingCart.ProdName = Reader("Name");
        //                    shoppingCart.ProdDescription = Reader("Description");
        //                    shoppingCart.Instock = Reader("InStock");
        //                    shoppingCart.Price = Reader("Price");
        //                    shoppingCart.ExtraDescription = Reader("ExtraDescription");
        //                    shoppingCart.Quantity = Reader("Quantity");
        //                    List.Add(shoppingCart);
        //                }

        //                //assign the list
        //                Session("Cart") = List;
        //                // End If
        //            }

        //        }


        //        //if the session has nothing
        //        if ((Session("Cart") == null))
        //        {

        //        }
        //        else
        //        {
        //            List<cProductCart> CartList = new List<cProductCart>();
        //            //create new list
        //            CartList = Session("Cart");
        //            //get list
        //            double totalCost;
        //            //total cost

        //            string retString = "";
        //            //string to return
        //            retString += "<table cellpadding=10px cellspacing=10px><tr style=background-color:#C0C0C0 ;color:#585858  ><td>Product</td><td>Product Description</td><td>Quantity</td><td>Price</td><td>Total</td></tr>";
        //            //loop through all the list
        //            foreach (cProductCart Prod in CartList)
        //            {

        //                string txtQuantityName = "txt" + Prod.ID;
        //                //create the input box

        //                //string to return
        //                retString += "<tr><td><img width=250px src =" + Prod.ImagePath + "></td><td>" + Prod.ProdDescription + "</td><td><input style=width:19px; type=text id=" + txtQuantityName + "  value=" + Prod.Quantity + " /></td><td>" + Prod.Price + "</td><td>R" + Prod.Totalprice + "</td><td><center><a href=ShoppingCart.aspx?RemoveId=" + Prod.ID + "><img src=../ImageFolder/remove.gif></img><br>Remove</a></center></td></tr>";
        //                totalCost += Prod.Price;
        //            }

        //            //place inside the page
        //            retString += "</table>";
        //            retString += "<table cellpadding=10px cellspacing=5px><tr><td>Have you modified your basket? Please click here to update</td><td style=background-color:#C0C0C0 ;color:#585858 >Total</td><td style=background-color:#C0C0C0 ;color:#585858 >R" + totalCost + "</td></tr></table>";
        //            innerCart.InnerHtml = retString;
        //            CartLink.InnerHtml = "<table cellpadding=10px cellspacing=5px><tr><td></td><td><a href=Checkout.aspx>Proceed to checkout</a><br/><br/><a href=Catalogue.aspx?Level=" + Session("Level") + ">Continue shopping</a></td></tr></table>";
        //        }



        //    }

        //    public void RemoveFromCart(int id)
        //    {
        //        ///////////////////////////////////////////
        //        //if user wants to remove from the cart
        //        List<cProductCart> list;
        //        //create new list
        //        list = (List<cProductCart>)Session["Cart"];
        //        //get the list

        //        //loop through all the lists
        //        foreach (cProductCart Prod in list)
        //        {
        //            if ((Prod.ID == id))
        //            {
        //                list.Remove(Prod);
        //                Session["Cart"] = list;
        //                //set list again
        //                break; // TODO: might not be correct. Was : Exit For
        //                //break loop
        //            }
        //        }

        //    }


        //    public void UpdateQuantities()
        //    {

        //        //if user wants to update the list quantity
        //        List<cProductCart> list;
        //        //create new list
        //        list =  (List<cProductCart>)Session["Cart"];
        //        //get list

        //        //loop through the whole list
        //        foreach (cProductCart Prod in list)
        //        {
        //            string QuantityValue = "txt" + Prod.ID;
        //            Prod.Quantity = Request.Form(QuantityValue);
        //            Prod.Quantity = Request.Form(QuantityValue);
        //            //update the product quantity

        //            //if there are no products left 
        //            if ((Prod.Quantity <= 0))
        //            {

        //                list.Remove(Prod);
        //                //remove the product
        //                break; // TODO: might not be correct. Was : Exit For

        //            }
        //        }
        //        Session["Cart"] = list;

        //    }

        //    protected void cmdUpdate_Click(object sender, EventArgs e)
        //    {

        //        //if user wants to update quantity
        //        UpdateQuantities();
        //    }






    }
}
