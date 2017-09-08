using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using KavsitWebLibrary;

public partial class Error : System.Web.UI.Page
{
    KavsitWeb KavsitWeb = new KavsitWeb();
    
    protected void Page_Load(object sender, EventArgs e)
    {
        
        //Page.MasterPageFile = "~" + KavsitWeb.ThemePath+"Master.master";
        string hata = Request.QueryString["hata"];
        lblHata.Text = hata;
    }
}