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
    public partial class Search : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            if (searchStudent() == 1)
            {
                lblSearchedStudent.Visible = false;
                gvSearchedStudent.Visible = true;
            }
            else
            {
                lblSearchedStudent.Text = "Invalid Search";
                lblSearchedStudent.Visible = true;
                lblSearchedStudent.ForeColor = System.Drawing.Color.Red;
                gvSearchedStudent.Visible = false;
            }
        }

        protected int searchStudent()
        {
            string searchColumn = "";
            string searchValue = "";
            string sqlCommand = "";

            if (rdoSkill.Checked)
            {
                searchColumn = "SkillSetName";
                searchValue = txtSearchStudentInput.Text + "%";
                DisplayNameOnLabel();
                sqlCommand = " LIKE";
                if (searchValue == "%%")
                {
                    return 0;
                }
            }

            else
            {
                searchColumn = "Name";
                searchValue = txtSearchStudentInput.Text + "%";
                sqlCommand = " LIKE";

                if (searchValue == "%%")
                {
                    return 0;
                }
            }
            string strConn = ConfigurationManager.ConnectionStrings
                ["ABCPolyTech"].ToString();

            SqlConnection conn = new SqlConnection(strConn);

            SqlCommand cmdStudentId = new SqlCommand("SELECT s.Name, t.SkillSetName AS Skill FROM Student s " +
                "INNER JOIN StudentSkillSet Se ON Se.StudentID = s.StudentID " +
                "INNER JOIN SkillSet t ON t.SkillSetID = Se.SkillSetID WHERE " + searchColumn + sqlCommand + " @value", conn);

            cmdStudentId.Parameters.AddWithValue("@value", searchValue);

            SqlDataAdapter da = new SqlDataAdapter(cmdStudentId);

            DataSet result = new DataSet();

            try
            {
                conn.Open();
                da.Fill(result, "StudentDetails");
                conn.Close();

                gvSearchedStudent.DataSource = result.Tables["StudentDetails"];
                gvSearchedStudent.DataBind();

                if (result.Tables["StudentDetails"].Rows.Count == 0)
                    return 0;
                else
                    return 1;
            }
            catch
            {
                return 0;
            }
        }

        protected int DisplayNameOnLabel()
        {
            string searchColumn = "";
            string searchValue = "";

            searchColumn = "Name";
            searchValue = txtSearchStudentInput.Text;

            string strConn = ConfigurationManager.ConnectionStrings
                ["ABCPolyTech"].ToString();

            SqlConnection conn = new SqlConnection(strConn);

            SqlCommand cmdStudentId = new SqlCommand("SELECT s.Name, t.SkillSetName AS Skill FROM Student s " +
                "INNER JOIN StudentSkillSet Se ON Se.StudentID = s.StudentID " +
                "INNER JOIN SkillSet t ON t.SkillSetID = Se.SkillSetID" +
                " WHERE " + searchColumn + " =@value AND M.EmailAddr =@MentorID", conn);
            cmdStudentId.Parameters.AddWithValue("@value", txtSearchStudentInput.Text);

            lblSearchedStudent.Visible = true;

            try
            {
                conn.Open();

                conn.Close();

                return 1;
            }
            catch
            {
                return 0;
            }
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            txtSearchStudentInput.Text = "";
            lblSearchedStudent.Visible = false;
            gvSearchedStudent.Visible = false;
        }
    }
}