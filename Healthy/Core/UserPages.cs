namespace Healthy.Core
{
    public class UserPages : UiCaltureBase
    {
        protected override void InitializeCulture()
        {
            base.InitializeCulture();
            if (!Tools.IsUserLogin(Session))
            {
                Response.Redirect("~/login.aspx?url=" + Request.RawUrl);
            }
            
        }
    }
}