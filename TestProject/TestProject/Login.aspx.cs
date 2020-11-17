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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            //Read inputs from textboxes
            string loginID = txtLoginID.Text;//Textbox: txtLoginID
            string password = txtPassword.Text;//Textbox:txtPassword

            //Read selection of radio buttons
            string userType = "";

            if (rdoAdmin.Checked == true)
                userType = "Admin";

            else if (rdoStudent.Checked == true)
                userType = "Student";

            else if (rdoMentor.Checked == true)
                userType = "Mentor";

            if (loginID == "admin@ap.edu.sg" && password == "passAdmin" && userType == "Admin")
            {
                Session["LoginID"] = loginID;
                Session["LoggedInTime"] = DateTime.Now;
                Response.Redirect("AdminMain.aspx");
            }

            else if (loginID == "s1234567@ap.edu.sg" && password == "p@55Student" && userType == "Student")
            {
                Session["LoginID"] = loginID;
                Session["LoggedInTime"] = DateTime.Now;
                Response.Redirect("StudentMain.aspx");
            }


            else //for other students and mentors
            {
                //Read connection string "Student_EPortfolio_Db_SetUp_Script (17 May 18)" from web.config file
                string strConn = ConfigurationManager.ConnectionStrings
                    ["ABCPolyTech"].ToString();

                //Instantiate a SqlConnection object with the Connection String read.
                SqlConnection conn = new SqlConnection(strConn);

                SqlCommand cmdMentor = new SqlCommand("SELECT * FROM Mentor", conn);
                SqlCommand cmdStudent = new SqlCommand("SELECT * FROM Student", conn);

                SqlDataAdapter daMentor = new SqlDataAdapter(cmdMentor);
                SqlDataAdapter daStudent = new SqlDataAdapter(cmdStudent);

                DataSet dsMentor = new DataSet();
                DataSet dsStudent = new DataSet();

                conn.Open();

                daMentor.Fill(dsMentor, "MentorDetails");
                daStudent.Fill(dsStudent, "StudentDetails");

                conn.Close();

                DataView dvMentor;
                DataView dvStudent;

                dvMentor = dsMentor.Tables[0].DefaultView;
                dvStudent = dsStudent.Tables[0].DefaultView;

                foreach (DataRowView datarow in dvMentor)
                {
                    string mentorEmailAdd = datarow["EmailAddr"].ToString();
                    string validpassword = datarow["Password"].ToString();
                    string mentorid = datarow["MentorID"].ToString();

                    if (loginID == mentorEmailAdd && password == validpassword && userType == "Mentor")
                    {
                        Session["LoginID"] = loginID;
                        Session["LoggedInTime"] = DateTime.Now;
                        Response.Redirect("MentorMain.aspx");
                    }

                    else
                    {
                        //Display error message
                        lblMessage.Text = "Invaild Login Credentials!";
                    }

                }

                foreach (DataRowView datarow in dvStudent)
                {
                    string StudentEmailAdd = datarow["EmailAddr"].ToString();
                    string validpassword = datarow["Password"].ToString();

                    if (loginID == StudentEmailAdd && password == validpassword && userType == "Student")
                    {
                        Session["LoginID"] = loginID;
                        Session["LoggedInTime"] = DateTime.Now;
                        Response.Redirect("StudentMain.aspx");
                    }

                    else
                    {
                        //Display error message
                        lblMessage.Text = "Invaild Login Credentials!";
                    }
                }
            }
        }
    }
}






                    //else
                    //{
                    //    //Display error message
                    //    lblMessage.Text = "Invaild Login Credentials!";
                    //}


            //else if (loginID == "Peter_Ghim@ap.edu.sg" && password == "p@55Mentor" && userType == "Mentor")
            //{
            //    Session["LoginID"] = loginID;
            //    Session["LoggedInTime"] = DateTime.Now;
            //    Response.Redirect("MentorMain.aspx");
            //}