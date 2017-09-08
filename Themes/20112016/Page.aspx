<%@ Page Title="" Language="C#" MasterPageFile="~/Themes/20112016/Master.master" AutoEventWireup="true" CodeFile="Page.aspx.cs" Inherits="Theme_Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cph_Content" Runat="Server">
    <asp:Repeater ID="rptr_page" runat="server">

        <HeaderTemplate>

        </HeaderTemplate>
        <ItemTemplate>
             <%#Eval("Title") %>
            <%#Eval("Content") %>
        </ItemTemplate>
        <FooterTemplate>

        </FooterTemplate>
    </asp:Repeater>
</asp:Content>

