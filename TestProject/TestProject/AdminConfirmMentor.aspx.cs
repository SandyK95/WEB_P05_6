using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestProject
{
    public partial class AdminConfirmMentor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string mentorName;
            string Email;
            int mentorid;
            mentorName = Request.QueryString["name"];
            Email = Request.QueryString["email"];
            mentorid = Convert.ToInt32(Request.QueryString["id"]);
            lblName.Text = mentorName;
            lblEmail.Text = Email;
            lblId.Text = Convert.ToString(mentorid);
        }

        

        protected void btnConfirm_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminCreateMentor.aspx?");
        }
    }
}