using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace bds_site_web_version7_.Models
{
    public class DemandeEmploiListViewComponent:ViewComponent
    {
        private readonly SiteWebBdsDbContext _context;
        public DemandeEmploiListViewComponent(SiteWebBdsDbContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var Emplois = await _context.DemandeEmplois.ToListAsync();
            return View(Emplois);
        }
    }
}
