using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using KavsitWebLibrary;

public partial class Panel_Page_PageAdd : System.Web.UI.Page
{
    LuffeyCMSDataContext dcx = new LuffeyCMSDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        Page p = new Page()
        {
            Title      = txtBaslik.Text,
            Content    = CKEditor1.Text,
            SeoTitle   = txtseo.Text,
            SeoMeta    = txtMeta.Text,
            SeoMetaKey = txtMetaKeywords.Text
        };

        dcx.Pages.InsertOnSubmit(p);
        dcx.SubmitChanges();
        success.Visible = true;



    }
}