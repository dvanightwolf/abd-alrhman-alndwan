using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
      
    public partial class WebForm1 : System.Web.UI.Page
    { 
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "")
            {
                Label1.Text = "<== Enter your text first";
            }

            if (TextBox1.Text != "")
            {
                TextBox2.Text = TextBox1.Text;
                Label1.Text = "that's it";
            }

            TextBox1.Text = "";
            if(TextBox2.Text  !="")
            Button2.Enabled = true;
        }
    }
}