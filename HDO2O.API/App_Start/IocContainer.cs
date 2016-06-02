using Autofac;
using Autofac.Integration.WebApi;
using HDO2O.Infranstructure;
using HDO2O.IRepository;
using HDO2O.IServices;
using HDO2O.Models;
using HDO2O.Repository;
using HDO2O.Services;
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
            builder.RegisterType<DbContextFactory>().As<IDbContextFactory<HDDbContext>>().AsImplementedInterfaces().InstancePerRequest();
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().AsImplementedInterfaces().InstancePerRequest();


            #region register service and repository
            builder.RegisterType<HairDresserRepository>().As<IHairDresserRepository>().AsImplementedInterfaces().InstancePerRequest();
            builder.RegisterType<BarbershopHairDresserRepository>().As<IBarbershopHairDresserRespository>().AsImplementedInterfaces().InstancePerRequest();
            builder.RegisterType<BarbershopRepository>().As<IBarbershopRepository>().AsImplementedInterfaces().InstancePerRequest();
            builder.RegisterType<MembershipCardRespository>().As<IMembershipCardRespository>().AsImplementedInterfaces().InstancePerRequest();
            builder.RegisterType<BarbershopService>().As<IBarbershopService>().AsImplementedInterfaces().InstancePerRequest();
            builder.RegisterType<HairDresserService>().As<IHairDresserService>().AsImplementedInterfaces().InstancePerRequest();
            builder.RegisterType<MembershipCardService>().As<IMembershipCardService>().AsImplementedInterfaces().InstancePerRequest();
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