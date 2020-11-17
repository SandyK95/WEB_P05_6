using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace TestProject
{
    public class Project
    {
        public int ProjectID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ProjectPoster { get; set; }
        public string ProjectURL { get; set; }

        public int CreateProject()
        {
            string strConn = ConfigurationManager.ConnectionStrings
                   ["ABCPolyTech"].ToString();

            //Instantiate a SqlConnection object with the Connection String read.
            SqlConnection Conn = new SqlConnection(strConn);

            SqlCommand cmdproject = new SqlCommand("INSERT INTO Project(Title,Description,ProjectPoster,ProjectURL)" +
                                                   " OUTPUT INSERTED.ProjectID VALUES(@Title,@Description,@ProjectPoster,@ProjectURL)", Conn);

            cmdproject.Parameters.AddWithValue("@Title", Title);
            cmdproject.Parameters.AddWithValue("@Description", Description);
            cmdproject.Parameters.AddWithValue("@ProjectPoster", ProjectPoster);
            cmdproject.Parameters.AddWithValue("@ProjectURL", ProjectURL);

            Conn.Open();
            int id = (int) cmdproject.ExecuteScalar();
            Conn.Close();
            return id;
        }
    }
}