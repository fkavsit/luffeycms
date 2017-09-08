<%@ Page Title="" Language="C#" MasterPageFile="~/Panel/PanelMaster.master" AutoEventWireup="true" CodeFile="sliders.aspx.cs" Inherits="Panel_sliders" %>

<asp:Content ID="Content2" ContentPlaceHolderID="cph_head" runat="Server">
    <!--Head Etiketi İçin Extra Link Ekle-->
    <link href='http://fonts.googleapis.com/css?family=Raleway:400,800,300' rel='stylesheet' type='text/css'>

    <link href="../Styles/set1.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="cphPanelContent" runat="Server">
    <asp:Panel ID="success" runat="server" Visible="false">
        <div class="alert alert-success" role="alert">Slider Başarılı Bir Şekilde Eklendi.</div>
    </asp:Panel>
    <asp:Panel ID="error" runat="server" Visible="false">
        <div class="alert alert-danger" role="alert">Bir Hata Meydana Geldi.</div>
    </asp:Panel>
    <asp:Repeater ID="slidersgrid" runat="server">
        <HeaderTemplate>
            <div class="row">
                <div class="col-md-8">
                    <div class="panel panel-default">
                        <div class="panel-heading">
                            <div class="panel-title">Slider</div>

                        </div>
                        <div class="panel-body">
                            <div class="grid">
        </HeaderTemplate>
        <ItemTemplate>
            <figure class="effect-zoe" style="height: 280px;">
                <img src="../Images/slider/<%#Eval("Image")%>" alt="img25" />
                <figcaption>
                    <h2 style="font-family: 'Raleway', Arial, sans-serif;">Kavsit <span>Web</span></h2>
                    <p class="icon-links">
                        <a href="#" onclick="areyousure(<%#Eval("ID") %>)"><i class="fa fa-fw fa-close"></i>Sil</a>&nbsp;
							
                        <a href="../Images/slider/<%#Eval("Image")%>" download="../Images/slider/<%#Eval("Image")%>"><i class="fa fa-fw fa-download"></i>İndir</a>
                    </p>
                    <p class="description"><%#Eval("Text") %></p>
                </figcaption>
            </figure>



        </ItemTemplate>
        <FooterTemplate>
            </div>
            </div>
             </div>
            

           
            </div>
           
        </FooterTemplate>
    </asp:Repeater>
    <div class="col-md-4">
        <div class="panel panel-default">
            <div class="panel-heading">
                <div class="panel-title">Slider Ekle</div>
            </div>
            <div class="panel-body">
                <dl>
                    <dt>Slider Sıra</dt>
                    <dd>
                        <asp:TextBox ID="txtSliderSira" runat="server" CssClass="form-control"></asp:TextBox></dd>

                    <dt>Menü İçerik</dt>
                    <dd>
                        <asp:TextBox ID="txtIcerik" runat="server" CssClass="form-control"></asp:TextBox></dd>
                    <dt>Resim</dt>
                    <dd>
                        <asp:FileUpload ID="FileUpload1" CssClass="form-control" runat="server" /></dd>

                    <dd style="margin-top: 5px">
                        <asp:Button ID="btnSave" runat="server" CssClass="btn btn-primary btn-block" Text="Kaydet" OnClick="btnSave_Click" />

                    </dd>


                </dl>
            </div>
        </div>
    </div>
    </div>
            </div>
            <script>

                function areyousure(getValue) {
                    var s = confirm('Are you sure to delete?');
                    if (s == true) {

                        window.location.href = "sliders.aspx?q=" + getValue;
                    }
                    else {

                    }
                }

            </script>
</asp:Content>


