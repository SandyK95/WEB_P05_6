using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace TestProject
{
    public partial class AdminUploadStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                displayStudentList();
            }

        }

        protected void ddlName_SelectedIndexChanged(object sender, EventArgs e)
        {

            string id = ddlName.SelectedValue;
            string img = "";

            string strConn = ConfigurationManager.ConnectionStrings
                                ["ABCPolyTech"].ToString();

            SqlConnection conn = new SqlConnection(strConn);
            SqlCommand cmd = new SqlCommand
                            ("SELECT Photo FROM Student Where StudentID = @selectedStudentID ", conn);

            cmd.Parameters.AddWithValue("@selectedStudentID", id);
            cmd.Parameters.AddWithValue("@img", img);

            SqlDataAdapter daPhoto = new SqlDataAdapter(cmd);
            DataSet result = new DataSet();

            conn.Open();
            //img = cmd.ExecuteScalar().ToString();
            daPhoto.Fill(result, "StudentPhoto");
            conn.Close();

            DataTable table = result.Tables["StudentPhoto"];
            if (!DBNull.Value.Equals(table.Rows[0]["Photo"]))
                img = (table.Rows[0]["Photo"].ToString());

            imgPhoto.ImageUrl = "~/Images/" + img;
            Label1.Text = img;

        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            if (upPhoto.HasFile == true)
            {
                string fileExt = Path.GetExtension(upPhoto.FileName);
                string id = ddlName.SelectedValue;
                string savePath;
                string uploadedFile;


                uploadedFile = id + fileExt;
                savePath = MapPath("~/Images/" + uploadedFile);

                string strConn = ConfigurationManager.ConnectionStrings
                            ["ABCPolyTech"].ToString();

                SqlConnection conn = new SqlConnection(strConn);

                SqlCommand cmd = new SqlCommand
                    ("UPDATE Student SET Photo=@img WHERE StudentID = @selectedStudentID", conn);

                cmd.Parameters.AddWithValue("@img", uploadedFile);
                cmd.Parameters.AddWithValue("@selectedStudentID", id);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                lblMsg.Text = "Image successfully Uploaded";
                lblMsg.ForeColor = System.Drawing.Color.ForestGreen;

                try
                {
                    upPhoto.SaveAs(savePath);
                    imgPhoto.ImageUrl = "~/Images/" + uploadedFile;
                    lblMsg.Text = "File uploaded successfully!";
                }

                catch (IOException)
                {
                    lblMsg.Text = "File upload failed!";
                }

                catch (Exception ex)
                {
                    lblMsg.Text = ex.Message;
                }


            }

            else
            {
                lblMsg.Text = "Please upload an Image!";
                lblMsg.ForeColor = System.Drawing.Color.Red;
            }
        }


        private void displayStudentList()
        {
            string strConn = ConfigurationManager.ConnectionStrings
                             ["ABCPolyTech"].ToString();

            SqlConnection conn = new SqlConnection(strConn);
            SqlCommand cmd = new SqlCommand
                            ("SELECT * FROM Student ", conn);

            SqlDataAdapter daPhoto = new SqlDataAdapter(cmd);

            DataSet result = new DataSet();

            conn.Open();
            daPhoto.Fill(result, "StudentPhoto");
            conn.Close();

            ddlName.DataSource = result.Tables["StudentPhoto"];

            ddlName.DataTextField = "StudentID";
            ddlName.DataValueField = "StudentID";

            ddlName.DataBind();

            //ddlName.Items.Insert(0, "--Select--");
        }
    }
}

    

