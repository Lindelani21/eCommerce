using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using web_G.ServiceReference1;

namespace web_G
{
    public partial class index : System.Web.UI.Page
    {
        Service1Client client = new Service1Client();

       
        protected void Page_Load(object sender, EventArgs e)
        {
            dynamic product = client.getAllProducts();
            String html = "";
            String display = "";

            

            foreach (Product p in product)
            {
                html += "<div class='col-lg-3'>";
                html += "<div class='categories__item set-bg'data-setbg= "+p.ProImage+">";
                html += "<h5><a href='shop-details.aspx?pID="+p.ProId+"'>"+ p.ProName+"</a></h5>";
                html += "</div>";
                html += "</div>";
               // Session["pID"] = p.ProId;
            }
            category.InnerHtml = html;

            foreach (Product p in product)
            {
                display += "<div class='col-lg-3 col-md-4 col-sm-6 mix fastfood vegetables'>";
                display += "<div class='featured__item'>";
                display += "<div class= 'featured__item__pic set-bg' data-setbg="+p.ProImage+">";
                display += "</div>";
                display += "<div class='featured__item__text'>"; 
                display += "<h6><a href ='shop-details.aspx?pID="+p.ProId+"'>" + p.ProName +"</a></h6>"; 
                display += "<h5>" + 'R' + p.ProPrice+"</h5>" ;
                display += "</div>";
                display += "</div>";
                display += "</div>";
               // Session["pID"] = p.ProId;
            }
            featured.InnerHtml = display;



        }
}
}