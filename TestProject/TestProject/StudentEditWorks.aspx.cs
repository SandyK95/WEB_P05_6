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
    public partial class StudentEditWorks : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string ProjectID = Request.QueryString["ProjectID"];
                string Title = Request.QueryString["Title"];
                string Description = Request.QueryString["Description"];

                lblProjectID.Text = ProjectID;
                txtTitle.Text = Title;
                txtDescription.Text = Description;

                string StudentID = (string)Session["StudentID"];
                string strConn = ConfigurationManager.ConnectionStrings
                                ["ABCPolyTech"].ToString();
                SqlConnection Conn = new SqlConnection(strConn);
                SqlCommand cmd = new SqlCommand("SELECT Reflection FROM ProjectMember WHERE StudentID = @selectedStudentID AND ProjectID = @ProjectID", Conn);
                SqlDataReader myReader = null;
                cmd.Parameters.AddWithValue("@selectedStudentID", StudentID);
                cmd.Parameters.AddWithValue("@ProjectID", ProjectID);

                Conn.Open();
                myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    txtReflection.Text = (myReader["Reflection"].ToString());
                }
                Conn.Close();
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            string ProjectID = Request.QueryString["ProjectID"];
            string Title = txtTitle.Text;
            string Description = txtDescription.Text;
            string Reflection = txtReflection.Text;
            string StudentID = (string)Session["StudentID"];
            string strConn = ConfigurationManager.ConnectionStrings
                            ["ABCPolyTech"].ToString();
            SqlConnection Conn = new SqlConnection(strConn);
            SqlCommand cmdProject = new SqlCommand("UPDATE Project SET Title = @Title, Description = @Description " +
                                                   "WHERE ProjectID=@ProjectID", Conn);
            SqlCommand cmdProjectMember = new SqlCommand("UPDATE ProjectMember SET Reflection = @Reflection " +
                                                   "WHERE ProjectID=@ProjectID AND StudentID = @StudentID", Conn);
            cmdProject.Parameters.AddWithValue("Title", Title);
            cmdProject.Parameters.AddWithValue("Description", Description);
            cmdProject.Parameters.AddWithValue("ProjectID", ProjectID);
            cmdProjectMember.Parameters.AddWithValue("@Reflection", Reflection);
            cmdProjectMember.Parameters.AddWithValue("@ProjectID", ProjectID);
            cmdProjectMember.Parameters.AddWithValue("@StudentID", StudentID);
            Conn.Open();
            int Pcount = cmdProject.ExecuteNonQuery();
            int PMcount = cmdProjectMember.ExecuteNonQuery();
            Conn.Close();
            Response.Redirect("StudentProjects.aspx");
        }
    }
}