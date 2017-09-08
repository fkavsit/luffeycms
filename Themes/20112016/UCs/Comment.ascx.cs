using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using KavsitWebLibrary;

public partial class Theme_UCs_Comment : System.Web.UI.UserControl
{
    KavsitWeb KavsitWeb = new KavsitWeb();
    LuffeyCMSDataContext dcx = new LuffeyCMSDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {

        var query = from a in dcx.News
                    where a.ID == int.Parse(Page.RouteData.Values["ID"] as string)
                    select a.ShowComment;
        if (query.Count() == 1)
        {
            string NewsID = Page.RouteData.Values["ID"] as string;
            var GetCommentQuery = from c in dcx.NewsComments
                                  where c.ID == int.Parse(NewsID)
                                  select c;
            rptr_comments.DataSource = GetCommentQuery;
            rptr_comments.DataBind();
        }
        else
        {
            panel_Comment.Visible = false;
            no_comment.Visible = true;
        }


    }

    protected void btn_comment_Click(object sender, EventArgs e)
    {
        string Name = txtName.Text;
        string Comment = txtComment.Text;
        string NewsID = Page.RouteData.Values["ID"] as string;
        string Date = DateTime.Now.ToShortDateString();

        NewsComment nc = new NewsComment()
        {
            Name = Name,
            Description = Comment,
            NewsID = int.Parse(NewsID)
        };
        dcx.NewsComments.InsertOnSubmit(nc);
        dcx.SubmitChanges();
        Response.Redirect(Page.Request.Url.ToString(), true);

    }
}