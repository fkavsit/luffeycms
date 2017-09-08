<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Products.ascx.cs" Inherits="Themes_default_UCs_Products_Products" %>

<asp:Repeater ID="rptr_products" runat="server">
    <HeaderTemplate>
        <div class="row">
    </HeaderTemplate>
    <ItemTemplate>
        <div class="col-md-4">
            <a href="#">
            <%#Eval("Title") %>
            <%#ProductPrice((int)Eval("ID")) %>

            </a>
            <br />
        </div>
    </ItemTemplate>
    <FooterTemplate>
        </div>
    </FooterTemplate>

</asp:Repeater>
