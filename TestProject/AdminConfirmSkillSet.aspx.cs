using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestProject
{
    public partial class AdminConfirmSkillSet : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblId.Text = " [id: #" + Request.QueryString["id"] + "] - ";
            lblName.Text = Request.QueryString["name"];
        }

        protected void btnAcknowledge_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminCreateSkillSet.aspx?");
        }
    }
}