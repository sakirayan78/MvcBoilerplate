using System.Web;

using MvcBoilerplate.Model;

namespace MvcBoilerplate.Mvc.Helper
{
    public static class Sessions
    {

        public static User CurrentUser
        {
            get
            {
                if (HttpContext.Current.Session["current_user"] != null)
                    return HttpContext.Current.Session["current_user"] as User;
                return null;
            }
            set
            {
                HttpContext.Current.Session["current_user"] = value;
            }
        }
    }
}