using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;
using KavsitWebLibrary;
using System.Web.UI.HtmlControls;
using System.IO;

public partial class Panel_menus : System.Web.UI.Page
{
    KavsitWeb KavsitWeb = new KavsitWeb();
    LuffeyCMSDataContext dcx = new LuffeyCMSDataContext();

    protected void Page_Load(object sender, EventArgs e)
    {

        if (!Page.IsPostBack)
        {
            UstMenu();
            DahiliLink();
        }

        MenuListeleVeSil();



    }
    [System.Web.Services.WebMethod]
    public static string DeleteMenuItems(string secililer)
    {
        KavsitWeb KavsitWeb = new KavsitWeb();
        KavsitWeb.Query("delete from Menu where ID IN(" + secililer + ")");

        return "<div class='alert alert-success' role='alert'>Silme İşlemi Başarılı.</div>";

    }
    #region Kaydet Butonu
    protected void btnSave_Click(object sender, EventArgs e)
    {
        if (txtLink.Text == null)
        {
            Menu menu = new Menu()
            {
                Title = txtBaslik.Text,
                Link = DrpdDahili.SelectedValue,
                Queue = int.Parse(txtMenuSira.Text),
                UpMenuID = int.Parse(TopMenu.SelectedValue)
            };
            dcx.Menus.InsertOnSubmit(menu);
            dcx.SubmitChanges();
            success.Visible = true;
        }
        else
        {
            if (DrpdDahili.AutoPostBack)
            {
                //Menu menu = new Menu()
                //{
                //    Title = txtBaslik.Text,
                //    Link = DrpdDahili.SelectedValue,
                //    Queue = int.Parse(txtMenuSira.Text),
                //    UpMenuID = int.Parse(TopMenu.SelectedValue)
                //};
                Menu menu = new Menu();
                menu.Title = txtBaslik.Text;
                menu.Link = DrpdDahili.SelectedValue;
                menu.Queue = int.Parse(txtMenuSira.Text);
                //menu.UpMenuID = int.Parse(TopMenu.SelectedValue);

                dcx.Menus.InsertOnSubmit(menu);
                dcx.SubmitChanges();
                success.Visible = true;
            }

        }


    }
    #endregion Kaydet

    #region Dahili Bağlantı Listeleme Fonksiyonu

    public void DahiliLink()
    {
        //Dahili Bağlantı Yolları Listeleme
        string[] filePaths = Directory.GetFiles(Server.MapPath("~" + KavsitWeb.ThemePath));
        List<ListItem> files = new List<ListItem>();
        foreach (string filePath in filePaths)
        {
            if (Path.GetExtension(filePath) != ".cs" && Path.GetExtension(filePath) != ".jpg" && Path.GetExtension(filePath) != ".master")
            {
                files.Add(new ListItem(@"\" + Path.GetFileName(filePath), filePath));
                DrpdDahili.DataSource = files;
                DrpdDahili.DataBind();
            }

        }
    }
    #endregion

    #region Üst Menü Listeleme Fonksiyonu
    public void UstMenu()
    {
        //Üst Menü Listeleme
        var q = from a in dcx.Menus select a;

        TopMenu.DataSource = q;
        TopMenu.DataTextField = "Title";
        TopMenu.DataValueField = "ID";
        TopMenu.DataBind();

    }
    #endregion

    #region Menu Silme Fonksiyonu
    public void MenuListeleVeSil()
    {
        var query = from a in dcx.Menus select a;

        rptr_menu.DataSource = query;
        rptr_menu.DataBind();

        int del = Convert.ToInt16(Request.QueryString["del"]);
        if (del != 0)
        {
            Menu m = dcx.Menus.SingleOrDefault(x => x.ID == del);
            dcx.Menus.DeleteOnSubmit(m);
            dcx.SubmitChanges();
            Response.Redirect("menus.aspx");

        }

    }
    #endregion
}