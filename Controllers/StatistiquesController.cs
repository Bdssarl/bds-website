using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
namespace bds_site_web_version7_.Controllers
{
    [Authorize]
    public class StatistiquesController : Controller
    {
        public IActionResult Statistiques()
        {
            return View();
        }
    }
}
