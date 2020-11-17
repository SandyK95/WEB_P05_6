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
    public partial class AdminApproveView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                displayApproveViewList();
            }

        }

        private void displayApproveViewList()
        {
            string strConn = ConfigurationManager.ConnectionStrings
                             ["ABCPolyTech"].ToString();

            SqlConnection conn = new SqlConnection(strConn);
            SqlCommand cmd = new SqlCommand("SELECT * FROM ViewingRequest WHERE Status = 'P' ORDER BY ViewingRequestID ",
                                            conn);

            SqlDataAdapter daViewingReq = new SqlDataAdapter(cmd);


            //Create a DataSet object to contain the records retrieved from database
            DataSet result = new DataSet();

            //A connection must be opened before any operations made.
            conn.Open();

            //Use DataAdapter to fetch data to a table "StaffDetails" in DataSet. 
            //DataSet "result" will store the result of the SELECT operation.
            daViewingReq.Fill(result, "ApproveViewDetails");

            //A connection should always be closed, whether error occurs or not.
            conn.Close();

            //Specify GridView to get data from table "Staff Details"
            //in DataSet "result"
            gvViewingRequest.DataSource = result.Tables["ApproveViewDetails"];

            //Display the list of data in GridView
            gvViewingRequest.DataBind();

            int count = 0;
            if (result.Tables["ApproveViewDetails"].Rows.Count > 0)
            {
                count = result.Tables["ApproveViewDetails"].Rows.Count;
                lblCount.Text =" " + count + " entries";
            }

            else
            {
                lblCount.Text = "  No Viewing Records Found!";
                lblCount.ForeColor = System.Drawing.Color.Red;
            }

        }

        protected void gvStaff_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            //Set the page index to the page clicked by user. 
            gvViewingRequest.PageIndex = e.NewPageIndex;
            //Display records on the new page.
            displayApproveViewList();
        }

    }
}