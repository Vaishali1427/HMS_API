using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication9
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Logout_btn_Click(object sender, EventArgs e)
        {

                Session.Remove("Id");
                Session.RemoveAll();
                Response.Redirect("Login.aspx");
            
        }
    }
}