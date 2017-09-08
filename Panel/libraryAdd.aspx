<%@ Page Title="" Language="C#" MasterPageFile="~/Panel/PanelMaster.master" AutoEventWireup="true" CodeFile="libraryAdd.aspx.cs" Inherits="Panel_libraryAdd" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit"%>
<asp:Content ID="Content1" ContentPlaceHolderID="cphPanelContent" Runat="Server">
    <asp:Panel ID="success" runat="server" Visible="false">
        <div class="alert alert-success" role="alert">Dosya Kütüphaneye Başarılı Bir Şekilde Eklendi.</div>
    </asp:Panel>
    <asp:Panel ID="error" runat="server" Visible="false">
        <div class="alert alert-danger" role="alert">Bir Hata Meydana Geldi.</div>
    </asp:Panel>
   
    <div class="form-group">
        <label>Dosya</label>
        <asp:FileUpload ID="FileUpload1" CssClass="form-control" runat="server" />
       

    </div>
      <div class="form-group">
          <asp:Button ID="Button1" runat="server" CssClass="btn btn-primary" Text="Ekle" OnClick="Button1_Click" />
           </div>
</asp:Content>


