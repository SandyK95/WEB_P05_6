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
    public partial class MentorCreateSuggestion : System.Web.UI.Page
    {
        MentorSuggestions suggestion = new MentorSuggestions();

        protected void Page_Load(object sender, EventArgs e)
        {
            lblStudentID.Text = Request.QueryString["studentid"];
            lblMentorID.Text = returnMentorID();

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                suggestion.mentorid = Convert.ToInt32(lblMentorID.Text);
                suggestion.studentid = Convert.ToInt32(lblStudentID.Text);
                suggestion.description = txtSuggestion.Text;
                suggestion.status = "N";
                suggestion.datecreated = DateTime.Now;

                int errorCode = suggestion.Add();
                if (errorCode == 0)
                {
                    lblStatus.Text =  suggestion.statusUpdate();
                    lblSubmit.Visible = true;
                    btnBack.Enabled = true;
                    //update status not to be released.
                }
            }
        }

        private string returnMentorID()
        {
            string strConn = ConfigurationManager.ConnectionStrings
                ["ABCPolyTech"].ToString();

            SqlConnection conn = new SqlConnection(strConn);

            SqlCommand cmd = new SqlCommand("SELECT M.MentorID FROM Suggestion S INNER JOIN Mentor M " +
                "ON S.MentorID = M.MentorID WHERE M.EmailAddr = @MentorID", conn);

            cmd.Parameters.AddWithValue("@MentorID", Session["LoginID"].ToString());

            conn.Open();

            string mentorid = Convert.ToString((int)cmd.ExecuteScalar());

            conn.Close();

            return mentorid;
        }
        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("MentorPostSuggestions.aspx");
        }
    }
}
//