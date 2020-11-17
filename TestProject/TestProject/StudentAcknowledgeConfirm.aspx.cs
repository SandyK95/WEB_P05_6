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
    public partial class StudentAcknowledgeConfirm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string SuggestionID = Request.QueryString["SuggestionID"];
                lblSuggestionID.Text = SuggestionID;
                string Description = Request.QueryString["Description"];
                lblDescription.Text = Description;
                string Status = Request.QueryString["Status"];
                lblStatus.Text = Status;
            }
        }

        protected void btnAcknowledge_Click(object sender, EventArgs e)
        {
            string SuggestionID = Request.QueryString["SuggestionID"];
            string strConn = ConfigurationManager.ConnectionStrings
                            ["ABCPolyTech"].ToString();
            SqlConnection Conn = new SqlConnection(strConn);
            SqlCommand cmd = new SqlCommand("UPDATE Suggestion SET Status=@Status " +
                                            "WHERE SuggestionID=@SuggestionID", Conn);
            cmd.Parameters.AddWithValue("@SuggestionID", SuggestionID);
            cmd.Parameters.AddWithValue("@Status", "Y");
            Conn.Open();
            int count = cmd.ExecuteNonQuery();
            Conn.Close();
            Response.Redirect("StudentAcknowledge.aspx");
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("StudentAcknowledge.aspx");
        }
    }
}