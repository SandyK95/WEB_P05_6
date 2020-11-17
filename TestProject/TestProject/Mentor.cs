using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace TestProject
{
    public class Mentor
    {
        //Properties
        public int mentorId { get; set; }
        public string name { get; set; }
        public string eMail { get; set; }
        public string password { get; set; }

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
                             ("INSERT INTO Mentor (Name, EmailAddr, Password)" +
                              "OUTPUT INSERTED.MentorID " +
                              "VALUES(@name, @email, @password)", conn);

            //Define parameters used in SQL statement, value for each parameter
            //is retrieved from respectiv class's property.
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@email", eMail);
            cmd.Parameters.AddWithValue("@password", password);
            
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
                             ("SELECT * FROM Mentor WHERE EmailAddr = @selectedEmail", conn);

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
    }
}