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
    public partial class StudentAcknowledge : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Suggestion();
            }
        }

        private void Suggestion()
        {
            string StudentID = (string)Session["StudentID"];
            string strConn = ConfigurationManager.ConnectionStrings
                                 ["ABCPolyTech"].ToString();
            SqlConnection Conn = new SqlConnection(strConn);
            SqlCommand cmd = new SqlCommand("SELECT SuggestionID,MentorID,Description,Status,DateCreated" +
                                            " FROM Suggestion WHERE StudentID = @StudentID",Conn);

            cmd.Parameters.AddWithValue("@StudentID", StudentID);

            SqlDataAdapter daSuggestion = new SqlDataAdapter(cmd);

            DataSet Result = new DataSet();
            Conn.Open();
            daSuggestion.Fill(Result, "SuggestionDetails");
            Conn.Close();
            gvSuggestion.DataSource = Result.Tables["SuggestionDetails"];
            gvSuggestion.DataBind();
        }
    }
}