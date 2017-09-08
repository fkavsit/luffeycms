<%@ Page Title="" Language="C#" MasterPageFile="~/Panel/PanelMaster.master" AutoEventWireup="true" CodeFile="catagorys.aspx.cs" Inherits="Panel_catagorys" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphPanelContent" runat="Server">

    <asp:Repeater ID="membersgrid" runat="server">
        <HeaderTemplate>
            <table class="table table-hover">
                <tr>
                    <th></th>
                    <th>#</th>
                    <th>Kategori Adı</th>
                    <th>Sil</th>

                </tr>
        </HeaderTemplate>
        <ItemTemplate>
            <tr>
                <td>
                    <asp:CheckBox Text="" ID="chck" runat="server" /></td>
                <td><%#Eval("ID") %>
               
                </td>
                <td><%#Eval("Title") %>
                    <br />
                    <a href="subcatagoryAdd.aspx?ID=<%#Eval("ID") %>"></td>

                <td>
                    <a href="?q=<%#Eval("ID") %>">
                        <img src="../Images/Panel/delete.png" width="30" height="30" alt="" />
                    </a>
                </td>

            </tr>
        </ItemTemplate>
        <FooterTemplate>
            </table>
            
        </FooterTemplate>

    </asp:Repeater>
    <asp:Button Text="Sil" ID="btnSil" OnClick="btnSil_Click" runat="server" />
</asp:Content>

