using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using KavsitWebLibrary;

public partial class Theme_Register : System.Web.UI.Page
{
    KavsitWeb KavsitWeb = new KavsitWeb();
    protected void Page_Load(object sender, EventArgs e)
    {
        
        Control regUC = (Control)Page.LoadControl("UCs/Register.ascx");
        phRegister.Controls.Add(regUC);
    }
}