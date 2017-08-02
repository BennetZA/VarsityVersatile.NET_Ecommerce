using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;


namespace IntelliCode
{
    public partial class Clothing : System.Web.UI.Page
    {
        private SqlConnection Connect;
        private SqlCommand Command;

        private SqlDataReader DataReader;
        


        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserNameSession"] == null) 
            {
                Response.Redirect("Login.aspx");
            }


            if (!IsPostBack)
            {

                String Category = Request.QueryString["cat"].ToString();

                String SelectItems = "SELECT * FROM Clothing WHERE ClothingCategory = @cat ";


                String Mat = "";

                Connect = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename=|Datadirectory|\\IntelliDB.mdf;Integrated Security=True");



                try
                {
                    Connect.Open();
                    Command = Connect.CreateCommand();
                    Command.Parameters.AddWithValue("@cat", Category);
                    Command.CommandText = SelectItems;
                    DataReader = Command.ExecuteReader();


                    if (DataReader.HasRows)
                    {

                        while (DataReader.Read())
                        {


                            Mat += "<ul><table>";
                            Mat += "<tr>";
                            Mat += " <td><img border = 1 src ='/img/clothing/" + DataReader["ClothingImage"] + "' style ='width : 400px; height : 250px; ' alt='img'/><br/>";
                            Mat += "<p><a href='ClothingDetails.aspx?ProdID= " + DataReader["ClothingID"] + "'>" + DataReader["ClothingName"] + "</a></p>";
                            Mat += "<p>R " + DataReader["ClothingPrice"] + "</p>";
                            Mat += "<p>" + DataReader["ClothingShortDescription"] + "</p></td>";
                            Mat += "</tr>";
                            Mat += "</table></li></ul>";

                        }
                        content.InnerHtml = Mat;
                        DataReader.Close();

                    }


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
        public Clothing()
        {
            Load += Page_Load;
        }
    }
}