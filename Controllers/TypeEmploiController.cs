using Microsoft.AspNetCore.Mvc;
using bds_site_web_version7_.Models;
using System.ComponentModel.DataAnnotations.Schema;
namespace bds_site_web_version7_.Controllers
{
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
            var typeEmplois = new TypeStage
            {
                LibelleTypeStage = typeEmploi.LibelleTypeEmploi,
                Stages = new List<Stage>
                {
                    new Stage{
                    DomaineStage = typeEmploi.DomaineEmploi
                    }
                }
            };
            _SiteWebBdsDbContext.Add(typeEmplois);
            _SiteWebBdsDbContext.SaveChanges();
            return View();
        }
    }
}
