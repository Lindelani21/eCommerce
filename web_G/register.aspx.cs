using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using web_G.ServiceReference1;

namespace web_G
{
    public partial class register : System.Web.UI.Page
    {

        Service1Client client = new Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_clicked(object sender, EventArgs e)
        {
            var reg = client.Registeration(email.Value, name.Value, surname.Value, Secrecy.HashPassword(password.Value), userType.Value);
            if (reg != null)
            {
                Response.Redirect("Login.aspx");
            }
        }
    }
}