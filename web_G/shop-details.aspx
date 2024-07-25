<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="shop-details.aspx.cs" Inherits="web_G.shop_details" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <!-- Breadcrumb Section Begin -->
    <section class="breadcrumb-section set-bg" data-setbg="img/breadcrumb.jpg">
        <div class="container">
            <div class="row">
                <div class="col-lg-12 text-center">
                    <div class="breadcrumb__text">
                        <h2>Vegetable’s Package</h2>
                        <div class="breadcrumb__option">
                            <a href="./index.aspx">Home</a>
                            <span>Vegetable’s Package</span>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- Breadcrumb Section End -->

    <!-- Product Details Section Begin -->
    <section class="product-details spad" runat="server" >
        <div class="container">
            <div class="row">
                <div class="col-lg-6 col-md-6">
                    <div class="product__details__pic">
                        <div class="product__details__pic__item" runat="server" id="itemImg">
                            <%--<img class="product__details__pic__item--large" src="img/product/details/product-details-1.jpg" alt="">--%>
                        </div>
                    </div>
                </div>
                <div class="col-lg-6 col-md-6" runat="server" >
                    <div class="product__details__text">
                        <h3 runat="server" id="itemName">Vetgetable’s Package</h3>
                        <div class="product__details__price" runat="server" id="itemPrice">$50.00</div>
                        <p runat="server" id="itemDescription">Mauris blandit aliquet elit, eget tincidunt nibh pulvinar a. Vestibulum ac diam sit amet quam
                            vehicula elementum sed sit amet dui. Sed porttitor lectus nibh. Vestibulum ac diam sit amet
                            quam vehicula elementum sed sit amet dui. Proin eget tortor risus.</p>
                        <div class="product__details__quantity">
                            <div class="quantity">
                                <div class="pro-qty">
                                    <input type="text" value="1" runat="server" id="prodvalue">
                                </div>
                            </div>
                        </div>
                        <form runat="server">
                            <a href="#" class="primary-btn" runat="server" ><asp:Button ID="Button1" runat="server" Text="Add To Cart" OnClick="AddCart"/></a>
                             <a href="#" class="heart-icon"><span class="icon_heart_alt"></span></a> 
                        </form>
                       
                    </div>
                </div>
                <div class="col-lg-12">
                    <div class="product__details__tab">
                        <ul class="nav nav-tabs" role="tablist">
                            <li class="nav-item">
                                <a class="nav-link" data-toggle="tab" href="#tabs-3" role="tab" aria-selected="false">Reviews</a>
                            </li>
                        </ul>
                    </div>
                </div>
                <div class="tab-pane" id="tabs-3" role="tabpanel">
                    <div class="product__details__tab__desc">
                        <p id="review" runat="server"> </p>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- Product Details Section End -->

</asp:Content>
