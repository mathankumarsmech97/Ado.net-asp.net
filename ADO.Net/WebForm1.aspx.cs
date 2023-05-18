using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data.SqlClient;
using System.Web.UI.WebControls;
using System.Drawing;
using System.Configuration;

namespace ADO.Net
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["DBMS"].ConnectionString;

            using (SqlConnection con = new SqlConnection(cs))
            {

                SqlCommand command = new SqlCommand("SELECT * FROM [dbo].[CustomerAddress]", con);
                con.Open();
                SqlDataReader readerreader = command.ExecuteReader();
                GridView1.DataSource = readerreader;
                GridView1.DataBind();
                con.Close();
            }





        }
    }
}