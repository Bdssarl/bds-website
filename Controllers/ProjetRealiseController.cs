using bds_site_web_version7_.Models;
using bds_site_web_version7_.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using bds_site_web_version7_.Migrations;

namespace bds_site_web_version7_.Controllers
{
    
    public class ProjetRealiseController : Controller
    {
        SiteWebBdsDbContext _context;
        IFileUpload _fileUpload;
        private static int i = 0;
        public ProjetRealiseController(SiteWebBdsDbContext context,IFileUpload fileUpload)
        {
            _context = context;
            _fileUpload = fileUpload;
            i = _context.ProjetRealises.Count();
            if (i == 0)
            {
                i = 1;
            }
        }

        public async Task<IActionResult> Index()
        {
            return _context.ProjetRealises != null ?
                        View(await _context.ProjetRealises.ToListAsync()) :
                        Problem("Entity set 'SiteWebBdsDbContext.ProjetRealises'  is null.");
        }

        // GET: Departementecoles/Details/5
        public async Task<IActionResult> Details(string? id)
        {
            if (id == null || _context.ProjetRealises == null)
            {
                return NotFound();
            }

            var projetRealises = await _context.ProjetRealises
                .FirstOrDefaultAsync(m => m.Id == id);
            if (projetRealises == null)
            {
                return NotFound();
            }

            return View(projetRealises);
        }

        // GET: Departementecoles/Create
        public IActionResult Create()
        {
            var ProjetRealise = new ProjetRealise();

            ProjetRealise.Id = $"pt{DateTime.Now.Year}{i}";

            return View(ProjetRealise);
        }
        [HttpGet]
        public async Task<IActionResult> Projet()
        {
            
            return View();
        }

        // POST: Departementecoles/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProjetRealise projetRealise)
        {
            if (ModelState.IsValid)
            {


                var fileName = _fileUpload.uploadimage(projetRealise.FormFile, "projet");
                projetRealise.ChemImageProjetRealise = fileName;
                _context.Add(projetRealise);
                await _context.SaveChangesAsync();

                ViewBag.Message = "Enregistrer avec succès";
                return RedirectToAction(nameof(Index));
            }
            return View(projetRealise);
        }

        // GET: Departementecoles/Edit/5
        public async Task<IActionResult> Edit(string? id)
        {
            if (id == null || _context.ProjetRealises == null)
            {
                return NotFound();
            }

            var projetRealise = await _context.ProjetRealises.FindAsync(id);
            if (projetRealise == null)
            {
                return NotFound();
            }
            return View(projetRealise);
        }

        // POST: Departementecoles/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, ProjetRealise projetRealise)
        {
            if (id != projetRealise.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(projetRealise);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProjetsRealisesExists(projetRealise.Id))
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
            return View(projetRealise);
        }

        // GET: Departementecoles/Delete/5
        public async Task<IActionResult> Delete(string? id)
        {
            if (id == null || _context.ProjetRealises == null)
            {
                return NotFound();
            }

            var projetRealise = await _context.ProjetRealises
                .FirstOrDefaultAsync(m => m.Id == id);
            if (projetRealise == null)
            {
                return NotFound();
            }

            return View(projetRealise);
        }

        // POST: Departementecoles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.ProjetRealises == null)
            {
                return Problem("Entity set 'SiteWebBdsDbContext.ProjetEncours'  is null.");
            }
            var projetRealise = await _context.ProjetRealises.FindAsync(id);
            if (projetRealise != null)
            {
                _context.ProjetRealises.Remove(projetRealise);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProjetsRealisesExists(string id)
        {
            return (_context.ProjetRealises?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}

