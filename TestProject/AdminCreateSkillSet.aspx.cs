using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestProject
{
    public partial class AdminCreateSkillSet : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                SkillSet objSkillSet = new SkillSet();

                objSkillSet.name = txtSkillName.Text;

                int id = objSkillSet.add();

                Response.Redirect("AdminConfirmSkillSet.aspx?name=" + txtSkillName.Text + "&id=" + id.ToString());
            }
        }

        protected void cvSkillSet_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if (Page.IsValid)
            {
                SkillSet objSkillSet = new SkillSet();

                if (objSkillSet.isNameExist(txtSkillName.Text) == true)
                    args.IsValid = false; //Raise error
                else args.IsValid = true; //No error
            }
        }
    }
}