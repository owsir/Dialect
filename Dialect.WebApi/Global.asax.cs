using System.Web.Http;
using System.Web.Http.Dispatcher;
using Castle.Windsor;
using Dialect.WebApi.Installer;

namespace Dialect.WebApi
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            var container = new WindsorContainer();
            WindsorBootstrapper.Initialize(container);
            GlobalConfiguration.Configure(WebApiConfig.Register);
            GlobalConfiguration.Configuration.Services.Replace(typeof(IHttpControllerActivator),
              new WindsorCompositionRoot(WindsorBootstrapper.Container));

        }
    }
}
