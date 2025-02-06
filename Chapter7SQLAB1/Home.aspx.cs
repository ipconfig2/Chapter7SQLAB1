using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Chapter7SQLAB1
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindData();
            }
        }



        public void BindData()
        {
            StudentDataTier aDataTier = new StudentDataTier();

            string myID = Convert.ToString(Session["vStudentID"]);
            string fname = Convert.ToString(Session["vFName"]);
            string lname = Convert.ToString(Session["vLName"]);


            txtStudentID.Text = myID;
            txtFName.Text = fname;
            txtLName.Text = lname;

            if (myID.Length > 0 || fname.Length > 0 || lname.Length > 0)
            {
                DataSet aDataSet = new DataSet();

                aDataSet = aDataTier.GetStudents(myID, fname, lname);
                grdStudent.DataSource = aDataSet.Tables[0];
                if (Cache["StudentData"] == null)
                {
                    Cache.Add("StudentData", new DataView(aDataSet.Tables[0]), null, System.Web.Caching.Cache.NoAbsoluteExpiration, System.TimeSpan.FromMinutes(10),
                    System.Web.Caching.CacheItemPriority.Default, null);

                    grdStudent.Visible = true;
                    grdStudent.DataBind();
                }
            }
        }

        public void Delete_Click(Object sender, CommandEventArgs e)
        {

           // try
          //  {

           // }

        }


        public void Edit_Click(Object sender, CommandEventArgs e)
        {

           // try
           // {

            //}

        }


        public void lbtnEdit_Click(Object sender, CommandEventArgs e)
        {
            string recordToBeEdited;
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
           // try
           // {

            //}

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {


            if((txtStudentID.Text.Trim() != null) || (txtFName.Text.Trim() != null) || (txtLName.Text.Trim() != null))
            {
                try
                {
                    Session["vStudentID"] = txtStudentID.Text.Trim();
                    Session["vFName"] = txtFName.Text.Trim();
                    Session["vLName"] = txtLName.Text.Trim();

                    Cache.Remove("StudentData");
                    BindData();

                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message, ex.InnerException);
                }
            }

        }

        protected void grdStudent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void grdStudent_RowDataBound(object sender, GridViewRowEventArgs e)
        {

            if (e.Row.RowType == DataControlRowType.Header)
            {
                ((CheckBox)e.Row.FindControl("cbSelectAll")).Attributes.Add("onclick", "javascript.SelectAll('" + ((CheckBox)e.Row.FindControl("cbSelectAll")).ClientID + "')");
            }


        }


    }
}