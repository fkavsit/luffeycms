<%@ Page Title="" Language="C#" MasterPageFile="~/Themes/20112016/Master.master" AutoEventWireup="true" CodeFile="contact.aspx.cs" Inherits="contact" %>


<asp:Content ID="Content2" ContentPlaceHolderID="cph_Content" runat="Server">
        <asp:Panel ID="success" runat="server" Visible="false">
        <div class="alert alert-success" role="alert">Mesaj Başarılı Bir Şekilde Gönderildi. En Kısa Sürede Sizinle İletişime Geçilecektir.</div>
    </asp:Panel>
    <asp:Panel ID="error" runat="server" Visible="false">
        <div class="alert alert-danger" role="alert">Bir Hata Meydana Geldi.</div>
    </asp:Panel>
    <div class="row">
        <div class="col-md-4">
            <h4>Contact Info</h4>
            <div>
                <h5>İlgin...</h5>
            </div>
        </div>
        <div class="col-md-8">
            <h4>Contact Form</h4>
            <div class="row">
                <div class="col-md-4">
                    <asp:TextBox ID="txtAd" CssClass="form-control" runat="server" PlaceHolder="Adı Soyad"></asp:TextBox>
                </div>
                 <div class="col-md-4">
                    <asp:TextBox ID="txtKonu" CssClass="form-control" runat="server" PlaceHolder="Konu"></asp:TextBox>
                </div>
                <div class="col-md-4">
                    <asp:TextBox ID="txtEmail" CssClass="form-control" runat="server" PlaceHolder="E-Posta"></asp:TextBox>
                </div>

                <div class="col-md-4">
                    <asp:TextBox ID="txtTel" CssClass="form-control" runat="server" PlaceHolder="Telefon"></asp:TextBox>
                </div>


            </div>
            <div class="row">
                <div class="col-md-12">
                    <asp:TextBox ID="txtMesaj" PlaceHolder="Mesajınız" TextMode="MultiLine" Height="200" CssClass="form-control" runat="server"></asp:TextBox>
                </div>
            </div>
            <div class="row">
                <div class="col-md-3">
                    <asp:Button ID="btnSend" runat="server" CssClass="btn btn-success" Text="GÖNDER" OnClick="btnSend_Click" />
                </div>
                <div class="col-md-2">
                    <asp:Button ID="btnClear" runat="server" CssClass="btn btn-danger" Text="TEMİZLE" OnClick="btnClear_Click" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>

