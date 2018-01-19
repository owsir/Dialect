using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Castle.Windsor;
using Castle.Windsor.Installer;
using Dialect.Logic.WindsorInstaller;
using Dialect.Repository.WindsorInstaller;
using Dialect.Web.Installer;

namespace Dialect.Web
{
    public class MvcApplication : HttpApplication
    {
        private static IWindsorContainer _container;

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            _container = new WindsorContainer()
          .Install(FromAssembly.This(),
                            FromAssembly.Containing<LogicInstaller>(),
                            FromAssembly.Containing<RepositoryInstaller>());
            var controllerFactory = new WindsorControllerFactory(_container.Kernel);
            ControllerBuilder.Current.SetControllerFactory(controllerFactory);
        }
        protected void Application_End()
        {
            _container.Dispose();
        }
    }


}
