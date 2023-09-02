using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoApplication
{
    public partial class Dashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] == null)
            {
                Response.Redirect("Login.aspx?msg=1");
            }
            welcome.InnerText = "Welcome " + Session["username"];
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            //remove cookie
            HttpCookie cookie = Request.Cookies["username"];
            if (cookie != null)
            {
                cookie.Expires = DateTime.Now.AddDays(-1);
                Response.Cookies.Add(cookie);
            }
            
            Session.Clear();
            Response.Redirect("Login.aspx?msg=2");
        }
    }
}