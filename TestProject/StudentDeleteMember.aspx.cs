using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace TestProject
{
    public partial class StudentDeleteMember : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string StudentID = Request.QueryString["StudentID"];

            string strConn = ConfigurationManager.ConnectionStrings
                               ["ABCPolyTech"].ToString();
            SqlConnection Conn = new SqlConnection(strConn);
            SqlCommand cmd = new SqlCommand("SELECT Name FROM Student WHERE StudentID = @StudentID", Conn);
            cmd.Parameters.AddWithValue("@studentID", StudentID);
            SqlDataReader myReader = null;
            Conn.Open();
            myReader = cmd.ExecuteReader();
            while (myReader.Read())
            {
                lblStudentName.Text = (myReader["Name"].ToString());
            }
            Conn.Close();
            lblStudentID.Text = StudentID;
        }

        protected void btnConfirm_Click(object sender, EventArgs e)
        {
            string StudentID = Request.QueryString["StudentID"];
            string ProjectID = Request.QueryString["ProjectID"];


            string strConn = ConfigurationManager.ConnectionStrings
                               ["ABCPolyTech"].ToString();
            SqlConnection Conn = new SqlConnection(strConn);
            SqlCommand cmd = new SqlCommand("DELETE FROM ProjectMember WHERE StudentID = @StudentID AND ProjectID = @ProjectID", Conn);
            cmd.Parameters.AddWithValue("@StudentID", StudentID);
            cmd.Parameters.AddWithValue("@ProjectID", ProjectID);
            Conn.Open();
            int count = cmd.ExecuteNonQuery();
            Conn.Close();
            Response.Redirect("StudentProjects.aspx");
        }
    }
}