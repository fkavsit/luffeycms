using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Web.Configuration;
using System.Data.SqlClient;
using System.Data;
using KavsitWebLibrary;
using System.Text;
using System.Configuration;


public partial class Panel_Settings : System.Web.UI.Page
{
    public KavsitWeb KavsitWeb = new KavsitWeb();
    LuffeyCMSDataContext dcx = new LuffeyCMSDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        string _ThemeID = Request.QueryString["theme"];
        if (_ThemeID != null)
        {

            try
            {

                Configuration config = WebConfigurationManager.OpenWebConfiguration("/");
                string oldValue = config.AppSettings.Settings["ThemeName"].Value;
                config.AppSettings.Settings["ThemeName"].Value = _ThemeID;
                config.Save(ConfigurationSaveMode.Modified);

                success.Visible = true;
            }
            catch (Exception)
            {
                success.Visible = false;
                error.Visible = true;
            }
        }


        if (!Page.IsPostBack)
        {
            var seo = from a in dcx.Seos select a;
            foreach (var item in seo)
            {
                txt_seo_title.Text = item.Title;
                txt_seo_keywords.Text = item.MetaKeys;
                txt_seo_meta.Text = item.Meta;
            }

            var company = from b in dcx.Companies select b;
            foreach (var item in company)
            {
                txt_CompanyName.Text = item.Name;
                txt_CompanyInfo.Text = item.Information;
                txt_CompanyPhone.Text = item.Phone;
                tx_CompanyEmail.Text = item.Email;
                txt_CompanyFax.Text = item.Fax;
            }

            var mail = from c in dcx.Mails select c;
            foreach (var item in mail)
            {
                txt_mail_email.Text = item.Email;
                txt_smtp_port.Text = item.SMTP_Port.ToString();
                txt_smtp_host.Text = item.SMTP_Host;
                chck_ssl.Checked = item.Enable_SSL;
                chck_enable.Checked = (bool)item.Enable;
            }
        }
    }

    protected void btn_design_Click(object sender, EventArgs e)
    {

        if (fup_logo.HasFile)
        {
            string yukleme = Request.PhysicalApplicationPath + "Items/Logo/";
            string extension = Path.GetExtension(fup_logo.PostedFile.FileName);
            fup_logo.SaveAs(yukleme + "logo" + extension);
        }

        if (fup_fav.HasFile)
        {
            string yukleme = Request.PhysicalApplicationPath + "Items/Favicon/";
            string extension = Path.GetExtension(fup_fav.PostedFile.FileName);
            fup_fav.SaveAs(yukleme + "favicon" + extension);
        }
    }

    protected void btn_seo_Click(object sender, EventArgs e)
    {
        Seo s = new Seo()
        {
            Title = txt_seo_title.Text,
            Meta = txt_seo_meta.Text,
            MetaKeys = txt_seo_keywords.Text
        };
        dcx.Seos.InsertOnSubmit(s);
        dcx.SubmitChanges();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Company c = new Company()
        {
            Name = txt_CompanyName.Text,
            Information = txt_CompanyInfo.Text,
            Phone = txt_CompanyPhone.Text,
            Email = tx_CompanyEmail.Text,
            Fax = txt_CompanyFax.Text
        };
        dcx.Companies.InsertOnSubmit(c);
        dcx.SubmitChanges();
    }
    protected void btn_mail_Click(object sender, EventArgs e)
    {
        Mail m = new Mail()
        {
            Enable = chck_enable.Checked,
            Email = txt_mail_email.Text,
            Password = txt_mail_password.Text,
            SMTP_Port = int.Parse(txt_smtp_port.Text),
            SMTP_Host = txt_smtp_host.Text,
            Enable_SSL = chck_ssl.Checked,
        };
        dcx.Mails.InsertOnSubmit(m);
        dcx.SubmitChanges();
    }

    #region Dahili Bağlantı Listeleme Fonksiyonu

    public string ThemeList()
    {

        //Dahili Bağlantı Yolları Listeleme
        string[] filePaths = Directory.GetDirectories(Server.MapPath("~/Themes/"));
        StringBuilder sb = new StringBuilder();
        //List<ListItem> files = new List<ListItem>();
        foreach (string filePath in filePaths)
        {
           
            sb.Append(" <div class='col-sm-6 col-md-3' style='width: 220px'>");
            
            sb.Append("<div class='thumbnail'>");
            sb.Append(String.Format("<img src='{0}'/>", ".." + KavsitWeb.ThemePath + "themeimage.jpg"));
            sb.Append(" <div class='caption'>");
            if (WebConfigurationManager.AppSettings["ThemeName"] == Path.GetFileName(filePath))
            {
                sb.Append("<p class='selectedTheme'>Selected</p>");
            }
            sb.Append("<h3>" + Path.GetFileName(filePath) + "</h3>");
            sb.Append(String.Format("<p><a href='Settings.aspx?theme={0}' class='btn btn-primary btn-block' role='button'>Değiştir</a></p>", Path.GetFileName(filePath)));
            sb.Append(" </div>");
            sb.Append(" </div>");
            sb.Append(" </div>");


        }
        return sb.ToString();

    }
    #endregion
    protected void btn_developkey_Click(object sender, EventArgs e)
    {
        TextBox tx = panelDevelop.FindControl("txtdevelopmentkey") as TextBox;
        if (tx.Text == "19A2E784-31E7-49C7-9640-961897B6378C")
        {
            panelDevelop.Visible = false;
            panelDevelopSettings.Visible = true;   
        }
    }
    protected void deleteCache_Click(object sender, EventArgs e)
    {
        foreach (System.Collections.DictionaryEntry entry in HttpContext.Current.Cache)
        {
            HttpContext.Current.Cache.Remove((string)entry.Key);
        }
    }
    protected void btn_sqlExecute_Click(object sender, EventArgs e)
    {
        TextBox sql = panelDevelopSettings.FindControl("txt_sqlQuery") as TextBox;
        KavsitWeb.Query(sql.Text);
    }
}