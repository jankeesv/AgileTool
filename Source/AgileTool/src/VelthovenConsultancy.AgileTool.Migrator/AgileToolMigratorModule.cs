using System.Data.Entity;
using System.Reflection;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Castle.MicroKernel.Registration;
using Microsoft.Extensions.Configuration;
using VelthovenConsultancy.AgileTool.Configuration;
using VelthovenConsultancy.AgileTool.EntityFramework;

namespace VelthovenConsultancy.AgileTool.Migrator
{
    [DependsOn(typeof(AgileToolEntityFrameworkModule))]
    public class AgileToolMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public AgileToolMigratorModule()
        {
            _appConfiguration = AppConfigurations.Get(
                typeof(AgileToolMigratorModule).Assembly.GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Database.SetInitializer<AgileToolDbContext>(null);

            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                AgileToolConsts.ConnectionStringName
                );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(typeof(IEventBus), () =>
            {
                IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                );
            });
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}