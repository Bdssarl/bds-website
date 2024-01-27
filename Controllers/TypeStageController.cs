using bds_site_web_version7_.Models;
using Microsoft.AspNetCore.Mvc;

namespace bds_site_web_version7_.Controllers
{
    public class TypeStageController : Controller
    {
        SiteWebBdsDbContext _SiteWebBdsDbContext;
        public TypeStageController(SiteWebBdsDbContext siteWebBdsDbContext)
        {
            _SiteWebBdsDbContext = siteWebBdsDbContext;


        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(TypeStage typestage)
        {
            var typeStages = new TypeStage
            {
                LibelleTypeStage = typestage.LibelleTypeStage,
                Stages = new List<Stage>
                {
                    new Stage{
                    DomaineStage = typestage.DomaineStage
                    }
                }
            };
            _SiteWebBdsDbContext.Add(typeStages);
            _SiteWebBdsDbContext.SaveChanges();
            return View();
        }
    }
}
