using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace assignment
{
    public partial class assgn1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Panel1.Visible = true;
            Label14.Text = TextBox10.Text;
            Label15.Text = TextBox11.Text;
            Label16.Text = TextBox12.Text;
            Label17.Text = TextBox13.Text;
            Label18.Text = TextBox14.Text;
            Label19.Text = RadioButtonList2.SelectedItem.Text;
            string p = "~/photo/" + FileUpload2.FileName;
            FileUpload2.SaveAs(MapPath(p));
            Label22.Text = p;
            Label23.Text = TextBox15.Text;
            Label24.Text = TextBox16.Text;
            Label25.Text = TextBox17.Text;
            Label26.Visible = true;
            Label26.Text = Button2.Text;
        }
    }
}