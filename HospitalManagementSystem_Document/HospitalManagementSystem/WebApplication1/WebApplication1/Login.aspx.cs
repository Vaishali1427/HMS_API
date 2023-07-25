using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogic;
using BusinessObject;

namespace WebApplication1
{
    public partial class Login : System.Web.UI.Page
    {
        LogIn_BEL belUlogin = new LogIn_BEL();
        LogIn_BLL bllUlogin = new LogIn_BLL();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_UserLogIn_Click(object sender, EventArgs e)
        {

            belUlogin.Userid = Txt_Userid.Text.Trim();
            belUlogin.Password = Txt_Password.Text.Trim();
            try
            {

                int result = bllUlogin.LogIn(belUlogin);

                if (result == 1)
                {
                    HttpCookie cook = new HttpCookie("Login");
                    cook["userid"] = Txt_Userid.Text;
                    cook["password"] = Txt_Password.Text;
                    cook.Expires = DateTime.Now.AddMinutes(1);
                    Response.Cookies.Add(cook);
                    Response.Redirect("Home.aspx");
                }
                else
                {
                    ClientScript.RegisterStartupScript(Page.GetType(), "Message", "alert('Login Failed. Please check Username / Password')", true);

                }



            }
            catch (Exception ex)
            {

                Response.Write("Oops! error occured :" +
                ex.Message.ToString());
            }
            belUlogin = null;
            bllUlogin = null;

        }

        
    }
}