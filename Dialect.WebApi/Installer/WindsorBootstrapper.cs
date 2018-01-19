using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Castle.Windsor.Installer;
using Dialect.Repository.WindsorInstaller;
using Dialect.Logic.WindsorInstaller;

namespace Dialect.WebApi.Installer
{
    public static class WindsorBootstrapper
    {
        public static void Initialize(IWindsorContainer container)
        {
            Container = container;
            InitializeCommon(container);
        }

        public static void InitializeCommon(IWindsorContainer container)
        {
            container.Install(FromAssembly.This(),
                FromAssembly.Containing<LogicInstaller>(),
                FromAssembly.Containing<RepositoryInstaller>()
                );

            container.Register(Component.For<IWindsorContainer>().Instance(container).LifestyleSingleton());
        }

        public static IWindsorContainer Container { get; private set; }
    }
}