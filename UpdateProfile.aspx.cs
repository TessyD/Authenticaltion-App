using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SocialMediaApplication
{
    public partial class UpdateProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["loginUser"] != null)
            {
                string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
                SqlConnection sqlConnection = new SqlConnection(mainconn);
                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand("select firstName,lastName,email,password,dateOfBirth,profileImage from [dbo].[Users] where email ='" + Session["loginUser"] + "'", sqlConnection);
                SqlDataReader sqlDataReader = cmd.ExecuteReader();
                if (sqlDataReader.Read())
                {
                    txtEmail.Text = sqlDataReader["email"].ToString();
                    txtPassword.Text = sqlDataReader["password"].ToString();
                    txtFirstName.Text = sqlDataReader["firstName"].ToString();
                    txtLastName.Text = sqlDataReader["lastName"].ToString();
                    txtDOB.Text = sqlDataReader["dateOfBirth"].ToString();
      

                }
            }
        }

        protected void updateProfile_Click(object sender, EventArgs e)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(mainconn);
            string sqlQuery = "Update [dbo].[Users] set firstName=@firstName,lastName=@lastName,email=@email,password=@password,dateOfBirth=@dateOfBirth where email='"+Session["loginUser"]+"'";
            SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
            sqlConnection.Open();
            sqlCommand.Parameters.AddWithValue("@firstName", txtFirstName.Text);
            sqlCommand.Parameters.AddWithValue("@lastName", txtLastName.Text);
            sqlCommand.Parameters.AddWithValue("@email", txtEmail.Text);
            sqlCommand.Parameters.AddWithValue("@password", txtPassword.Text);
            sqlCommand.Parameters.AddWithValue("@dateOfBirth", txtDOB.Text);
            
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
    }
}