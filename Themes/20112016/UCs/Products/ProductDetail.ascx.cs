using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Themes_default_UCs_Products_ProductDetail : System.Web.UI.UserControl
{
    LuffeyCMSDataContext dcx = new LuffeyCMSDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        string productId = Page.RouteData.Values["ProductID"] as string;
        string productTitle = Page.RouteData.Values["ProductTitle"] as string;

        Page.Title = productTitle;
        Page.MetaDescription = productTitle;
        
        var query = from a in dcx.Products where a.ID == int.Parse(productId) select a;
        rptr_produtdetail.DataSource = query;
        rptr_produtdetail.DataBind();
    }

    

    
}