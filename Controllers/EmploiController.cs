using bds_site_web_version7_.Models;
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
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Emploi emploi)
        {
            _siteWebBdsDbContext.Add(emploi);
            _siteWebBdsDbContext.SaveChanges();

            return View();
        }
    }
}
