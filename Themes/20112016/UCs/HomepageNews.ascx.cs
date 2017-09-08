using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using KavsitWebLibrary;
public partial class Theme_UCs_News : System.Web.UI.UserControl
{
    LuffeyCMSDataContext dcx = new LuffeyCMSDataContext();

    protected void Page_Load(object sender, EventArgs e)
    {
        var query =     from a 
                        in dcx.News.Take(10) 
                        orderby a.ID 
                        descending select a;
        rptr_news.DataSource = query;
        rptr_news.DataBind();
        //DataRow dizi = KavsitWeb.DataRowGetir("select homepageNewsSize as newsCount from Settings_HomePage");


        //int HomePageNewsCount = Convert.ToInt32(dizi["newsCount"]); 

        
        //DataTable dt = KavsitWeb.Query("select TOP "+HomePageNewsCount+" * from news ORDER BY ID DESC");
        //rptr_news.DataSource = dt;
        //rptr_news.DataBind();
        
    }

    protected string WriteUrl(string haberID,string haberBaslik) {
        string tempUrl = UrlSeo(haberBaslik);
       return Page.GetRouteUrl("NewsDetail", new { ID = haberID, NewTitle = tempUrl });

    }

    public static string UrlSeo(string Metin) {
        string deger = Metin;
        deger = deger.Replace("'", "");
        deger = deger.Replace(".", "");
        deger = deger.Replace(",", "");
        deger = deger.Replace(" ", "-");
        deger = deger.Replace("<", "-");
        deger = deger.Replace(">", "-");
        deger = deger.Replace("&", "-");
        deger = deger.Replace("[", "-");
        deger = deger.Replace("!", "");
        deger = deger.Replace("?", "");
        deger = deger.Replace("]", "-");
        deger = deger.Replace("ı", "i");
        deger = deger.Replace("ö", "o");
        deger = deger.Replace("ü", "u");
        deger = deger.Replace("ş", "s");
        deger = deger.Replace("ç", "c");
        deger = deger.Replace("ğ", "g");
        deger = deger.Replace("İ", "i");
        deger = deger.Replace("Ö", "o");
        deger = deger.Replace("Ü", "u");
        deger = deger.Replace("Ş", "s");
        deger = deger.Replace("Ç", "c");
        deger = deger.Replace("Ğ", "g");

        return deger;
    }
}
