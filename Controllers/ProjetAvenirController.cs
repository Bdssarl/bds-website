using bds_site_web_version7_.Models;
using bds_site_web_version7_.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace bds_site_web_version7_.Controllers
{

    public class ProjetAvenirController : Controller
    {
        SiteWebBdsDbContext _context;
        IFileUpload _fileUpload;
        private static int i = 0;
        private static int NombreProjet;
        public ProjetAvenirController(SiteWebBdsDbContext context, IFileUpload fileUpload)
        {
            _context = context;
            _fileUpload = fileUpload;
            i = _context.ProjetAVenirs.Count();
            if (i == 0)
            {
                i = 1;
            }
            else
            {
                i = i + 1;
            }
        }
        public IActionResult AutoEcole()
        {
            return View();
        }
          public IActionResult  MarketingDeLuxe()
        {
            return View();
        }
            
        public async Task<IActionResult> Index()
        {
            return _context.ProjetAVenirs != null ?
                        View(await _context.ProjetAVenirs.ToListAsync()) :
                        Problem("Entity set 'SiteWebBdsDbContext.ProjetAvenirs'  is null.");
        }

        // GET: Partenaires/Details/5
        public async Task<IActionResult> Details(string? id)
        {
            if (id == null || _context.ProjetAVenirs == null)
            {
                return NotFound();
            }

            var projetAvenir = await _context.ProjetAVenirs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (projetAvenir == null)
            {
                return NotFound();
            }

            return View(projetAvenir);
        }

        // GET: Partenaires/Create
       
        public IActionResult Create()
        {

            var ProjetAvenir = new ProjetAVenir();
           

                ProjetAvenir.Id = $"pt{DateTime.Now.Year}{i}";
           

            return View(ProjetAvenir);
        }
        public  IActionResult Projet(){
            
            return View();
        }
        // POST:Partenaires/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProjetAVenir projetAVenir)
        {
            if (ModelState.IsValid)
            {
                var fileName = _fileUpload.uploadimage(projetAVenir.FormFile, "projet");
                projetAVenir.cheminImage = fileName;
                _context.Add(projetAVenir);
                await _context.SaveChangesAsync();
              return RedirectToAction(nameof(Index));
            }
            return View();
        }

        // GET: Partenaires/Edit/5
        public async Task<IActionResult> Edit(string? id)
        {
            if (id == null || _context.ProjetAVenirs == null)
            {
                return NotFound();
            }

            var projetAVenir = await _context.ProjetAVenirs.FindAsync(id);
            if (projetAVenir == null)
            {
                return NotFound();
            }
            return View(projetAVenir);
        }

        // POST: Departementecoles/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, ProjetAVenir projetAVenir)
        {
            if (id !=projetAVenir.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(projetAVenir);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProjetsAvenirExists(projetAVenir.Id))
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
            return View(projetAVenir);
        }

        // GET: Partenaires/Delete/5
        public async Task<IActionResult> Delete(string? id)
        {
            if (id == null || _context.ProjetAVenirs == null)
            {
                return NotFound();
            }

            var projetAVenir = await _context.ProjetAVenirs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (projetAVenir == null)
            {
                return NotFound();
            }

            return View(projetAVenir);
        }

        // POST: Partenaires/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.ProjetAVenirs == null)
            {
                return Problem("Entity set 'SiteWebBdsDbContext.ProjetAvenir'  is null.");
            }
            var projetAvenir = await _context.ProjetAVenirs.FindAsync(id);
            if (projetAvenir!= null)
            {
                _context.ProjetAVenirs.Remove(projetAvenir);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProjetsAvenirExists(string id)
        {
            return (_context.ProjetAVenirs?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}

