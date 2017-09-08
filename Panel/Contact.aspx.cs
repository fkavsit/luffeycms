using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using KavsitWebLibrary;
using System.Text;

public partial class Panel_contactUs : System.Web.UI.Page
{
    //KavsitWeb KavsitWeb = new KavsitWeb();
    LuffeyCMSDataContext dcx = new LuffeyCMSDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        var query = from a in dcx.Contacts select a;
        contactgrid.DataSource = query;
        contactgrid.DataBind();


        int q = Convert.ToInt16(Request.QueryString["q"]);

        if (q != 0)
        {
            Contact c = new Contact();
            c = dcx.Contacts.SingleOrDefault(u => u.ID == q);
            dcx.Contacts.DeleteOnSubmit(c);
            dcx.SubmitChanges();

            Response.Redirect("contactUs.aspx");

        }
        else
        {
            
        }
    }
    [System.Web.Services.WebMethod]
    public static string DeleteContactItems(string secililer)
    {
        
        KavsitWeb KavsitWeb = new KavsitWeb();
        KavsitWeb.Query("delete from Contact where ID IN(" + secililer + ")");
       
        return "<div class='alert alert-success' role='alert'>Silme İşlemi Başarılı.</div>";

    }
    //Yapım Aşamasında
    [System.Web.Services.WebMethod]
    public static string SearchContact(string aranacak)
    {
        StringBuilder sb = new StringBuilder();
        //LuffeyCMSDataContext dcx = new LuffeyCMSDataContext();
        //var Search = from a in dcx.Contacts.Where(x => x.Name.Contains(aranacak)) select a;
        
        //foreach (var item in Search)
        //{
            
        //    sb.Append("<td>");
        //    sb.Append("<input type='checkbox' class='chckItem' value="+item.ID+" v-model='checkedNames' />");
        //    sb.Append("</td>");
        //    sb.Append("<td class='mailbox-star'><a href='#'><i class='fa fa-star text-yellow'></i></a></td>");
        //    sb.Append("<td class='mailbox-name'><a href='read-mail.html'>"+item.Name+"</a></td>");
        //    sb.Append("<td class='mailbox-subject'>" + item.Summary + " </td>");
        //    sb.Append("<td class='mailbox-date2>"+item.Date+"</td>");
        //    sb.Append("</td>");
            
           
        //}

        return sb.ToString();

    }

   
}