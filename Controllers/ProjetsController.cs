using bds_site_web_version7_.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
namespace bds_site_web_version7_.Controllers
{
    
    public class ProjetsController : Controller
    {
        SiteWebBdsDbContext _context;
        public ProjetsController(SiteWebBdsDbContext context)
        {
            _context = context;
        }
        public IActionResult Projets()
        {
            return View();
        }

    }
}

