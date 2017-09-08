using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Collections.Specialized;
using System.Text;
using KavsitWebLibrary;

public partial class Panel_catagorys : System.Web.UI.Page
{
    KavsitWeb KavsitWeb = new KavsitWeb();
    LuffeyCMSDataContext dcx = new LuffeyCMSDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        var query = from a in dcx.News_Categories select a;

        membersgrid.DataSource = query;
        membersgrid.DataBind();
        int q = Convert.ToInt16(Request.QueryString["q"]);

        if (q != 0)
        {
            KavsitWeb.Query("delete from catagory where ID=" + q);
            Response.Redirect("catagorys.aspx");

        }
    }


    protected void btnSil_Click(object sender, EventArgs e)
    {
        for (int i = 0; i < membersgrid.Items.Count; i++)
        {
            CheckBox ck = ((CheckBox)membersgrid.Items[i].FindControl("chck"));
            if (ck.Checked == true)
            {
                Response.Redirect("aa");
            }
        }
    }
}
