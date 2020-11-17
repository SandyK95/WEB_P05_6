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
    public partial class MentorViewandReply : System.Web.UI.Page
    {
        Reply reply = new Reply();

        protected void Page_Load(object sender, EventArgs e)
        {
            lblMessageID.Text = Request.QueryString["messageid"];
            lblMentorID.Text = Session["LoginID"].ToString();
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("MentorView.aspx");
        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            reply.messageid = Convert.ToInt32(lblMessageID.Text);
            reply.text = txtReplyBox.Text;
            reply.mentorid = returnMentorID();
            reply.datetimeposted = DateTime.Now;

            int errorCode = reply.Add();

            if (errorCode == 0)
            {
                lblReplied.Visible = true;
                clear();
            }
        }

        private string returnMentorID()
        {
            //Read connection string "Student_EPortfolio_Db_SetUp_Script (17 May 18)" from web.config file
            string strConn = ConfigurationManager.ConnectionStrings
                ["ABCPolyTech"].ToString();

            //Instantiate a SqlConnection object with the Connection String read.
            SqlConnection conn = new SqlConnection(strConn);

            string command = "SELECT MentorID FROM Reply WHERE MessageID = " + lblMessageID.Text;
            SqlCommand cmd = new SqlCommand(command, conn);

            conn.Open();

            string mentorid = Convert.ToString((int)cmd.ExecuteScalar());

            conn.Close();

            return mentorid;
        }

        private void clear()
        {
            lblMentorID.Text = "";
            lblMessageID.Text = "";
            txtReplyBox.Text = "";
        }
    }
}