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
    public partial class Engineering : System.Web.UI.Page
    {
        private SqlConnection Connection;
        private SqlCommand Command;
        private SqlDataReader Reader;

        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["UserNameSession"] == null)
            {
                Response.Redirect("Login.aspx");
            }


            if (!IsPostBack)
            {

                String Book = "";

                Connection = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename=|Datadirectory|\\IntelliDB.mdf;Integrated Security=True");

                try
                {

                    Connection.Open();
                    Command = Connection.CreateCommand();
                    Command.CommandText = "Select  * From TextBook where TextBookCategory = 'Engineering'";
                    Reader = Command.ExecuteReader();


                    if (Reader.HasRows)
                    {

                        while (Reader.Read())
                        {
                            Book += "<ul><li>";
                            Book += "<table width=100%><tr><td class='Display'><a href='TextBookDetails.aspx?BookID=" + Reader["TextBookID"] + "'><img border = 3 src='Img/TextBooks/" + Reader["ImgL"] + ".png" + "' style='width:320px;height:400px;'/></a></td></tr><br>";
                            Book += "<tr><td class='Display'>" + "<p style='color:white'>  Book Name: <b>" + "<a href='TextBooksDetails.aspx?BookID=" + Reader["TextBookID"] + "'>" + Reader["TextBookName"] + "</p></a></b><br/></td></tr>";
                            Book += "<tr><td class='Display'> <p style='color:white'>   Price : R " + Reader["TextBookPrice"] + "</p></td></tr>";
                            Book += "<tr><td class='DesDisplay'><br/>" + "Description: " + Reader["TextBookShortDescription"] + "</td></tr></table>";
                            Book += "</li></ul>";
                        }
                        Reader.Close();
                        Display.InnerHtml += Book;

                    }


                }


                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Response.Write(ex.Message);
                }
                finally
                {
                    Connection.Close();

                }

            }
        }


        public Engineering()
        {
            Load += Page_Load;
        }
    }
}