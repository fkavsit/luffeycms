<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Register.ascx.cs" Inherits="Theme_UCs_Register" %>

<asp:Panel ID="success" runat="server" Visible="false">
    <div class="alert alert-success" role="alert">Kayıt Başarılı Bir Şekilde Yapılmıştır. Lütfen Mail Kutunuzu Kontrol Ediniz.</div>
</asp:Panel>
<asp:Panel ID="error" runat="server" Visible="false">
    <div class="alert alert-danger" role="alert">Bir Hata Meydana Geldi.</div>
</asp:Panel>

<asp:Label ID="memName" runat="server" Text="Ad: "></asp:Label><br />
<asp:TextBox ID="name" runat="server"></asp:TextBox><br />

<asp:Label ID="memSur" runat="server" Text="Soyad: "></asp:Label><br />
<asp:TextBox ID="sur" runat="server"></asp:TextBox><br />

<asp:Label ID="memEmail" runat="server" Text="Email: "></asp:Label><br />
<asp:TextBox ID="mail" runat="server"></asp:TextBox><br />

<asp:Label ID="memuUser" runat="server" Text="Kullanıcı Adı: "></asp:Label><br />
<asp:TextBox ID="user" runat="server"></asp:TextBox><br />

<asp:Label ID="memPass" runat="server" Text="Şifre: "></asp:Label><br />
<asp:TextBox ID="pass" runat="server"></asp:TextBox><br />

<asp:Button ID="bntRegister" runat="server" Text="Kayıt Ol" OnClick="bntRegister_Click" />

<asp:Label ID="lblerror" runat="server" Text=""></asp:Label>