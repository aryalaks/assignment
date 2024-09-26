using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace assignment
{
    public partial class assign2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Panel1.Visible = true;
            Label13.Visible = true;
            Label13.Text = TextBox1.Text;
            Label14.Visible = true;
            Label14.Text = TextBox2.Text;
            Label15.Visible = true;
            Label15.Text = TextBox3.Text;
            Label16.Visible = true;
            Label16.Text = TextBox4.Text;
            Label17.Visible = true;
            Label17.Text = TextBox5.Text;
            Label18.Text = RadioButtonList1.SelectedItem.Text;
            Label19.Text = DropDownList1.SelectedItem.Text;
            string ch = " ";
            for(int i=0;i<CheckBoxList1.Items.Count;i++)
            {
                if(CheckBoxList1.Items[i].Selected)
                {
                    ch = ch + CheckBoxList1.Items[i].Text + ",";
                }
            }
            Label20.Text = ch;
            
                string p = "~/pic/" + FileUpload1.FileName;
                FileUpload1.SaveAs(MapPath(p));
                Label21.Text = p;
            Label22.Text = TextBox6.Text;
            Label22.Visible = true;
            Label23.Text = TextBox7.Text;
            Label23.Visible = true;
            Label24.Text = TextBox8.Text;
            Label24.Visible = true;
        }
    }
}