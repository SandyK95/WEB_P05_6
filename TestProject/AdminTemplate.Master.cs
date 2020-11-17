using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestProject
{
    public partial class AdminTemplate : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["LoginID"] != null)
            {
                lblLoginID.Text = (string)Session["LoginID"].ToString();
                lblLoggedTime.Text = "You have logged in since " + Session["LoggedInTime"].ToString();
            }

            else // user not logged in
            {
                Response.Redirect("Login.aspx");
            }
        }
    }
}