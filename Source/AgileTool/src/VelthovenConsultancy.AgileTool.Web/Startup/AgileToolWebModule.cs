using System.Reflection;
using Abp.AspNetCore;
using Abp.AspNetCore.Configuration;
using Abp.Modules;
using VelthovenConsultancy.AgileTool.Configuration;
using VelthovenConsultancy.AgileTool.EntityFramework;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Zero.Configuration;

namespace VelthovenConsultancy.AgileTool.Web.Startup
{
    [DependsOn(
        typeof(AgileToolApplicationModule), 
        typeof(AgileToolEntityFrameworkModule), 
        typeof(AbpAspNetCoreModule))]
    public class AgileToolWebModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public AgileToolWebModule(IHostingEnvironment env)
        {
            _appConfiguration = AppConfigurations.Get(env.ContentRootPath, env.EnvironmentName);
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(AgileToolConsts.ConnectionStringName);

            //Use database for language management
            Configuration.Modules.Zero().LanguageManagement.EnableDbLocalization();

            Configuration.Navigation.Providers.Add<AgileToolNavigationProvider>();

            Configuration.Modules.AbpAspNetCore()
                .CreateControllersForAppServices(
                    typeof(AgileToolApplicationModule).Assembly
                );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}