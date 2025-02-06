using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Chapter7SQLAB1
{
    public partial class StudentNew : System.Web.UI.Page
    {

        static String connString = ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;

        static SqlConnection myConn = new SqlConnection(connString);

        static System.Data.SqlClient.SqlCommand cmdstring = new System.Data.SqlClient.SqlCommand();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                myConn.Open();
                cmdstring.Parameters.Clear();
                cmdstring.Connection = myConn;
                cmdstring.CommandType = CommandType.StoredProcedure;
                cmdstring.CommandTimeout = 1500;
                cmdstring.CommandText = "STUDENTNEW";

                if (string.IsNullOrWhiteSpace(txtSTUDENTID.Text))
                {
                    Response.Write("<script>alert('Invalid Student ID!');</script>");
                    return;
                }
                cmdstring.Parameters.AddWithValue("@STUDENT_ID", txtSTUDENTID.Text.Trim());

                if (string.IsNullOrWhiteSpace(txtFNAME.Text))
                {
                    Response.Write("<script>alert('Invalid First Name!');</script>");
                    return;
                }
                cmdstring.Parameters.AddWithValue("@FNAME", txtFNAME.Text.Trim());

                if (string.IsNullOrWhiteSpace(txtLNAME.Text))
                {
                    Response.Write("<script>alert('Invalid Last Name!');</script>");
                    return;
                }
                cmdstring.Parameters.AddWithValue("@LNAME", txtLNAME.Text.Trim());

                if (!DateTime.TryParse(txtddob.Text, out DateTime dob))
                {
                    Response.Write("<script>alert('Invalid Date of Birth!');</script>");
                    return;
                }
                cmdstring.Parameters.AddWithValue("@DOB", dob);

                if (string.IsNullOrWhiteSpace(txtGender.Text))
                {
                    Response.Write("<script>alert('Invalid Gender!');</script>");
                    return;
                }
                cmdstring.Parameters.AddWithValue("@GENDER", txtGender.Text.Trim());

                if (!decimal.TryParse(txtAcc.Text, out decimal accountBalance))
                {
                    Response.Write("<script>alert('Invalid Account Balance!');</script>");
                    return;
                }
                cmdstring.Parameters.AddWithValue("@ACCT_BAL", accountBalance);

                if (string.IsNullOrWhiteSpace(txtMajor.Text))
                {
                    Response.Write("<script>alert('Invalid Major!');</script>");
                    return;
                }
                cmdstring.Parameters.AddWithValue("@MAJOR", txtMajor.Text.Trim());

                if (string.IsNullOrWhiteSpace(txtHome_Phone.Text))
                {
                    Response.Write("<script>alert('Invalid Home Phone!');</script>");
                    return;
                }
                cmdstring.Parameters.AddWithValue("@HOME_PHONE", txtHome_Phone.Text.Trim());

                if (string.IsNullOrWhiteSpace(txtCell_Phone.Text))
                {
                    Response.Write("<script>alert('Invalid Cell Phone!');</script>");
                    return;
                }
                cmdstring.Parameters.AddWithValue("@CELL_PHONE", txtCell_Phone.Text.Trim());

                if (string.IsNullOrWhiteSpace(txtWork_Phone.Text))
                {
                    Response.Write("<script>alert('Invalid Work Phone!');</script>");
                    return;
                }
                cmdstring.Parameters.AddWithValue("@WORK_PHONE", txtWork_Phone.Text.Trim());

                if (string.IsNullOrWhiteSpace(txtAddress.Text))
                {
                    Response.Write("<script>alert('Invalid Address!');</script>");
                    return;
                }
                cmdstring.Parameters.AddWithValue("@ADDRESS_ONE", txtAddress.Text.Trim());

                if (string.IsNullOrWhiteSpace(txtCity.Text))
                {
                    Response.Write("<script>alert('Invalid City!');</script>");
                    return;
                }
                cmdstring.Parameters.AddWithValue("@CITY", txtCity.Text.Trim());

                if (string.IsNullOrWhiteSpace(txtState.Text) || txtState.Text.Length != 2)
                {
                    Response.Write("<script>alert('Invalid State! Must be 2 characters.');</script>");
                    return;
                }
                cmdstring.Parameters.AddWithValue("@STU_STATE", txtState.Text.Trim());

                if (string.IsNullOrWhiteSpace(txtZip.Text) || txtZip.Text.Length != 5)
                {
                    Response.Write("<script>alert('Invalid ZIP! Must be 5 digits.');</script>");
                    return;
                }
                cmdstring.Parameters.AddWithValue("@ZIP", txtZip.Text.Trim());

                if (!decimal.TryParse(txtTotalCredits.Text, out decimal totalCredits))
                {
                    Response.Write("<script>alert('Invalid Total Credits!');</script>");
                    return;
                }
                cmdstring.Parameters.AddWithValue("@TOTALCREDITS", totalCredits);

                SqlParameter returnValue = new SqlParameter("@ReturnValue", SqlDbType.Int);
                returnValue.Direction = ParameterDirection.ReturnValue;
                cmdstring.Parameters.Add(returnValue);

                cmdstring.ExecuteNonQuery();
                int result = (int)returnValue.Value;

                if (result > -1)
                {
                    Response.Write("<script>alert('Record added successfully!');</script>");
                }
                else
                {
                    Response.Write($"<script>alert('Error: Record not added! SQL Return Value: {result}');</script>");
                }

            }
            catch (Exception ex)
            {
                Response.Write($"<script>alert('SQL Error: {ex.Message}');</script>");
            }

            finally
            {
                myConn.Close();
            }
        }


        protected void btnClose_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
    }
}