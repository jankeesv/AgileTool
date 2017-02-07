using Microsoft.AspNetCore.Mvc;

namespace VelthovenConsultancy.AgileTool.Web.Controllers
{
    public class AboutController : AgileToolControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}