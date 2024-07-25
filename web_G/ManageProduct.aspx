<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ManageProduct.aspx.cs" Inherits="web_G.ManageProduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <style>
        .manage{
            display: flex;
            justify-content: space-around;
        }

        .btns{
            background-color:green;
            color:white;
          
        }
    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br /><br /><br /><br />
    <form runat="server">
    <div class="manage">
        <div class="btns">
            <asp:Button runat="server" ID="addButton" text="Add Item" OnClick="addButton_Click" />
        </div>
        <div class="btns">
            <asp:Button runat="server" ID="editButton" text="Edit Item" OnClick="editButton_Click" />
        </div>
        <div class="btns">
            <asp:Button runat="server" ID="removeButton" text="Remove Item" OnClick="removeButton_Click" />
        </div>

    </div>
        </form>
    <br /><br /><br /><br />
</asp:Content>
