using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;

namespace Bds_site_web.Models
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

    public virtual DbSet<Formation> Formations { get; set; }

    public virtual DbSet<Image> Images { get; set; }

    public virtual DbSet<Message> Messages { get; set; }

    public virtual DbSet<Newsletter> Newsletters { get; set; }

    public virtual DbSet<Page> Pages { get; set; }

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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
            => optionsBuilder.UseMySQL("server=localhost;database=site_web_bds_db;port=3306;user=root;password=faquira5379");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
            base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Actualite>(entity =>
        {
            entity.HasKey(e => e.IdActualite).HasName("PRIMARY");

            entity.ToTable("actualite");

            entity.Property(e => e.IdActualite)
                .HasMaxLength(25)
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
            entity.HasKey(e => e.IdAnnonceRecrutement).HasName("PRIMARY");

            entity.ToTable("annonce_recrutement");

            entity.Property(e => e.IdAnnonceRecrutement)
                .HasMaxLength(25)
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
            entity.HasKey(e => e.IdEbook).HasName("PRIMARY");

            entity.ToTable("ebook");

            entity.Property(e => e.IdEbook)
                .HasMaxLength(25)
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
            entity.HasKey(e => e.IdEmploi).HasName("PRIMARY");

            entity.ToTable("emploi");

            entity.Property(e => e.IdEmploi)
                .HasMaxLength(25)
                .HasColumnName("id_Emploi");
            entity.Property(e => e.DomaineEmploi)
                .HasMaxLength(20)
                .HasColumnName("domaine_emploi");
            entity.Property(e => e.TypeEmploi)
                .HasMaxLength(45)
                .HasColumnName("type_emploi");
        });

        modelBuilder.Entity<Formation>(entity =>
        {
            entity.HasKey(e => e.IdFormation).HasName("PRIMARY");

            entity.ToTable("formation");

            entity.Property(e => e.IdFormation)
                .HasMaxLength(20)
                .HasColumnName("id_formation");
            entity.Property(e => e.DebutFormation)
                .HasColumnType("date")
                .HasColumnName("debut_formation");
            entity.Property(e => e.DescriptionFormation)
                .HasMaxLength(45)
                .HasColumnName("description_formation");
            entity.Property(e => e.FinFormation)
                .HasColumnType("date")
                .HasColumnName("fin_formation");
            entity.Property(e => e.NomFormation)
                .HasMaxLength(45)
                .HasColumnName("nom_formation");
            entity.Property(e => e.StatutFormation)
                .HasMaxLength(10)
                .HasColumnName("statut_formation");
        });

        modelBuilder.Entity<Image>(entity =>
        {
            entity.HasKey(e => e.IdImage).HasName("PRIMARY");

            entity.ToTable("image_");

            entity.Property(e => e.IdImage)
                .HasMaxLength(25)
                .HasColumnName("id_Image");
            entity.Property(e => e.CheminImage)
                .HasMaxLength(25)
                .HasColumnName("chemin_image");
            entity.Property(e => e.DateCreation)
                .HasColumnType("date")
                .HasColumnName("date_creation");
            entity.Property(e => e.ExtensionImage)
                .HasMaxLength(25)
                .HasColumnName("extension_image");
            entity.Property(e => e.HauteurImage)
                .HasMaxLength(10)
                .HasColumnName("hauteur_image");
            entity.Property(e => e.LargeurImage)
                .HasMaxLength(10)
                .HasColumnName("largeur_image");
            entity.Property(e => e.NomImage)
                .HasMaxLength(25)
                .HasColumnName("nom_image");
            entity.Property(e => e.TailleImage)
                .HasMaxLength(25)
                .HasColumnName("taille_image");
            entity.Property(e => e.TypeImage)
                .HasMaxLength(10)
                .HasColumnName("type_image");
        });

        modelBuilder.Entity<Message>(entity =>
        {
            entity.HasKey(e => e.IdMessage).HasName("PRIMARY");

            entity.ToTable("message");

            entity.Property(e => e.IdMessage)
                .HasMaxLength(25)
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
            entity.HasKey(e => e.IdNewsletter).HasName("PRIMARY");

            entity.ToTable("newsletter");

            entity.Property(e => e.IdNewsletter)
                .HasMaxLength(20)
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

        modelBuilder.Entity<Page>(entity =>
        {
            entity.HasKey(e => new { e.IdPage, e.IdActualite }).HasName("PRIMARY");

            entity.ToTable("page_");

            entity.HasIndex(e => e.IdActualite, "fk_1_page");

            entity.Property(e => e.IdPage)
                .HasMaxLength(25)
                .HasColumnName("id_Page");
            entity.Property(e => e.IdActualite)
                .HasMaxLength(25)
                .HasColumnName("id_Actualite");
            entity.Property(e => e.DateTelechargement)
                .HasColumnType("date")
                .HasColumnName("date_telechargement");
            entity.Property(e => e.LibellePage)
                .HasMaxLength(25)
                .HasColumnName("libelle_page");

            entity.HasOne(d => d.IdActualiteNavigation).WithMany(p => p.Pages)
                .HasForeignKey(d => d.IdActualite)
                .HasConstraintName("fk_1_page");
        });

        modelBuilder.Entity<Partenaire>(entity =>
        {
            entity.HasKey(e => e.IdPartenaire).HasName("PRIMARY");

            entity.ToTable("partenaire");

            entity.Property(e => e.IdPartenaire)
                .HasMaxLength(20)
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
            entity.HasKey(e => e.IdProjetAVenir).HasName("PRIMARY");

            entity.ToTable("projet_a_venir");

            entity.Property(e => e.IdProjetAVenir)
                .HasMaxLength(25)
                .HasColumnName("id_projet_A_venir");
            entity.Property(e => e.CheminImageProjetAVenir)
                .HasMaxLength(25)
                .HasColumnName("chemin_image_projet_A_venir");
            entity.Property(e => e.DateDebutProjetAVenir)
                .HasColumnType("date")
                .HasColumnName("date_debut_projet_A_venir");
            entity.Property(e => e.DateFinProjetAVenir)
                .HasColumnType("date")
                .HasColumnName("date_fin_projet_A_venir");
            entity.Property(e => e.DureeProjetAVenir)
                .HasMaxLength(10)
                .HasColumnName("duree_projet_A_venir");
            entity.Property(e => e.NomImageProjetAVenir)
                .HasMaxLength(25)
                .HasColumnName("nom_image_projet_A_venir");
            entity.Property(e => e.NomProjetAVenir)
                .HasMaxLength(25)
                .HasColumnName("nom_projet_A_venir");
            entity.Property(e => e.ObjectifProjetAVenir)
                .HasMaxLength(20)
                .HasColumnName("objectif_projet_A_venir");
        });

        modelBuilder.Entity<ProjetEnCour>(entity =>
        {
            entity.HasKey(e => e.IdProjetEnCours).HasName("PRIMARY");

            entity.ToTable("projet_en_cours");

            entity.Property(e => e.IdProjetEnCours)
                .HasMaxLength(25)
                .HasColumnName("id_projet_En_cours");
            entity.Property(e => e.CheminImageProjetEnCours)
                .HasMaxLength(25)
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
            entity.HasKey(e => e.IdProjetRealise).HasName("PRIMARY");

            entity.ToTable("projet_realises");

            entity.Property(e => e.IdProjetRealise)
                .HasMaxLength(25)
                .HasColumnName("id_projet_realise");
            entity.Property(e => e.CheminImageProjetRealise)
                .HasMaxLength(25)
                .HasColumnName("chemin_image_projet_realise");
            entity.Property(e => e.DateDebutProjetRealise)
                .HasColumnType("date")
                .HasColumnName("date_debut_projet_realise");
            entity.Property(e => e.DateFinProjetRealise)
                .HasColumnType("date")
                .HasColumnName("date_fin_projet_realise");
            entity.Property(e => e.DureeProjetRealise)
                .HasMaxLength(10)
                .HasColumnName("duree_projet_realise");
            entity.Property(e => e.NomImageProjetRealise)
                .HasMaxLength(25)
                .HasColumnName("nom_image_projet_realise");
            entity.Property(e => e.NomProjetRealise)
                .HasMaxLength(25)
                .HasColumnName("nom_projet_realise");
            entity.Property(e => e.ObjectifResultatRealise)
                .HasMaxLength(20)
                .HasColumnName("objectif_resultat_realise");
            entity.Property(e => e.ResultatProjetRealise)
                .HasMaxLength(20)
                .HasColumnName("resultat_projet_realise");
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
            entity.HasKey(e => e.IdStage).HasName("PRIMARY");

            entity.ToTable("stage");

            entity.Property(e => e.IdStage)
                .HasMaxLength(25)
                .HasColumnName("id_Stage");
            entity.Property(e => e.DomaineStage)
                .HasMaxLength(255)
                .HasColumnName("domaine_stage");
            entity.Property(e => e.TypeStage)
                .HasMaxLength(45)
                .HasColumnName("type_stage");
        });
            modelBuilder.Entity<User>()
 .HasMany(e => e.Ebooks)
 .WithMany(e => e.Users)
 .UsingEntity<Telecharger>();

            modelBuilder.Entity<Temoignage>(entity =>
        {
            entity.HasKey(e => e.IdTemoignage).HasName("PRIMARY");

            entity.ToTable("temoignage");

            entity.Property(e => e.IdTemoignage)
                .HasMaxLength(20)
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
            entity.HasKey(e => e.IdVideo).HasName("PRIMARY");

            entity.ToTable("video");

            entity.Property(e => e.IdVideo)
                .HasMaxLength(25)
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
                entity.HasKey(e => e.IdMetier).HasName("PRIMARY");

                entity.ToTable("metier");

                entity.Property(e => e.IdMetier)
                    .HasMaxLength(25)
                    .HasColumnName("Id_Metier");
                entity.Property(e => e.NameImageMetier)
                    .HasMaxLength(25)
                    .HasColumnName("Name_Image_Metier");
                entity.Property(e => e.CheminImageMetier)
                    .HasMaxLength(25)
                    .HasColumnName("Chemin_Image_Metier");
                entity.Property(e => e.TitleMetier)
                    .HasMaxLength(25)
                    .HasColumnName("Title_Metier");
                entity.Property(e => e.DescriptionMetier)
                   .HasMaxLength(25)
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
