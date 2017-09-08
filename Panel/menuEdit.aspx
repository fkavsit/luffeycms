<%@ Page Title="" Language="C#" MasterPageFile="~/Panel/PanelMaster.master" AutoEventWireup="true" CodeFile="menuEdit.aspx.cs" Inherits="Panel_menuEdit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphPanelContent" Runat="Server">
     <asp:Panel ID="success" runat="server" Visible="false">
        <div class="alert alert-success" role="alert">Menü Başarılı Bir Şekilde Eklendi.</div>
    </asp:Panel>
    <asp:Panel ID="error" runat="server" Visible="false">
        <div class="alert alert-danger" role="alert">Bir Hata Meydana Geldi.</div>
    </asp:Panel>

    <div class="form-group">
        <label>Menü Sıra</label>
        <asp:TextBox ID="txtMenuSira" runat="server" CssClass="form-control"></asp:TextBox>
    </div>
    <div class="form-group">
        <label>Menü Başlık</label>
        <asp:TextBox ID="txtBaslik" runat="server" CssClass="form-control"></asp:TextBox>
    </div>
        <div class="form-group">
        <label>Menü Link</label>
        <asp:TextBox ID="txtLink" runat="server" CssClass="form-control"></asp:TextBox>
    </div>
    <div class="form-group">
        <asp:Button ID="btnSave" runat="server" CssClass="btn btn-primary" Text="Kaydet" OnClick="btnSave_Click" />
    </div>
</asp:Content>

