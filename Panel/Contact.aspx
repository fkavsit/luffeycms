<%@ Page Title="" Language="C#" MasterPageFile="~/Panel/PanelMaster.master" AutoEventWireup="true" CodeFile="Contact.aspx.cs" Inherits="Panel_contactUs" %>

<asp:Content ID="Content2" ContentPlaceHolderID="cph_head" runat="Server">
    <!--Head Etiketi İçin Extra Link Ekle-->
    <script src="https://unpkg.com/vue/dist/vue.js"></script>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="cphPanelContent" runat="Server">
    <asp:Panel ID="success" runat="server" Visible="false">
        <div class="alert alert-success" role="alert">Mesajlar Başarılı Bir Şekilde Silindi.</div>
    </asp:Panel>
    <span id="sonuc"></span>
    <asp:Panel ID="error" runat="server" Visible="false">
        <div class="alert alert-danger" role="alert">Bir Hata Meydana Geldi.</div>
    </asp:Panel>

    <asp:Repeater ID="contactgrid" runat="server">
        <HeaderTemplate>
            <div id="app">
                <section class="content">
                    <div class="row">

                        <div class="col-md-12">
                            <div class="box box-primary">
                                <div class="box-header with-border">
                                    <h3 class="box-title">Mesaj Kutusu</h3>

                                    <div class="box-tools pull-right">
                                        <div class="has-feedback">
                                            <input type="text" v-model="searchText" v-on:keyup.space="search(searchText)" />

                                            <span class="glyphicon glyphicon-search form-control-feedback"></span>
                                        </div>
                                    </div>
                                    <!-- /.box-tools -->
                                </div>
                                <!-- /.box-header -->
                                <div class="box-body no-padding">
                                    <div class="mailbox-controls">
                                        <!-- Check all button -->
                                        <button type="button" class="btn btn-default btn-sm checkbox-toggle">
                                            <i class="fa fa-square-o"></i>
                                        </button>
                                        <div class="btn-group">
                                            <button type="button" v-on:click="say(checkedNames)" class="btn btn-default btn-sm"><i class="fa fa-trash-o"></i></button>
                                            <button type="button" class="btn btn-default btn-sm"><i class="fa fa-reply"></i></button>

                                        </div>
                                        <!-- /.btn-group -->
                                        <button type="button" class="btn btn-default btn-sm"><i class="fa fa-refresh"></i></button>
                                        <div class="pull-right">


                                            <div class="btn-group">
                                                <button type="button" class="btn btn-default btn-sm"><i class="fa fa-chevron-left"></i></button>
                                                <button type="button" class="btn btn-default btn-sm"><i class="fa fa-chevron-right"></i></button>
                                            </div>
                                            <!-- /.btn-group -->
                                        </div>
                                        <!-- /.pull-right -->
                                    </div>
                                    <div class="table-responsive mailbox-messages">
                                        <table class="table table-hover table-striped">
                                            <tbody>
        </HeaderTemplate>
        <ItemTemplate>
            <tr id="aramasonuc"></tr>

                <tr>
                    <td>
                        <input type="checkbox" class="chckItem" value="<%#Eval("ID") %>" v-model="checkedNames" />

                    </td>
                    <td class="mailbox-star"><a href="#"><i class="fa fa-star text-yellow"></i></a></td>
                    <td class="mailbox-name"><a href="read-mail.html"><%#Eval("Name") %></a></td>
                    <td class="mailbox-subject"><b></b><%#Eval("Summary") %>
                                 </td>
                    <td class="mailbox-attachment"></td>
                    <td class="mailbox-date"><%#Eval("Date") %></td>
                </tr>
        </ItemTemplate>
        <FooterTemplate>
            </div>

                            </tbody>
                        </table>
                        <!-- /.table -->
            </div>
                    <!-- /.mail-box-messages -->
            </div>
                <!-- /.box-body -->

            </div>
            <!-- /. box -->
            </div>
        <!-- /.col -->
            </div>
    <!-- /.row -->
            </section>
            </div>
            <!-- /.content -->

        </FooterTemplate>
    </asp:Repeater>
    <script>
        var app = new Vue({
            el: '#app',
            data: {
                checkedNames: [],
                searchText: ""
            },
            methods: {
                say: function (message) {
                    var sure = confirm('Are you sure to delete?');
                    if (sure == true) {

                        $.ajax({
                            type: 'POST',
                            url: 'Contact.aspx/DeleteContactItems',
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

                },
                search: function (searchText) {
                    $.ajax({
                        type: 'POST',
                        url: 'Contact.aspx/SearchContact',
                        data: '{ "aranacak":"' + searchText + '" }',
                        contentType: 'application/json; charset=utf-8',
                        dataType: 'json',
                        success: function (result) {
                            $('#aramasonuc').html(result.d);
                        },
                        error: function () {
                            alert('Bağlantı sırasında bir sorun oluştu. Yeniden deneyin');
                        }
                    });

                }
            }
        })
    </script>
</asp:Content>




















