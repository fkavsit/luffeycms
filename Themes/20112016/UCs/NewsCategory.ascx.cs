using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using KavsitWebLibrary;
using System.Text;
using System.Web.Routing;
using System.Configuration;
public partial class Theme_UCs_NewsCategory : System.Web.UI.UserControl
{
    KavsitWeb KavsitWeb = new KavsitWeb();
    protected void Page_Load(object sender, EventArgs e)
    {

        //int haberid =Convert.ToInt16(Page.RouteData.Values["CategoryID"]);

        DataTable dt = KavsitWeb.GetDataQuery("select * from Category");
        rptr_newCategorys.DataSource = dt;
        rptr_newCategorys.DataBind();
 

    }


    //public string Sub_Categories(int a)
    //{
    //    //string CategoryID = Page.RouteData.Values["CategoryID"] as string;
    //    StringBuilder sb = new StringBuilder();

    //    DataTable dt = KavsitWeb.veriCek("SELECT Sub_Category.catagoryName as AltKategori,catagory.catagoryName as ÜstKategori,Sub_Category.ID as kategoriID	 from Sub_Category Inner Join catagory on Sub_Category.upcatagory=catagory.ID where upcatagory="+a);
    //    //Categories();
        
    //    for (int i = 0; i < dt.Rows.Count; i++) {
    //        sb.Append("<li>");
    //        //sb.Append(Categories());
    //        sb.Append("<a href='news.aspx?Subcategory=" + dt.Rows[i]["kategoriID"] + "'>");
    //        sb.Append(dt.Rows[i]["AltKategori"]);
    //        sb.Append("</a>");
    //        sb.Append("</li>");
    //    }
        


    //    return sb.ToString();
    //}
    protected string WriteUrl(string categoryID, string categoryTitle)
    {
        string tempUrl = UrlSeo(categoryTitle);
        return Page.GetRouteUrl("Category", new { ID = categoryID, NewTitle = tempUrl });

    }

    public static string UrlSeo(string Metin)
    {
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