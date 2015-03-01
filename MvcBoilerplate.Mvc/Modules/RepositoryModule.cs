using System.Reflection;
using Autofac;


namespace MvcBoilerplate.Mvc.Modules
{
    public class RepositoryModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(Assembly.Load("MvcBoilerplate.Repository"))
                   .Where(t => t.Name.EndsWith("Repository"))
                  
                   .AsImplementedInterfaces()
                  .InstancePerLifetimeScope();
            //builder.RegisterType<CacheManager>().As<ICacheManager>().SingleInstance();
        }
    }
}