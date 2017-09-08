<%@ Page Title="" Language="C#" MasterPageFile="~/Panel/PanelMaster.master" AutoEventWireup="true" CodeFile="PageAdd.aspx.cs" Inherits="Panel_Page_PageAdd" %>

<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphPanelContent" runat="Server">
    <asp:Panel ID="success" runat="server" Visible="false">
        <div class="alert alert-success" role="alert">Sayfa Başarılı Bir Şekilde Oluşturuldu</div>
    </asp:Panel>
    <asp:Panel ID="error" runat="server" Visible="false">
        <div class="alert alert-danger" role="alert">Bir Hata Meydana Geldi.</div>
    </asp:Panel>


    <div class="form-group">
        <label>Sayfa Başlığı</label>
        <asp:TextBox ID="txtBaslik" runat="server" CssClass="form-control"></asp:TextBox>
    </div>
    <div class="form-group">
        <label>Sayfa SEO İsmi</label>
        <asp:TextBox ID="txtseo" runat="server" CssClass="form-control"></asp:TextBox>
    </div>
    <div class="form-group">
        <label>Sayfa İçerik</label>
        <CKEditor:CKEditorControl ID="CKEditor1" runat="server">
        </CKEditor:CKEditorControl>
    </div>

        <div class="form-group">
        <label>Sayfa Meta Başlık</label>
        <asp:TextBox ID="txtMeta" runat="server" CssClass="form-control"></asp:TextBox>
    </div>
  
        <div class="form-group">
        <label>Sayfa Meta Keywords</label>
        <asp:TextBox ID="txtMetaKeywords" runat="server" CssClass="form-control"></asp:TextBox>
    </div>
    
    <div class="form-group">
        <asp:Button ID="Button1" runat="server" CssClass="btn btn-primary" Text="Kaydet" OnClick="Button1_Click" />
    </div>
</asp:Content>

