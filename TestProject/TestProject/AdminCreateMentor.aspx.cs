using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestProject
{
    public partial class AdminCreateMentor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            //default password
            txtPassword.Text = "p@55Mentor";
            txtCfmPassword.Text = "p@55Mentor";
        }

        protected void btnConfirm_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                Mentor objMentor = new Mentor();

                objMentor.name = txtName.Text;
                objMentor.eMail = txtEmailAddr.Text;
                objMentor.password = "p@55Mentor";

                int id = objMentor.add();

                //Redirecting data
                Response.Redirect("AdminConfirmMentor.aspx?" +
                                  "name=" + txtName.Text +
                                  "&id=" + id.ToString() +
                                  "&email=" + txtEmailAddr.Text +
                                  "&password=" + txtPassword.Text);
                                  
            }
        }

        protected void cuvEmail_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if (Page.IsValid)// other client-side validation passed
            {
                Mentor objStaff = new Mentor();

                if (objStaff.isEmailExist(txtEmailAddr.Text) == true)
                    args.IsValid = false; //Raise error
                else args.IsValid = true; //No error
            }
        }
    }
}