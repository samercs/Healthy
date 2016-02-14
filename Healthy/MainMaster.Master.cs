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
                    lblUserName.Text = "Welcome ";
                    MultiView1.ActiveViewIndex = 0;
                }
                else
                {
                    Users u = t.GetUser(Session);
                    linkProfileReg.Text = "Personal Profile";
                    linkProfileReg.NavigateUrl = "Profile.aspx";
                    lblUserName.Text = "Welcome " + u.UserName;
                    MultiView1.ActiveViewIndex = 1;
                }
                switch (pageName)
                {
                    case @"default.aspx":
                        HomeCon.Attributes.Add("class", "active");
                        break;
                    case "register.aspx":
                    case "profile.aspx":
                        RegisterCon.Attributes.Add("class", "active");
                        break;
                }
            }
        }
    }
}