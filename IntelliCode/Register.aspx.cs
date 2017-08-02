using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using System.Data;

namespace IntelliCode
{
    public partial class Register : System.Web.UI.Page
    {
      

       private  string  FirstName  ;
       private  string  Surname  ;
       private string Gender;
       private string Username;
       private  string   Email ;
       private string Password;
       private string HashedPassword;
       private SqlConnection Connection;


        

        protected void Page_Load(object sender, EventArgs e)
        {
          
        }

        protected void btnRgister_Click(object sender, EventArgs e)
        {
            FirstName = txtFirstName.Text;
            Surname = txtLastName.Text;
            Gender = GenderDropDown.SelectedItem.Text;
            Username = txtUsername.Text;
            Email = txtEmail.Text;
            Password = txtPassword.Text;
            HashedPassword = Secrecy.HashPassword(Password);

            if (Password.Equals(txtConfirmpassword.Text))
            {
                //new Connection String
                Connection = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename=|Datadirectory|\\IntelliDB.mdf;Integrated Security=True");

                string CommandString = "INSERT INTO [SiteUser] VALUES ('" + FirstName + "','" + Surname + "', '" + Gender + "',   '" + Username + "', '" + Email + "','" + HashedPassword + "'," + 1 + ");";
                SqlCommand command = new SqlCommand(CommandString);
                command.CommandType = CommandType.Text;
                command.Connection = Connection;
                command.Connection.Open();
                command.ExecuteNonQuery();

                Response.Redirect("Login.aspx");
                command.Connection.Close();
                command.Dispose();
                Connection.Dispose();


            }
            else {
              PassWordMatch.Text = "Passwords do not match";
             PassWordMatch.Visible=true;
            
            }

          }
       }
 }

       

    
