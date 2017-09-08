<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Comment.ascx.cs" Inherits="Theme_UCs_Comment" %>

<asp:Repeater ID="rptr_comments" runat="server">
    <HeaderTemplate>
        <div class="col-sm-16 comments-area">
            <div class="main-title-outer pull-left">
                <div class="main-title">Yorumlar</div>
            </div>
            <div class="opinion pull-left">
    </HeaderTemplate>
    <ItemTemplate>

        <div class="media">
            <a href="#" class="pull-left">
                <img alt="64x64" data-src="holder.js/64x64" class="media-object" style="width: 64px; height: 64px;" src="http://i.imgur.com/qYVuv24.gif">
            </a>
            <div class="media-body">
                <div>
                    <h4 class="media-heading"><%#Eval("CommentName") %></h4>
                    <div class="time text-danger"><span class="ion-clock"></span>&nbsp; <%#Eval("CommentTime") %></div>
                </div>
                <%#Eval("CommentDesc") %>
            </div>
        </div>

    </ItemTemplate>
    <FooterTemplate>
        </div>
                </div>
    </FooterTemplate>

</asp:Repeater>
<asp:Panel ID="panel_Comment" runat="server">
    <div class="main-title-outer pull-left">
                <div class="main-title">Yorum Yap</div>
            </div>
  

<table>
  <tr>
    <td>Adınız</td>
    <td><asp:TextBox ID="txtName" CssClass="form-control" Style="margin:5px" runat="server"></asp:TextBox></td>
  </tr>
  <tr>
    <td>Yorumunuz</td>
    <td> <asp:TextBox ID="txtComment" CssClass="form-control" Rows="5" Columns="50" Style="margin:5px"  TextMode="MultiLine" runat="server"></asp:TextBox></td>
       
  </tr>
    
    <tr>
        <td>&nbsp</td>
        <td>
               <asp:Button ID="btn_comment" Style="margin:5px"  CssClass="btn btn-danger" runat="server" Text="Yorum Yap" OnClick="btn_comment_Click" />
        </td>
    </tr>
</table>

  
  

</asp:Panel>
<asp:Panel ID="no_comment" Visible="false" runat="server">
    <h3>Bu Habere Yorum Yapılması Engellenmiştir.</h3>
</asp:Panel>


