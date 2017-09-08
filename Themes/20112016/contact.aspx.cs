using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.IO;
using System.Net.Mail;
using System.Net;
using KavsitWebLibrary;

public partial class contact : System.Web.UI.Page
{
   public KavsitWeb KavsitWeb = new KavsitWeb();
   LuffeyCMSDataContext dcx = new LuffeyCMSDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        
        Label baslik = this.Master.FindControl("masterPageTitle") as Label;
        baslik.Text = "İLETİŞİM";
    }
    protected void btnClear_Click(object sender, EventArgs e)
    {
        txtAd.Text = "";
        txtEmail.Text = "";
        txtTel.Text = "";
        txtMesaj.Text = "";
    }
    protected void btnSend_Click(object sender, EventArgs e)
    {
        string ad = txtAd.Text;
        string email = txtEmail.Text;
        string tel = txtTel.Text;
        string mesaj = txtMesaj.Text;
        try
        {
            Contact c = new Contact
            {
                Email   = txtEmail.Text,
                Name    = txtAd.Text,
                Message = txtMesaj.Text,
                Phone   = txtTel.Text,
                Date    = DateTime.Now,
                Summary = txtKonu.Text
            };
            dcx.Contacts.InsertOnSubmit(c);
            dcx.SubmitChanges();
            KavsitWeb.SendMail("furkan.kavsit@gmail.com", "Blog İletişim Mesajı", "Gönderen Adı: "+ad+"<br />"+"Gönderen E-Posta: "+email+"<br />"+"Telefonu: "+tel+"<br />"+"Mesajı: "+mesaj+"");
            success.Visible = true;
            
        }
        catch (Exception a)
        {

            error.Visible = true;
            Response.Write(a.Message);
        }
        
    }
}