using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using KavsitWebLibrary;

public partial class Panel_Page_Pages : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        LuffeyCMSDataContext dcx = new LuffeyCMSDataContext();        
        string q = Request.QueryString["q"];
        string del = Request.QueryString["del"];
        if (q!=null) {
            var Search = from a in dcx.Pages.Where(x=>x.Title.Contains(q)) select a;

            rptr_pages.DataSource = Search;
            rptr_pages.DataBind();
        }
        else {
            var SelectAll = from a in dcx.Pages select a;
            rptr_pages.DataSource = SelectAll;
            rptr_pages.DataBind();
        }
        if (del != null)
        {
            
            Page p = dcx.Pages.SingleOrDefault(x=>x.ID==int.Parse(del));
            dcx.Pages.DeleteOnSubmit(p);
            dcx.SubmitChanges();
            Response.Redirect("Pages.aspx");

        }


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
    protected void btn_search_Click(object sender, EventArgs e) {
        string search = txtSearch.Text;
        Response.Redirect("Pages.aspx?q="+search);
    }
}