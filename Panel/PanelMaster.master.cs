using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using KavsitWebLibrary;


public partial class Panel_PanelMaster : System.Web.UI.MasterPage
{
    LuffeyCMSDataContext dcx = new LuffeyCMSDataContext();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["ID"] == null)
        {
            Response.Redirect("~/kavsit.aspx");
        }
        else
        {
  
           
        }
        
        var query = from a in dcx.Contacts select a;
        int contactItem = (int)query.Count();
        headerMessageCount.Text = contactItem.ToString();
        lblCountMessage.Text = contactItem.ToString();

        var messages = from b in dcx.Contacts.Take(5) select b;

        rptr_message.DataSource = messages;
        rptr_message.DataBind();

        //DataRow dizi = KavsitWeb.DataRowGetir("select COUNT(*) as sayi from contact");
        //lblCountMessage.Text = dizi["sayi"].ToString();
        //headerMessageCount.Text = dizi["sayi"].ToString();
        //_headerMessageCount.Text = dizi["sayi"].ToString();


        //DataTable dt = KavsitWeb.Query("Select TOP 5 * From contact ORDER BY ID DESC");
        //rptr_message.DataSource = dt;
        //rptr_message.DataBind();
      
    }
    protected void btn_abandon_Click(object sender, EventArgs e)
    {

        Session.Abandon();
        Response.Redirect("~/Default.aspx");
       
    }
}
