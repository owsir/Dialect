using System.Web;
using System.Web.Mvc;

namespace Dialect.Web.App_Start
{
    public class BasicAuthorizeAttribute: AuthorizeAttribute
    {
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            return HttpContext.Current.Session["user"] != null;
        }

        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            base.HandleUnauthorizedRequest(filterContext);

            if (HttpContext.Current.Session["user"] == null)
            {
                var loginUrl = "/Account/Login/";
                if (filterContext.HttpContext.Request.Url != null)
                {
                    loginUrl = string.Concat("/Account/Login/","?ReturnUrl=",filterContext.HttpContext.Server.UrlEncode(filterContext.HttpContext.Request.Url.AbsoluteUri));
                    
                }
                filterContext.Result = new RedirectResult(loginUrl);
            }
            else
            {
                filterContext.Result = new RedirectResult("/Home/Index");
            }

        }
    }
}