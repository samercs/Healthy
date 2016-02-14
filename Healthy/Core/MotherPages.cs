namespace Healthy.Core
{
    public class MotherPages : UserPages
    {
        protected override void InitializeCulture()
        {
            
            Users u = Tools.GetUser(Session);
            if (!u.Type.Equals("1"))
            {
                Response.Redirect("~/login.aspx?url=" + Request.RawUrl);
            }
        }
    }
}