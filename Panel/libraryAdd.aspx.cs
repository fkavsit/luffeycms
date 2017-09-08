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

public partial class Panel_libraryAdd : System.Web.UI.Page
{
    KavsitWeb KavsitWeb = new KavsitWeb();
    LuffeyCMSDataContext dcx = new LuffeyCMSDataContext();
    string yol;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {

        string rndsayi = KavsitWeb.CreateRandomPassword(7);
        string yukleme = Request.PhysicalApplicationPath + "Library/";
        if (FileUpload1.HasFile)
        {
            string extension = Path.GetExtension(FileUpload1.PostedFile.FileName);
            FileUpload1.SaveAs(yukleme + rndsayi + extension);
            yol = (rndsayi + extension).ToString();
        }
        Library lb = new Library() { Content = yol.ToString() };
        dcx.Libraries.InsertOnSubmit(lb);
        dcx.SubmitChanges();
        Response.Redirect("~/Panel/library.aspx");

    }

}