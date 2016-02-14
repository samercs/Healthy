using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI.WebControls;

namespace Healthy.Core
{
    public class UiCaltureBase : System.Web.UI.Page
    {
        public readonly Database db;
        public readonly Tools Tools;

        public UiCaltureBase()
        {
            db = new Database();
            Tools = new Tools();
        }
        protected override void InitializeCulture()
        {
            Title = "Interactive and Digital Mother Child Health Handbook (idMCHH)";

            HttpCookie CultureCookie = Request.Cookies["ASLang"];

            CultureInfo ci;
            if (CultureCookie == null)
            {
                ci = new CultureInfo("en-US");
            }
            else
            {
                ci = new CultureInfo(CultureCookie.Value);
            }
            Thread.CurrentThread.CurrentCulture = ci;
            Thread.CurrentThread.CurrentUICulture = ci;
            base.InitializeCulture();
            switch (Page.Culture)
            {
                case "Arabic (Jordan)":
                    Page.Theme = "Ar";
                    break;
                default:
                    Page.Theme = "En";
                    break;
            }


        }


        /*public void ShowAlert(string text, MsgType msgType)
        {
            string baseClass = "alert msgBox text-center";
            Panel panel = Master.FindControl("msg") as Panel;
            Label lbl = Master.FindControl("lblMsg") as Label;
            if (panel == null)
            {
                panel = Master.Master.FindControl("msg") as Panel;
                lbl = Master.Master.FindControl("lblMsg") as Label;
            }
            panel.Visible = true;
            switch (msgType)
            {
                case MsgType.Success:
                    panel.CssClass = baseClass + " alert-success";
                    break;
                case MsgType.Error:
                    panel.CssClass = baseClass + " alert-danger";
                    break;
                case MsgType.Warning:
                    panel.CssClass = baseClass + " alert-warning";
                    break;

            }

            lbl.Text = text;

        }*/
    }


    public enum MsgType
    {
        Success = 1,
        Error = 2,
        Warning = 3
    }
}