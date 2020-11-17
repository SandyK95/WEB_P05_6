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
    public partial class StudentPersonalWork : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnCreate_Click(object sender, EventArgs e)
        {
            Project objProject = new Project();
            objProject.Title = txtPrjName.Text;
            objProject.Description = txtDesc.Text;
            if (fupProject.HasFile == false)
            {
                objProject.ProjectPoster = DBNull.Value.ToString();
            }
            else
            {
                objProject.ProjectPoster = fupProject.ToString();
            }
            string StudentID = (string)Session["StudentID"];
            objProject.ProjectURL = txtPrjURL.Text;
            int id = objProject.CreateProject();

            string strConn = ConfigurationManager.ConnectionStrings
                 ["ABCPolyTech"].ToString();
            SqlConnection Conn = new SqlConnection(strConn);
            SqlCommand cmdleader = new SqlCommand("INSERT INTO ProjectMember (ProjectID,StudentID,Role,Reflection) " +
                                                  "VALUES(@ProjectID,@StudentID,@Role,@Reflection)", Conn);
            SqlCommand cmdmember = new SqlCommand("INSERT INTO ProjectMember (ProjectID,StudentID,Role,Reflection) " +
                                                  "VALUES(@memberProjectID,@memberStudentID,@memberRole,@memberReflection)", Conn);

            cmdleader.Parameters.AddWithValue("@ProjectID", id);
            cmdleader.Parameters.AddWithValue("@StudentID", StudentID);
            cmdleader.Parameters.AddWithValue("@Role", "Leader");
            cmdleader.Parameters.AddWithValue("@Reflection", DBNull.Value.ToString());

            List<string> Member = txtMembers.Text.Split(',').ToList<string>();

            foreach (string MBID in Member)
            {
                cmdmember.Parameters.AddWithValue("@memberProjectID", id);
                cmdmember.Parameters.AddWithValue("@memberRole", "member");
                cmdmember.Parameters.AddWithValue("@memberReflection", DBNull.Value.ToString());
                cmdmember.Parameters.AddWithValue("@memberStudentID", MBID);
                Conn.Open();
                int PMID = cmdmember.ExecuteNonQuery();
                Conn.Close();
                cmdmember.Parameters.Clear();
            }
            Conn.Open();
            int MID = cmdleader.ExecuteNonQuery();
            Conn.Close();

            Response.Redirect("StudentProjects.aspx");

        }
    }
}