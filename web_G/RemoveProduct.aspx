<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="RemoveProduct.aspx.cs" Inherits="web_G.RemoveProduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <style>
        .remove{
            justify-content: space-evenly;
            display: flex;
            align-content: center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br /><br /><br /><br />
    <form runat="server">
        <div class="remove">
        <div class="item">
            <input type="text" runat="server" id="removeId" placeholder="Enter name of item to remove" size="90" required/>
        </div>
        <div class="item">
            <asp:Button runat="server" ID="removeBtn" Text="Delete Item" OnClick="removeBtn_Click" />
        </div>
            </div>
    </form>
    <br /><br /><br /><br />
</asp:Content>
