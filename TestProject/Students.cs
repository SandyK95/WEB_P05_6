using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace TestProject
{
    public class Students
    {
        //properties
        public int studentId { get; set; }
        public string name { get; set; }
        public string course { get; set; }
        public string photo { get; set; }
        public string description { get; set; }
        public string achievement { get; set; }
        public string externalLink { get; set; }
        public string eMail { get; set; }
        public string password { get; set; }
        public string status { get; set; }
        public int mentorID { get; set; }
        public virtual string ImageUrl { get; set; }

        public int requestId { get; set; }
        public int parentId { get; set; }
        public DateTime dateCreated { get; set; }


        public int add()
        {
            //Read connection string "NPBookConnectionString" from web.config file.
            string strConn = ConfigurationManager.ConnectionStrings
                             ["ABCPolyTech"].ToString();

            //Instantiate a SqlConnection object with the Connection String read.
            SqlConnection conn = new SqlConnection(strConn);

            //Instantiat a SqlCommand object, supply it with an INSERT SQL statement
            //which will return the auto-generated StaffID after insertion,
            //and the connection object for connecting to the database.
            SqlCommand cmd = new SqlCommand
                             ("INSERT INTO Student (Name, Course, Photo, Description," +
                             "Achievement, ExternalLink, EmailAddr, Password, Status, MentorID)" +
                              "OUTPUT INSERTED.StudentID " +
                              "VALUES(@name, @course, @photo, @description, @achievement, @externalLink, @email, @password, @status, @mentorid)", conn);

            //Define parameters used in SQL statement, value for each parameter
            //is retrieved from respectiv class's property.
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@course", course);
            cmd.Parameters.AddWithValue("@photo", photo);
            cmd.Parameters.AddWithValue("@description", description);
            cmd.Parameters.AddWithValue("@achievement", achievement);
            cmd.Parameters.AddWithValue("@externallink", externalLink);
            cmd.Parameters.AddWithValue("@email", eMail);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("@mentorid", mentorID);

            //A connection to database must be opened before any operations made.
            conn.Open();

            //ExecuteScalar is used to retrieve the auto-generated 
            //StaffID after executing the INSERT SQL statement
            int id = (int)cmd.ExecuteScalar();

            //A connection should be closed after operations.
            conn.Close();

            //Return id when no error occurs.
            return id;

        }

        public bool isEmailExist(string email)
        {
            string strConn = ConfigurationManager.ConnectionStrings
                             ["ABCPolyTech"].ToString();

            SqlConnection conn = new SqlConnection(strConn);
            SqlCommand cmd = new SqlCommand
                             ("SELECT * FROM Student WHERE EmailAddr = @selectedEmail", conn);

            cmd.Parameters.AddWithValue("@selectedEmail", email);

            SqlDataAdapter daEmail = new SqlDataAdapter(cmd);
            DataSet result = new DataSet();

            conn.Open();
            //Use DataAdapter to fetch data to a table to a table "EmailDetails" in DataSet.
            daEmail.Fill(result, "EmailDetails");
            conn.Close();

            if (result.Tables["EmailDetails"].Rows.Count > 0)
                return true; //The email given exists
            else
                return false; //The email given does not exist

        }

        public int update()
        {
            
            string strConn = ConfigurationManager.ConnectionStrings
                             ["ABCPolyTech"].ToString();

            SqlConnection conn = new SqlConnection(strConn);
            SqlCommand cmd = new SqlCommand("UPDATE ViewingRequest SET Status=@approval WHERE ViewingRequestID = @selectedViewingRequestID "
                , conn);

            //Defind the parameters used in SQL statement, value for each parameter 
            //is retrieved from respective class's property.
            cmd.Parameters.AddWithValue("@approval", status);
            cmd.Parameters.AddWithValue("@selectedViewingRequestID", requestId);

           
            conn.Open();
            int count = cmd.ExecuteNonQuery();
            conn.Close();

            if (count > 0)
                return 0;
            else
                return -2;
        }

        

    }
}