using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace VelthovenConsultancy.AgileTool.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : AgileToolControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}