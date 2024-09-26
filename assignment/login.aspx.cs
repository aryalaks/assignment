using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace assignment
{
    public partial class login : System.Web.UI.Page
    {
        SqlConnection con=new SqlConnection(@"server=ARYA\SQLEXPRESS;database=juneb1;Integrated security=true");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string s = "select count(id) from user_registration where username='" + TextBox1.Text + "'and Password='" + TextBox2.Text + "'";
            SqlCommand cmd = new SqlCommand(s, con);
            con.Open();
            string cid = cmd.ExecuteScalar().ToString();
            con.Close();
            if(cid == "1")
            {
                string sid="select id from user_registration where username = '" + TextBox1.Text + "'and Password = '" + TextBox2.Text + "'";
                SqlCommand cmd1 = new SqlCommand(sid, con);
                con.Open();
                string id = cmd1.ExecuteScalar().ToString();
                con.Close();
                Session["uid"] = id;
                Response.Redirect("userprofile.aspx");
            }
            else
            {
                Label1.Text = "Invalid username and password";
            }
        }
    }
}