using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using KavsitWebLibrary;
public partial class Panel_sliders : System.Web.UI.Page
{
    LuffeyCMSDataContext dcx = new LuffeyCMSDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        var query = from a in dcx.Sliders select a;
        slidersgrid.DataSource = query;
        slidersgrid.DataBind();

        string q = Request.QueryString["q"];
        
        if (q != null)
        {
            Slider s = dcx.Sliders.SingleOrDefault(x => x.ID == int.Parse(q));
            dcx.Sliders.DeleteOnSubmit(s);
            dcx.SubmitChanges();
            Response.Redirect("sliders.aspx");

        }
    }
}