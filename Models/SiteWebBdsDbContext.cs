using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using bds_site_web_version7_.Models;

namespace bds_site_web_version7_.Models
{
    public partial class SiteWebBdsDbContext : IdentityDbContext<User>
{
    public SiteWebBdsDbContext()
    {
    }

    public SiteWebBdsDbContext(DbContextOptions options)
        : base(options)
    {
    }

    public virtual DbSet<Actualite> Actualites { get; set; }

    public virtual DbSet<AnnonceRecrutement> AnnonceRecrutements { get; set; }

    public virtual DbSet<Consulter> Consulters { get; set; }

    public virtual DbSet<DemandeEmploi> DemandeEmplois { get; set; }

    public virtual DbSet<DemandeStage> DemandeStages { get; set; }

    public virtual DbSet<Ebook> Ebooks { get; set; }

    public virtual DbSet<Emploi> Emplois { get; set; }

    public virtual DbSet<FormationTermine> FormationTermines { get; set; }

    public virtual DbSet<Image> Images { get; set; }

    public virtual DbSet<Message> Messages { get; set; }

    public virtual DbSet<Newsletter> Newsletters { get; set; }

    public virtual DbSet<Partenaire> Partenaires { get; set; }

    public virtual DbSet<PostulerAnnonceRecrutement> PostulerAnnonceRecrutements { get; set; }

    public virtual DbSet<ProjetAVenir> ProjetAVenirs { get; set; }

    public virtual DbSet<ProjetEnCour> ProjetEnCours { get; set; }

    public virtual DbSet<ProjetRealise> ProjetRealises { get; set; }

    public virtual DbSet<Recommandation> Recommandations { get; set; }

    public virtual DbSet<Stage> Stages { get; set; }

    public virtual DbSet<Telecharger> Telechargers { get; set; }

    public virtual DbSet<Temoignage> Temoignages { get; set; }

    public virtual DbSet<Video> Videos { get; set; }
    public virtual DbSet<Metier> Metiers { get; set; }
    public virtual DbSet<UserNewsletter> UserNewsletters { get; set; }
    public virtual DbSet<UserToNewsLetter> UserToNewsLetters { get; set; }
    public virtual DbSet<TypeStage> TypeStages { get; set; }
    public virtual DbSet<Chiffre> Chiffres { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
            => optionsBuilder.UseMySQL("server=localhost;database=site_web_bds_db;port=3306;user=root;password=faquira5379");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
            base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Actualite>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("actualite");

            entity.Property(e => e.Id)
                .HasMaxLength(255)
                .HasColumnName("id_Actualite");
            entity.Property(e => e.CheminMediaActualite)
                .HasMaxLength(25)
                .HasColumnName("chemin_media_actualite");
            entity.Property(e => e.DescriptionActualite)
                .HasMaxLength(25)
                .HasColumnName("description_actualite");
            entity.Property(e => e.LibelleActualite)
                .HasMaxLength(25)
                .HasColumnName("libelle_actualite");
        });

        modelBuilder.Entity<AnnonceRecrutement>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("annonce_recrutement");

