using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using KavsitWebLibrary;

public partial class Theme_UCs_Slider : System.Web.UI.UserControl
{
    //KavsitWeb KavsitWeb = new KavsitWeb();
    LuffeyCMSDataContext dcx = new LuffeyCMSDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {

        var query = from a in dcx.Sliders
                    orderby a.Queue
                    descending
                    select a;
        if (query.Count() != 0)
        {
            rptr_slider.DataSource = query;
            rptr_slider.DataBind();
        }

        else
        {
            
        }

        //DataTable dt = KavsitWeb.Query("Select * From slider order by sliderSira ASC");
        //rptr_slider.DataSource = dt;
        //rptr_slider.DataBind();
    }
}