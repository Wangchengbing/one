using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        string href= Request.ServerVariables["SERVER_NAME"].ToLower();
        switch(href){
            case "www.boyy.top":
                Response.Redirect("wwwetcpcn/index.html", true);
                //Server.Transfer("one/Default.aspx", true); 
                break;
            case "www.boyy.site":
                Response.Redirect("one/Default.aspx", true);
                //Server.Transfer("wwwetcpcn/index.html", true);
                break;
        }
    }
}