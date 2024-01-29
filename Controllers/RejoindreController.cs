
using bds_site_web_version7_.Models;
using bds_site_web_version7_.Services;
using bds_site_web_version7_.Validations;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace bds_site_web_version7_.Controllers
{
    public class RejoindreController : Controller
    {

        public  SiteWebBdsDbContext _context { get; set; }
        public  IFileUpload _fileUpload { get; set; }
        
        public RejoindreController(SiteWebBdsDbContext context,IFileUpload fileUpload)
        {
            _context = context;
            _fileUpload = fileUpload;
            

        }
        [HttpGet]
        public IActionResult NousRejoindre()
        {
            return View();
        }
        [HttpPost]
        public IActionResult NousRejoindre(UserEmploi userEmploi)
        {
            var user = new User
            {
                Id = "candit7", 
                civilite = userEmploi.civilite,
                Email = userEmploi.Email,
                FirstName = userEmploi.FirstName,
                LastName = userEmploi.LastName,
                PhoneNumber = userEmploi.PhoneNumber
            };
            _context.Users.Add(user);
            var emploi = _context.Emplois.Include(e => e.TypeEmploi).Where(e => e.DomaineEmploi == userEmploi.DomaineEmploi && e.TypeEmploi == userEmploi.TypeEmploi).First();
            var demandeEmploi = new DemandeEmploi
            {

                UserId = user.Id,
                EmploiId = emploi.Id,
                DateEnvoiDemandeEmploi = DateTime.Now,
                 ObjetMessageEmploi = userEmploi.ObjetMessage,
                MessageDemandeEmploi = userEmploi.DescriptionMessage,
                NomCvDemandeEmploi = _fileUpload.uploadfile(userEmploi.formFile, "emploi")
            }
            ;
            _context.DemandeEmplois.Add(demandeEmploi);
            _context.SaveChanges();



            return View();
        }
        public IActionResult Rejoindre()
        {
            return View();
        }
        [HttpGet]
        public IActionResult PostulerStage()
        {
            return View();
        }
        [HttpPost]
        public IActionResult PostulerStage(UserStage userStage)
        {

            var user = new User
            {
                Id="candit1",
                civilite = userStage.civilite,
                Email = userStage.Email,
                FirstName = userStage.FirstName,
                LastName = userStage.LastName,
                PhoneNumber = userStage.PhoneNumber
            };

            _context.Users.Add(user);
            var stage = _context.Stages.Include(e => e.typestage).Where(e => e.DomaineStage == userStage.DomaineStage && e.typestage.LibelleTypeStage == userStage.TypeStage).First();

            var demandeStage = new DemandeStage
            {
                StageId = stage.Id,
                UserId = user.Id,
                DateEnvoiDemandeStage = DateTime.Now,
                ObjetMessage = userStage.ObjetMessage,
                DescriptionMessage = userStage.DescriptionMessage,
                NomCvDemandeStage = _fileUpload.uploadfile(userStage.formFile, "stage")
            }
            ;
            _context.DemandeStages.Add(demandeStage);
            _context.SaveChanges();

            return View();
        }

    }
}
