<%@ Control Language="C#" AutoEventWireup="true" CodeFile="New_Detail.ascx.cs" Inherits="Theme_UCs_News_Detail" %>

<asp:Repeater ID="rptr_new_detail" runat="server">
    <HeaderTemplate>
       
    </HeaderTemplate>
    <ItemTemplate>
  <!-- Haber Başlığımm -->
        <%#Eval("Title") %>
         <!-- Haber İçerik -->
        <%#Eval("Content") %>
         <!-- Haber Tarihi -->
        <%#Eval("Date") %>
        <!-- Haber Kategori -->
        <%#Eval("CategoryID") %>
        <!-- Haber Resmi -->
		<img src="/Images/newsImage/<%#Eval("Image") %>"/>
		
        
        <!-- Haber Kısa Özeti -->
        <%#Eval("Summary") %>
    </ItemTemplate>
    <FooterTemplate>

    </FooterTemplate>
</asp:Repeater>
