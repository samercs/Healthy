using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Healthy.Core;

namespace Healthy
{
    public partial class Login : UiCaltureBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_OnClick(object sender, EventArgs e)
        {
            Users u = ValidateData();
            if (u != null)
            {
                Session["User"] = u;
                if (Request.QueryString["url"] != null)
                {
                    Response.Redirect(Request.QueryString["url"]);
                }
                Response.Redirect("Profile.aspx");
            }
        }

        private Users ValidateData()
        {
            Panel1.Visible = false;
            Panel1.CssClass = "alert";
            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                Panel1.CssClass += " alert-danger";
                lblError.Text = "please enter username or email";
                Panel1.Visible = true;
                return null;
            }
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                Panel1.CssClass += " alert-danger";
                lblError.Text = "please enter password";
                Panel1.Visible = true;
                return null;
            }

            db.AddParameter("@username", txtUserName.Text);
            db.AddParameter("@password", txtPassword.Text);
            DataTable dt =
                db.ExecuteDataTable(
                    "select * from users where (username=@username or email=@username) and password=@password");

            if (dt.Rows.Count <= 0)
            {
                Panel1.CssClass += " alert-danger";
                lblError.Text = "wrong login information. please check your username and password.";
                Panel1.Visible = true;
                return null;
            }
            if (!dt.Rows[0]["status"].ToString().Equals("2"))
            {
                Panel1.CssClass += " alert-danger";
                lblError.Text = "your account is ("+db.GetType(dt.Rows[0]["status"].ToString(),"4") +")";
                Panel1.Visible = true;
                return null;
            }

            Users u = new Users();
            u.Id = dt.Rows[0]["id"].ToString();
            u.Password = dt.Rows[0]["password"].ToString();
            u.UserName = dt.Rows[0]["username"].ToString();
            u.Email = dt.Rows[0]["email"].ToString();
            u.Name = dt.Rows[0]["firstname"].ToString()+" " + dt.Rows[0]["lastname"].ToString();
            u.Type = dt.Rows[0]["Type"].ToString();
            return u;
        }
    }
}