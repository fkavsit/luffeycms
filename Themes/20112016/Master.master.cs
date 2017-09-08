using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;
using KavsitWebLibrary;
using System.Web.Configuration;

public partial class Master : System.Web.UI.MasterPage
{

    public KavsitWeb KavsitWeb = new KavsitWeb();
    LuffeyCMSDataContext dcx = new LuffeyCMSDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
    }

    public string GetMenu()
    {
        var query = from a in dcx.Menus
                    orderby a.Queue
                    ascending
                    select a;

        StringBuilder sb = new StringBuilder();
        //Static Pages
        sb.Append("<li>");
        sb.Append("<a href='http://" + Request.Url.Authority + "/Theme/Default.aspx'>");
        sb.Append("Anasayfa");
        sb.Append("</a>");
        sb.Append("</li>");

        sb.Append("<li>");
        sb.Append("<a href='/Theme/contact.aspx'>");
        sb.Append("Hakkımızda");
        sb.Append("</a>");
        sb.Append("</li>");

        foreach (var item in query)
        {
            sb.Append("<li>");
            sb.Append("<a href='http://" + item.Link + "'>");
            sb.Append(item.Title);
            sb.Append("</a>");
            sb.Append("</li>");
        }
        return sb.ToString();


    }
    public static string ThemePath
    {
        get { return "/Themes/" + WebConfigurationManager.AppSettings["ThemeName"] + "/"; }
    }


}
