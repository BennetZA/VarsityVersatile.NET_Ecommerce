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
    public partial class ProductDeletionPage : System.Web.UI.Page
    {
         private SqlConnection Connect;
        private SqlCommand Command;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            String CommandString = "Delete from Stationary  where StationaryName  = @Name and StationaryID = @ID";

            Connect = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename=|Datadirectory|\\IntelliDB.mdf;Integrated Security=True");
            if ((Session["UserNameSession"] != null) && (Session["UserAuthentication"].ToString() == "admin"))
            {
                try
                {

                    Connect.Open();
                    Command = Connect.CreateCommand();
                    Command.Parameters.AddWithValue("@ID", txtID.Text);
                    Command.Parameters.AddWithValue("@Name", txtName.Text);
                    Command.CommandText = CommandString;
                    Command.ExecuteNonQuery();
                    MessageBox.Show("productURemoved");
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
    
