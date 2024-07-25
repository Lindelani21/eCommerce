using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using web_G.ServiceReference1;

namespace web_G
{
    public partial class shopping_cart : System.Web.UI.Page
    {
        Service1Client service = new Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserID"] != null)
            {
                int U_ID = (int)Session["UserID"];
                string load = "";
                dynamic cartItems = service.listCartItemProducts(U_ID);
                //int cartId = -1;

                foreach (CartItem item in cartItems)
                {

                    //cartId = item.ItemId;
                    //product info

                    var prodImage = service.GetImage(item.ProId);
                    var product = service.GetProductWithId(item.ProId);

                    load += "<table>";
                    load += "<thead>";
                    load += "<tr><th class='shoping__product'>Products</th>";
                    load += "<th>Price</th><th>Quantity</th><th></th></tr>";
                    load += "</thead><tbody>";
                    load += "<tr><td class='shoping__cart__item'>";
                    load += "<img src='"+ prodImage.ProImage+"' alt=''>";
                    load += "<h5>"+product.ProName+"</h5>";
                    load += "</td><td class='shoping__cart__price'>"+product.ProPrice+"</td>";
                    load += "<td class='shoping__cart__price'>" + item.Quantity + "</td>";
                    load += "</td></tr></tbody></table>";

                }


                //total area

                int total = service.getCartTotal(U_ID);
                //calculate total with tax
                double diff = total * (15 / 100);
                double finalTotal = total + diff;

                string load2 = "";

                load2 += "<h5>Cart Total</h5>";
                load2 += "<ul>";
                load2 += "<li>Subtotal<span>"+total+"</span></li>";
                load2 += "<li>Total<span>" + finalTotal + "</span></li>";
                load2 += "</ul><ahref='checkout.aspx' class='primary-btn'>PROCEED TO CHECKOUT</a>";                                     

                shoppingCart.InnerHtml = load;
                totalP.InnerHtml = load2;

            }
        }
    }
}