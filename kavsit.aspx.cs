using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;
using KavsitWebLibrary;

public partial class kavsit : System.Web.UI.Page
{
    LuffeyCMSDataContext dcx = new LuffeyCMSDataContext();
    
    KavsitWeb KavsitWeb = new KavsitWeb();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["ID"] != null)
        {
            Response.Redirect("~/Panel/kavsit.aspx");
        }
    }

    protected void btnGir_Click(object sender, EventArgs e)
    {
        string email = txtEmail.Text;
        string passwordMD = KavsitWeb.CreateMD5Hash(txtsifre.Text);

        var query = from a in dcx.Members where a.Email == email && a.Password == passwordMD select a;
        if (query.Count() == 1)
        {
            var user = query.SingleOrDefault();
            Session["Ad"] = user.Name;
            Session["ID"] = user.ID;
            Session["Authority"] = user.MemberType.Title;
            Response.Redirect("~/Panel/kavsit.aspx");
        }
        else
        {
            Label1.Text = "Giriş Başarısız...";
        }

       
    }
}