using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using KavsitWebLibrary;

public partial class Theme_UCs_Register : System.Web.UI.UserControl
{
    KavsitWeb KavsitWeb = new KavsitWeb();
    LuffeyCMSDataContext dcx = new LuffeyCMSDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void bntRegister_Click(object sender, EventArgs e)
    {
        string ActivationKey = KavsitWeb.CreateRandomPassword(7);
        string Domain = Request.Url.Authority;
        string MD5pass = KavsitWeb.CreateMD5Hash(pass.Text);
        Member m = new Member()
        {
            Name = name.Text,
            Surname = sur.Text,
            Email = mail.Text,
            UserName = user.Text,
            Password = MD5pass,
            ActivationKey = ActivationKey
        };
        dcx.Members.InsertOnSubmit(m);
        dcx.SubmitChanges();
        success.Visible = true; 
       
        try
        {
            KavsitWeb.SendMail(mail.Text, KavsitWeb.Company("companyName") + " Aktivasyon Kodu", "<a href='http://" + Domain + "/Theme/Activation.aspx?key="+ ActivationKey + "'>Aktivasyon İçin Tıklayınız.<a>");
        }
        catch (Exception ex)
        {

            lblerror.Text = ex.Message;
        }

    }
}