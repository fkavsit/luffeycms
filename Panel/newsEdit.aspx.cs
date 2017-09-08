using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using KavsitWebLibrary;

public partial class Panel_newsEdit : System.Web.UI.Page
{

    LuffeyCMSDataContext dcx = new LuffeyCMSDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            string qString = Request.QueryString["edit"];
            var query = from a in dcx.News where a.ID == int.Parse(qString) select a;
            foreach (var item in query)
            {
                txtBaslik.Text = item.Title;
                txtOzet.Text = item.Summary;
                CKEditor1.Text = item.Content;
                chc_comment.Checked = (bool)item.ShowComment;
            }

        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        int qString = int.Parse(Request.QueryString["edit"]);

        New n = dcx.News.SingleOrDefault(x => x.ID == qString);
        n.Title = txtBaslik.Text;
        n.Content = CKEditor1.Text;
        n.Summary = txtOzet.Text;

        dcx.SubmitChanges();






    }
}