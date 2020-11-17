using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace TestProject
{
    public class SkillSet
    {
        public string skillId { get; set; }
        public string name { get; set; }

        public int add()
        {
            //Read connection string "NPBookConnectionString" from web.config file.
            string strConn = ConfigurationManager.ConnectionStrings
                             ["ABCPolyTech"].ToString();

            //Instantiate a SqlConnection object with the Connection String read.
            SqlConnection conn = new SqlConnection(strConn);

            SqlCommand cmd = new SqlCommand
                             ("INSERT INTO SkillSet (SkillSetName)" +
                              "OUTPUT INSERTED.SkillSetID " +
                              "VALUES(@name)", conn);

            cmd.Parameters.AddWithValue("@name", name);
            

            conn.Open();

            int id = (int)cmd.ExecuteScalar();
            conn.Close();

            return id;

        }

        public bool isNameExist(string name)
        {
            string strConn = ConfigurationManager.ConnectionStrings
                             ["ABCPolyTech"].ToString();

            SqlConnection conn = new SqlConnection(strConn);
            SqlCommand cmd = new SqlCommand
                             ("SELECT * FROM SkillSet WHERE SkillSetName = @selectedName", conn);

            cmd.Parameters.AddWithValue("@selectedName", name);

            SqlDataAdapter daName = new SqlDataAdapter(cmd);
            DataSet result = new DataSet();

            conn.Open();
            //Use DataAdapter to fetch data to a table to a table "EmailDetails" in DataSet.
            daName.Fill(result, "SkillSet");
            conn.Close();

            if (result.Tables["SkillSet"].Rows.Count > 0)
                return true; //The email given exists
            else
                return false; //The email given does not exist

        }
    }
}