<%@ Page Title="" Language="C#" MasterPageFile="~/Panel/PanelMaster.master" AutoEventWireup="true" CodeFile="Settings.aspx.cs" Inherits="Panel_Settings" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphPanelContent" runat="Server">
    <script>
        jQuery(document).ready(function ($) {
            $('.hello_world').pwstabs();
        });
    </script>

    <asp:Panel ID="success" runat="server" Visible="false">
        <div class="alert alert-success" role="alert">Menü Başarılı Bir Şekilde Eklendi.</div>
    </asp:Panel>
    <asp:Panel ID="error" runat="server" Visible="false">
        <div class="alert alert-danger" role="alert">Bir Hata Meydana Geldi.</div>
    </asp:Panel>
    <div class="hello_world">

        <div data-pws-tab="anynameyouwant1" style="width: 100%" data-pws-tab-name="Firma" data-pws-tab-icon="fa fa-cogs">


            <div class="form-group">
                <label>Firma Adı : </label>
                <asp:TextBox ID="txt_CompanyName" runat="server" CssClass="form-control"></asp:TextBox>

            </div>
            <div class="form-group">
                <label>Firma Bilgisi :</label>
                <asp:TextBox ID="txt_CompanyInfo" Rows="5" runat="server" TextMode="MultiLine" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <label>Firma Telefonu :</label>
                <asp:TextBox ID="txt_CompanyPhone" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <label>Firma E-Postası :</label>
                <asp:TextBox ID="tx_CompanyEmail" runat="server" placeholder="ornek@firma.com" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <label>Firma Fax :</label>
                <asp:TextBox ID="txt_CompanyFax" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Button ID="Button1" runat="server" CssClass="btn btn-primary" Text="Firma Bilgilerini Kaydet" OnClick="Button1_Click" />
            </div>

        </div>











        <div data-pws-tab="anynameyouwant2" data-pws-tab-name="Tasarım" data-pws-tab-icon="fa fa-desktop">
            <div class="form-group">
                <label>Logo</label>
                <asp:FileUpload ID="fup_logo" CssClass="form-control" runat="server" />
                <img src="/Items/Logo/logo.png" width="75" height="30" />
            </div>
            <div class="form-group">
                <label>Favicon</label>
                <asp:FileUpload ID="fup_fav" CssClass="form-control" runat="server" />
                <img src="../Items/Favicon/favicon.png" width="75" height="30" />
            </div>
            <div class="form-group">
                <asp:Button ID="btn_design" runat="server" CssClass="btn btn-primary" Text="Değişiklikleri Kaydet" OnClick="btn_design_Click" />
            </div>
        </div>


        <div data-pws-tab="anynameyouwant3" style="width: 100%" data-pws-tab-name="SEO" data-pws-tab-icon="fa fa-server">


            <div class="form-group">
                <label>SEO Başlık :  </label>
                <asp:TextBox ID="txt_seo_title" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <label>SEO Meta Açıklaması :</label>
                <asp:TextBox ID="txt_seo_meta" Rows="5" runat="server" TextMode="MultiLine" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <label>Meta Anahtar Kelimeler :</label>
                <asp:TextBox ID="txt_seo_keywords" runat="server" PlaceHolder="Her Kelimeden Sonra Virgül(,) İşareti Koyunuz." CssClass="form-control"></asp:TextBox>
            </div>

            <div class="form-group">

                <asp:Button ID="btn_seo" runat="server" CssClass="btn btn-primary" Text="Kaydet" OnClick="btn_seo_Click" />
            </div>

        </div>




        <div data-pws-tab="anynameyouwant4" style="width: 100%" data-pws-tab-name="Mail" data-pws-tab-icon="fa fa-envelope">
            <div class="form-group">
                <label>Enable :  </label>
                <asp:CheckBox ID="chck_enable" runat="server" CssClass="form-control" /></asp:CheckBox>
            </div>

            <div class="form-group">
                <label>E-Mail :  </label>
                <asp:TextBox ID="txt_mail_email" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <label>Password :  </label>
                <asp:TextBox ID="txt_mail_password" runat="server" TextMode="Password" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <label>SMTP Host :  </label>
                <asp:TextBox ID="txt_smtp_host" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <label>SMTP Port :  </label>
                <asp:TextBox ID="txt_smtp_port" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <label>SSL Enable :  </label>
                <asp:CheckBox ID="chck_ssl" runat="server" CssClass="form-control" /></asp:CheckBox>
            </div>
            <div class="form-group">

                <asp:Button ID="btn_mail" runat="server" CssClass="btn btn-primary" Text="Kaydet" OnClick="btn_mail_Click" />

            </div>

        </div>



        <div data-pws-tab="anynameyouwant5" style="width: 100%" data-pws-tab-name="Tema" data-pws-tab-icon="fa-window-restore">



            <div class="row">
                <%=ThemeList() %>
            </div>

        </div>
        <div data-pws-tab="anynameyouwant6" style="width: 100%" data-pws-tab-name="Geliştirici" data-pws-tab-icon="fa-cog">


            <asp:Panel runat="server" ID="panelDevelop">
                <div class="row">
                    <div class="col-md-10">
                        <asp:TextBox ID="txtdevelopmentkey" placeholder="Geliştirici Şifresini Giriniz.." runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="col-md-1">
                        <asp:Button runat="server" CssClass="btn btn-primary btn-block" ID="btn_developkey" OnClick="btn_developkey_Click" Text="Gir" />
                    </div>

                </div>
            </asp:Panel>
            <asp:Panel runat="server" Visible="false" ID="panelDevelopSettings">
                <div class="panel panel-default">
                    <div class="panel-heading">
                        <h3 class="panel-title">SQL Sorgu</h3>
                    </div>
                    <div class="panel-body">
                        <asp:TextBox runat="server" TextMode="MultiLine" CssClass="form-control" ID="txt_sqlQuery"></asp:TextBox>
                        <asp:Button runat="server"  CssClass="btn btn-primary" OnClick="btn_sqlExecute_Click" ID="btn_sqlExecute" Text="Çalıştır" />
                    </div>
                </div>
               
                <div class="panel panel-default">
                <div class="panel-heading">
                    <h3 class="panel-title">Önbellek Temizle</h3>
                </div>
                <div class="panel-body">
                     <asp:Button runat="server" CssClass="btn btn-primary" ID="deleteCache" OnClick="deleteCache_Click" Text="Delete Cache" />
                </div>
            </div>
               
            </asp:Panel>

        </div>
    </div>

    <script>
        $('.tabset11').pwstabs({
            effect: 'none',
            containerWidth: '900px',
            theme: "pws_theme_orange"
        });
    </script>
</asp:Content>

