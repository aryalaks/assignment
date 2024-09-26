using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace assignment
{
    public partial class assignment : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"server=ARYA\SQLEXPRESS;database=juneb1;Integrated security=true");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Panel1.Visible = true;
            Label51.Text = TextBox1.Text;
            Label52.Text = TextBox2.Text;
            Label53.Text = TextBox3.Text;
            Label54.Text = TextBox4.Text;
            Label55.Text = TextBox5.Text;
            Label56.Text = RadioButtonList1.SelectedItem.Text;
            Label57.Text = DropDownList1.SelectedItem.Text;
            string ch = " ";                                         
            for (int i = 0; i < CheckBoxList1.Items.Count; i++)
            {
                if (CheckBoxList1.Items[i].Selected)
                {
                    ch = ch + CheckBoxList1.Items[i].Text + ",";
                }
            }
            Label58.Text = ch;
            string p = "~/pic/" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(p));
            Image1.ImageUrl = p;
            Label60.Text = TextBox6.Text;
            Label61.Text = TextBox7.Text;
            Label62.Text = TextBox8.Text;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string p = "~/photo1/" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(p));
            
            string ch = " ";
            for(int i=0;i<CheckBoxList1.Items.Count;i++)
            {
                if(CheckBoxList1.Items[i].Selected)
                {
                    ch = ch + CheckBoxList1.Items[i].Text + ",";
                }
            }
            string s="insert into user_registration values('"+ TextBox1.Text+"',"+TextBox3.Text+",'"+ TextBox2.Text+"',"+TextBox4.Text+",'"+ TextBox5.Text+"','"+ RadioButtonList1.SelectedItem.Text+"','"+ DropDownList1.SelectedItem.Text+ "','" + ch + "','" + p + "','" + TextBox6.Text+"','"+ TextBox7.Text +"')";
            SqlCommand cmd = new SqlCommand(s, con);
            con.Open();
            int i1 = cmd.ExecuteNonQuery();
            con.Close();
            if(i1==1)
            {
                Label63.Text="inserted";
            }

        }

        protected void TextBox6_TextChanged(object sender, EventArgs e)
        {
            string s = "select count(id) from user_registration where username='" + TextBox6.Text + "'";
            SqlCommand cmd1 = new SqlCommand(s, con);
            con.Open();
            string i = cmd1.ExecuteScalar().ToString();
            int j = Convert.ToInt32(i);
            con.Close();
            if (j == 1)
            {
                Label64.Visible = true;
                Label64.Text = "Username already exists";
            }
            else
            {
                Label64.Visible = false;
            }

        }
    }
}