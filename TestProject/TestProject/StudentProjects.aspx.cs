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
    public partial class StudentProjects : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                projects();
            }
        }
        private void projects()
        {
            string StudentID = (string)Session["StudentID"];
            string strConn = ConfigurationManager.ConnectionStrings
                                 ["ABCPolyTech"].ToString();
            SqlConnection Conn = new SqlConnection(strConn);
            SqlCommand cmd = new SqlCommand("SELECT P.ProjectID,PM.Role,P.Title,P.Description FROM Project P INNER JOIN " +
                                            "ProjectMember PM ON PM.ProjectID=P.ProjectID " +
                                            "WHERE PM.StudentID = @selectedStudentID", Conn);

            cmd.Parameters.AddWithValue("@selectedStudentID", StudentID);

            SqlDataAdapter daProjects = new SqlDataAdapter(cmd);

            DataSet result = new DataSet();

            Conn.Open();
            daProjects.Fill(result, "ProjectDetails");
            Conn.Close();

            gvProjects.DataSource = result.Tables["ProjectDetails"];
            gvProjects.DataBind();
        }

        protected void btnCreate_Click(object sender, EventArgs e)
        {
            Response.Redirect("StudentCreateWork.aspx");
        }
    }
}