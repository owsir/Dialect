using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Dialect.IRepository;

namespace Dialect.Repository.WindsorInstaller
{
    public class RepositoryInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(
                Component.For<IForumRepository>().ImplementedBy<ForumRepository>().LifestylePerWebRequest(),
                Component.For<IForumPostRepository>().ImplementedBy<ForumPostRepository>().LifestylePerWebRequest(),
                Component.For<IUserRepository>().ImplementedBy<UserRepository>().LifestylePerWebRequest(),
                Component.For<IPostReplyRepository>().ImplementedBy<PostReplyRepository>().LifestylePerWebRequest()
                );
        }
    }
}
