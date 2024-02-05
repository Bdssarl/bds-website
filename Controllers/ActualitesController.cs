using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace bds_site_web_version7_.Controllers
{
    public class ActualitesController : Controller
    {
        // GET: ActualiteController
        public ActionResult Actualites()
        {
            return View();
        }

        public ActionResult Excel()
        {
            return View();
        }


    }
}
