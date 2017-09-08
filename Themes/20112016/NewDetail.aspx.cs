using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using KavsitWebLibrary;

public partial class site1_Theme_NewDetail : System.Web.UI.Page
{
    KavsitWeb KavsitWeb = new KavsitWeb();
    protected void Page_Load(object sender, EventArgs e)
    {
        
         Control newsUC2 = (Control)Page.LoadControl("UCs/New_Detail.ascx");
         ph_New_Detail.Controls.Add(newsUC2);
         Control CommentUC = (Control)Page.LoadControl("UCs/Comment.ascx");
         ph_Comment.Controls.Add(CommentUC);




    }
}