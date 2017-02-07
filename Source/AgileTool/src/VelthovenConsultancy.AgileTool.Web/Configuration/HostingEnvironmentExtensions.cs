using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using VelthovenConsultancy.AgileTool.Configuration;

namespace VelthovenConsultancy.AgileTool.Web.Configuration
{
    public static class HostingEnvironmentExtensions
    {
        public static IConfigurationRoot GetAppConfiguration(this IHostingEnvironment env)
        {
            return AppConfigurations.Get(env.ContentRootPath, env.EnvironmentName, env.IsDevelopment());
        }
    }
}