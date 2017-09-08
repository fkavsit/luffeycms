<%@ Page Title="" Language="C#" MasterPageFile="~/Panel/PanelMaster.master" AutoEventWireup="true" CodeFile="Pages.aspx.cs" Inherits="Panel_Page_Pages" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphPanelContent" runat="Server">
    <div class="row" style="padding-bottom: 15px;">
        <div class="col-md-11">
            <asp:TextBox ID="txtSearch" PlaceHolder="Ara..." CssClass="form-control" runat="server"></asp:TextBox>
        </div>
        <div class="col-md-1">
            <asp:Button ID="btn_search" Style="width: 145%; border-radius: 0px !important; margin-left: -25px" CssClass="btn btn-primary" runat="server" Text="Ara" OnClick="btn_search_Click" />
        </div>

    </div>


    <asp:Repeater ID="rptr_pages" runat="server">
        <HeaderTemplate>

            <table class="table table-hover">
                <tr>
                    <th>Sayfa Başlık</th>

                    <th>URL</th>

                </tr>
        </HeaderTemplate>
        <ItemTemplate>
            <tr>
                <td><%#Eval("Title") %></td>

                <td>
                    <input style="width: 90%" id="text2" value="<%Response.Write(Request.Url.Authority);%>/Page/<%#UrlSeo(Eval("Title").ToString()) %>-<%#Eval("ID") %>" type="text" />

                </td>
                <td><a href="?del=<%#Eval("ID") %>">
                    <img src="../Images/Panel/delete.png" width="30" height="30" alt="" />
                </a></td>
            </tr>
        </ItemTemplate>
        <FooterTemplate>
            </table>
        </FooterTemplate>

    </asp:Repeater>
</asp:Content>

