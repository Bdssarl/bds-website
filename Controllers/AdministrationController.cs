using Microsoft.AspNetCore.Mvc;

namespace bds_site_web_version_6_.Controllers
{
    public class AdministrationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
