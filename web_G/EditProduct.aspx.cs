using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using web_G.ServiceReference1;

namespace web_G
{
    public partial class EditProduct : System.Web.UI.Page
    {
        Service1Client client = new Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }

        protected void getInfoBtn_Click(object sender, EventArgs e)
        {
            get();

        }

        public void get()
        {
            var Itemname = client.getProduct(infoId.Value);
            if (IsPostBack)
            {

                if (infoId.Value != null)
                {
                    infoId.Value = name.Value = Itemname.ProName;
                    price.Value = Itemname.ProPrice.ToString();
                    description.Value = Itemname.ProDescription;
                    category.Value = Itemname.ProCategory;
                    image.Value = Itemname.ProImage;
                }
            }
        }

        protected void editBtn_Click(object sender, EventArgs e)
        {
            var editPro = client.editProduct(name.Value, int.Parse(price.Value), description.Value, category.Value, image.Value);
            if(editPro == true)
            {
                Response.Redirect("ManageProduct.aspx");
            }
        }
    }
}