using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace session
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["s1"] = TextBox1.Text;
            if(Session["s1"]!=null)
            {
                Label1.Text = "Session has been created ";
                Label2.Text = Session["s1"].ToString();
            }
        }
    }
}