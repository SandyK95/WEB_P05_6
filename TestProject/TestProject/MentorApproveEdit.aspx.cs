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
    public partial class MentorApproveEdit : System.Web.UI.Page
    {
        //Create a new Staff object
        MentorStudent objStudent = new MentorStudent();
        List<String> Status = new List<string> { "Yes", "No" };

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                for (int i = 0; i < Status.Count; i++)
                {
                    rdoStatus.Items.Add(Status[i]);
                }

                if (Request.QueryString["studentid"] != null)
                {

                    //Read Staff ID from query string
                    objStudent.studentid = Convert.ToInt32(Request.QueryString["studentid"]);

                    //Load staff information to controls
                    int errorCode = objStudent.getStudentStatus();
                    if (errorCode == 0)
                    {
                        lblStudentID.Text = Convert.ToString(objStudent.studentid);
                        lblName.Text = objStudent.name;
                        lblCourse.Text = objStudent.course;

                        if (objStudent.status == "Y")
                        {
                            rdoStatus.SelectedValue = "Yes";
                            
                        }
                        else if (objStudent.status == "N")
                        {
                            rdoStatus.SelectedValue = "No";
                        }
                    }
                }
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                MentorStudent objStudent = new MentorStudent();

                objStudent.studentid = Convert.ToInt32(Request.QueryString["studentid"]);

                if (rdoStatus.SelectedValue == "Yes")
                    objStudent.status = "Y";
                else if (rdoStatus.SelectedValue == "No")
                    objStudent.status = "N";

                int errorCode = objStudent.update();

                if (errorCode == 0)
                {
                    lblMessage.Text = "Updated Successfully!";
                    
                }
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("MentorApproveStudentPortfolio.aspx");
        }

        protected void btnPortfolio_Click(object sender, EventArgs e)
        {
            string strValue = "";
            strValue = "studentid=" + lblStudentID.Text;
            Response.Redirect("MentorPostSuggestions2.aspx?" + strValue);
        }
    }
}



            //if (rdoStatus.SelectedItem.Value !="1" || rdoStatus.SelectedItem.Value !="0")
            //{
            //    args.IsValid = false;
            //}
            //else
            //    args.IsValid = true;













/* Custom Validate
protected void cuvStatus_ServerValidate(object source, ServerValidateEventArgs args)
{
    if (Page.IsValid)
    {
        if (objStudent.Status(rdoStatus.SelectedValue) == true)
        {
            args.IsValid = false; //error
        }

        else
            args.IsValid = true;
    }
}
*/