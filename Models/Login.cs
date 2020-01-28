using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;

using System.Configuration;
using System.Data;
using Microsoft.Extensions.Configuration;


namespace MealPlanner.Models
{
    public partial class Login
    {
        /*
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from UserRegistration where Username =@Username and Password=@Password", con);
            cmd.Parameters.AddWithValue("@Username", Username.Text);
            cmd.Parameters.AddWithValue("@Password", inputpassword.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {

                Response.Redirect("LoginPage.aspx");

            }

            else
            {

                Label3.Visible = true;
                Label3.Text = "Wrong Details";
            }
        }*/
    }
}

