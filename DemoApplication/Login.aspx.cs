using System;
using System.Web;

namespace DemoApplication
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["username"];
            if (cookie != null)
            {
                Session.Add("username", cookie.Value);
                Response.Redirect("Dashboard.aspx");
            }
            if (Request.QueryString["msg"] != null)
            {
                if (Request.QueryString["msg"].ToString() == "1")
                {
                    error_message.InnerText = "Please login to access dashboard page";
                }

                if (Request.QueryString["msg"].ToString() == "2")
                {
                    error_message.InnerText = "Logout Success";
                }
            }
            
            errUsername.InnerHtml = String.Empty;
            errPassword.InnerHtml = String.Empty;
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            int error = 0;

            if (String.IsNullOrEmpty(txtUsername.Text))
            {
                error++;
                errUsername.InnerHtml = "Enter Username";
            }
            if (String.IsNullOrEmpty(txtPassword.Text))
            {
                error++;
                errPassword.InnerHtml = "Enter Password";
            }
            if (error == 0)
            {
                if (username == "Suraj" && password =="admin123")
                {
                    if (chkRemember.Checked)
                    {
                        //add cookie
                        HttpCookie cookie = new HttpCookie("username");
                        cookie.Value = username;
                        cookie.Expires = DateTime.Now.AddDays(1);
                        Response.Cookies.Add(cookie);
                    }
                    Session.Add("username", username);
                    Response.Redirect("Dashboard.aspx");
                } else
                {
                    error_message.Style.Add("Color", "red");
                    error_message.InnerText = "Login failed";
                }
            }
        }
    }
}