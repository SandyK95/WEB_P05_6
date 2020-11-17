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
    public partial class PostSuggestions : System.Web.UI.Page
    {
        public string studentID = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                displayStudentList();
            }
        }

        private void displayStudentList()
        {
            string strConn = ConfigurationManager.ConnectionStrings
                ["ABCPolyTech"].ToString();

            SqlConnection conn = new SqlConnection(strConn);

            SqlCommand cmd = new SqlCommand("SELECT * FROM STUDENT S INNER JOIN Mentor M " +
                "ON S.MentorID = M.MentorID WHERE M.EmailAddr = @MentorID", conn);

            cmd.Parameters.AddWithValue("@MentorID", Session["LoginID"].ToString());

            SqlDataAdapter daStudent = new SqlDataAdapter(cmd);

            DataSet result = new DataSet();

            conn.Open();

            daStudent.Fill(result, "StudentDetails");

            conn.Close();

            gvStudent.DataSource = result.Tables["StudentDetails"];

            gvStudent.DataBind();
        }

        protected void gvStudent_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvStudent.PageIndex = e.NewPageIndex;
            displayStudentList();
        }

        protected void gvStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedStudentID = Convert.ToInt32(gvStudent.SelectedDataKey[0]);

            MentorSuggestions getStudentSuggestion = new MentorSuggestions();

            DataSet dsViewSuggestion = new DataSet();

            getStudentSuggestion.studentid = selectedStudentID;

            int errorCode = getStudentSuggestion.getStudentSuggestion(ref dsViewSuggestion);

            if (errorCode == 0)
            {
                gvSuggestions.DataSource = dsViewSuggestion.Tables["Suggestions"];
                gvSuggestions.DataBind();
            }

        }
    }
}