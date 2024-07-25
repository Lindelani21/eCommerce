using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web_G
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["loggedIn"] != null)
            {
                if (Session["UserType"].Equals("Client"))
                {
                    custNav.Visible = true;
                    manNav.Visible = false;
                }
                else if (Session["UserType"].Equals("Admin"))
                {
                    custNav.Visible = false;
                    manNav.Visible = true;
                    cust2Nav.Visible = false;
                }
            }
            else
            {
                custNav.Visible = true;
                manNav.Visible = false;
            }
        }
    }
}