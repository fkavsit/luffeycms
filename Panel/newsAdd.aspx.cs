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
using KavsitWebLibrary;
using System.Text;

public partial class Panel_newsAdd : System.Web.UI.Page
{
    string path;
    KavsitWeb KavsitWeb = new KavsitWeb();
    LuffeyCMSDataContext dcx = new LuffeyCMSDataContext();


    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            var query = from a in dcx.News_Categories select a;
            dropdown_category.DataSource = query;
            dropdown_category.DataTextField = "Title";
            dropdown_category.DataValueField = "ID";
            dropdown_category.DataBind(); 
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string rndsayi = KavsitWeb.CreateRandomPassword(7);
        string yukleme = Request.PhysicalApplicationPath + "Images/newsImage/";

        if (FileUpload1.HasFile)
        {
            string extension = Path.GetExtension(FileUpload1.PostedFile.FileName);
            FileUpload1.SaveAs(yukleme + rndsayi + extension);
            path = (rndsayi + extension).ToString();
        }

        New n = new New()
             {
                 Title = txtBaslik.Text,
                 Content = CKEditor1.Text,
                 Summary = txtOzet.Text,
                 Image = path.ToString(),
                 ShowComment = chk_comment.Checked,
                 //CatagoryID = dropdown_category.SelectedIndex

             };
        dcx.News.InsertOnSubmit(n);
        dcx.SubmitChanges();



    }
   
}