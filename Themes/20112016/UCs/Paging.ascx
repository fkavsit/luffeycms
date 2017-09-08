<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Paging.ascx.cs" Inherits="Theme_UCs_Paging" %>

<asp:Repeater ID="rptr_paging" runat="server">
    <HeaderTemplate>
    </HeaderTemplate>
    <ItemTemplate>
        <div style="border: 1px solid #000; margin: 5px; padding: 10px; background-color: #fff">
            <!-- Haber Başlığı -->
            <div style="width: 350px; float: left">
                <img src="../Images/newsImage/<%#Eval("Image") %>" height="250" width="250" />
            </div>
            <div style="width: 700px; float: left">
                <strong><%#Eval("Title") %> </strong>/ <%#Eval("Date") %><br>
                <%#Eval("Summary") %>
                <br>

                <span style="padding: 4px; border: 1px solid #000; margin: 5px"><%#Eval("CategoryID") %></span>

                <br>
                <a href="<%# WriteUrl(Eval("ID").ToString(),Eval("Title").ToString()) %>">Haberi OKU </a>
            </div>
            <div style="clear: both"></div>





            <!-- Haber Resmi -->

            <!-- Haber Kısa Özeti -->

            <%--<a href="NewDetail.aspx?NewID=<%#Eval("ID")%>"> Haberi OKU </a>--%>
        </div>
    </ItemTemplate>
    <FooterTemplate>
    </FooterTemplate>

</asp:Repeater>
<div id="paging" runat="server">
</div>
<%--<asp:HyperLink ID="linkPrev" runat="server">Önceki</asp:HyperLink>
<asp:HyperLink ID="linkNext" runat="server">Sonraki</asp:HyperLink>
<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>--%>