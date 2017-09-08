using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using KavsitWebLibrary;

public partial class Theme_Activation : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        KavsitWeb KavsitWeb = new KavsitWeb();
        
        if (!Page.IsPostBack)
        {
            string ActivationKey = Request.QueryString["key"];
            int Result = KavsitWeb.Query("update Members SET memberActivated='True' where memberActivationKey='" + ActivationKey + "'");
            if (Result==1)
            {
                KavsitWeb.Query("update Members SET memberActivationKey='' where memberActivationKey='" + ActivationKey + "'");
                Response.Redirect("~/Theme/Login.aspx");
            }
            else
            {
                error.Text = "Hata";

            }
        }
    }
}