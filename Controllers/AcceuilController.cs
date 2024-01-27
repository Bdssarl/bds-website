using bds_site_web_version7_.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace bds_site_web_version7_.Controllers
{
    public class AcceuilController : Controller
    {
        SiteWebBdsDbContext _context;
        public AcceuilController(SiteWebBdsDbContext context)
        {
            _context = context;
        }
        // GET: AcceuilController
        public async Task< ActionResult> Acceuil()
        {
            ViewData["Title"] = "Acceuil";
            
            return View();
        }
        

      
    }
}
