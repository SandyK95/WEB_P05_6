using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace TestProject
{
    public class MentorSuggestions
    {
        public int studentid { get; set; }
        public int mentorid { get; set; }
        public int suggestionid { get; set; }
        public string description { get; set; }
        public string status { get; set; }
        public DateTime datecreated { get; set; }

        public int getSuggestionDetails()
        {
            string strConn = ConfigurationManager.ConnectionStrings
                ["ABCPolyTech"].ToString();

            SqlConnection conn = new SqlConnection(strConn);

            SqlCommand cmd = new SqlCommand
                ("SELECT SU.SuggestionID, SU.Description, SU.Status, SU.DateCreated FROM Student S INNER JOIN Suggestion SU " +
                "ON S.StudentID = SU.StudentID WHERE S.StudentID = @selectedStudentID", conn);

            cmd.Parameters.AddWithValue("@selectedStudentID", studentid);

            SqlDataAdapter daStudent = new SqlDataAdapter(cmd);

            DataSet result = new DataSet();

            conn.Open();

            daStudent.Fill(result, "SuggestionDetails");

            conn.Close();

            if (result.Tables["SuggestionDetails"].Rows.Count > 0)
            {
                DataTable table = result.Tables["SuggestionDetails"];
                if (!DBNull.Value.Equals(table.Rows[0]["SuggestionID"]))
                    suggestionid = Convert.ToInt32(table.Rows[0]["SuggestionID"]);
                if (!DBNull.Value.Equals(table.Rows[0]["Description"]))
                    description = Convert.ToString(table.Rows[0]["Description"]);
                if (!DBNull.Value.Equals(table.Rows[0]["Status"]))
                    status = Convert.ToString(table.Rows[0]["Status"]);
                if (!DBNull.Value.Equals(table.Rows[0]["DateCreated"]))
                    datecreated = Convert.ToDateTime(table.Rows[0]["DateCreated"]);
                return 0;
            }

            else
                return -2;
        }

        public int Add()
        {
            //Read connection string "Student_EPortfolio_Db_SetUp_Script (17 May 18)" from web.config file
            string strConn = ConfigurationManager.ConnectionStrings
                ["ABCPolyTech"].ToString();

            //Instantiate a SqlConnection object with the Connection String read.
            SqlConnection conn = new SqlConnection(strConn);

            SqlCommand cmd = new SqlCommand
                ("INSERT INTO SUGGESTION (MentorID, StudentID, Description, Status, DateCreated) " +
                "VALUES(@mentorid, @studentid, @description, @status, @datecreated)", conn);

            cmd.Parameters.AddWithValue("@mentorid", mentorid);
            cmd.Parameters.AddWithValue("@studentid", studentid);
            cmd.Parameters.AddWithValue("@description", description);
            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("@datecreated", datecreated);

            conn.Open();

            cmd.ExecuteNonQuery();

            conn.Close();

            return 0;
        }


        public string statusUpdate()
        {
            string strConn = ConfigurationManager.ConnectionStrings
    ["ABCPolyTech"].ToString();

            SqlConnection conn = new SqlConnection(strConn);

            SqlCommand cmd = new SqlCommand("UPDATE Student SET Status= 'N' WHERE StudentID =@studentid", conn);

            cmd.Parameters.AddWithValue("@studentid", studentid);

            conn.Open();

            int count = cmd.ExecuteNonQuery(); 

            conn.Close();

            if (count > 0)
                return "Successful";
            else
                return "Not Successful";

        }

        public int getStudentSuggestion(ref DataSet result)
        {
            //Read connection string "Student_EPortfolio_Db_SetUp_Script (17 May 18)" from web.config file
            string strConn = ConfigurationManager.ConnectionStrings
                ["ABCPolyTech"].ToString();

            //Instantiate a SqlConnection object with the Connection String read.
            SqlConnection conn = new SqlConnection(strConn);

            SqlCommand cmd = new SqlCommand
                ("SELECT SU.SuggestionID, SU.Description, SU.Status, SU.DateCreated FROM Student S INNER JOIN Suggestion SU " +
                "ON S.StudentID = SU.StudentID WHERE S.StudentID = @selectedStudentID", conn);

            cmd.Parameters.AddWithValue("@selectedStudentID", studentid);

            SqlDataAdapter daStudent = new SqlDataAdapter(cmd);

            conn.Open();

            daStudent.Fill(result, "Suggestions");

            conn.Close();

            return 0;
        }
    }
}