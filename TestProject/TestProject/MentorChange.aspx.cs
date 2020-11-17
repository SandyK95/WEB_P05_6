using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace TestProject
{
    public partial class Change : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void updatepassword()
        {
            //Read connection string "Student_EPortfolio_Db_SetUp_Script (17 May 18)" from web.config file
            string strConn = ConfigurationManager.ConnectionStrings
                ["ABCPolyTech"].ToString();

            //Instantiate a SqlConnection object with the Connection String read.
            SqlConnection conn = new SqlConnection(strConn);

            SqlCommand cmd = new SqlCommand
                ("UPDATE MENTOR SET Password = @password WHERE EmailAddr = @Mentorid",conn);
            cmd.Parameters.AddWithValue("@password",txtNewPwd.Text.ToString());
            cmd.Parameters.AddWithValue("@Mentorid", Session["LoginID"].ToString());
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                string strValues;

                strValues = "MentorID=" + Session["LoginID"].ToString();
                strValues += "&ConfirmPassword=" + txtConfirmPwd.Text;
                updatepassword();
                Response.Redirect("MentorConfirmPasswordChange.aspx?" + strValues);
            }
        }

        protected void cuvConfirmPassword_ServerValidate(object source, ServerValidateEventArgs args)
        {
            string ConfirmPassword = txtConfirmPwd.Text;
            if (ConfirmPassword.Length >= 8 && ConfirmPassword.Any(char.IsDigit))
            {
                args.IsValid = true;
            }
            else
                args.IsValid = false;
        }
    }
}