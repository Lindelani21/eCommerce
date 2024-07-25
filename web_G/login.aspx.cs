using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using web_G.ServiceReference1;

namespace web_G
{
    public partial class login : System.Web.UI.Page
    {
        Service1Client client = new Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Clicked(object sender, EventArgs e)
        {
            var log = client.Login(name.Value, Secrecy.HashPassword(password.Value));

            if(log == true)
            {
                Session["loggedIn"] = log;
                var user = client.getUser(name.Value);
                Session["UserType"] = user.UserType;
                Session["UserID"] = user.UserId;
                Response.Redirect("index.aspx");
            }
            
            
          
            
        }
    }
}