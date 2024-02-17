using bds_site_web_version7_.Models;
using bds_site_web_version7_.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ZstdSharp.Unsafe;

namespace bds_site_web_version7_.Controllers
{
    [Authorize]
    public class PartenaireController : Controller
    {
        SiteWebBdsDbContext _context;
        IFileUpload _fileUpload;
        public PartenaireController(SiteWebBdsDbContext context,IFileUpload fileUpload)
        {
            _context = context;
            _fileUpload = fileUpload;
        }

        public async Task<IActionResult> Index()
        {
            return _context.Partenaires != null ?
                        View(await _context.Partenaires.ToListAsync()) :
                        Problem("Entity set 'SiteWebBdsDbContext.Partenaires'  is null.");
        }

        // GET: Partenaires/Details/5
        public async Task<IActionResult> Details(string? id)
        {
            if (id == null || _context.Partenaires == null)
            {
                return NotFound();
            }

            var partenaire = await _context.Partenaires
                .FirstOrDefaultAsync(m => m.Id == id);
            if (partenaire == null)
            {
                return NotFound();
            }

            return View(partenaire);
        }

        // GET: Partenaires/Create
        public IActionResult Create()
        {
            return View();
        }
       

        // POST: Partenaires/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Partenaire partenaire)
        {
            if (ModelState.IsValid)
            {
                var fileName = _fileUpload.uploadimage(partenaire.formFile, "partennaire");
                partenaire.CheminImageTemoignage = fileName;
                _context.Add(partenaire);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(partenaire);
        }

        // GET: Partenaires/Edit/5
        public async Task<IActionResult> Edit(string? id)
        {
            if (id == null || _context.Partenaires == null)
            {
                return NotFound();
            }

            var formation = await _context.Partenaires.FindAsync(id);
            if (formation == null)
            {
                return NotFound();
            }
            return View(formation);
        }

        // POST: Partenaires/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, Partenaire partenaire)
        {
            if (id != partenaire.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(partenaire);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PartenairesExists(partenaire.Id))
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
            return View(partenaire);
        }

        // GET:Partenaires/Delete/5
        public async Task<IActionResult> Delete(string? id)
        {
            if (id == null || _context.Partenaires == null)
            {
                return NotFound();
            }

            var partenaire = await _context.Partenaires
                .FirstOrDefaultAsync(m => m.Id == id);
            if (partenaire == null)
            {
                return NotFound();
            }

            return View(partenaire);
        }

            // POST: Partenaires/Delete/5
            [HttpPost, ActionName("Delete")]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> DeleteConfirmed(string id)
            {
                if (_context.Partenaires == null)
                {
                    return Problem("Entity set 'SiteWebBdsDbContext.Partenaires'  is null.");
                }
                var partenaire = await _context.Partenaires.FindAsync(id);
                if (partenaire != null)
                {
                    _context.Partenaires.Remove(partenaire);
                }

                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            private bool PartenairesExists(string id)
            {
                return (_context.Partenaires?.Any(e => e.Id == id)).GetValueOrDefault();
            }
        }
    }

    
