<%@ Page Title="" Language="C#" MasterPageFile="~/Panel/PanelMaster.master" AutoEventWireup="true" CodeFile="menus.aspx.cs" Inherits="Panel_menus" %>

<asp:Content ID="Content2" ContentPlaceHolderID="cph_head" runat="Server">
    <!--Head Etiketi İçin Extra Link Ekle-->
    <script src="https://unpkg.com/vue/dist/vue.js"></script>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="cphPanelContent" runat="Server">


    
    <asp:Panel ID="success" runat="server" Visible="false">
        <div class="alert alert-success" role="alert">Menü Başarılı Bir Şekilde Eklendi.</div>
    </asp:Panel>
    <span id="sonuc"></span>
    <asp:Panel ID="error" runat="server" Visible="false">
        <div class="alert alert-danger" role="alert">Bir Hata Meydana Geldi.</div>
    </asp:Panel>



    <div id="app">


        <asp:Repeater ID="rptr_menu" runat="server">
            <HeaderTemplate>
                <div class="row">

                    <div class="col-md-8">

                        <div class="panel panel-default">

                            <div class="panel-heading">

                                <div class="panel-title">Menüler</div>

                            </div>
                            <div class="panel-body">
                                <button v-on:click="say(checkedNames)" style="padding: 9px 11px 4px" class="btn btn-default btn-sm" type="button"><i class="fa fa-trash-o" style="font-size: 18px"></i></button>
                                <table class="table table-bordered">
                                    <tr>
                                        <th>
                                            <input type="checkbox" id="selectAll" name="selectAll" value="" />

                                            <th>Menü Adı</th>
                                            <th>Sil</th>
                                    </tr>
            </HeaderTemplate>
            <ItemTemplate>

                <tr>
                    <td>
                        <input type="checkbox" class="chckItem" id="<%#Eval("ID") %>" value="<%#Eval("ID") %>" v-model="checkedNames" />
                        <td>
                            <a href="menuEdit.aspx?edit=<%#Eval("ID") %>">
                                <%#Eval("Title") %>
                                
                            </a>


                        </td>
                        <td><a href="?del=<%#Eval("ID") %>">
                            <img src="../Images/Panel/delete.png" width="30" height="30" alt="" />
                        </a></td>
                </tr>
            </ItemTemplate>
            <FooterTemplate>
                </table>
            </div>
             </div>
    </div>
                
                
            </FooterTemplate>

        </asp:Repeater>
        <div class="col-md-4">
            <div class="panel panel-default">
                <div class="panel-heading">
                    <div class="panel-title">Menu Ekle</div>

                </div>
                <div class="panel-body">


                    <dl>
                        <dt>Menü Sıra</dt>
                        <dd>
                            <asp:TextBox ID="txtMenuSira" runat="server" CssClass="form-control"></asp:TextBox></dd>

                        <dt>Menü Başlık</dt>
                        <dd>
                            <asp:TextBox ID="txtBaslik" runat="server" CssClass="form-control"></asp:TextBox></dd>

                        <dt>Bağlantı Biçimi</dt>
                        <dd>
                            <select id="linktipi" class="form-control">
                                <option value="haricilink" selected="selected">Harici</option>
                                <option value="dahililink">Dahili</option>

                            </select></dd>

                        <dt>Menü Link</dt>
                        <dd id="harici">
                            <asp:TextBox ID="txtLink" runat="server" CssClass="form-control"></asp:TextBox>

                        </dd>
                        <dd id="dahili" style="display: none">
                            <asp:DropDownList ID="DrpdDahili" CssClass="form-control" runat="server" AutoPostBack="True">
                            </asp:DropDownList></dd>
                        <dt>Üst Menu</dt>
                        <dd>
                            <asp:DropDownList ID="TopMenu" CssClass="form-control" runat="server" AutoPostBack="True">
                            </asp:DropDownList></dd>
                        <dd style="margin-top: 5px">
                            <asp:Button ID="btnSave" runat="server" CssClass="btn btn-primary btn-block" Text="Kaydet" OnClick="btnSave_Click" /></dd>


                    </dl>

                </div>
            </div>
        </div>

        <script>


            $("#linktipi").change(function () {

                $("#linktipi> option:selected").each(function () {

                    if ($(this).text() == "Dahili") {
                        $('#dahili').show();
                        $('#harici').hide();
                    }
                    else {
                        if ($(this).text() == "Harici") {
                            $('#dahili').hide();
                            $('#harici').show();
                        }
                    }

                });

            })


        </script>

        <template type="javascript">
            var app = new Vue({
                el: '#app',
                data: {
                    checkedNames: []
                },
                methods: {
                    say: function (message) {
                        var sure = confirm('Are you sure to delete?');
                        if (sure == true) {

                            $.ajax({
                                type: 'POST',
                                url: 'menus.aspx/DeleteMenuItems',
                                data: '{ "secililer":"' + message + '" }',
                                contentType: 'application/json; charset=utf-8',
                                dataType: 'json',
                                success: function (result) {
                                    $('#sonuc').html(result.d);
                                },
                                error: function () {
                                    alert('Bağlantı sırasında bir sorun oluştu. Yeniden deneyin');
                                }
                            });
                        }

                    }
                }
            })
        </template>

    </div>
</asp:Content>

