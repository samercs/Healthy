using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Healthy.Core;

namespace Healthy
{
    public partial class ChangePassword : UserPages
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_OnClick(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                Users u = Tools.GetUser(Session);
                db.AddParameter("@password", txtPassword2.Text);
                db.AddParameter("@id", u.Id);
                db.ExecuteNonQuery("update users set password=@password where id=@id");
                u.Password = txtPassword2.Text;
                Session["User"] = u;
                Panel1.CssClass += " alert-success";
                lblError.Text = "password has been changed successfully.";
                Panel1.Visible = true;
            }
        }

        private bool ValidateData()
        {
            Panel1.Visible = false;
            Panel1.CssClass = "alert";
            if (string.IsNullOrEmpty(txtPassword1.Text))
            {
                Panel1.CssClass += " alert-danger";
                lblError.Text = "please enter current password";
                Panel1.Visible = true;
                return false;
            }
            if (string.IsNullOrEmpty(txtPassword2.Text))
            {
                Panel1.CssClass += " alert-danger";
                lblError.Text = "please enter new password";
                Panel1.Visible = true;
                return false;
            }

            if (!txtPassword2.Text.Equals(txtPassword3.Text))
            {
                Panel1.CssClass += " alert-danger";
                lblError.Text = "please check password confirmation not equal new password ";
                Panel1.Visible = true;
                return false;
            }

            Users u = Tools.GetUser(Session);
            if (!u.Password.Equals(txtPassword1.Text))
            {
                Panel1.CssClass += " alert-danger";
                lblError.Text = "current password is wrong. plesae check your current password";
                Panel1.Visible = true;
                return false;
            }

            return true;
        }

    }
}