using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bds_site_web.Controllers
{
    public class AcceuilController : Controller
    {
        // GET: AcceuilController
        public ActionResult Acceuil()
        {
            ViewData["Title"] = "Acceuil";
            return View();
        }
        

      
    }
}
