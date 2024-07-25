using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using web_G.ServiceReference1;

namespace web_G
{
    public partial class shop_details : System.Web.UI.Page
    {
        Service1Client client = new Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {
            getProduct();
        }

        public void getProduct()
        {
           
           string ProdIDD =  Request.QueryString["pID"];
            int IDD = int.Parse(ProdIDD);

            //int ProdID = int.Parse(ProdIDD);
            Session["ProductIDI"] = IDD;

            //string ProdIddd = Session["ProductIDI"].ToString();

            //var ProxP = client.GetProductWithId(int.Parse(ProdIddd));
            // var Proimg = client.GetImage(int.Parse(ProdIddd));

            var ProxP = client.GetProductWithId(int.Parse(ProdIDD));
            var rev = client.getReview(int.Parse(ProdIDD));
            var Proimg = client.GetImage(int.Parse(ProdIDD));

            itemImg.InnerHtml = "<img class='product__details__pic__item--large' src='"+Proimg.ProImage+"' alt=''>";  
            itemPrice.InnerHtml = "R" +ProxP.ProPrice;
            itemDescription.InnerHtml = ProxP.ProDescription;
            itemName.InnerHtml = ProxP.ProName;

            review.InnerHtml = rev.review1;

        }

        protected void AddCart(object sender, EventArgs e)
        {
            string ProxyIDD = Session["UserID"].ToString();
            //string ProdID = Session["ProductIDI"].ToString();

            //string ProdID =  Request.QueryString["pID"];
            string ProdID = Session["ProductIDI"].ToString();

            client.addToCart(int.Parse(ProdID), int.Parse(ProxyIDD), int.Parse(prodvalue.Value));


            //var StS = client.addToCart(int.Parse(ProdID),int.Parse(ProxyIDD), int.Parse(prodvalue.Value));


            //if (StS==true)
            //{
            //    Response.Redirect("shopping-cart.aspx");
            //}
            //else
            //{
            //    Response.Redirect("shop-details.aspx");
            //}

        }
    }
}