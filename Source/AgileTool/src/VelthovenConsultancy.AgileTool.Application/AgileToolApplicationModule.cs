using System.Reflection;
using Abp.AutoMapper;
using Abp.Modules;
using VelthovenConsultancy.AgileTool.Authorization;

namespace VelthovenConsultancy.AgileTool
{
    [DependsOn(
        typeof(AgileToolCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class AgileToolApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<AgileToolAuthorizationProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}