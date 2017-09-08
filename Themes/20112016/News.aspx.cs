using KavsitWebLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Theme_News : System.Web.UI.Page
{
    KavsitWeb KavsitWeb = new KavsitWeb();
    protected void Page_Load(object sender, EventArgs e)
    {
        
        Label baslik = this.Master.FindControl("masterPageTitle") as Label;
        baslik.Text = "HABERLER";
        //Control haberler = (Control)Page.LoadControl("UCs/NewsPage.ascx");
        //ph_haberler.Controls.Add(haberler);
      

        //Control newsCategory = (Control)Page.LoadControl("UCs/NewsCategory.ascx");
        //ph_newsCategory.Controls.Add(newsCategory);
        Control pagingNews = (Control)Page.LoadControl("UCs/Paging.ascx");
        ph_Paging_News.Controls.Add(pagingNews);
    }
}