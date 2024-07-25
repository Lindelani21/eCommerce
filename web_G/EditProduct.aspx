<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="EditProduct.aspx.cs" Inherits="web_G.EditProduct" %>
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
            <div class="container1">
                <div class="item">
            <input type="text" runat="server" id="infoId" placeholder="Enter name of item to edit" size="90" required/>
        </div>
        <div class="item">
            <asp:Button runat="server" ID="getInfoBtn" Text="Get Info" OnClick="getInfoBtn_Click" />
        </div>
            </div> 
            <div class="container1">
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
            <asp:Button runat="server" ID="editBtn" Text="Save" OnClick="editBtn_Click" />
        </div>
        </div>
            </div>
       
    </form>
    <br /><br />
</asp:Content>