            entity.Property(e => e.Id)
                .HasMaxLength(255)
                .HasColumnName("id_Annonce_Recrutement");
            entity.Property(e => e.DateLimiteAnnonceRecrutement)
                .HasColumnType("date")
                .HasColumnName("date_limite_annonce_recrutement");
            entity.Property(e => e.DescriptionAnnonceRecrutement)
                .HasMaxLength(25)
                .HasColumnName("description_annonce_recrutement");
            entity.Property(e => e.LibelleAnnonceRecrutement)
                .HasMaxLength(25)
                .HasColumnName("libelle_Annonce_recrutement");
        });
            modelBuilder.Entity<Chiffre>(entity =>
            {
                entity.HasKey(e=>e.Id).HasName("PRIMARY");

                entity.ToTable("chiffre");
                entity.Property(e => e.Id)
                   .HasMaxLength(255)
                   .HasColumnName("Id_chiffre");
                entity.Property(e => e.AnneeExperience)
                    .HasMaxLength(25)
                    .HasColumnName("AnneeExperience");
                entity.Property(e => e.NombreProjetsRealises)
                    .HasMaxLength(25)
                    .HasColumnName("NombreProjetsRealises");
                entity.Property(e => e.NombreProjetsRealises)
                    .HasMaxLength(25)
                    .HasColumnName("NombreProjetsRealises");
            });

            modelBuilder.Entity<User>()
      .HasMany(e => e.Ebooks)
      .WithMany(e => e.Users)
      .UsingEntity<Consulter>();

       

        modelBuilder.Entity<User>()
          .HasMany(e => e.Stages)
          .WithMany(e => e.Users)
          .UsingEntity<DemandeStage>();
            modelBuilder.Entity<User>()
         .HasMany(e => e.Emplois)
         .WithMany(e => e.Users)
         .UsingEntity<DemandeEmploi>();


            modelBuilder.Entity<Ebook>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("ebook");

            entity.Property(e => e.Id)
                .HasMaxLength(255)
                .HasColumnName("id_Ebook");
            entity.Property(e => e.CheminEbook)
                .HasMaxLength(25)
                .HasColumnName("chemin_Ebook");
            entity.Property(e => e.DateCreationEbook)
                .HasColumnType("date")
                .HasColumnName("date_creation_Ebook");
            entity.Property(e => e.ExtensionEbook)
                .HasMaxLength(25)
                .HasColumnName("extension_Ebook");
            entity.Property(e => e.NomEbook)
                .HasMaxLength(25)
                .HasColumnName("nom_Ebook");
            entity.Property(e => e.TailleEbook)
                .HasMaxLength(25)
                .HasColumnName("taille_Ebook");
        });

        modelBuilder.Entity<Emploi>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("emploi");

            entity.Property(e => e.Id)
                .HasMaxLength(255)
                .HasColumnName("id_Emploi");
            entity.Property(e => e.DomaineEmploi)
                .HasMaxLength(20)
                .HasColumnName("domaine_emploi");
            entity.Property(e => e.TypeEmploi)
                .HasMaxLength(45)
                .HasColumnName("type_emploi");
        });

        modelBuilder.Entity<FormationTermine>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("formationTermine");

            entity.Property(e => e.Id)
                .HasMaxLength(255)
                .HasColumnName("id_formation");
            entity.Property(e => e.IntituleFormation)
                .HasMaxLength(255)
                .HasColumnName("IntituleFormation");
            entity.Property(e => e.CompetenceAcquise)
                .HasMaxLength(255)
                .HasColumnName("CompetenceAcquise");
            entity.Property(e => e.Participants)
                .HasMaxLength(255)
                .HasColumnName("participant");
            entity.Property(e => e.PartenaireTechnique)
               .HasMaxLength(255)
               .HasColumnName("partenaireTechnique");
            entity.Property(e => e.CheminImage)
              .HasMaxLength(255)
              .HasColumnName("CheminImage");
            entity.Property(e => e.Periode)
             .HasMaxLength(25)
             .HasColumnName("Periode");
            entity.Property(e => e.Annee)
            .HasMaxLength(4)
            .HasColumnName("Annee");
        });

        modelBuilder.Entity<Image>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("image_");

            entity.Property(e => e.Id)
                .HasMaxLength(255)
                .HasColumnName("id_Image");
            entity.Property(e => e.CheminImage)
                .HasMaxLength(255)
                .HasColumnName("chemin_image");
            entity.Property(e => e.DateCreation)
                .HasColumnType("date")
                .HasColumnName("date_creation");
            entity.Property(e => e.ExtensionImage)
                .HasMaxLength(25)
                .HasDefaultValue("jpg")
                .HasColumnName("extension_image");
            entity.Property(e => e.HauteurImage)
                  .HasDefaultValue("455")
                .HasMaxLength(10)
                .HasColumnName("hauteur_image");
            entity.Property(e => e.LargeurImage)
                  .HasDefaultValue("255")
                .HasMaxLength(10)
                .HasColumnName("largeur_image");
            entity.Property(e => e.NomImage)
                .HasMaxLength(25)
                .HasColumnName("nom_image");
            entity.Property(e => e.TailleImage)
                 .HasDefaultValue("256")
                .HasMaxLength(25)
                .HasColumnName("taille_image");
            entity.Property(e => e.TypeImage)
                .HasMaxLength(10)
                .HasColumnName("type_image");
        });

        modelBuilder.Entity<Message>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("message");

            entity.Property(e => e.Id)
                .HasMaxLength(255)
                .HasColumnName("id_Message");
            entity.Property(e => e.DateMessage)
                .HasColumnType("date")
                .HasColumnName("date_message");
            entity.Property(e => e.DescriptionMessage)
                .HasMaxLength(255)
                .HasColumnName("description_message");
            entity.Property(e => e.ObjetMessage)
                .HasMaxLength(45)
                .HasColumnName("objet_message");
        });

        modelBuilder.Entity<Newsletter>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("newsletter");

            entity.Property(e => e.Id)
                .HasMaxLength(255)
                .HasColumnName("id_newsletter");
            entity.Property(e => e.CheminMediaNewsletter)
                .HasMaxLength(20)
                .HasColumnName("chemin_media_newsletter");
            entity.Property(e => e.DescriptionNewsletter)
                .HasMaxLength(20)
                .HasColumnName("description_newsletter");
            entity.Property(e => e.NomNewsletter)
                .HasMaxLength(20)
                .HasColumnName("nom_newsletter");
        });

       /* modelBuilder.Entity<Page>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Id }).HasName("PRIMARY");

            entity.ToTable("page_");

            entity.HasIndex(e => e.Id, "fk_1_page");

            entity.Property(e => e.Id)
                .HasMaxLength(25)
                .HasColumnName("id_Page");
            entity.Property(e => e.Id)
                .HasMaxLength(25)
                .HasColumnName("id_Actualite");
            entity.Property(e => e.DateTelechargement)
                .HasColumnType("date")
                .HasColumnName("date_telechargement");
            entity.Property(e => e.LibellePage)
                .HasMaxLength(25)
                .HasColumnName("libelle_page");

            entity.HasOne(d => d.Id).WithMany(p => p.Pages)
                .HasForeignKey(d => d.Id)
                .HasConstraintName("fk_1_page");
        });*/

        modelBuilder.Entity<Partenaire>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("partenaire");

            entity.Property(e => e.Id)
                .HasMaxLength(255)
                .HasColumnName("id_partenaire");
            entity.Property(e => e.CheminImageTemoignage)
                .HasMaxLength(45)
                .HasColumnName("chemin_image__temoignage");
            entity.Property(e => e.NomPartenaire)
                .HasMaxLength(45)
                .HasColumnName("nom_partenaire");
        });

            modelBuilder.Entity<User>()
         .HasMany(e => e.AnnonceRecrutements)
         .WithMany(e => e.Users)
         .UsingEntity<PostulerAnnonceRecrutement>();

            modelBuilder.Entity<ProjetAVenir>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("projet_a_venir");

            entity.Property(e => e.Id)
                .HasMaxLength(255)
                .HasColumnName("id_projet_A_venir");
            entity.Property(e => e.Idee)
                .HasMaxLength(255)
                .HasColumnName("Idee");
            entity.Property(e => e.cheminImage)
                .HasMaxLength(255)
                .HasColumnName("CheminImage");
        });

        modelBuilder.Entity<ProjetEnCour>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("projet_en_cours");

            entity.Property(e => e.Id)
                .HasMaxLength(255)
                .HasColumnName("id_projet_En_cours");
            entity.Property(e => e.CheminImageProjetEnCours)
                .HasMaxLength(255)
                .HasColumnName("chemin_image_projet_En_cours");
            entity.Property(e => e.DateDebutProjetEnCours)
                .HasColumnType("date")
                .HasColumnName("date_debut_projet_En_cours");
            entity.Property(e => e.DateFinProjetEnCours)
                .HasColumnType("date")
                .HasColumnName("date_fin_projet_En_cours");
            entity.Property(e => e.DureeProjetEnCours)
                .HasMaxLength(10)
                .HasColumnName("duree_projet_En_cours");
            entity.Property(e => e.NomImageProjetEnCours)
                .HasMaxLength(25)
                .HasColumnName("nom_image_projet_En_cours");
            entity.Property(e => e.NomProjetEnCours)
                .HasMaxLength(25)
                .HasColumnName("nom_projet_En_cours");
            entity.Property(e => e.ObjectifResultatRealise)
                .HasMaxLength(20)
                .HasColumnName("objectif_resultat_realise");
            entity.Property(e => e.ResumeDuProjetEnCours)
                .HasMaxLength(20)
                .HasColumnName("resume_du_projet_en_cours");
        });

        modelBuilder.Entity<ProjetRealise>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("projet_realises");

            entity.Property(e => e.Id)
                .HasMaxLength(255)
                .HasColumnName("id_projet_realise");
            entity.Property(e => e.Intitule_Projet)
                .HasMaxLength(255)
                .HasColumnName("Intitule_Projet");
            entity.Property(e => e.Donneur_Ordre)
                   .HasMaxLength(255)
                .HasColumnName("Donneur_Ordre");  
            entity.Property(e => e.Duree)
            .HasMaxLength(255)
                .HasColumnName("Duree");
            entity.Property(e => e.TacheExecute)
            .HasMaxLength(255)
                .HasColumnName("TacheExecute");
            entity.Property(e => e.Annee)
            .HasMaxLength(4)
               .HasColumnName("Annee");
            entity.Property(e => e.ChemImageProjetRealise)
            .HasMaxLength(255)
               .HasColumnName("cheminImage");
        });

        modelBuilder.Entity<Recommandation>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("recommandation");

            entity.Property(e => e.FirstName).HasMaxLength(45);
            entity.Property(e => e.LastName).HasMaxLength(45);
        });

        modelBuilder.Entity<Stage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("stage");

            entity.Property(e => e.Id)
                .HasMaxLength(255)
                .HasColumnName("id_Stage");
            entity.Property(e => e.DomaineStage)
                .HasMaxLength(255)
                .HasColumnName("domaine_stage");
           
        });
            modelBuilder.Entity<TypeStage>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("TypeStage");

                entity.Property(e => e.Id)
                    .HasMaxLength(255)
                    .HasColumnName("id_TypeStage");
                entity.Property(e => e.LibelleTypeStage)
                    .HasMaxLength(255)
                    .HasColumnName("Libelelle_TypeStage");

            });
            modelBuilder.Entity<TypeStage>()
   .HasMany(e => e.Stages)
   .WithOne(e => e.typestage)
   .HasForeignKey(e=>e.IdTypeStage);
            modelBuilder.Entity<Emploi>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("Emploi");

                entity.Property(e => e.Id)
                    .HasMaxLength(255)
                    .HasColumnName("id_Emploi");
                entity.Property(e => e.DomaineEmploi)
                    .HasMaxLength(255)
                    .HasColumnName("domaine_Emploi");

            });
            modelBuilder.Entity<TypeEmploi>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("TypeEmploi");

                entity.Property(e => e.Id)
                    .HasMaxLength(255)
                    .HasColumnName("id_TypeEmploi");
                entity.Property(e => e.LibelleTypeEmploi)
                    .HasMaxLength(255)
                    .HasColumnName("Libelelle_TypeEmploi");

            });
            modelBuilder.Entity<TypeEmploi>()
  .HasMany(e => e.Emplois)
  .WithOne(e => e.typeEmploi)
  .HasForeignKey(e => e.IdTypeEmploi);

            modelBuilder.Entity<User>()
 .HasMany(e => e.Ebooks)
 .WithMany(e => e.Users)
 .UsingEntity<Telecharger>();

            modelBuilder.Entity<Temoignage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("temoignage");

            entity.Property(e => e.Id)
                .HasMaxLength(255)
                .HasColumnName("id_temoignage");
            entity.Property(e => e.CheminImageTemoignage)
                .HasMaxLength(40)
                .HasColumnName("chemin_image_temoignage");
            entity.Property(e => e.DescriptionTemoignage)
                .HasMaxLength(45)
                .HasColumnName("description_temoignage");
            entity.Property(e => e.NomTemoignage)
                .HasMaxLength(45)
                .HasColumnName("nom_temoignage");
            entity.Property(e => e.RoleTemoignage)
                .HasMaxLength(45)
                .HasColumnName("role_temoignage");
        });

        modelBuilder.Entity<Video>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("video");

            entity.Property(e => e.Id)
                .HasMaxLength(255)
                .HasColumnName("id_Video");
            entity.Property(e => e.CheminVideo)
                .HasMaxLength(25)
                .HasColumnName("chemin_video");
            entity.Property(e => e.DateCreationVideo)
                .HasColumnType("date")
                .HasColumnName("date_creation_video");
            entity.Property(e => e.ExtensionVideo)
                .HasMaxLength(25)
                .HasColumnName("extension_video");
            entity.Property(e => e.NomVideo)
                .HasMaxLength(25)
                .HasColumnName("nom_video");
            entity.Property(e => e.TailleVideo)
                .HasMaxLength(25)
                .HasColumnName("taille_video");
        });
            modelBuilder.Entity<User>()
.HasMany(e => e.Messages)
.WithOne(e => e.user)
.HasForeignKey(e => e.IdUser)
.IsRequired();
            modelBuilder.Entity<Metier>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("metier");

                entity.Property(e => e.Id)
                    .HasMaxLength(255)
                    .HasColumnName("Id_Metier");
                entity.Property(e => e.NameImageMetier)
                    .HasMaxLength(255)
                    .HasColumnName("Name_Image_Metier");
                entity.Property(e => e.TitleMetier)
                    .HasMaxLength(255)
                    .HasColumnName("Title_Metier");
                entity.Property(e => e.DescriptionMetier)
                   .HasMaxLength(255)
                   .HasColumnName("Decription_Metier");
            });
            modelBuilder.Entity<UserNewsletter>(entity =>
            {
                entity.HasKey(e => e.EmailUser).HasName("PRIMARY");

                entity.ToTable("UserNewsletter");

                entity.Property(e => e.EmailUser)
                    .HasMaxLength(25)
                    .HasColumnName("Email_User");
            });
            modelBuilder.Entity<UserNewsletter>()
.HasMany(e => e.Newsletters)
.WithMany(e => e.UserNewsletters)
.UsingEntity<UserToNewsLetter>();

            OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
}
