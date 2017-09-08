using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using KavsitWebLibrary;

public partial class Panel_menuEdit : System.Web.UI.Page
{
    LuffeyCMSDataContext dcx = new LuffeyCMSDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            int edit = int.Parse(Request.QueryString["edit"]);
            var query = from a in dcx.Menus where a.ID == edit select a;
            foreach (var item in query)
            {
                txtBaslik.Text = item.Title;
                txtLink.Text = item.Link;
                txtMenuSira.Text = item.Queue.ToString();
            }
        }
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        int id = Convert.ToInt16(Request.QueryString["edit"]);
        Menu m = dcx.Menus.SingleOrDefault(x => x.ID == id);
        m.Title = txtBaslik.Text;
        m.Link = txtLink.Text;
        m.Queue = int.Parse(txtMenuSira.Text);

        dcx.SubmitChanges();
        Response.Redirect("~/Panel/menus.aspx");

    }
}