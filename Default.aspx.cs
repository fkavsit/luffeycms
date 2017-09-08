using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using KavsitWebLibrary;
public partial class _Default : System.Web.UI.Page
{
    KavsitWeb kw = new KavsitWeb();
    protected void Page_Load(object sender, EventArgs e)
    {
        
        Control sliderUC = (Control)Page.LoadControl(kw.ThemePath+"UCs/Slider.ascx");
        phSlider.Controls.Add(sliderUC);

        Control newsUC = (Control)Page.LoadControl(kw.ThemePath + "UCs/HomepageNews.ascx");
        ph_Default_News.Controls.Add(newsUC);
    }
    
    
}