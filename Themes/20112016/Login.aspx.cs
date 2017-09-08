using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using KavsitWebLibrary;
using System.Web.UI.WebControls;

public partial class Theme_Login : System.Web.UI.Page
{
    KavsitWeb KavsitWeb = new KavsitWeb();
    protected void Page_Load(object sender, EventArgs e)
    {
        
        Control loginUC = (Control)Page.LoadControl("UCs/Login.ascx");
        phLogin.Controls.Add(loginUC);
    }
}