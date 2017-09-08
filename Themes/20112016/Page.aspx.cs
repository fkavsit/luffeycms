using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using KavsitWebLibrary;

public partial class Theme_Page : System.Web.UI.Page
{
    LuffeyCMSDataContext dcx = new LuffeyCMSDataContext();
    KavsitWeb KavsitWeb = new KavsitWeb();
    protected void Page_Load(object sender, EventArgs e)
    {
        
        string pageid = Page.RouteData.Values["PageID"] as string;
        string pagetitle = Page.RouteData.Values["PageTitle"] as string;
        this.Master.Page.Title = pagetitle;
        
        if (pageid != null)
        {
            var query = from a in dcx.Pages where a.ID==int.Parse(pageid) select a;
            rptr_page.DataSource = query;
            rptr_page.DataBind();
        }
        

    }
}