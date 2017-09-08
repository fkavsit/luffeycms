<%@ Page Title="" Language="C#" MasterPageFile="~/Panel/PanelMaster.master" AutoEventWireup="true" CodeFile="newsAdd.aspx.cs" Inherits="Panel_newsAdd" %>

<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphPanelContent" runat="Server">
    <asp:Panel ID="success" runat="server" Visible="false">
        <div class="alert alert-success" role="alert">Haber Başarılı Bir Şekilde Eklendi.</div>
    </asp:Panel>
    <asp:Panel ID="error" runat="server" Visible="false">
        <div class="alert alert-danger" role="alert">Bir Hata Meydana Geldi.</div>
    </asp:Panel>
    <div class="form-group">
        <label>Haber Başlığı</label>
        <asp:TextBox ID="txtBaslik" runat="server" CssClass="form-control"></asp:TextBox>
    </div>
    <div class="form-group">
        <label>Haber Özeti</label>
        <asp:TextBox ID="txtOzet" runat="server" CssClass="form-control"></asp:TextBox>
    </div>
    <div class="form-group">
        <label>Haber İçerik</label>
        <CKEditor:CKEditorControl ID="CKEditor1" runat="server">
        </CKEditor:CKEditorControl>
    </div>

    <div class="form-group">
        <label>Haber Kategori</label>
        <asp:DropDownList CssClass="form-control" ID="dropdown_category" runat="server" AutoPostBack="True"></asp:DropDownList>

    </div>
    
    <div class="form-group">
        <label>Haber Görseli</label>
        <asp:FileUpload ID="FileUpload1" CssClass="form-control" runat="server" />
    </div>
  <div class="form-group">
       
            <asp:CheckBox ID="chk_comment" Text="-Yorum Eklensin" Checked="true" AutoPostBack="true" runat="server" />
    </div>
    <div class="form-group">
        <asp:Button ID="Button1" runat="server" CssClass="btn btn-primary" Text="Haber Ekle" OnClick="Button1_Click" />
    </div>
</asp:Content>

