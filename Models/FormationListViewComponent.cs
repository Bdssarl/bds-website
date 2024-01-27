using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace bds_site_web_version7_.Models
{
    public class FormationListViewComponent : ViewComponent
    {
        private readonly SiteWebBdsDbContext _context;
        public FormationListViewComponent(SiteWebBdsDbContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var formationTermines = await _context.FormationTermines.ToListAsync();
            return View(formationTermines);
        }

    }
}
