using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using KavsitWebLibrary;


public partial class _Default : System.Web.UI.Page
{


    public KavsitWeb KavsitWeb = new KavsitWeb();
    LuffeyCMSDataContext dcx = new LuffeyCMSDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        Page.MasterPageFile = "~"+KavsitWeb.ThemePath;
        var query = from a in dcx.Seos select a;
        var result = query.SingleOrDefault();

        Page.Title = result.Title;
        Page.MetaDescription = result.Meta;
        Page.MetaKeywords = result.MetaKeys;

        

        Control sliderUC = (Control)Page.LoadControl("UCs/Slider.ascx");
        phSlider.Controls.Add(sliderUC);

        Control newsUC = (Control)Page.LoadControl("UCs/HomepageNews.ascx");
        ph_Default_News.Controls.Add(newsUC);
    }
    //public string Company(string Deger)
    //{
    //    StringBuilder sb = new StringBuilder();
    //    DataTable dt = KavsitWeb.Query("select * from Company");


    //    string deger = Deger;
    //    for (int i = 0; i < 1; i++)
    //    {

    //       sb.Append(deger = dt.Rows[i][deger].ToString());


    //    }


    //    return sb.ToString();
    //}
}