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
    public partial class Stationary : System.Web.UI.Page
    {
        private SqlConnection Connect;
        private SqlCommand Command;

        private SqlDataReader DataReader;

        protected void Page_Load(object sender, EventArgs e)
        {
             String Category = Request.QueryString["Category"].ToString();

            String SelectItems = "Select * from Stationary where StationaryCategory = @C ";


            String Mat = "";

            Connect = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename=|Datadirectory|\\IntelliDB.mdf;Integrated Security=True");

            try
            {

                Connect.Open();
                Command = Connect.CreateCommand();
                Command.Parameters.AddWithValue("@C", Category);
                Command.CommandText = SelectItems;
                DataReader = Command.ExecuteReader();


                if (DataReader.HasRows)
                {
                   
                    while (DataReader.Read())
                    {
                       

                        Mat += "<ul><li><table>";
                        Mat += "<tr>";
                        Mat += " <td><img border = 1 src ='/img/stationary/" + DataReader["StationarImage"] + "' style ='width : 400px; height : 250px; ' alt='img'/><br/>";
                        Mat += "<p><a href='StationaryDetails.aspx?ProdID=" + DataReader["StationaryID"] + "'>" + DataReader["StationaryName"] + "</a></p>";
                        Mat += "<p>R " + DataReader["StationaryPrice"] + "</p>";
                        Mat += "<p>" + DataReader["StationaryShortDescription"] + "</p></td>";
                        Mat += "</tr>";
                        Mat += "</table></li></ul>";

                    }
                    stationaryHtml.InnerHtml = Mat;
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
         public Stationary()
        {
            
            Load += Page_Load;
        
        }
    }
}
