using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace TestProject
{
    public class student
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public string Course { get; set; }
        public string Photo { get; set; }
        public string Description { get; set; }
        public string Achievement { get; set; }
        public string ExternalLink { get; set; }
        public string EmailAddr { get; set; }
        public string Password { get; set; }
        public string Status { get; set; }
        public int MentorID { get; set; }

        public int Update()
        {
            string strConn = ConfigurationManager.ConnectionStrings
                ["ABCPolyTech"].ToString();

            SqlConnection conn = new SqlConnection(strConn);

            SqlCommand cmd = new SqlCommand("UPDATE Student SET Name = @Name, Course = @Course, Description = @Description,"+
                                            "Achievement = @Achievement, EmailAddr=@EmailAddr, ExternalLink = @ExternalLink WHERE StudentID = @selectedStudentID", conn);

            cmd.Parameters.AddWithValue("@Name", Name);
            cmd.Parameters.AddWithValue("@Course", Course);
            cmd.Parameters.AddWithValue("@Description", Description);
            cmd.Parameters.AddWithValue("@Achievement", Achievement);
            cmd.Parameters.AddWithValue("@EmailAddr", EmailAddr);
            cmd.Parameters.AddWithValue("@selectedStudentID", StudentID);
            cmd.Parameters.AddWithValue("@ExternalLink", ExternalLink);

            conn.Open();

            int count = cmd.ExecuteNonQuery();

            conn.Close();

            if (count > 0)
            {
                return 0;
            }
            else
                return -2;
        }
    }
}