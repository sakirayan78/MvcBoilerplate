using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Autofac;
using Autofac.Integration.Mvc;
using AutoMapper;
using MvcBoilerplate.Model;
using MvcBoilerplate.Mvc.Helper;
using MvcBoilerplate.Mvc.Modules;

namespace MvcBoilerplate.Mvc
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            //Autofac Configuration
            var builder = new Autofac.ContainerBuilder();

            builder.RegisterControllers(typeof(MvcApplication).Assembly).PropertiesAutowired();
            builder.RegisterFilterProvider();

            builder.RegisterModule(new RepositoryModule());
            builder.RegisterModule(new ServiceModule());
            builder.RegisterModule(new EFModule());
            builder.RegisterType<AuthorizeUserAttribute>().PropertiesAutowired();
            var container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

            //  Automapper configuration
            Mapper.CreateMap<UserDto, User>();
            Mapper.CreateMap<User, UserDto>();
                
           // Mapper.AssertConfigurationIsValid();
        }
    }
}
