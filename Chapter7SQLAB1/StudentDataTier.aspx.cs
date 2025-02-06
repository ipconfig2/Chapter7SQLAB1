using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Globalization;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Collections;
using System.Xml.Linq;

namespace Chapter7SQLAB1
{
    public partial class StudentDataTier : System.Web.UI.Page
    {

        static String connString = ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;

        static SqlConnection myConn = new SqlConnection(connString);

        static System.Data.SqlClient.SqlCommand cmdstring = new System.Data.SqlClient.SqlCommand();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
             
            }
        }


        public DataSet GetAllStudents()
        {
            try
            {
                myConn.Open();
                cmdstring.Parameters.Clear();

                cmdstring.Connection = myConn;
                cmdstring.CommandType = CommandType.StoredProcedure;
                cmdstring.CommandTimeout = 1500;
                cmdstring.CommandText = "GetAllStudents";
                SqlDataAdapter aAdapter = new SqlDataAdapter();
                aAdapter.SelectCommand = cmdstring;
                DataSet aDataset = new DataSet();

                aAdapter.Fill(aDataset);
                return aDataset;


            }

            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
            finally
            {
                myConn.Close();
            }
        }

        public DataSet GetStudents(string STUDENT_ID, string fname, string lname)
        {
            try
            {
                myConn.Open();
                cmdstring.Parameters.Clear();

                cmdstring.Connection = myConn;
                cmdstring.CommandType = CommandType.StoredProcedure;
                cmdstring.CommandTimeout = 1500;
                cmdstring.CommandText = "SearchStudent";
                cmdstring.Parameters.Add("@studentid", SqlDbType.VarChar, 6).Value = STUDENT_ID;
                cmdstring.Parameters.Add("@fname", SqlDbType.VarChar, 25).Value = fname;
                cmdstring.Parameters.Add("@lname", SqlDbType.VarChar, 25).Value = lname;
                

                SqlDataAdapter aAdapter = new SqlDataAdapter();
                aAdapter.SelectCommand = cmdstring;
                DataSet aDataset = new DataSet();

                aAdapter.Fill(aDataset);
                return aDataset;


            }

            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
            finally
            {
                myConn.Close();
            }
        }


    }
}