<%@ Page Title="" Language="C#" MasterPageFile="~/Panel/PanelMaster.master" AutoEventWireup="true" CodeFile="sliderAdd.aspx.cs" Inherits="Panel_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphPanelContent" runat="Server">
    <asp:Panel ID="success" runat="server" Visible="false">
        <div class="alert alert-success" role="alert">Slider Başarılı Bir Şekilde Eklendi.</div>
    </asp:Panel>
    <asp:Panel ID="error" runat="server" Visible="false">
        <div class="alert alert-danger" role="alert">Bir Hata Meydana Geldi.</div>
    </asp:Panel>
    <div class="form-group">
        <label>Slider Sıra No:</label>
        <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox>
    </div>
        <div class="form-group">
        <label>Slider Yazısı:</label>
        <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control"></asp:TextBox>
    </div>
    <div class="form-group">
        <label>Slider Resim</label>
        <asp:FileUpload ID="FileUpload1" CssClass="form-control" runat="server" />
    </div>
      <div class="form-group">
          <asp:Button ID="Button1" runat="server" CssClass="btn btn-primary" Text="Kaydet" OnClick="Button1_Click" />
           </div>

</asp:Content>

