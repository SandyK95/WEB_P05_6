using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace TestProject
{
    public class Reply
    {
        public int replyid { get; set; }
        public int messageid { get; set; }
        public string mentorid { get; set; }

        public DateTime datetimeposted { get; set; }
        public string text { get; set; }

        public int getmessageid(ref DataSet result)
        {
            //Read connection string "Student_EPortfolio_Db_SetUp_Script (17 May 18)" from web.config file
            string strConn = ConfigurationManager.ConnectionStrings
                ["ABCPolyTech"].ToString();

            //Instantiate a SqlConnection object with the Connection String read.
            SqlConnection conn = new SqlConnection(strConn);

            SqlCommand cmd = new SqlCommand("SELECT * FROM Reply WHERE MessageID = @MessageID", conn);

            cmd.Parameters.AddWithValue("@MessageID", messageid);

            SqlDataAdapter daReply = new SqlDataAdapter(cmd);

            conn.Open();

            daReply.Fill(result, "ReplyDetails");

            conn.Close();

            return 0;
        }

        public int Add()
        {
            //Read connection string "Student_EPortfolio_Db_SetUp_Script (17 May 18)" from web.config file
            string strConn = ConfigurationManager.ConnectionStrings
                ["ABCPolyTech"].ToString();

            //Instantiate a SqlConnection object with the Connection String read.
            SqlConnection conn = new SqlConnection(strConn);

            SqlCommand cmd = new SqlCommand("INSERT INTO Reply (MessageID, " +
                "MentorID, DateTimePosted, Text) " +
                "VALUES(@messageid, @mentorid, @datetimeposted, @text)", conn);

            cmd.Parameters.AddWithValue("@messageid", messageid);
            cmd.Parameters.AddWithValue("@mentorid", mentorid);
            cmd.Parameters.AddWithValue("@datetimeposted", datetimeposted);
            cmd.Parameters.AddWithValue("@text", text);

            conn.Open();

            cmd.ExecuteNonQuery();

            conn.Close();

            return 0;
        }
    }
}