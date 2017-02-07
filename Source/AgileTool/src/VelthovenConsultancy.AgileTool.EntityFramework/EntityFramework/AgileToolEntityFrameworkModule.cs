using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;

namespace VelthovenConsultancy.AgileTool.EntityFramework
{
    [DependsOn(
        typeof(AgileToolCoreModule), 
        typeof(AbpZeroEntityFrameworkModule))]
    public class AgileToolEntityFrameworkModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<AgileToolDbContext>());
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}