<%@ Page Title="" Language="C#" MasterPageFile="~/Panel/PanelMaster.master" AutoEventWireup="true" CodeFile="catagoryAdd.aspx.cs" Inherits="Panel_catagoryAdd" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphPanelContent" runat="Server">

    <asp:Panel ID="success" runat="server" Visible="False">
        <div class="form-group">
            <div class="alert alert-success" role="alert">Kategori Ekleme Başarılı...</div>
        </div>
    </asp:Panel>
    <asp:Panel ID="error" runat="server" Visible="False">
        <div class="form-group">
            <div class="alert alert-danger" role="alert">Kategori Ekleme Başarısız...</div>
        </div>
    </asp:Panel>


    <div class="form-group">
        <label>Kategori Adı :</label>
        <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox>
    </div>
    <div class="form-group">
        <label>Kategori Türü :</label>
        <asp:DropDownList ID="categoryType" CssClass="form-control" runat="server" AutoPostBack="True"></asp:DropDownList>
    </div>
    <div class="form-group">
        <label>Üst Kategori :</label>
        <asp:DropDownList ID="TopCategory" CssClass="form-control" runat="server" AutoPostBack="True">
           
            
        </asp:DropDownList>
    </div>
    <div class="form-group">
        <asp:Button ID="btnSave" runat="server" CssClass="btn btn-primary" Text="Kaydet"  />
    </div>

</asp:Content>

