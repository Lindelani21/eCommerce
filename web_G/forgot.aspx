<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="forgot.aspx.cs" Inherits="web_G.forgot" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Forgot Password</title>
    <style>
       <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f2f2f2;
        }

        .container {
            width: 100%; max-width: 400px;
            margin: 0 auto; padding: 20px;
            background-color: #ffffff;
            border-radius: 5px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.2);
            text-align: center;
            position: relative; top: 50px;
        }

        .container img {
            width: 100px; height: 100px;
            margin-bottom: 20px;
        }

        .container input[type="text"],
        .container input[type="password"],
        .container input[type="email"] {
            width: 100%; padding: 10px;
            margin: 8px 0;
            border: 1px solid #ccc;
            border-radius: 3px;
        }

        .container input[type="submit"] {
            background-color: #007bff;
            color: #fff;  border-radius: 3px;
            border: none; padding: 10px 20px;
            cursor: pointer;
        }

        .container input[type="submit"]:hover {
            background-color: #0056b3;
        }

        .container h1 {
            font-size: 24px; margin-bottom: 20px;
        }
    </style>
</head>
<body>
    <div class="container">
        <img src="assets/img/logo.png" alt="Logo">
        <h1>Update Password</h1>
        <form action="Register.aspx" method="post" runat="server" id="formId">
            <input type="text" name="name" placeholder="Name" required id="name" runat="server">
            <input type="text" name="surname" placeholder="Surname" required id="surname" runat="server">
            <input type="email" name="email" placeholder="Email" required id="email" runat="server">
            <input type="password" name="password" placeholder="Password" required id="password" runat="server">
            <asp:Button runat="server" ID="btnForgot" Text="Register" OnClick="btnForgot_clicked"></asp:Button>
        </form>
    </div>
</body>
</html>
