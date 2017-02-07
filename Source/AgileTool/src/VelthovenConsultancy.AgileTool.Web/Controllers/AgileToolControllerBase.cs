using Abp.AspNetCore.Mvc.Controllers;
using Microsoft.AspNet.Identity;
using Abp.IdentityFramework;

namespace VelthovenConsultancy.AgileTool.Web.Controllers
{
    public abstract class AgileToolControllerBase: AbpController
    {
        protected AgileToolControllerBase()
        {
            LocalizationSourceName = AgileToolConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}