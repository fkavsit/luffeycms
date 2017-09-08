<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Slider.ascx.cs" Inherits="Theme_UCs_Slider" %>

 <asp:Repeater ID="rptr_slider" runat="server">
            <HeaderTemplate>
              
<div class="col-sm-16 banner-outer wow fadeInLeft animated" data-wow-delay="1s" data-wow-offset="50">
                    <div class="row">
                        <div class="col-sm-16 col-md-10 col-lg-8">
            </HeaderTemplate>
            <ItemTemplate>
                       <div id="sync1" class="owl-carousel">
                                <div class="box item">
                                    <a href="#">
                                        <div class="carousel-caption">
                                        <%#Eval("Text") %>
                                        </div>
                                        <img class="img-responsive" src="/Images/slider/<%#Eval("Image") %>" width="1600" height="972" alt="" />
                                        <div class="overlay"></div>
                                        <div class="overlay-info">
                                            <div class="cat">
                                                <p class="cat-data"><span class="ion-model-s"></span>lifestyle</p>
                                            </div>
                                            <div class="info">
                                                <p><span class="ion-android-data"></span>Dec 16 2014<span class="ion-chatbubbles"></span>351</p>
                                            </div>
                                        </div>
                                    </a>
                                </div>
                                

                            </div>
                            <div class="row">
                                <div id="sync2" class="owl-carousel">
                                   
                                    <div class="item"><img class="img-responsive " src="/Images/slider/<%#Eval("Image") %>" width="1600" height="972" alt="" /></div>
                                </div>
                            </div>
               
            </ItemTemplate>
            <FooterTemplate>
       
                             </div>
                        
                    </div>
                </div>
            </FooterTemplate>
        </asp:Repeater>















                            <!-- carousel start -->
                     
                       
                            
                     