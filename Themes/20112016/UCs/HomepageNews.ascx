<%@ Control Language="C#" AutoEventWireup="true" CodeFile="HomepageNews.ascx.cs" Inherits="Theme_UCs_News" %>

<asp:Repeater ID="rptr_news" runat="server">
    <HeaderTemplate>
    
    </HeaderTemplate>

    <ItemTemplate>
        
        <div class="sec-topic col-sm-16 col-md-8 wow fadeInDown animated " data-wow-delay="0.5s">
                                    <a href="<%# WriteUrl(Eval("ID").ToString(),Eval("Title").ToString()) %>">
                                        <img style="width:320px !important;height:210px" alt="" src="../Images/newsImage/<%#Eval("Image") %>" class="img-thumbnail">
                                        <div class="sec-info">
                                            <h3><%#Eval("Title") %></h3>
                                            <div class="text-danger sub-info-bordered">
                                                <div class="time"><span class="ion-android-data icon"></span><%#Eval("Date") %></div>
                                                <div class="comments"><span class="ion-chatbubbles icon"></span><%#Eval("CategoryID") %></div>
                                               
                                            </div>
                                        </div>
                                    </a>
                                    <p><%# (Eval("Summary").ToString().Length>=65) ? Eval("Summary").ToString().Substring(0,10) :Eval("Summary") %></p>
                                </div>

      
    </ItemTemplate>



    <FooterTemplate>

    </FooterTemplate>

</asp:Repeater>













                                


<%--                                <div class="col-sm-16">
                                    <hr />
                                    <ul class="pagination">
                                        <li><a href="#">&laquo;</a></li>
                                        <li class="active"><a href="#">1</a></li>
                                        <li><a href="#">2</a></li>
                                        <li><a href="#">3</a></li>
                                        <li><a href="#">4</a></li>
                                        <li><a href="#">5</a></li>
                                        <li><a href="#">&raquo;</a></li>
                                    </ul>
                                </div>
                         --%>