using Bds_site_web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using bds_site_web_version7_.Models;
using bds_site_web_version7_.Services;

namespace bds_site_web_version7_.Controllers
{
    public class MetiersController : Controller
    {
        SiteWebBdsDbContext _context;
        IFileUpload _fileUpload;
        public MetiersController(SiteWebBdsDbContext context,IFileUpload fileUpload)
        {
            _context = context;
            _fileUpload = fileUpload;
        }

        public async Task<IActionResult> Index()
        {
            return _context.Metiers != null ?
                        View(await _context.Metiers.ToListAsync()) :
                        Problem("Entity set 'SiteWebBdsDbContext.Metiers'  is null.");
        }

        // GET: Departementecoles/Details/5
        public async Task<IActionResult> Details(string? id)
        {
            if (id == null || _context.Metiers == null)
            {
                return NotFound();
            }

            var metier = await _context.Metiers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (metier == null)
            {
                return NotFound();
            }

            return View(metier);
        }

        // GET: Departementecoles/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Departementecoles/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create( Metier metier)
        {
            
            
                var fileName = _fileUpload.uploadimage(metier.formFile, "metier");
                metier.NameImageMetier = fileName;
                _context.Add(metier);
                await _context.SaveChangesAsync();
               
            return View();
        }
        public IActionResult Conseil()
        {
            return View();
        }
        public IActionResult Ingenierie()
        {
            return View();
        }
        public IActionResult FormationContinue()
        {
            return View();
        }
        // GET: Departementecoles/Edit/5
        public async Task<IActionResult> Edit(string? id)
        {
            if (id == null || _context.Metiers == null)
            {
                return NotFound();
            }

            var metier = await _context.Metiers.FindAsync(id);
            if (metier == null)
            {
                return NotFound();
            }
            return View(metier);
        }

        // POST: Departementecoles/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id,  Metier metier)
        {
            if (id != metier.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(metier);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MetierExists(metier.Id))
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
            return View(metier);
        }

        // GET: Departementecoles/Delete/5
        public async Task<IActionResult> Delete(string? id)
        {
            if (id == null || _context.Metiers == null)
            {
                return NotFound();
            }

            var metier = await _context.Metiers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (metier == null)
            {
                return NotFound();
            }

            return View(metier);
        }

        // POST: Departementecoles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.Metiers == null)
            {
                return Problem("Entity set 'SiteWebBdsDbContext.Metiers'  is null.");
            }
            var metier = await _context.Metiers.FindAsync(id);
            if (metier != null)
            {
                _context.Metiers.Remove(metier);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool    MetierExists(string id)
        {
            return (_context.Metiers?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
