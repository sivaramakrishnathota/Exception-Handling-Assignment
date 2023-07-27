using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SignUpAndLoginApp
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtLoginEmail.Text.Trim();
            string password = txtLoginPassword.Text.Trim();
            BLL bll_Obj = new BLL();
            bool isAuthenticated = bll_Obj.UserLogin(email, password);
            if (isAuthenticated)
            {
                Response.Redirect("LogOut.aspx");
            }
            else
            {
                Response.Write("Invalid email or password.");
            }
        }
        protected void btnForgotPassword_Click(object sender, EventArgs e)
        {
            Response.Redirect("ForGotPassword.aspx");
        }
    }
}