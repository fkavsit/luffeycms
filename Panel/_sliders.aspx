<%@ Page Title="" Language="C#" MasterPageFile="~/Panel/PanelMaster.master" AutoEventWireup="true" CodeFile="_sliders.aspx.cs" Inherits="Panel_sliders" %>

<asp:Content ID="Content2" ContentPlaceHolderID="cph_head" runat="Server">
    <!--Head Etiketi İçin Extra Link Ekle-->
    <link href="../Styles/set2.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="cphPanelContent" runat="Server">
    <div class="row">
        <div class="col-md-11">&nbsp;</div>
        <div class="col-md-1">
            <a href="sliderAdd.aspx" class="btn btn-default">
                <i class="fa fa-plus" aria-hidden="true"></i>
            </a>

        </div>
    </div>
    <asp:Repeater ID="slidersgrid" runat="server">
        <HeaderTemplate>
            <table class="table table-hover">
                <tr>
                    <th>Resim</th>

                    <th>Slider İçerik</th>
                    <th>Sil</th>
                </tr>
        </HeaderTemplate>
        <ItemTemplate>

            <tr>
                <td>
                    <img src="../Images/slider/<%#Eval("Image")%>" alt="" height="100" width="130" class="img-thumbnail" />
                </td>

                <td><%#Eval("Text") %>
                
                </td>
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
</asp:Content>

