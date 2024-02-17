using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
namespace bds_site_web_version7_.Controllers
{
    [Authorize]
    public class AdministrationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
