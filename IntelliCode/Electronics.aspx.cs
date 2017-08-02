using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;


namespace IntelliCode
{
    public partial class TextBooks : System.Web.UI.Page
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


                String Category = Request.QueryString["Category"].ToString();

                String SelectItems = "Select * from Electronics where DeviceName = @Category ";


                String Mat = "";

                Connect = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename=|Datadirectory|\\IntelliDB.mdf;Integrated Security=True");

                try
                {

                    Connect.Open();
                    Command = Connect.CreateCommand();
                    Command.Parameters.AddWithValue("@Category", Category);
                    Command.CommandText = SelectItems;
                    DataReader = Command.ExecuteReader();


                    if (DataReader.HasRows)
                    {

                        while (DataReader.Read())
                        {

                            Mat += "<ul><li><table>";
                            Mat += "<tr>";
                            Mat += " <td><img border = 1 src ='/img/electronics/" + DataReader["ElectronicImage"] + "' style ='width : 400px; height : 250px; ' alt='img'/><br/>";
                            Mat += "<p><a href='ElectronicsDetails.aspx?ProdID=" + DataReader["ElectronicID"] + "'>" + DataReader["BrandName"] + "</a></p>";
                            Mat += "<p>R " + DataReader["ElectronicPrice"] + "</p>";
                            Mat += "<p>" + DataReader["ElectronicShortDescription"] + "</p></td>";
                            Mat += "</tr>";
                            Mat += "</table></li></ul>";






                        }
                        mathset.InnerHtml = Mat;
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
        public TextBooks()
        {
            
            Load += Page_Load;
        
        }


    }
}