using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;
using KavsitWebLibrary;

public partial class Theme_UCs_Paging : System.Web.UI.UserControl
{
    KavsitWeb KavsitWeb = new KavsitWeb();
    LuffeyCMSDataContext dcx = new LuffeyCMSDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        //if (!Page.IsPostBack)
        //{
        //    string qq = Request.QueryString["page"];

        //KavsitWeb.Paging("News","http://localhost:37390/LuffeyCMS/Theme/News.aspx", qq, rptr_paging, 7, paging);
        //}


        //int PageSize = 4;
        var query = from a in dcx.News select a;        
        //PagedDataSource pds = new PagedDataSource();
        //pds.DataSource = query;
        //pds.AllowPaging = true;
        //pds.PageSize = PageSize;
        //int currentPage;
        //string q = Request.QueryString["page"];

        //if (q != null)
        //    currentPage = int.Parse(q);        
        //else
        //    currentPage = 1;
       
        //pds.CurrentPageIndex = currentPage - 1;

        //int sonuc = query.Count() / PageSize;

        //for (int i = 1; i <= sonuc; i++)
        //{
        //    paging.InnerHtml += "<a class='pagination' href='?page=" + i + "'" + ">" + "" + i + "</a>";

        //}

        rptr_paging.DataSource = query;
        rptr_paging.DataBind();
        


    }
    protected string WriteUrl(string haberID, string haberBaslik)
    {
        string tempUrl = UrlSeo(haberBaslik);
        return Page.GetRouteUrl("NewsDetail", new { ID = haberID, NewTitle = tempUrl });

    }

    public static string UrlSeo(string Metin)
    {
        string deger = Metin;
        deger = deger.Trim();
        deger = deger.ToLower();
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
