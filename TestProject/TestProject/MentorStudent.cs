using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace TestProject
{
    public class MentorStudent
    {
        //Properties
        //Student
        public string img { get; set; }
        public string status { get; set; }
        public string name { get; set; }
        public string course { get; set; }
        public string description { get; set; }
        public int studentid { get; set; }
        public string achievement { get; set; }
        public string externallink { get; set; }

        //Project
        public int projectid { get; set; }
        public string title { get; set; }
        public string Projectdescription { get; set; }
        public string url { get; set; }
        public string Posterimg { get; set; }

        //ProjectMember
        public string role { get; set; }
        public string reflection { get; set; }

        //Skills
        public string skills { get; set; }

        public int getStudentStatus()
        {
            //Read connection string "Student_EPortfolio_Db_SetUp_Script (17 May 18)" from web.config file
            string strConn = ConfigurationManager.ConnectionStrings
                ["ABCPolyTech"].ToString();

            //Instantiate a SqlConnection object with the Connection String read.
            SqlConnection conn = new SqlConnection(strConn);

            SqlCommand cmd = new SqlCommand("SELECT StudentID, Name, Status, Course FROM Student WHERE StudentID = @studentid", conn);

            cmd.Parameters.AddWithValue("@studentid", studentid);

            //Instantiate a DataAdapter object, pass the SqlCommand
            //object created as parameter.
            SqlDataAdapter daStudentStatus = new SqlDataAdapter(cmd);

            //Create a DataSet object result
            DataSet result = new DataSet();

            //Open a database connection.
            conn.Open();

            //Use DataAdapter to fetch data to a table "StaffDetails in DataSet."
            daStudentStatus.Fill(result, "StudentStatus");

            //Close database connection
            conn.Close();

            if (result.Tables["StudentStatus"].Rows.Count > 0)
            {
                //Fill Student object with values from the DataSet
                DataTable table = result.Tables["StudentStatus"];
                if (!DBNull.Value.Equals(table.Rows[0]["StudentID"]))
                    studentid = Convert.ToInt32(table.Rows[0]["StudentID"]);
                if (!DBNull.Value.Equals(table.Rows[0]["Name"]))
                    name = table.Rows[0]["Name"].ToString();
                if (!DBNull.Value.Equals(table.Rows[0]["Status"]))
                    status = table.Rows[0]["Status"].ToString();
                if (!DBNull.Value.Equals(table.Rows[0]["Course"]))
                    course = table.Rows[0]["Course"].ToString();
                return 0;
            }
            else
                return -2;

         }


        public int getStudentProjectDetails()
        {
            //Read connection string "Student_EPortfolio_Db_SetUp_Script (17 May 18)" from web.config file
            string strConn = ConfigurationManager.ConnectionStrings
                ["ABCPolyTech"].ToString();

            //Instantiate a SqlConnection object with the Connection String read.
            SqlConnection conn = new SqlConnection(strConn);

            //Instantiate a SqlCommand object, supply it with a SELECT SQL
            //statement which retrieves all attributes of a staff record. 
            SqlCommand cmd = new SqlCommand
                ("SELECT * " +
                "FROM Project P INNER JOIN ProjectMember PM " +
                "ON P.ProjectID = PM.ProjectID WHERE P.ProjectID = @projectid", conn);


            cmd.Parameters.AddWithValue("@projectid", projectid);
            //Instantiate a DataAdapter object, pass the SqlCommand
            //object created as parameter.
            SqlDataAdapter daStudentProject = new SqlDataAdapter(cmd);

            //Create a DataSet object result
            DataSet result = new DataSet();

            //Open a database connection.
            conn.Open();

            //Use DataAdapter to fetch data to a table "StaffDetails in DataSet."
            daStudentProject.Fill(result, "StudentProjectDetails");

            //Close database connection
            conn.Close();

            if (result.Tables["StudentProjectDetails"].Rows.Count > 0)
            {
                //Fill Student object with values from the DataSet
                DataTable table = result.Tables["StudentProjectDetails"];
                if (!DBNull.Value.Equals(table.Rows[0]["ProjectID"]))
                    projectid = Convert.ToInt32(table.Rows[0]["ProjectID"]);
                if (!DBNull.Value.Equals(table.Rows[0]["Title"]))
                    title = table.Rows[0]["Title"].ToString();
                if (!DBNull.Value.Equals(table.Rows[0]["Description"]))
                    Projectdescription = table.Rows[0]["Description"].ToString();
                if (!DBNull.Value.Equals(table.Rows[0]["ProjectPoster"]))
                    Posterimg ="Images/" + table.Rows[0]["ProjectPoster"].ToString();
                if (!DBNull.Value.Equals(table.Rows[0]["ProjectURL"]))
                    url = table.Rows[0]["ProjectURL"].ToString();
                if (!DBNull.Value.Equals(table.Rows[0]["Description"]))
                    Projectdescription = table.Rows[0]["Description"].ToString();
                if (!DBNull.Value.Equals(table.Rows[0]["Reflection"]))
                    reflection = table.Rows[0]["Reflection"].ToString();
                return 0;//No error occurs
            }

            else
            {
                return -2; //Record not found
            }
        
        }

        public int update()
        {
            //Read connection string "Student_EPortfolio_Db_SetUp_Script (17 May 18)" from web.config file
            string strConn = ConfigurationManager.ConnectionStrings
                ["ABCPolyTech"].ToString();

            //Instantiate a SqlConnection object with the Connection String read.
            SqlConnection conn = new SqlConnection(strConn);

            SqlCommand cmd = new SqlCommand
                ("UPDATE Student SET Status=@status WHERE StudentID =@studentid", conn);

            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("@studentid", studentid);

            conn.Open();

            int count = cmd.ExecuteNonQuery(); //string or boolean

            conn.Close();

            if (count > 0)
                return 0;
            else
                return -2;
        }

        public int getStudentDetails()
        {
            //Read connection string "Student_EPortfolio_Db_SetUp_Script (17 May 18)" from web.config file
            string strConn = ConfigurationManager.ConnectionStrings
                ["ABCPolyTech"].ToString();

            //Instantiate a SqlConnection object with the Connection String read.
            SqlConnection conn = new SqlConnection(strConn);

            SqlCommand cmd = new SqlCommand
                ("SELECT S.Name, S.Course, S.Photo, S.Description, S.Achievement, S.ExternalLink," +
                " PM.Role, PM.Reflection, " +
                "P.ProjectID, P.Title, P.Description, P.ProjectPoster, P.ProjectURL FROM Student S INNER JOIN ProjectMember PM " +
                "ON S.StudentID = PM.StudentID INNER JOIN Project P " +
                "ON PM.ProjectID = P.ProjectID WHERE S.StudentID = @selectedStudentID", conn);

            cmd.Parameters.AddWithValue("@selectedStudentID", studentid);

            SqlDataAdapter daStudent = new SqlDataAdapter(cmd);

            DataSet result = new DataSet();

            conn.Open();

            daStudent.Fill(result, "StudentDetails");

            conn.Close();

            if (result.Tables["StudentDetails"].Rows.Count > 0)
            {
                DataTable table = result.Tables["StudentDetails"];
                if (!DBNull.Value.Equals(table.Rows[0]["Name"]))
                    name = table.Rows[0]["Name"].ToString();
                if (!DBNull.Value.Equals(table.Rows[0]["Course"]))
                    course = table.Rows[0]["Course"].ToString();
                if (!DBNull.Value.Equals(table.Rows[0]["Photo"]))
                    img = "Images/" + table.Rows[0]["Photo"].ToString();
                if (!DBNull.Value.Equals(table.Rows[0]["Description"]))
                    description = table.Rows[0]["Description"].ToString();
                if (!DBNull.Value.Equals(table.Rows[0]["Achievement"]))
                    achievement = table.Rows[0]["Achievement"].ToString();
                if (!DBNull.Value.Equals(table.Rows[0]["ExternalLink"]))
                    externallink = table.Rows[0]["ExternalLink"].ToString();
                return 0;
            }
            else
                return -2;

        }
    }
}

//public bool Status(string status)
//{
//    //Read connection string "Student_EPortfolio_Db_SetUp_Script (17 May 18)" from web.config file
//    string strConn = ConfigurationManager.ConnectionStrings
//        ["ABCPolyTech"].ToString();

//    //Instantiate a SqlConnection object with the Connection String read.
//    SqlConnection conn = new SqlConnection(strConn);

//    SqlCommand cmd = new SqlCommand
//        ("SELECT * FROM ViewingRequest WHERE Status=@selectedStatus", conn);

//    cmd.Parameters.AddWithValue("@selectedStatus", status);

//    SqlDataAdapter daStatus = new SqlDataAdapter(cmd);
//    DataSet result = new DataSet();

//    conn.Open();

//    daStatus.Fill(result, "StatusDetails");
//    conn.Close();

//    if (result.Tables["StatusDetails"].Rows.Count > 0)
//        return true;
//    else
//        return false;
//}