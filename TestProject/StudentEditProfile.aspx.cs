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
    public partial class EditProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string StudentID = (string)Session["StudentID"];
                string strConn = ConfigurationManager.ConnectionStrings
                                ["ABCPolyTech"].ToString();
                SqlConnection Conn = new SqlConnection(strConn);
                SqlCommand cmd = new SqlCommand("SELECT * FROM Student WHERE StudentID = @selectedStudentID", Conn);
                SqlDataReader myReader = null;
                cmd.Parameters.AddWithValue("@selectedStudentID", StudentID);

                Conn.Open();
                myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    txtName.Text = (myReader["Name"].ToString());
                    ddlCourse.Text = (myReader["Course"].ToString());
                    txtAbout.Text = (myReader["Description"].ToString());
                    txtEmail.Text = (myReader["EmailAddr"].ToString());
                    txtExternalLink.Text = (myReader["ExternalLink"].ToString());
                    txtAchievements.Text = (myReader["Achievement"].ToString());
                }
                Conn.Close();
                SqlCommand cmdSkillsetID = new SqlCommand("SELECT SkillSetID FROM Skillset", Conn);
                SqlCommand cmdSkillsetName = new SqlCommand("SELECT SkillSetName FROM Skillset", Conn);
                SqlDataAdapter daSkillsetName = new SqlDataAdapter(cmdSkillsetName);
                DataSet Result = new DataSet();
                SqlCommand cmdskills = new SqlCommand("SELECT SkillSetID FROM StudentSkillSet WHERE StudentID = @selectedStudentID", Conn);
                cmdskills.Parameters.AddWithValue("@selectedStudentID", StudentID);
                SqlDataAdapter daSkills = new SqlDataAdapter(cmdskills);
                DataSet result = new DataSet();
                Conn.Open();
                daSkillsetName.Fill(Result);
                daSkills.Fill(result, "StudentSkillSet");
                Conn.Close();
                cblSkillSet.DataSource = Result;
                cblSkillSet.DataTextField = "SkillSetName";
                cblSkillSet.DataValueField = "SkillSetName";
                cblSkillSet.DataBind();
            }
            
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int index = 0;
            student objstudent = new student();
            string StudentID = (string)Session["StudentID"];
            string Name = txtName.Text;
            string Course = ddlCourse.Text;
            string Description = txtAbout.Text;
            string Achievement = txtAchievements.Text;
            string EmailAddr = txtEmail.Text;
            string ExternalLink = txtExternalLink.Text;
            objstudent.StudentID = Convert.ToInt32(StudentID);
            objstudent.Name = Name;
            objstudent.Course = Course;
            objstudent.Description = Description;
            objstudent.Achievement = Achievement;
            objstudent.EmailAddr = EmailAddr;
            objstudent.ExternalLink = ExternalLink;
            int errorcode = objstudent.Update();
            string strConn = ConfigurationManager.ConnectionStrings
                             ["ABCPolyTech"].ToString();
            SqlConnection conn = new SqlConnection(strConn);
            SqlCommand cmddelete = new SqlCommand("DELETE FROM StudentSkillSet WHERE StudentID = @StudentID",conn);
            cmddelete.Parameters.AddWithValue("@StudentID", StudentID);
            conn.Open();
            int cmd = cmddelete.ExecuteNonQuery();
            conn.Close();
            foreach (ListItem skill in cblSkillSet.Items)
            {
                index += 1;
                if (skill.Selected)
                {
                    SqlCommand cmdinsert = new SqlCommand("INSERT INTO StudentSkillSet (StudentID, SkillSetID) " + "VALUES(@studentid, @skillsetid)", conn);
                    cmdinsert.Parameters.AddWithValue("@studentid", StudentID);
                    cmdinsert.Parameters.AddWithValue("@skillsetid", index);
                    conn.Open();
                    int count = cmdinsert.ExecuteNonQuery();
                    conn.Close();
                    cmdinsert.Parameters.Clear();
                }
            }
            Response.Redirect("StudentMain.aspx");
        }
    }
}