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
    public partial class MentorPostSuggestions2 : System.Web.UI.Page
    {
        MentorStudent objStudent = new MentorStudent();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Request.QueryString["studentid"] != null)
                {
                    objStudent.studentid = Convert.ToInt32(Request.QueryString["studentid"]);

                    int errorCode = objStudent.getStudentDetails();
                    if (errorCode == 0)
                    {
                        Img.ImageUrl = objStudent.img;
                        lblStudentID.Text = Convert.ToString(objStudent.studentid);
                        lblStudentName.Text = objStudent.name;
                        lblCourse.Text = objStudent.course;
                        lblDescription.Text = objStudent.description;
                        lblAchievement.Text = objStudent.achievement;
                        hlExternalLink.NavigateUrl = objStudent.externallink;
                        skills();
                        projects();
                    }               
                }
            }
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("MentorPostSuggestions.aspx");
        }

        protected void btnSuggest_Click(object sender, EventArgs e)
        {
            string strValue = "";
            strValue = "studentid=" + lblStudentID.Text;
            Response.Redirect("MentorCreateSuggestion.aspx?" + strValue);
        }

        private void skills()
        {
            //Read connection string "Student_EPortfolio_Db_SetUp_Script (17 May 18)" from web.config file
            string strConn = ConfigurationManager.ConnectionStrings
                ["ABCPolyTech"].ToString();

        //Instantiate a SqlConnection object with the Connection String read.
        SqlConnection conn = new SqlConnection(strConn);

        SqlCommand cmd = new SqlCommand("SELECT SE.SkillSetName FROM Student ST " +
            "INNER JOIN StudentSkillSet SK ON ST.StudentID = SK.StudentID " +
            "INNER JOIN SkillSet SE ON SK.SkillSetID = SE.SkillSetID WHERE ST.StudentID = @studentid", conn);

            cmd.Parameters.AddWithValue("@studentid", lblStudentID.Text);

            SqlDataAdapter daSKills = new SqlDataAdapter(cmd);

            DataSet result = new DataSet();

            conn.Open();

            daSKills.Fill(result, "SkillsDetails");

            conn.Close();

            gvSkills.DataSource = result.Tables["SkillsDetails"];

            gvSkills.DataBind();
        }

        private void projects()
        {
            //Read connection string "Student_EPortfolio_Db_SetUp_Script (17 May 18)" from web.config file
            string strConn = ConfigurationManager.ConnectionStrings
                ["ABCPolyTech"].ToString();

            //Instantiate a SqlConnection object with the Connection String read.
            SqlConnection conn = new SqlConnection(strConn);

            SqlCommand cmd = new SqlCommand("SELECT P.ProjectID,S.StudentID, P.Title, PM.Role FROM Student S " +
                "INNER JOIN ProjectMember PM ON S.StudentID = PM.StudentID " +
                "INNER JOIN Project P ON PM.ProjectID = P.ProjectID WHERE S.StudentID = @studentid", conn);

            cmd.Parameters.AddWithValue("@studentid", lblStudentID.Text);

            SqlDataAdapter daProjects = new SqlDataAdapter(cmd);

            DataSet result = new DataSet();

            conn.Open();

            daProjects.Fill(result, "ProjectsDetails");

            conn.Close();

            gvProjects.DataSource = result.Tables["ProjectsDetails"];

            gvProjects.DataBind();
        }

        protected void btnApprove_Click(object sender, EventArgs e)
        {
            string strValue = "";
            strValue = "studentid=" + lblStudentID.Text;
            Response.Redirect("MentorApproveEdit.aspx?" + strValue);
        }
    }
}