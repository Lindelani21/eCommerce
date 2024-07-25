<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="wishlist.aspx.cs" Inherits="web_G.wishlist" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f2f2f2;
            margin: 0; padding: 0;
        }

        .wishlist-container {
            max-width: 800px; margin: 0 auto;
            padding: 20px;
        }

        .wishlist-item {
            display: flex; align-items: center;
            border: 1px solid #ccc; border-radius: 5px;
            margin-bottom: 10px; padding: 10px;
            background-color: #fff;
        }

        .wishlist-item img {
            max-width: 100px; max-height: 100px;
            margin-right: 10px;
        }

        .item-details {
            flex-grow: 1;
        }

        .item-name {
            font-size: 18px; font-weight: bold;
            margin: 0;
        }

        .item-price {
            font-size: 16px; color: #007bff;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <div class="wishlist-container">
        <div class="wishlist-item" runat="server" id="wishlistItem">
            <%--<img src="img/banana.jpg" alt="Item 1">
            <div class="item-details">
                <h2 class="item-name">Item Name 1</h2>
                <p class="item-price">R29.99</p>
            </div>--%>
        </div>
    </div>
</asp:Content>
