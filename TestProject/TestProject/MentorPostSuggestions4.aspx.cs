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
    public partial class MentorPostSuggestions4 : System.Web.UI.Page
    {
        MentorStudent objStudent = new MentorStudent();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Request.QueryString["projectid"] != null)
                {
                    objStudent.projectid = Convert.ToInt32(Request.QueryString["projectid"]);

                    int errorCode = objStudent.getStudentProjectDetails();
                    if (errorCode == 0)
                    {
                        lblProjectID.Text = Convert.ToString(objStudent.projectid);
                        imgPoster.ImageUrl = objStudent.Posterimg;
                        hlProjectURL.NavigateUrl = objStudent.url;
                        lblProjectTitle.Text = objStudent.title;
                        lblProjectDescription.Text = objStudent.Projectdescription;
                        lblReflection.Text = objStudent.reflection;
                    }
                }
            }
        }
    }
}
