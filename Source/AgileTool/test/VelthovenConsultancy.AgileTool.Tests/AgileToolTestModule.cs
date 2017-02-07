using System;
using Abp.Modules;
using Abp.MultiTenancy;
using Abp.TestBase;
using Abp.Zero.Configuration;
using VelthovenConsultancy.AgileTool.EntityFramework;
using Castle.MicroKernel.Registration;
using NSubstitute;

namespace VelthovenConsultancy.AgileTool.Tests
{
    [DependsOn(
        typeof(AgileToolApplicationModule),
        typeof(AgileToolEntityFrameworkModule),
        typeof(AbpTestBaseModule)
        )]
    public class AgileToolTestModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.Timeout = TimeSpan.FromMinutes(30);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;

            //Use database for language management
            Configuration.Modules.Zero().LanguageManagement.EnableDbLocalization();

            RegisterFakeService<IAbpZeroDbMigrator>();
        }

        private void RegisterFakeService<TService>() where TService : class
        {
            IocManager.IocContainer.Register(
                Component.For<TService>()
                    .UsingFactoryMethod(() => Substitute.For<TService>())
                    .LifestyleSingleton()
            );
        }
    }
}