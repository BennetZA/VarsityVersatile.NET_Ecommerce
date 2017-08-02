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
    public partial class ClothingDetails : System.Web.UI.Page
    {
        private SqlConnection Connect;
        private SqlCommand Command;
        private SqlDataReader DataReader;

        protected void Page_Load(object sender, EventArgs e)
        {
            String SelectItems1 = "Select  * From Clothing where ClothingID = @ProdID   ";


            String Mat = "";

            string ProductID = Request.QueryString["ProdID"].ToString();
            Connect = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename=|Datadirectory|\\IntelliDB.mdf;Integrated Security=True");

            try
            {

                Connect.Open();
                Command = Connect.CreateCommand();
                Command.Parameters.AddWithValue("@ProdID", ProductID);
                Command.CommandText = SelectItems1;
                DataReader = Command.ExecuteReader();


                if (DataReader.HasRows)
                {

                    while (DataReader.Read())
                    {
                        Mat += "<ul><li><table border = 1><tr><td>";
                        Mat += "<img border = 1 src ='/img/clothing/" + DataReader["clothingImage"] + "' style ='width : 500px; height : 160px; ' alt='img'/><br/><p><p>" + DataReader["ClothingDescription"] + "</p>";
                        Mat += "</td></tr></table></li></ul>";

                    }
                    DataReader.Close();
                    DescrHtml.InnerHtml += Mat;


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


        public ClothingDetails()
        {
            Load += Page_Load;
        }
    }
}