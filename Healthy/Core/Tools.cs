using System.Web.SessionState;

namespace Healthy.Core
{
    public class Tools
    {
        public bool IsUserLogin(HttpSessionState session)
        {
            return session["User"] != null;
        }

        public Users GetUser(HttpSessionState session)
        {
            if (IsUserLogin(session))
            {
                Users u = session["User"] as Users;
                return u;
            }
            return null;
        }
    }
}