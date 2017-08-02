using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace IntelliCode
{
    public partial class ProductAdditionPage : System.Web.UI.Page
    {
        private SqlConnection Connect;
        private SqlCommand Command;
        
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }


        void ExecuteAddition()
        { 
        
        
        }

        void Stationar()
        { 
        
        }

        void Electronics() {
    
           
        
        }

        void Clothing() { 
        
        
        }
        void category()
        {
        }



        protected void btnAdd_Click(object sender, EventArgs e)
        {
         

            String CommandString = "insert into Stationary Values(@Name,@cat,@price,@Img,@sDes,@fDes)";

            

            Connect = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename=|Datadirectory|\\IntelliDB.mdf;Integrated Security=True");

            if ((Session["UserNameSession"] != null) && (Session["UserAuthentication"].ToString() == "admin"))
            {

                try
                {
                    upLoad.SaveAs(Server.MapPath("img/stationary/" + upLoad.FileName));
                    MessageBox.Show(upLoad.FileName);
                    Connect.Open();
                    Command = Connect.CreateCommand();
                    Command.Parameters.AddWithValue("@Name", txtName.Text);
                    Command.Parameters.AddWithValue("@cat", DropDownList1.SelectedItem.ToString());
                    Command.Parameters.AddWithValue("@price", txtPrice.Text);
                    Command.Parameters.AddWithValue("@Img", upLoad.FileName);
                    Command.Parameters.AddWithValue("@sDes", txtSdescription.Text);
                    Command.Parameters.AddWithValue("@fDes", txtFdescription.Text);
                    Command.CommandText = CommandString;
                    Command.ExecuteNonQuery();
                    MessageBox.Show("product Upated");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Response.Write(ex.Message);
                }
                finally
                {
                    Connect.Close();

                }

            }
            else
            {
                Response.Redirect("Index.aspx");
            }
           
         }

       

       

        
       }
}