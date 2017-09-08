<%@ Application Language="C#" %>
<%@ Import Namespace="System.Web.Routing" %>
<%@ Import Namespace="KavsitWebLibrary" %>

<script RunAt="server">
    public KavsitWeb KavsitWeb = new KavsitWeb();

    void Application_Start(object sender, EventArgs e) {


        RouteTable.Routes.Add("yonetim2", new Route("admin", new PageRouteHandler("~/kavsit.aspx")));
        RouteTable.Routes.Add("Contact", new Route("Contact", new PageRouteHandler("~"+KavsitWeb.ThemePath+"/contact.aspx")));
        RouteTable.Routes.Add("Products", new Route("Products", new PageRouteHandler("~" + KavsitWeb.ThemePath + "/Products.aspx")));
        RouteTable.Routes.Add("News", new Route("News", new PageRouteHandler("~" + KavsitWeb.ThemePath + "/News.aspx")));
        RouteTable.Routes.Add("Login", new Route("Login", new PageRouteHandler("~" + KavsitWeb.ThemePath + "/Login.aspx")));
        RouteTable.Routes.Add("Register", new Route("Register", new PageRouteHandler("~" + KavsitWeb.ThemePath + "/Register.aspx")));

        RegisterRouotes(RouteTable.Routes);

    }

    void RegisterRouotes(RouteCollection routes) {
        routes.MapPageRoute("NewsDetail", "News/{NewTitle}-h{ID}", "~/"+ KavsitWeb.ThemePath +"/NewDetail.aspx");
        routes.MapPageRoute("Page", "Page/{PageTitle}-{PageID}", "~/"+ KavsitWeb.ThemePath +"/Page.aspx");
        routes.MapPageRoute("Product", "Product/{ProductTitle}-{ProductID}", "~/"+ KavsitWeb.ThemePath +"/ProductDetail.aspx");

    }



    void Application_BeginRequest(object sender, EventArgs e)
    {
        //KavsitWeb.Query("insert into [dbo].[Statistics] (adress,ip,time) VALUES ('" + Request.ServerVariables["URL"].ToString() + "','" + Request.ServerVariables["Remote_Addr"].ToString() + "','" + DateTime.Now.ToString() + "')");

    }

</script>
