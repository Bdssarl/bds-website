using bds_site_web_version7_.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
namespace bds_site_web_version7_.Controllers
{
    [Authorize]
    public class StagesController : Controller
    {
        SiteWebBdsDbContext _SiteWebBdsDbContext;
        public StagesController(SiteWebBdsDbContext siteWebBdsDbContext)
        {
            _SiteWebBdsDbContext = siteWebBdsDbContext;

           
        }
       
        public IActionResult create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Stage stage)
        {
            _SiteWebBdsDbContext.Add(stage);
            _SiteWebBdsDbContext.SaveChanges();
            ViewBag.Message = "Enregistrer avec succès";
            return View();
        }
    }
}
