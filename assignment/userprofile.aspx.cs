using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace assignment
{
    public partial class userprofile : System.Web.UI.Page
    {SqlConnection con=new SqlConnection(@"server=ARYA\SQLEXPRESS;database=juneb1;Integrated security=true");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string s = "select Name,Age,Address,Phone,Photo from user_registration where id=" + Session["uid"] + "";
                SqlCommand cmd = new SqlCommand(s, con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    TextBox1.Text = dr["Name"].ToString();
                    TextBox2.Text = dr["Age"].ToString();
                    TextBox3.Text = dr["Address"].ToString();
                    TextBox4.Text = dr["Phone"].ToString();
                    Image1.ImageUrl = dr["Photo"].ToString();
                }
               
            }
            con.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string s = "update user_registration set Age=" + TextBox2.Text + ",Address='" + TextBox3.Text + "'where id ='" + Session["uid"] + "'";
            SqlCommand cmd = new SqlCommand(s, con);
            con.Open();
            int i1 = cmd.ExecuteNonQuery();
            con.Close();
            if (i1 == 1)
            {
                Label1.Text = "Update";
            }
        }    
    }   
}