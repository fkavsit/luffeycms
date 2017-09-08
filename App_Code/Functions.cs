using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Functions
/// </summary>
public class Functions
{
    public bool AuthorityControl(string authority)
    {
        HttpContext context = HttpContext.Current;
        LuffeyCMSDataContext dcx = new LuffeyCMSDataContext();
        #region YorumSatırları
        //var query = from a in dcx.Members where a.ID == (int)context.Session["ID"] select a.MemberType;
        //Member mem = (dcx.Members.SingleOrDefault(x => x.ID == (int)context.Session["ID"]));
        //if (mem.MemberType.ToString()==authority)
        //{
        //              
        //}
        #endregion
        if (context.Session["Authority"] == authority)
        {
            return true;
        }
        else
        {
            return false;
        }

    }
}