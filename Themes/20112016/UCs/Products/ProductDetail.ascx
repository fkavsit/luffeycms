<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ProductDetail.ascx.cs" Inherits="Themes_default_UCs_Products_ProductDetail" %>
<asp:Repeater ID="rptr_produtdetail" runat="server">
    <ItemTemplate> 
        <%#Eval("Title") %>
    </ItemTemplate>
</asp:Repeater>
