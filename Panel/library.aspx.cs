using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;
using System.Web.Configuration;
using System.Data.SqlClient;
using KavsitWebLibrary;

public partial class Panel_library : System.Web.UI.Page
{
    KavsitWeb KavsitWeb = new KavsitWeb();
    LuffeyCMSDataContext dcx = new LuffeyCMSDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
       
        Session["url"] = Request.Url.Authority;



        var query = from a in dcx.Libraries select a;
        librarygrid.DataSource = query;
        librarygrid.DataBind();

        string q = Request.QueryString["q"];
        //  Response.Write("<script>alert("+q+"); </script>");
      	if(q!=null){

            
                string bag_str = WebConfigurationManager.ConnectionStrings["baglanti"].ConnectionString;
                SqlConnection baglanti = new SqlConnection(bag_str);
                baglanti.Open();
                SqlCommand sorgum = new SqlCommand("select libraryContent from library where ID="+q.ToString(), baglanti);
                SqlDataReader dr = sorgum.ExecuteReader();
                if (dr.Read())
                {
                    string Yol = dr["libraryContent"].ToString();
                    File.Delete(Request.PhysicalApplicationPath + "Library/" + Yol);
                KavsitWeb.Query("delete from library where ID=" + q);
                    Response.Redirect("library.aspx");
                    
                    _success.Visible = true;
                }
                else
                {
                    _error.Visible = true;
                }
            
           
            

           

      }
    }
}