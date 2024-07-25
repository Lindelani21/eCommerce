using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using web_G.ServiceReference1;

namespace web_G
{
    public partial class AddProducts : System.Web.UI.Page
    {
        Service1Client client = new Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void addBtn_Click(object sender, EventArgs e)
        {
            var item = client.AddProduct(name.Value, description.Value, category.Value, int.Parse(price.Value), image.Value);
        }
    }
}