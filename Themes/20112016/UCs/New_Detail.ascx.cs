using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Web.Routing;
using KavsitWebLibrary;


public partial class Theme_UCs_News_Detail : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        KavsitWeb KavsitWeb = new KavsitWeb();

        string haberid = Page.RouteData.Values["ID"] as string;
        string haberbaslik = Page.RouteData.Values["NewTitle"] as string;

        Page.Title = haberbaslik;
        Page.MetaDescription = haberbaslik;
        //string haberID = Request.QueryString["NewID"].ToString();
        DataTable dt = KavsitWeb.GetDataQuery("select * from news where ID=" + haberid);
        rptr_new_detail.DataSource = dt;
        rptr_new_detail.DataBind();

        
        
    }
}