﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="web_G.login" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Login Page</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f2f2f2;
        }

        .container {
            width: 100%; max-width: 400px;
            margin: 0 auto; padding: 20px;
            background-color: #ffffff;
            border-radius: 5px; text-align: center;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.2);
            position: relative; top: 50px;
        }

        .container img {
            width: 100px; height: 100px;
            margin-bottom: 20px;
        }

        .container input[type="text"],
        .container input[type="password"] {
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

        .signup-link {
            text-align: center; margin-top: 10px;
        }
    </style>
</head>
<body>
    <div class="container">
        <img src="img/logo.png" alt="Logo">
         <h1>Login</h1>
        <form action="login.aspx" method="post" runat="server" id="formId" >
            <input type="text" name="username" placeholder="Username" required id="name" runat="server">
            <input type="password" name="password" placeholder="Password" required id="password" runat="server">
            <div class="signup-link">
            <asp:Button runat="server" ID="btnLogin"  OnClick="btnLogin_Clicked" text="Login" ></asp:Button>
            <p>Not registered yet? <a href="register.aspx">Sign up here</a></p> 
            <p> <a href="forgot.aspx">Forgot Password?</a></p>
        </div>
        </form>     
    </div>
</body>
</html>
