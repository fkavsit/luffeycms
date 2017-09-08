<%@ Control Language="C#" AutoEventWireup="true" CodeFile="NewsCategory.ascx.cs" Inherits="Theme_UCs_NewsCategory" %>

<asp:Repeater ID="rptr_newCategorys" runat="server">
    <HeaderTemplate>
        <h3>Haber Kategorileri</h3>
        <ul>
    </HeaderTemplate>
    <ItemTemplate>
        <li>
           <a href="<%# WriteUrl(Eval("ID").ToString(),Eval("Title").ToString()) %>"><%#Eval("Title") %> </a>

        </li>

    </ItemTemplate>
    <FooterTemplate>
        </ul>
    </FooterTemplate>

</asp:Repeater>
