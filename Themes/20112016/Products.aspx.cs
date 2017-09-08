using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using KavsitWebLibrary;

public partial class Themes_default_Products : System.Web.UI.Page
{
    KavsitWeb KavsitWeb = new KavsitWeb();
    protected void Page_Load(object sender, EventArgs e)
    {
        
        Control productC = (Control)Page.LoadControl("UCs/Products/Products.ascx");
        phProducts.Controls.Add(productC);
    }
}