using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using KavsitWebLibrary;
using System.IO;
public partial class Panel_sliders : System.Web.UI.Page
{
    string yol;
    KavsitWeb KavsitWeb = new KavsitWeb();
    LuffeyCMSDataContext dcx = new LuffeyCMSDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        var query = from a in dcx.Sliders orderby a.Queue ascending select a;
        slidersgrid.DataSource = query;
        slidersgrid.DataBind();

        string q = Request.QueryString["q"];
        
        if (q != null)
        {
            Slider s = dcx.Sliders.SingleOrDefault(x => x.ID == int.Parse(q));
            dcx.Sliders.DeleteOnSubmit(s);
            dcx.SubmitChanges();
            File.Delete(Request.PhysicalApplicationPath + "Images/slider/" + s.Image);
            Response.Redirect("sliders.aspx");

        }
    }
    protected void btnSave_Click(object sender, EventArgs e)
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
            Queue = int.Parse(txtSliderSira.Text),
            Text = txtIcerik.Text

        };
        dcx.Sliders.InsertOnSubmit(s);
        dcx.SubmitChanges();
        success.Visible = true;
        var query = from a in dcx.Sliders orderby a.Queue ascending select a;
        slidersgrid.DataSource = query;
        slidersgrid.DataBind();
    }
}