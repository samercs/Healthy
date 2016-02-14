using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Healthy.Core;

namespace Healthy
{
    public partial class Profile : UserPages
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Users u = Tools.GetUser(Session);
                lblName.Text = u.Name;
                lblUserName.Text = u.UserName;
                lblEmail.Text = u.Email;
                lblType.Text = db.GetType(u.Type,"3");
            }
        }
    }
}