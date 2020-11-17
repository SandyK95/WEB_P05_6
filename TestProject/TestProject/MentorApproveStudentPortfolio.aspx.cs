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
    public partial class ApproveStudentPortfolio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                displayStudentList();
            }
        }
        private void displayStudentList()
        {
            //Read connection string "Student_EPortfolio_Db_SetUp_Script (17 May 18)" from web.config file
            string strConn = ConfigurationManager.ConnectionStrings
                ["ABCPolyTech"].ToString();

            //Instantiate a SqlConnection object with the Connection String read.
            SqlConnection conn = new SqlConnection(strConn);

            //Instantiate a Sql Command object, supply it with the SQL statement 
            //Select that operates against the database, and the connection object
            //used for connecting to the database.
            SqlCommand cmd = new SqlCommand("SELECT S.StudentID, S.Name, S.Status FROM Student S " +
                "INNER JOIN Mentor M ON S.MentorID = M.MentorID " +
                "WHERE M.EmailAddr = @emailaddress ORDER BY StudentID",
                conn);

            cmd.Parameters.AddWithValue("@emailaddress", Session["LoginID"].ToString());


            //Instantiate a DataAdapter object and pass the SqlCommand object
            // Created a parameter.
            SqlDataAdapter daStudent = new SqlDataAdapter(cmd);

            //Create a DataSet Object to contain the records retrieved from database
            DataSet result = new DataSet();

            //A connection must be openeded before any operations made.
            conn.Open();

            //User DataAdapter to fetch data to a table "StudentDetails" in DataSet.
            // DataSet "result will store the result of the SELECT operation
            daStudent.Fill(result, "StudentStatus");

            //A connection should always be closed, whether error occurs or not.
            conn.Close();

            //Specify GridView to get data from table "StaffDetails"
            //in DataSet "result"
            gvStudent.DataSource = result.Tables["StudentStatus"];

            //Display the list of data in GridView
            gvStudent.DataBind();

            int count = 0;
            if (result.Tables["StudentStatus"].Rows.Count > 0)
            {
                count = result.Tables["StudentStatus"].Rows.Count;
                lblMessage.Text = "Number of Student records : " + count.ToString();
            }
            else
            {
                lblMessage.Text = "No Student Record";
            }
        }

        protected void gvStudent_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            //Set the page index to the page clicked by user
            gvStudent.PageIndex = e.NewPageIndex;
            //Display records on the new page.
            displayStudentList();
        }
    }
}