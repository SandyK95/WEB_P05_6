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
                string Role = Request.QueryString["Role"];

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
                if (Role == "Leader")
                {
                    lblAddMembers.Visible = true;
                    lblRemoveMembers.Visible = true;
                    gvMembers.Visible = true;
                    txtMembers.Visible = true;
                    SqlCommand cmdRoles = new SqlCommand("SELECT ProjectID,StudentID From ProjectMember WHERE ProjectID = @ProjectID and (Role = 'Member' or Role = 'member')", Conn);
                    cmdRoles.Parameters.AddWithValue("@ProjectID",ProjectID);
                    SqlDataAdapter daMember = new SqlDataAdapter(cmdRoles);

                    DataSet result = new DataSet();
                    Conn.Open();
                    daMember.Fill(result, "MemberDetails");
                    Conn.Close();
                    gvMembers.DataSource = result.Tables["MemberDetails"];
                    gvMembers.DataBind();
                }

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
            string Role = Request.QueryString["Role"];

            string strConn = ConfigurationManager.ConnectionStrings
                            ["ABCPolyTech"].ToString();
            SqlConnection Conn = new SqlConnection(strConn);
            SqlCommand cmdProject = new SqlCommand("UPDATE Project SET Title = @Title, Description = @Description " +
                                                   "WHERE ProjectID=@ProjectID", Conn);
            SqlCommand cmdProjectMember = new SqlCommand("UPDATE ProjectMember SET Reflection = @Reflection " +
                                                   "WHERE ProjectID=@ProjectID AND StudentID = @StudentID", Conn);
            
            if (Role == "Leader")
            {
                SqlCommand cmdmember = new SqlCommand("INSERT INTO ProjectMember (ProjectID,StudentID,Role,Reflection) " +
                                                 "VALUES(@memberProjectID,@memberStudentID,@memberRole,@memberReflection)", Conn);

                List<string> Member = txtMembers.Text.Split(',').ToList<string>();

                foreach (string MBID in Member)
                {
                    cmdmember.Parameters.AddWithValue("@memberProjectID", ProjectID);
                    cmdmember.Parameters.AddWithValue("@memberRole", "member");
                    cmdmember.Parameters.AddWithValue("@memberReflection", DBNull.Value.ToString());
                    cmdmember.Parameters.AddWithValue("@memberStudentID", MBID);
                    Conn.Open();
                    int PMID = cmdmember.ExecuteNonQuery();
                    Conn.Close();
                    cmdmember.Parameters.Clear();
                }
            }
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