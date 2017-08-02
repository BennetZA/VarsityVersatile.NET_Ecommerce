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
    public partial class ProductEditPage : System.Web.UI.Page
    {
        private SqlConnection Connect;
        private SqlCommand Command;
        private SqlDataReader Datareader;

        protected void Page_Load(object sender, EventArgs e)
        {

            Connect = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename=|Datadirectory|\\IntelliDB.mdf;Integrated Security=True");
            Command = new SqlCommand("select * From Stationary  where StationaryID = @prodID ", Connect);

            if ((Session["UserNameSession"] != null) && (Session["UserAuthentication"].ToString() == "admin"))
            {
                try
                {
                    Command.Parameters.AddWithValue("@ProdID", txtID.Text);
                    Command.CommandType = CommandType.Text;
                    Command.Connection.Open();
                    Datareader = Command.ExecuteReader();

                    if (!IsPostBack)
                    {
                        if (Datareader.HasRows)
                        {

                            while (Datareader.Read())
                            {
                                txtID.Text = Datareader["StationaryID"].ToString();
                                txtName.Text = Datareader["StationaryName"].ToString();
                                DropDownList1.SelectedItem.Text = Datareader["StationaryCategory"].ToString();
                                txtPrice.Text = Datareader["StationaryPrice"].ToString();
                                txtPrice.Text = Datareader["StationarImage"].ToString();
                                txtSdescription.Text = Datareader["StationaryShortDescription"].ToString();
                                txtFdescription.Text = Datareader["StationaryDescription"].ToString();

                            }
                            Command.Dispose();
                            Datareader = null;

                        }



                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
           
            }
            else
            {
            
                Response.Redirect("Index.aspx");
            }
           

        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            String CommandString = "Update Stationary set StationaryName = @Name ,StationaryCategory= @cat, StationaryPrice = @price, StationarImage = @Img,StationaryShortDescription = @sDes ,StationaryDescription = @fDes where StationaryID = @ID";

            Connect = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename=|Datadirectory|\\IntelliDB.mdf;Integrated Security=True");

            try
            {
                Upload.SaveAs(Server.MapPath("img/stationary/" + Upload.FileName));
                Connect.Open();
                Command = Connect.CreateCommand();
                Command.Parameters.AddWithValue("@ID",txtID.Text);
                Command.Parameters.AddWithValue("@Name",txtName.Text);
                Command.Parameters.AddWithValue("@cat", DropDownList1.SelectedItem.ToString());
                Command.Parameters.AddWithValue("@price", txtPrice.Text);
                Command.Parameters.AddWithValue("@Img", Upload.FileName);
                Command.Parameters.AddWithValue("@sDes", txtSdescription.Text);
                Command.Parameters.AddWithValue("@fDes", txtFdescription.Text);
                Command.CommandText = CommandString;
                Command.ExecuteNonQuery();
                MessageBox.Show("productUpated");
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

       
       
    
        
    }
}