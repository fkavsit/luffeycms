using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using d = System.Drawing;
public partial class Panel_ProductAdd : System.Web.UI.Page
{
    LuffeyCMSDataContext dcx = new LuffeyCMSDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btn_save_Click(object sender, EventArgs e)
    {
        Product pr = new Product 
        {
        Title = txt_product_title.Text,
        Code = txt_product_code.Text,
        Content = CKEditor1.Text,
        Price = int.Parse(txt_product_price.Text),
        Date = DateTime.Now
        };
        dcx.Products.InsertOnSubmit(pr);
        dcx.SubmitChanges();

        IList<HttpPostedFile> SecilenDosyalar = uploadImages.PostedFiles;
        for (int i = 0; i < SecilenDosyalar.Count; i++)
        {
            d.Image orjinalImage = d.Bitmap.FromStream(uploadImages.PostedFiles[i].InputStream);
            string photoName = uploadImages.PostedFiles[i].FileName;
            string newName=pr.Title+Guid.NewGuid()+Path.GetExtension(photoName);
            string sPath = "/Images/ProductImage/_s/" + newName;
            string mPath = "/Images/ProductImage/_m/" + newName;
            string lPath = "/Images/ProductImage/_l/" + newName;

            int swidth = int.Parse(ConfigurationManager.AppSettings["smallPhotoWidth"]);
            int sheight = int.Parse(ConfigurationManager.AppSettings["smallPhotoHeight"]);

            int mwidth = int.Parse(ConfigurationManager.AppSettings["mediumPhotoWidth"]);
            int mheight = int.Parse(ConfigurationManager.AppSettings["mediumPhotoHeight"]);

            int lwidth = int.Parse(ConfigurationManager.AppSettings["largePhotoWidth"]);
            int lheight = int.Parse(ConfigurationManager.AppSettings["largePhotoHeight"]);

            if (orjinalImage.Width>orjinalImage.Height)
            {
                sheight = sheight * orjinalImage.Width / swidth;
                mheight = mheight * orjinalImage.Width / mwidth;
                lheight = lheight * orjinalImage.Width / lwidth;
            }
            else
            {
                swidth = swidth * orjinalImage.Height / sheight;
                mwidth = mwidth * orjinalImage.Height / mheight;
                lwidth = lwidth * orjinalImage.Height / lheight;
            }
            d.Bitmap imageSmall = new d.Bitmap(orjinalImage,swidth,sheight);
            d.Bitmap imageMedium = new d.Bitmap(orjinalImage, mwidth, mheight);
            d.Bitmap imageLarge = new d.Bitmap(orjinalImage, lwidth, lheight);

            imageSmall.Save(Server.MapPath("~/"+sPath));
            imageMedium.Save(Server.MapPath("~/" + mPath));
            imageLarge.Save(Server.MapPath("~/" + lPath));

            ProductImage pi = new ProductImage 
            {
                SmallSize = sPath,
                MediumSize = mPath,
                LargeSize = lPath
            };
            dcx.ProductImages.InsertOnSubmit(pi);
            dcx.SubmitChanges();

            Product_ProductImage ppi = new Product_ProductImage
            {
               ProductID = pr.ID,
               ProductImageID = pi.ID
            };
            dcx.Product_ProductImages.InsertOnSubmit(ppi);
            dcx.SubmitChanges();
        }

        
    }
}