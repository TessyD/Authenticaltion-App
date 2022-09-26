using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SocialMediaApplication
{
    public partial class LandingPage2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["loginUser"]!= null)
            {
                string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
                SqlConnection sqlConnection = new SqlConnection(mainconn);
                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand("select firstName,lastName,email,dateOfBirth,profileImage from [dbo].[Users] where email ='"+Session["loginUser"] +"'", sqlConnection);
                SqlDataReader sqlDataReader = cmd.ExecuteReader();
                if (sqlDataReader.Read())
                {
                    lblEmail.Text = sqlDataReader["email"].ToString();
                    lblFirstName.Text = sqlDataReader["firstName"].ToString();
                    lblLastName.Text = sqlDataReader["lastName"].ToString();
                    lblDob.Text = sqlDataReader["dateOfBirth"].ToString();
                    string imgname = sqlDataReader["profileImage"].ToString();
                    imgprofile.ImageUrl = imgname;

                }
            }

        }

        protected void updateProfile_Click(object sender, EventArgs e)
        {
            Response.Redirect("UpdateProfile.aspx");
        }
    }
}