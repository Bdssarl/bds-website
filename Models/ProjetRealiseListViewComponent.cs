using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace bds_site_web_version7_.Models
{
    public class ProjetRealiseListViewComponent:ViewComponent
    {
        private readonly SiteWebBdsDbContext _context;
        public ProjetRealiseListViewComponent (SiteWebBdsDbContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var projetRealises = await _context.ProjetRealises.ToListAsync();
            return View(projetRealises);
        }
    }
}
