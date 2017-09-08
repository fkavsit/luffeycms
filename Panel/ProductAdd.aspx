<%@ Page Title="" Language="C#" MasterPageFile="~/Panel/PanelMaster.master" AutoEventWireup="true" CodeFile="ProductAdd.aspx.cs" Inherits="Panel_ProductAdd" %>

<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphPanelContent" runat="Server">




            <div class="form-group">
                <label>Sıra No :</label>
                <asp:TextBox ID="txt_product_queue" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <label>Ürün Başlık :</label>
                <asp:TextBox ID="txt_product_title" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <label>Ürün Kodu :</label>
                <asp:TextBox ID="txt_product_code" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <label>Fiyatı :</label>
                <asp:TextBox ID="txt_product_price" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <label>Ürün Açıklaması :</label>
                <CKEditor:CKEditorControl ID="CKEditor1" runat="server">
                </CKEditor:CKEditorControl>
            </div>
            <div class="form-group">
                <label>SEO Başlığı :</label>
                <asp:TextBox ID="txt_seo" Rows="5" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            
            <div class="form-group">
                <label>Resimler :</label>
                <asp:FileUpload ID="uploadImages" AllowMultiple="true" CssClass="form-control" runat="server" />
            </div>
            <div class="form-group">
                <asp:Button ID="btn_save" runat="server" OnClick="btn_save_Click" CssClass="btn btn-primary" Text="Kaydet" />
            </div>
      



   
   
</asp:Content>

