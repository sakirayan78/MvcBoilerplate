using System.Data.Entity;

using Autofac;
using MvcBoilerplate.Model;
using MvcBoilerplate.Repository.Common;


namespace MvcBoilerplate.Mvc.Modules

{
    

    public class EFModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterModule(new RepositoryModule());

            builder.RegisterType(typeof(MvcBoilerplateContext)).As(typeof(DbContext)).InstancePerLifetimeScope();
           
            builder.RegisterType(typeof(UnitOfWork)).As(typeof(IUnitOfWork)).SingleInstance().InstancePerDependency();  
        }

    }
}