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
    public partial class Register : UiCaltureBase
    {
       

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                db.LoadDDL("Country",ref ddlCountry,"Select Nationality");
                
            }
        }

        protected void Button1_OnClick(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                db.AddParameter("@FirstName", txtFName.Text);
                db.AddParameter("@LastName", txtLName.Text);
                db.AddParameter("@UserName", txtUserName.Text);
                db.AddParameter("@Email", txtEmail.Text);
                db.AddParameter("@password", txtPassword.Text);
                db.AddParameter("@type", "1");
                var userId =
                    db.ExecuteNonQuery_id(
                        "insert into Users(FirstName,LastName,UserName,Email,[Type],Password) values(@FirstName,@LastName,@UserName,@Email,@Type,@password)");
                db.AddParameter("@nationality", ddlCountry.SelectedValue);
                db.AddParameter("@birthDate", txtBirthDate.Text);
                db.AddParameter("@UserId", userId);
                db.ExecuteNonQuery(
                        "insert into Mother(Nationality,BirthDate,UserId) values(@Nationality,@BirthDate,@UserId)");

                lblError.Text = "your information has been send to site administrator. please wait until you'r recive and email notification ";
                Panel1.CssClass = "alert alert-success";
                Panel1.Visible = true;

            }
        }

        private bool ValidateData()
        {
            Panel1.Visible = false;
            Panel1.CssClass = "alert";
            if (string.IsNullOrEmpty(txtFName.Text))
            {
                Panel1.CssClass += " alert-danger";
                lblError.Text = "please enter mother first name";
                Panel1.Visible = true;
                return false;
            }
            DateTime tmp;
            if (!DateTime.TryParse(txtBirthDate.Text, out tmp))
            {
                Panel1.CssClass += " alert-danger";
                lblError.Text = "please check mother birth date";
                Panel1.Visible = true;
                return false;
            }
            db.AddParameter("@email", txtEmail.Text);
            DataTable dt = db.ExecuteDataTable("select * from users where email=@email");
            if (dt.Rows.Count > 0)
            {
                Panel1.CssClass += " alert-danger";
                lblError.Text = "this email ("+txtEmail.Text+") is register for another user";
                Panel1.Visible = true;
                return false;
            }
            db.AddParameter("@username", txtUserName.Text);
            dt = db.ExecuteDataTable("select * from users where username=@username");
            if (dt.Rows.Count > 0)
            {
                Panel1.CssClass += " alert-danger";
                lblError.Text = "this username (" + txtUserName.Text + ") is register for another user";
                Panel1.Visible = true;
                return false;
            }
            return true;
        }
    }
}