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
    public partial class AdminCreateStudentAccount : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                displayMentorDropDownList();

                ddCourse.Items.Add("IT");
                ddCourse.Items.Add("FI");
                ddCourse.Items.Add("A3DA");
                ddCourse.Items.Add("MMA");
                ddCourse.Items.Add("ISF");

                lblCurrentYear.Text = Convert.ToString(DateTime.Now.Year);
                txtPassword.Text = "p@55Student";
                txtConfirmPassword.Text = "p@55Student";
            }

        }

        private void displayMentorDropDownList()
        {
            string strConn = ConfigurationManager.ConnectionStrings
                            ["ABCPolyTech"].ToString();

            SqlConnection conn = new SqlConnection(strConn);

            SqlCommand cmd = new SqlCommand("SELECT * FROM Mentor", conn);
 
            SqlDataAdapter daMentor = new SqlDataAdapter(cmd);
            DataSet result = new DataSet();

            conn.Open();
            daMentor.Fill(result, "MentorDetails");
            conn.Close();

            ddMentor.DataSource = result.Tables["MentorDetails"];
            ddMentor.DataTextField = "Name";
            ddMentor.DataValueField = "MentorID";

            ddMentor.DataBind();

            ddMentor.Items.Insert(0, "--Select--");


        }

        protected void btnConfirm_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                Students objStudent = new Students();

                objStudent.name = txtName.Text;
                objStudent.course = ddCourse.SelectedItem.Text;
                objStudent.photo = "";
                objStudent.description = "";
                objStudent.achievement = "";
                objStudent.externalLink = "";
                objStudent.eMail = txtEmailAddr.Text;
                objStudent.password = "p@55Student";
                objStudent.status = "N";
                objStudent.mentorID = ddMentor.SelectedIndex;

                int id = objStudent.add();

                Response.Redirect("AdminConfirmStudent.aspx?" +
                                  "name=" + txtName.Text +
                                  "&course=" + ddCourse.SelectedItem.Text +
                                  "&email=" + txtEmailAddr.Text +
                                  "&id=" + id.ToString());

            }
        }

        protected void cuvEmail_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if (Page.IsValid)// other client-side validation passed
            {
                Students objStaff = new Students();

                if (objStaff.isEmailExist(txtEmailAddr.Text) == true)
                    args.IsValid = false; //Raise error
                else args.IsValid = true; //No error
            }
        }

    }
}