<%@ Page Title="" Language="C#" MasterPageFile="~/Panel/PanelMaster.master" AutoEventWireup="true" CodeFile="~/Panel/library.aspx.cs" Inherits="Panel_library" %>


<asp:Content ID="Content1" ContentPlaceHolderID="cphPanelContent" runat="Server">
    <asp:Panel ID="_success" runat="server" Visible="false">
        <div class="alert alert-success" role="alert">Dosya Kütüphaneye Başarılı Bir Şekilde Silindi.</div>
    </asp:Panel>
    <asp:Panel ID="_error" runat="server" Visible="false">
        <div class="alert alert-danger" role="alert">Bir Hata Meydana Geldi.</div>
    </asp:Panel>
    <div class="row">
        <div class="col-md-11">&nbsp;</div>
        <div class="col-md-1">
            <a href="libraryAdd.aspx" class="btn btn-default">
                <i class="fa fa-plus" aria-hidden="true"></i>
            </a>

        </div>
    </div>

  
    <asp:Repeater ID="librarygrid" runat="server">
        <HeaderTemplate>
            <table class="table table-hover">
                <tr>
                    <th>DOSYA</th>
                    <th>DOSYA URL</th>
                    <th>SİL</th>

                </tr>
        </HeaderTemplate>
        <ItemTemplate>
            <tr>
                <td>
                    <img src="../Library/<%#Eval("Content")%>" alt="" height="65" width="65" class="img-thumbnail images-extension" />
                </td>

                <td>
                    <input id="Text1" type="text" value="<%Response.Write(Session["url"].ToString()); %>/Library/<%#Eval("Content")%>" class="form-control deneme" />
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
                <script>

                    $('img').error(function () {

                        $(this).attr("src", "../Items/Items/no-image.jpg");

                    })



                </script>
        </FooterTemplate>
    </asp:Repeater>

</asp:Content>

