using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using KavsitWebLibrary;


public partial class Panel_news : System.Web.UI.Page
{
    LuffeyCMSDataContext dcx = new LuffeyCMSDataContext();

    protected void Page_Load(object sender, EventArgs e)
    {
        string edit = Request.QueryString["edit"];
        string del = Request.QueryString["del"];

        var query = from a in dcx.News orderby a.ID descending select a; ;

        newsgrid.DataSource = query;
        newsgrid.DataBind();


        if (del != null)
        {
            int deleteID = int.Parse(Request.QueryString["del"]);
            New n = dcx.News.SingleOrDefault(x => x.ID == deleteID);
            dcx.News.DeleteOnSubmit(n);
            dcx.SubmitChanges();
            Response.Redirect("news.aspx");

        }
        if (edit != null)
        {
            
            Response.Redirect("newsEdit.aspx?edit=" + edit);
        }

    }
}