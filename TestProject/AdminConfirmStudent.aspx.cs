using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestProject
{
    public partial class AdminConfirmStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblId.Text = Request.QueryString["id"];
            lblName.Text = Request.QueryString["name"];
            lblCourse.Text = Request.QueryString["course"];
            lblEmail.Text = Request.QueryString["email"];
        }

        protected void btnConfirm_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {

                Response.Redirect("AdminCreateStudentAccount.aspx?");
            }
        }
    }
}