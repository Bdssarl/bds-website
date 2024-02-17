using bds_site_web_version7_.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace bds_site_web_version7_.Controllers
{
    public class EmploiController : Controller
    {
        SiteWebBdsDbContext _siteWebBdsDbContext;
        public EmploiController(SiteWebBdsDbContext siteWebBdsDbContext)
        {
            _siteWebBdsDbContext = siteWebBdsDbContext;
        }
        [Authorize]
        public IActionResult Create()
        {
            return View();
        }
        [Authorize]
        [HttpPost]
        public IActionResult Create(Emploi emploi)
        {
            if (ModelState.IsValid)
            {
                _siteWebBdsDbContext.Add(emploi);
                _siteWebBdsDbContext.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
           

            return View(emploi);
        }
    }
}
