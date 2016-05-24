using Autofac;
using Autofac.Integration.WebApi;
using HDO2O.Infranstructure;
using HDO2O.Models;
using System.Reflection;
using System.Web.Http;

namespace HDO2O.API.App_Start
{
    public class IocContainer
    {
        public static void Configure()
        {
            ConfigureAutofacContainer();
            // AutoMapperConfiguration.Configure();
        }

        public static void ConfigureAutofacContainer()
        {

            var webApiContainerBuilder = new ContainerBuilder();
            ConfigureWebApiContainer(webApiContainerBuilder);
        }

        public static void ConfigureWebApiContainer(ContainerBuilder builder)
        {
            var config = GlobalConfiguration.Configuration;

            //register infranstructure
            builder.RegisterType<DbContextFactory>().As<IDbContextFactory<ApplicationDbContext>>().AsImplementedInterfaces().InstancePerRequest();
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().AsImplementedInterfaces().InstancePerRequest();


            #region register service and repository

            #endregion


            //register api controller
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            builder.RegisterWebApiFilterProvider(config);

            //设置Resolver
            var container = builder.Build();
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }
}