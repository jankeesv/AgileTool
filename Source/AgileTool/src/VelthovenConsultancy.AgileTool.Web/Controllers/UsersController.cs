using System.Threading.Tasks;
using Abp.AspNetCore.Mvc.Authorization;
using VelthovenConsultancy.AgileTool.Authorization;
using VelthovenConsultancy.AgileTool.Users;
using Microsoft.AspNetCore.Mvc;

namespace VelthovenConsultancy.AgileTool.Web.Controllers
{
    [AbpMvcAuthorize(PermissionNames.Pages_Users)]
    public class UsersController : AgileToolControllerBase
    {
        private readonly IUserAppService _userAppService;

        public UsersController(IUserAppService userAppService)
        {
            _userAppService = userAppService;
        }

        public async Task<ActionResult> Index()
        {
            var output = await _userAppService.GetUsers();
            return View(output);
        }
    }
}