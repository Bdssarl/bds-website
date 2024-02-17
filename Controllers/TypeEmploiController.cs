using Microsoft.AspNetCore.Mvc;
using bds_site_web_version7_.Models;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Authorization;
namespace bds_site_web_version7_.Controllers
{
    [Authorize]
    public class TypeEmploiController : Controller
    {

        SiteWebBdsDbContext _SiteWebBdsDbContext;
        public TypeEmploiController(SiteWebBdsDbContext siteWebBdsDbContext)
        {
            _SiteWebBdsDbContext = siteWebBdsDbContext;


        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(TypeEmploi typeEmploi)
        {
            if (ModelState.IsValid)
            {
                var typeEmplois = new TypeEmploi
                {
                    LibelleTypeEmploi = typeEmploi.LibelleTypeEmploi,
                    Emplois = new List<Emploi>
                {
                    new Emploi{
                  DomaineEmploi= typeEmploi.DomaineEmploi
                    }
                }
                };
                _SiteWebBdsDbContext.Add(typeEmplois);
                _SiteWebBdsDbContext.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(typeEmploi);
        }
    }
}
