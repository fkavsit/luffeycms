<%@ Page Title="" Language="C#" MasterPageFile="~/Panel/PanelMaster.master" AutoEventWireup="true" CodeFile="newsEdit.aspx.cs" Inherits="Panel_newsEdit" %>


    <%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>

<asp:Content ID="Content2" ContentPlaceHolderID="cphPanelContent" runat="Server">
    <asp:Panel ID="success" runat="server" Visible="false">
        <div class="alert alert-success" role="alert">Haber Başarılı Bir Şekilde Güncellendi.</div>
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
        <asp:DropDownList ID="ddl_katagori" runat="server" CssClass="form-control" AutoPostBack="True" >
        </asp:DropDownList>
       
    </div>
  
       <div class="form-group">
       
            <asp:CheckBox ID="chk_timeUpdate" Text="-Tarihi Güncelle" Checked="true" AutoPostBack="true" runat="server" /> <asp:CheckBox ID="chc_comment" Text="-Yorum Eklensin"  AutoPostBack="true" runat="server" />
    </div>
          
       
           
   
    <div class="form-group">
        <asp:Button ID="Button1" runat="server" CssClass="btn btn-primary" Text="Haberi Güncelle" OnClick="Button1_Click"  />
    </div>
</asp:Content>

