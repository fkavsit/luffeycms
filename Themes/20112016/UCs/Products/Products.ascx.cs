using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Themes_default_UCs_Products_Products : System.Web.UI.UserControl
{
    LuffeyCMSDataContext dcx = new LuffeyCMSDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {

        rptr_products.DataSource = dcx.Products;
        rptr_products.DataBind();
        
    }
    public string ProductPrice(int ProductId) 
    {
        int result = dcx.Products.SingleOrDefault(x=> x.ID==ProductId).Price;
        return result.ToString("C0");
    }
}