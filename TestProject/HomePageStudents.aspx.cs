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
    public partial class HomePageStudents : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                projectPoster();
            }
        }

        private void projectPoster()
        {
            //Read connection string "Student_EPortfolio_Db_SetUp_Script (17 May 18)" from web.config file
            string strConn = ConfigurationManager.ConnectionStrings
                ["ABCPolyTech"].ToString();

            //Instantiate a SqlConnection object with the Connection String read.
            SqlConnection conn = new SqlConnection(strConn);

            SqlCommand cmd = new SqlCommand("SELECT ProjectPoster FROM Project", conn);

            SqlDataAdapter daProjects = new SqlDataAdapter(cmd);

            DataSet result = new DataSet();

            conn.Open();

            daProjects.Fill(result, "ProjectPosters");

            conn.Close();

            gvPosters.DataSource = result.Tables["ProjectPosters"];

            gvPosters.DataBind();
        }
    }
}