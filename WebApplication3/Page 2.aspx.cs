using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (CheckBox1.Checked == false)
            { CheckBox1.Checked = true; }
            else                          //Extra
            { CheckBox1.Checked = false; }//Extra
            if (CheckBox1.Checked == true)
                Label1.Text = "on";
            if (CheckBox1.Checked == false)
                Label1.Text = "off";
            Button2.Enabled = true;
        }
    }
}