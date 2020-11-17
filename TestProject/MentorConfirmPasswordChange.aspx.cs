using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestProject
{
    public partial class MentorConfirmPasswordChange : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblMentorID.Text = Request.QueryString["MentorID"];
            lblNewPassword.Text = Request.QueryString["ConfirmPassword"];
        }
    }
}