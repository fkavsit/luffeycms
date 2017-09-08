using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using KavsitWebLibrary;

public partial class Panel_catagoryAdd : System.Web.UI.Page
{
    KavsitWeb KavsitWeb = new KavsitWeb();
    LuffeyCMSDataContext dcx = new LuffeyCMSDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        //if (!Page.IsPostBack)
        //{
        //    var categoryTypeQuery = from a in dcx.CategoryTypes select a;
            
        //    categoryType.DataSource = categoryTypeQuery;
        //    categoryType.DataTextField = "Title";
        //    categoryType.DataValueField = "ID";
        //    categoryType.DataBind();
        //}
    }


    //protected void categoryType_SelectedIndexChanged(object sender, EventArgs e)
    //{
    //    int category = int.Parse(categoryType.SelectedValue);
    //    var upCategory = from b in dcx.Categories.Where(x => x.ID == category) select b;

    //    TopCategory.DataSource = upCategory;
    //    TopCategory.DataTextField = "Title";
    //    TopCategory.DataValueField = "ID";
    //    TopCategory.DataBind();
    //}
    //protected void btnSave_Click(object sender, EventArgs e)
    //{
    //    Category c = new Category() 
    //    {
    //        Title = TextBox1.Text,
    //        CategoryTypeID = int.Parse(categoryType.SelectedValue),
    //        UpCategoryID = int.Parse(TopCategory.SelectedValue)

    //    };
    //    dcx.Categories.InsertOnSubmit(c);
    //    dcx.SubmitChanges();
    //}
}