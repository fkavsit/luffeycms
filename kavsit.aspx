<%@ Page Language="C#" AutoEventWireup="true" CodeFile="kavsit.aspx.cs" Inherits="kavsit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>Giriş</title>
    <link href="../Styles/bootstrap.min.css" rel="stylesheet" />
    <style> 
        .login-form{ width:260px;margin:150px auto 20px;}
        .logo{margin:1px 21% 20px;}
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="row">
                <div class="login-form">
                    <img src="/Items/Logo/logo.png" class="logo" width="150" height="150" alt="" />
                    <div class="form-group">
                        <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" placeholder="Eposta"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:TextBox ID="txtsifre" runat="server" CssClass="form-control" placeholder="Şifre" TextMode="Password"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Button ID="btnGir" runat="server" Text="Giriş" CssClass="btn btn-primary btn-block" OnClick="btnGir_Click" />
                    </div>
                    <p>
                        <asp:Label ID="Label1" runat="server" ForeColor="Red"></asp:Label>
                    </p>
                </div>
            </div>
        </div>


    </form>
</body>
</html>


