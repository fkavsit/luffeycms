<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Login.ascx.cs" Inherits="Theme_UCs_Login" %>
<asp:TextBox ID="txtUser" runat="server"></asp:TextBox><br />
<asp:TextBox ID="txtPass" runat="server"></asp:TextBox><br />
<asp:Button ID="login" runat="server" Text="Giriş Yap" OnClick="login_Click" />
<asp:Label ID="error" runat="server" Text=""></asp:Label>