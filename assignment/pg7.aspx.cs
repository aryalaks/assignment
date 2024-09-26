using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace assignment
{
    public partial class pg7 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"server=ARYA\SQLEXPRESS;database=juneb1;Integrated security=true");
        protected void Page_Load(object sender, EventArgs e)
        {
            GridBind_Fun();
        }
        public void GridBind_Fun()
        {
            string sel = "select * from user_registration";
            SqlDataAdapter da = new SqlDataAdapter(sel, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }

        protected void LinkButton1_Command(object sender, CommandEventArgs e)//e=2
        {
            int getid = Convert.ToInt32(e.CommandArgument);
            string del = "delete from user_registration where Id=" + getid + "";
            SqlCommand cmd = new SqlCommand(del, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            GridBind_Fun();
        }
    }
}