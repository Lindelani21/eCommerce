<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AddProducts.aspx.cs" Inherits="web_G.AddProducts" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <style>
        .container{
          align-items: center;
          padding: 7px;
      }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br /><br />

    <form runat="server">
    <div class="container">
            <div class="item">
                <input type="text" runat="server" id="name" placeholder="Enter name" size="90" />
            </div>
            <div class="item">
                <input type="text" runat="server" id="price" placeholder="Price" size="90"/>
            </div>
            <div class="item">
                <input type="text" runat="server" id="description" placeholder="Description" size="90"/>
            </div>
            <div class="item">
                <input type="text" runat="server" id="category" placeholder="Category" size="90" />
            </div>
            <div class="item">
                <input type="text" runat="server" id="image" placeholder="Image" size="90" />
            </div>
                <div class="item">
            <asp:Button runat="server" ID="addBtn" Text="Add Item" OnClick="addBtn_Click" />
        </div>
        </div>
        </form>

    <br /><br />
</asp:Content>
