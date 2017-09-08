using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using KavsitWebLibrary;
using System.Data.SqlClient;
using System.Web.Configuration;

public partial class Theme_UCs_Login : System.Web.UI.UserControl
{
    KavsitWeb KavsitWeb = new KavsitWeb();
    LuffeyCMSDataContext dcx = new LuffeyCMSDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void login_Click(object sender, EventArgs e)
    {
        string UserName = txtUser.Text;
        string Password = KavsitWeb.CreateMD5Hash(txtPass.Text);



        try
        {
            string bag_str = WebConfigurationManager.ConnectionStrings["baglanti"].ConnectionString;
            SqlConnection baglanti = new SqlConnection(bag_str);
            baglanti.Open();

            SqlCommand sorgu = new SqlCommand("select ID,memberName,memberActivated,memberEmail,memberUserName,memberPassword from Members WHERE ((memberUserName=@username OR memberEmail=@email) AND memberPassword=@password) AND memberActivated='True';", baglanti);

            sorgu.Parameters.AddWithValue("@username", txtUser.Text);
            sorgu.Parameters.AddWithValue("@email", txtUser.Text);
            sorgu.Parameters.AddWithValue("@password", Password);
            SqlDataReader dr = sorgu.ExecuteReader();
            if (dr.Read())
            {
                Session["ID"] = dr["ID"].ToString();
                Session["username"] = dr["memberName"].ToString();
                KavsitWeb.Query("update Members SET memberOnline='True' where ID=" + Session["ID"]);
                Response.Redirect("~/Theme/Profile.aspx");
            }
        }
        catch (Exception ex)
        {

            error.Text = ex.Message;
        }
        


    }
}