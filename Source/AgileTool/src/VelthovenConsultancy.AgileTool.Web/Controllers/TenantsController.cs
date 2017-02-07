using Abp.AspNetCore.Mvc.Authorization;
using VelthovenConsultancy.AgileTool.Authorization;
using VelthovenConsultancy.AgileTool.MultiTenancy;
using Microsoft.AspNetCore.Mvc;

namespace VelthovenConsultancy.AgileTool.Web.Controllers
{
    [AbpMvcAuthorize(PermissionNames.Pages_Tenants)]
    public class TenantsController : AgileToolControllerBase
    {
        private readonly ITenantAppService _tenantAppService;

        public TenantsController(ITenantAppService tenantAppService)
        {
            _tenantAppService = tenantAppService;
        }

        public ActionResult Index()
        {
            var output = _tenantAppService.GetTenants();
            return View(output);
        }
    }
}