using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace bds_site_web_version7_.Controllers
{
    [Authorize]
    public class MediathèqueController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
