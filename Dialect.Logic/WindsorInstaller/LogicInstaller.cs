using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Dialect.Logic;
using Dialect.ILogic;

namespace Dialect.Logic.WindsorInstaller
{
    public class LogicInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(
                Component.For<IForumLogic>().ImplementedBy<ForumLogic>().LifestylePerWebRequest(),
                Component.For<IForumPostLogic>().ImplementedBy<ForumPostLogic>().LifestylePerWebRequest(),
                Component.For<IPostReplyLogic>().ImplementedBy<PostReplyLogic>().LifestylePerWebRequest(),
                Component.For<IUserLogic>().ImplementedBy<UserLogic>().LifestylePerWebRequest()
                );
        }
    }
}
