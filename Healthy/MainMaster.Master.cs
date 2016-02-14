using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Healthy.Core;

namespace Healthy
{
    public partial class MainMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                var pageName = System.IO.Path.GetFileName(Request.RawUrl).ToLower();
                Tools t = new Tools();
                if (!t.IsUserLogin(Session))
                {
                    linkProfileReg.Text = "Register";
                    linkProfileReg.NavigateUrl = "Register.aspx";
                    
                }
                else
                {
                    Users u = t.GetUser(Session);
                    linkProfileReg.Text = "Personal Profile";
                    linkProfileReg.NavigateUrl = "Profile.aspx";
                    loginLink.Text = "Welcome " + u.UserName;
                    loginLink.NavigateUrl = "~/Profile.aspx";
                }
                switch (pageName)
                {
                    case @"default.aspx":
                        HomeCon.Attributes.Add("class", "selected");
                        break;
                    case @"login.aspx":
                        LoginCon.Attributes.Add("class", "selected");
                        break;
                    case "register.aspx":
                    case "profile.aspx":
                        RegisterCon.Attributes.Add("class", "selected");
                        break;
                }
            }
        }
    }
}