using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace bds_site_web_version7_.Controllers
{
    [Authorize]
    public class InterêtController : Controller
    {
        public IActionResult Interêt()
        {

            return View();
        }
    }
}
