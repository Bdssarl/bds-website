using bds_site_web_version7_.Models;
using bds_site_web_version7_.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace bds_site_web_version7_.Controllers
{
    public class ProjetEnCourController : Controller
    {
        SiteWebBdsDbContext _context;
        IFileUpload _fileUpload;
        public ProjetEnCourController(SiteWebBdsDbContext context,IFileUpload fileUpload)
        {
            _context = context;
            _fileUpload = fileUpload;
        }

        public async Task<IActionResult> Index()
        {
            return _context.ProjetEnCours != null ?
                        View(await _context.ProjetEnCours.ToListAsync()) :
                        Problem("Entity set 'SiteWebBdsDbContext.ProjetEncours'  is null.");
        }

        // GET: Departementecoles/Details/5
        public async Task<IActionResult> Details(string? id)
        {
            if (id == null || _context.ProjetEnCours == null)
            {
                return NotFound();
            }

            var projetEnCours = await _context.ProjetEnCours
                .FirstOrDefaultAsync(m => m.Id == id);
            if (projetEnCours == null)
            {
                return NotFound();
            }

            return View(projetEnCours);
        }

        // GET: Departementecoles/Create
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Projet()
        {
            return View();
        }

        // POST: Departementecoles/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProjetEnCour projetEnCour)
        {
            var fileName = _fileUpload.uploadimage(projetEnCour.formFile, "projet");
            projetEnCour.CheminImageProjetEnCours = fileName;
            projetEnCour.NomImageProjetEnCours = fileName;

            _context.Add(projetEnCour);
                await _context.SaveChangesAsync();
            
            return View();
        }

        // GET: Departementecoles/Edit/5
        public async Task<IActionResult> Edit(string? id)
        {
            if (id == null || _context.ProjetEnCours == null)
            {
                return NotFound();
            }

            var projetEnCour = await _context.ProjetEnCours.FindAsync(id);
            if (projetEnCour == null)
            {
                return NotFound();
            }
            return View(projetEnCour);
        }

        // POST: Departementecoles/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, ProjetEnCour projetEnCour)
        {
            if (id != projetEnCour.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(projetEnCour);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProjetsEnCoursExists(projetEnCour.Id))
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
            return View(projetEnCour);
        }

        // GET: Departementecoles/Delete/5
        public async Task<IActionResult> Delete(string? id)
        {
            if (id == null || _context.ProjetEnCours == null)
            {
                return NotFound();
            }

            var projetEnCour = await _context.ProjetAVenirs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (projetEnCour == null)
            {
                return NotFound();
            }

            return View(projetEnCour);
        }

        // POST: Departementecoles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.ProjetEnCours == null)
            {
                return Problem("Entity set 'SiteWebBdsDbContext.ProjetEncours'  is null.");
            }
            var projetEnCour = await _context.ProjetEnCours.FindAsync(id);
            if (projetEnCour != null)
            {
                _context.ProjetEnCours.Remove(projetEnCour);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProjetsEnCoursExists(string id)
        {
            return (_context.ProjetEnCours?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}

