using bds_site_web_version7_.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using SendGrid.Helpers.Mail;

namespace bds_site_web_version7_.Controllers
{
    [Authorize]
    public class TypeStageController : Controller
    {
        SiteWebBdsDbContext _SiteWebBdsDbContext;
        public TypeStageController(SiteWebBdsDbContext siteWebBdsDbContext)
        {
            _SiteWebBdsDbContext = siteWebBdsDbContext;


        }
        //GET:typeStage
        public async Task<IActionResult> Index()
        {
            return _SiteWebBdsDbContext.TypeStages != null ?
                        View(await _SiteWebBdsDbContext.TypeStages.ToListAsync()) :
                        Problem("Entity set 'SiteWebBdsDbContext.TypeStages'  is null.");
        }
        // GET: typeStage/Details/5
        public async Task<IActionResult> Details(string? id)
        {
            if (id == null || _SiteWebBdsDbContext.TypeStages == null)
            {
                return NotFound();
            }

            var typeStage = await _SiteWebBdsDbContext.TypeStages
                .FirstOrDefaultAsync(m => m.Id == id);
            if (typeStage == null)
            {
                return NotFound();
            }
            

            return View(typeStage);
        }
        // GET: TypeStage/Edit/5
        public async Task<IActionResult> Edit(string? id)
        {
            if (id == null || _SiteWebBdsDbContext.TypeStages == null)
            {
                return NotFound();
            }

            var typeStage = await _SiteWebBdsDbContext.TypeStages.FindAsync(id);
            if (typeStage == null)
            {
                return NotFound();
            }
            return View(typeStage);
        }

        // POST: TypeStage/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id,  TypeStage typeStage)
        {
            if (id != typeStage.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _SiteWebBdsDbContext.Update(typeStage);
                    await _SiteWebBdsDbContext.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TypeStageExists(typeStage.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(typeStage);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(TypeStage typestage)
        {
            if (ModelState.IsValid)
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
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
        private bool TypeStageExists(string id)
        {
            return (_SiteWebBdsDbContext.TypeStages?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
