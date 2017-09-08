<%@ Page Title="" Language="C#" MasterPageFile="~/Panel/PanelMaster.master" AutoEventWireup="true" CodeFile="news.aspx.cs" Inherits="Panel_news" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphPanelContent" runat="Server">
    <asp:Repeater ID="newsgrid" runat="server">
        <HeaderTemplate>
            
            <table class="table table-hover">
                <tr>
                    <th>#</th>
                    <th>Haber Başlığı</th>
                    <th>Tarih(AA/GG/YY)</th>
                    <th>Sil</th>
                                      
                </tr>
        </HeaderTemplate>
        <ItemTemplate>
           
            <tr>
                <td>
                   <%#Eval("ID") %>
                </td>
                <td>
                   <%-- <%#Eval("newsContent").ToString().Substring(0,350) %>...--%>
                    
                    <a href="newsEdit.aspx?edit=<%#Eval("ID") %>"><%#Eval("Title") %></a>
              
                </td>
                <td>
             <%#Eval("Date") %>
                </td>
                 <td>
                    <a href="?del=<%#Eval("ID") %>"> <img src="../Images/Panel/delete.png" width="30" height="30" alt="" /> </a>
                </td>
                
            </tr>
        </ItemTemplate>
        <FooterTemplate>
            </table>
        </FooterTemplate>
    </asp:Repeater>
</asp:Content>

