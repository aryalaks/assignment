using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;


namespace assignment
{
    public partial class changepassword : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"server=ARYA\SQLEXPRESS;database=juneb1;Integrated security=true");
        protected void Page_Load(object sender, EventArgs e)
        {

            string s = "select password from user_registration where id=" + Session["uid"] + "";
            SqlCommand cmd = new SqlCommand(s, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                TextBox1.Text = dr["password"].ToString();
            }
            con.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string s="update user_registration set password="+TextBox2.Text+"where id="+Session["uid"]+"";
            SqlCommand cmd = new SqlCommand(s, con);
            con.Open();
            int i1 = cmd.ExecuteNonQuery();
            con.Close();
            if(i1==1)
            {
                Label1.Text = "password changed";
            }

        }
    }
}