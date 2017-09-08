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
public partial class Panel_Default : System.Web.UI.Page
{
    string yol;
    KavsitWeb KavsitWeb = new KavsitWeb();
    LuffeyCMSDataContext dcx = new LuffeyCMSDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
       
        string rndsayi = KavsitWeb.CreateRandomPassword(7);        
        string yukleme = Request.PhysicalApplicationPath + "Images/slider/";

        if (FileUpload1.HasFile)
        {
            string extension = Path.GetExtension(FileUpload1.PostedFile.FileName);
            FileUpload1.SaveAs(yukleme + rndsayi + extension);
            yol = (rndsayi + extension).ToString();
        }
       

        Slider s = new Slider() 
        { 
            Image = yol,
            Queue = int.Parse(TextBox1.Text),
            Text  = TextBox2.Text

        };
        dcx.Sliders.InsertOnSubmit(s);
        dcx.SubmitChanges();
        success.Visible = true;
       
    }
}