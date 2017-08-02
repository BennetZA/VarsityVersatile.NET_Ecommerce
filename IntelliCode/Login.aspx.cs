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

    public partial class Login : System.Web.UI.Page
    {



       private string Username ;
       private string Password;
       private string HashedPassword;
       private SqlConnection connection;
       private SqlCommand command;
    

        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Username = txtUsername.Text;
            Password = txtPasword.Text;
            HashedPassword = Secrecy.HashPassword(Password);
            connection = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename=|Datadirectory|\\IntelliDB.mdf;Integrated Security=True");
            string commandString = "SELECT * FROM [SiteUser] WHERE UserName ='" + Username + "'";
            
        command = new SqlCommand(commandString) ;
        command.CommandType = CommandType.Text ; 
        command.Connection = connection ; 
        command.Connection.Open() ; 
        command.ExecuteNonQuery() ;
        SqlDataReader reader;
        reader = command.ExecuteReader(CommandBehavior.CloseConnection);

        if (reader.HasRows)
        {



            while(reader.Read())
            {
               if ( Username.Equals(reader["UserName"].ToString())  && HashedPassword.Equals(reader["UserPassWord"].ToString()))
                {



                    HttpCookie UsernameCookie = new HttpCookie("UserName", reader["UserName"].ToString());
                    HttpCookie TrackTimeLoggedIn = new HttpCookie("Log in Time", DateTime.Now.TimeOfDay.ToString());
                    Response.Cookies.Add(UsernameCookie);
                    Response.Cookies.Add(TrackTimeLoggedIn);


                    Session.Add("UserNameSession", reader["UserName"]);
                    Session.Add("Level", reader["UserAuthentication"]);
                    Session.Add("UserId", reader["UserID"]);
                    Session.Add("Cart", new List<cProductCart>());
                    Session["UserAuthentication"] = reader["UserAuthentication"];

                    Response.Redirect("index.aspx?Level=" + Session["Level"]);


                }
                else
                {
                    LoginError.Visible = true;
                    LoginError.Text = "Incorrect Username/Password Please Make Sure Your Username/Password is Correct";

                }



            } 
        
        
        }
            

           
        }
    }
}
