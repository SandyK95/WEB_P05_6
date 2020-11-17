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
    public partial class View : System.Web.UI.Page
    {
        public string messageid = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!(Page.IsPostBack))
            {
                displayallreply();
            }
        }

        private void displayallreply()
        {
            int mentorid = returnMentorID();

            //Read connection string "Student_EPortfolio_Db_SetUp_Script (17 May 18)" from web.config file
            string strConn = ConfigurationManager.ConnectionStrings
                ["ABCPolyTech"].ToString();

            //Instantiate a SqlConnection object with the Connection String read.
            SqlConnection conn = new SqlConnection(strConn);

            SqlCommand cmd = new SqlCommand("Select DISTINCT M.Text, M.MessageID from Reply R " +
    "INNER JOIN Message M on R.MessageID = M.MessageID WHERE FromID =@MentorID", conn);
            //SqlCommand cmd = new SqlCommand("Select M.MessageID, M.Title, M.DateTimePosted, M.Text AS MESSAGE, R.Text AS REPLY from Reply R " +
            //    "INNER JOIN Message M on R.MessageID = M.MessageID WHERE FromID =@MentorID", conn);

            cmd.Parameters.AddWithValue("@MentorID",mentorid);

            SqlDataAdapter RP = new SqlDataAdapter(cmd);

            DataSet result = new DataSet();

            conn.Open();
            RP.Fill(result, "displayallreply");
            gvSender.DataSource = result.Tables["displayallreply"];
            gvSender.DataBind();
        }

        protected void gvSender_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedMessageID = Convert.ToInt32(gvSender.SelectedDataKey[0]);

            Reply objReply = new Reply();

            DataSet dsViewReply = new DataSet();

            objReply.messageid = selectedMessageID;

            int errorCode = objReply.getmessageid(ref dsViewReply);

            if (errorCode == 0)
            {
                gvReceiver.DataSource = dsViewReply.Tables["ReplyDetails"];
                gvReceiver.DataBind();
            }
        }

        private int returnMentorID()
        {
            string strConn = ConfigurationManager.ConnectionStrings
                ["ABCPolyTech"].ToString();

            SqlConnection conn = new SqlConnection(strConn);

            SqlCommand cmd = new SqlCommand("SELECT * FROM Mentor WHERE EmailAddr = @MentorID", conn);

            cmd.Parameters.AddWithValue("@MentorID", Session["LoginID"].ToString());

            conn.Open();

            int mentorid = (int)cmd.ExecuteScalar();

            conn.Close();

            return mentorid;
        }
    }
}