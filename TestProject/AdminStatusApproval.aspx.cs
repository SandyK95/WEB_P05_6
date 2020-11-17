using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestProject
{
    public partial class AdminStatusApproval : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblViewID.Text = Request.QueryString["viewingrequestid"] + "    ";
            lblStudName.Text = Request.QueryString["studentname"];
        }

        protected void btnApprove_Click(object sender, EventArgs e)
        {
            if (Request.QueryString["viewingrequestid"] != null)
            {
                //Create a Staff object
                Students objStudent = new Students();

                //Get the staff Id from query string
                //and convert the query string to 32-bit integer. 
                objStudent.requestId = Convert.ToInt32(Request.QueryString["viewingrequestid"]);
                objStudent.status = "A";

                int errorCode = objStudent.update();

                if (errorCode == 0)
                {
                    btnApprove.Enabled = false;
                    btnReject.Enabled = false;
                    lblChange.Text = "The selected viewing request has been approved.";
                    Response.Redirect("AdminApproveView.aspx");
                }

            }
        }

        protected void btnReject_Click(object sender, EventArgs e)
        {
            if (Request.QueryString["viewingrequestid"] != null)
            {
                //Create a Staff object
                Students objStudent = new Students();

                //Get the staff Id from query string
                //and convert the query string to 32-bit integer. 
                objStudent.requestId = Convert.ToInt32(Request.QueryString["viewingrequestid"]);
                objStudent.status = "R";

                int errorCode = objStudent.update();

                if (errorCode == 0)
                {
                    btnApprove.Enabled = false;
                    btnReject.Enabled = false;
                    lblChange.Text = "The selected viewing request has been denied.";
                    Response.Redirect("AdminApproveView.aspx");
                }
            }


        }

        protected void btnReturn_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminApproveView.aspx");
        }

    }
}