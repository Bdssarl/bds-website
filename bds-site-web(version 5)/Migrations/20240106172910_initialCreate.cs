using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace bds_site_web_version_5_.Migrations
{
    /// <inheritdoc />
    public partial class initialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "actualite",
                columns: table => new
                {
                    id_Actualite = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false),
                    libelle_actualite = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false),
                    description_actualite = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false),
                    chemin_media_actualite = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id_Actualite);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "annonce_recrutement",
                columns: table => new
                {
                    id_Annonce_Recrutement = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false),
                    libelle_Annonce_recrutement = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false),
                    description_annonce_recrutement = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false),
                    date_limite_annonce_recrutement = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id_Annonce_Recrutement);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false),
                    Name = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ebook",
                columns: table => new
                {
                    id_Ebook = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false),
                    nom_Ebook = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false),
                    taille_Ebook = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false),
                    extension_Ebook = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false),
                    chemin_Ebook = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false),
                    date_creation_Ebook = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id_Ebook);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "emploi",
                columns: table => new
                {
                    id_Emploi = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false),
                    type_emploi = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false),
                    domaine_emploi = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id_Emploi);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "formation",
                columns: table => new
                {
                    id_formation = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    nom_formation = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false),
                    description_formation = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false),
                    debut_formation = table.Column<DateTime>(type: "date", nullable: false),
                    fin_formation = table.Column<DateTime>(type: "date", nullable: false),
                    statut_formation = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id_formation);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "image_",
                columns: table => new
                {
                    id_Image = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false),
                    nom_image = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false),
                    taille_image = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false),
                    type_image = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    extension_image = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false),
                    chemin_image = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false),
                    date_creation = table.Column<DateTime>(type: "date", nullable: false),
                    hauteur_image = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    largeur_image = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id_Image);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "metier",
                columns: table => new
                {
                    Id_Metier = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false),
                    Name_Image_Metier = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false),
                    Chemin_Image_Metier = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false),
                    Title_Metier = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false),
                    Decription_Metier = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.Id_Metier);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "newsletter",
                columns: table => new
                {
                    id_newsletter = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    nom_newsletter = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    chemin_media_newsletter = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    description_newsletter = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id_newsletter);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "partenaire",
                columns: table => new
                {
                    id_partenaire = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    nom_partenaire = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false),
                    chemin_image__temoignage = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id_partenaire);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "projet_a_venir",
                columns: table => new
                {
                    id_projet_A_venir = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false),
                    nom_projet_A_venir = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false),
                    duree_projet_A_venir = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    objectif_projet_A_venir = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    date_debut_projet_A_venir = table.Column<DateTime>(type: "date", nullable: false),
                    date_fin_projet_A_venir = table.Column<DateTime>(type: "date", nullable: false),
                    nom_image_projet_A_venir = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false),
                    chemin_image_projet_A_venir = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id_projet_A_venir);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "projet_en_cours",
                columns: table => new
                {
                    id_projet_En_cours = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false),
                    nom_projet_En_cours = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false),
                    duree_projet_En_cours = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    objectif_resultat_realise = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    resume_du_projet_en_cours = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    date_debut_projet_En_cours = table.Column<DateTime>(type: "date", nullable: false),
                    date_fin_projet_En_cours = table.Column<DateTime>(type: "date", nullable: false),
                    nom_image_projet_En_cours = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false),
                    chemin_image_projet_En_cours = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id_projet_En_cours);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "projet_realises",
                columns: table => new
                {
                    id_projet_realise = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false),
                    nom_projet_realise = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false),
                    duree_projet_realise = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    date_debut_projet_realise = table.Column<DateTime>(type: "date", nullable: false),
                    date_fin_projet_realise = table.Column<DateTime>(type: "date", nullable: false),
                    objectif_resultat_realise = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    resultat_projet_realise = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    nom_image_projet_realise = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false),
                    chemin_image_projet_realise = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id_projet_realise);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "recommandation",
                columns: table => new
                {
                    FirstName = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false),
                    LastName = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false)
                },
                constraints: table =>
                {
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "temoignage",
                columns: table => new
                {
                    id_temoignage = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    nom_temoignage = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false),
                    description_temoignage = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false),
                    role_temoignage = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true),
                    chemin_image_temoignage = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id_temoignage);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "UserNewsletter",
                columns: table => new
                {
                    Email_User = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.Email_User);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "video",
                columns: table => new
                {
                    id_Video = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false),
                    nom_video = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false),
                    taille_video = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false),
                    extension_video = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false),
                    chemin_video = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false),
                    date_creation_video = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id_Video);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: false),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "UserToNewsLetters",
                columns: table => new
                {
                    NewslettersId = table.Column<string>(type: "varchar(20)", nullable: false),
                    UserNewslettersEmailUser = table.Column<string>(type: "varchar(25)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserToNewsLetters", x => new { x.NewslettersId, x.UserNewslettersEmailUser });
                    table.ForeignKey(
                        name: "FK_UserToNewsLetters_UserNewsletter_UserNewslettersEmailUser",
                        column: x => x.UserNewslettersEmailUser,
                        principalTable: "UserNewsletter",
                        principalColumn: "Email_User",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserToNewsLetters_newsletter_NewslettersId",
                        column: x => x.NewslettersId,
                        principalTable: "newsletter",
                        principalColumn: "id_newsletter",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "varchar(255)", nullable: false),
                    ProviderKey = table.Column<string>(type: "varchar(255)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "longtext", nullable: true),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false),
                    civilite = table.Column<string>(type: "longtext", nullable: false),
                    FirstName = table.Column<string>(type: "longtext", nullable: false),
                    LastName = table.Column<string>(type: "longtext", nullable: false),
                    DemandeStageStagesId = table.Column<string>(type: "varchar(25)", nullable: true),
                    DemandeStageUsersId = table.Column<string>(type: "varchar(255)", nullable: true),
                    UserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PasswordHash = table.Column<string>(type: "longtext", nullable: true),
                    SecurityStamp = table.Column<string>(type: "longtext", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true),
                    PhoneNumber = table.Column<string>(type: "longtext", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false),
                    LoginProvider = table.Column<string>(type: "varchar(255)", nullable: false),
                    Name = table.Column<string>(type: "varchar(255)", nullable: false),
                    Value = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Consulters",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false),
                    IdConsulter = table.Column<string>(type: "longtext", nullable: false),
                    DateConsulter = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IdUser = table.Column<string>(type: "longtext", nullable: false),
                    EbooksId = table.Column<string>(type: "varchar(25)", nullable: false),
                    UsersId = table.Column<string>(type: "varchar(255)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consulters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Consulters_AspNetUsers_UsersId",
                        column: x => x.UsersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Consulters_ebook_EbooksId",
                        column: x => x.EbooksId,
                        principalTable: "ebook",
                        principalColumn: "id_Ebook",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "DemandeEmplois",
                columns: table => new
                {
                    IdEmploiNavigationId = table.Column<string>(type: "varchar(25)", nullable: false),
                    UsersId = table.Column<string>(type: "varchar(255)", nullable: false),
                    IdDemandeEmploi = table.Column<string>(type: "longtext", nullable: false),
                    IdEmploi = table.Column<string>(type: "longtext", nullable: false),
                    DateEnvoiDemandeEmploi = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    TypeEmploi = table.Column<string>(type: "longtext", nullable: false),
                    Periode = table.Column<string>(type: "longtext", nullable: false),
                    NomCvDemandeEmploi = table.Column<string>(type: "longtext", nullable: false),
                    CheminCvDemandeEmploi = table.Column<string>(type: "longtext", nullable: false),
                    MessageDemandeEmploi = table.Column<string>(type: "longtext", nullable: false),
                    ObjetMessageEmploi = table.Column<string>(type: "longtext", nullable: false),
                    DescriptionMessageEmploi = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DemandeEmplois", x => new { x.IdEmploiNavigationId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_DemandeEmplois_AspNetUsers_UsersId",
                        column: x => x.UsersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DemandeEmplois_emploi_IdEmploiNavigationId",
                        column: x => x.IdEmploiNavigationId,
                        principalTable: "emploi",
                        principalColumn: "id_Emploi",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "message",
                columns: table => new
                {
                    id_Message = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false),
                    objet_message = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false),
                    description_message = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    date_message = table.Column<DateTime>(type: "date", nullable: false),
                    IdUser = table.Column<string>(type: "varchar(255)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id_Message);
                    table.ForeignKey(
                        name: "FK_message_AspNetUsers_IdUser",
                        column: x => x.IdUser,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PostulerAnnonceRecrutements",
                columns: table => new
                {
                    AnnonceRecrutementsId = table.Column<string>(type: "varchar(25)", nullable: false),
                    UsersId = table.Column<string>(type: "varchar(255)", nullable: false),
                    IdPostulerAnnonceRecrutement = table.Column<string>(type: "longtext", nullable: false),
                    IdAnnonceRecrutement = table.Column<string>(type: "longtext", nullable: false),
                    MessagePostulerAnnonceRecrutement = table.Column<string>(type: "longtext", nullable: false),
                    DateEnvoiPostulerAnnonceRecrutement = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostulerAnnonceRecrutements", x => new { x.AnnonceRecrutementsId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_PostulerAnnonceRecrutements_AspNetUsers_UsersId",
                        column: x => x.UsersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PostulerAnnonceRecrutements_annonce_recrutement_AnnonceRecru~",
                        column: x => x.AnnonceRecrutementsId,
                        principalTable: "annonce_recrutement",
                        principalColumn: "id_Annonce_Recrutement",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Telechargers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false),
                    IdEbook = table.Column<string>(type: "longtext", nullable: false),
                    DateTelechargement = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Avis = table.Column<string>(type: "longtext", nullable: true),
                    idUser = table.Column<string>(type: "longtext", nullable: false),
                    EbooksId = table.Column<string>(type: "varchar(25)", nullable: false),
                    UsersId = table.Column<string>(type: "varchar(255)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Telechargers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Telechargers_AspNetUsers_UsersId",
                        column: x => x.UsersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Telechargers_ebook_EbooksId",
                        column: x => x.EbooksId,
                        principalTable: "ebook",
                        principalColumn: "id_Ebook",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "DemandeStages",
                columns: table => new
                {
                    StagesId = table.Column<string>(type: "varchar(25)", nullable: false),
                    UsersId = table.Column<string>(type: "varchar(255)", nullable: false),
                    ObjetMessage = table.Column<string>(type: "longtext", nullable: false),
                    DescriptionMessage = table.Column<string>(type: "longtext", nullable: true),
                    DateEnvoiDemandeStage = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    NomCvDemandeStage = table.Column<string>(type: "longtext", nullable: false),
                    CheminCvDemandeStage = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DemandeStages", x => new { x.StagesId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_DemandeStages_AspNetUsers_UsersId",
                        column: x => x.UsersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "stage",
                columns: table => new
                {
                    id_Stage = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false),
                    domaine_stage = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    DemandeStageStagesId = table.Column<string>(type: "varchar(25)", nullable: true),
                    DemandeStageUsersId = table.Column<string>(type: "varchar(255)", nullable: true),
                    StageTypeStageStagesId = table.Column<string>(type: "varchar(25)", nullable: true),
                    StageTypeStageTypeStagesId = table.Column<string>(type: "varchar(25)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id_Stage);
                    table.ForeignKey(
                        name: "FK_stage_DemandeStages_DemandeStageStagesId_DemandeStageUsersId",
                        columns: x => new { x.DemandeStageStagesId, x.DemandeStageUsersId },
                        principalTable: "DemandeStages",
                        principalColumns: new[] { "StagesId", "UsersId" });
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "StageTypeStages",
                columns: table => new
                {
                    StagesId = table.Column<string>(type: "varchar(25)", nullable: false),
                    TypeStagesId = table.Column<string>(type: "varchar(25)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StageTypeStages", x => new { x.StagesId, x.TypeStagesId });
                    table.ForeignKey(
                        name: "FK_StageTypeStages_stage_StagesId",
                        column: x => x.StagesId,
                        principalTable: "stage",
                        principalColumn: "id_Stage",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TypeStage",
                columns: table => new
                {
                    id_TypeStage = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false),
                    Libelelle_TypeStage = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    StageTypeStageStagesId = table.Column<string>(type: "varchar(25)", nullable: true),
                    StageTypeStageTypeStagesId = table.Column<string>(type: "varchar(25)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id_TypeStage);
                    table.ForeignKey(
                        name: "FK_TypeStage_StageTypeStages_StageTypeStageStagesId_StageTypeSt~",
                        columns: x => new { x.StageTypeStageStagesId, x.StageTypeStageTypeStagesId },
                        principalTable: "StageTypeStages",
                        principalColumns: new[] { "StagesId", "TypeStagesId" });
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_DemandeStageStagesId_DemandeStageUsersId",
                table: "AspNetUsers",
                columns: new[] { "DemandeStageStagesId", "DemandeStageUsersId" });

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Consulters_EbooksId",
                table: "Consulters",
                column: "EbooksId");

            migrationBuilder.CreateIndex(
                name: "IX_Consulters_UsersId",
                table: "Consulters",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_DemandeEmplois_UsersId",
                table: "DemandeEmplois",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_DemandeStages_UsersId",
                table: "DemandeStages",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_message_IdUser",
                table: "message",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "IX_PostulerAnnonceRecrutements_UsersId",
                table: "PostulerAnnonceRecrutements",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_stage_DemandeStageStagesId_DemandeStageUsersId",
                table: "stage",
                columns: new[] { "DemandeStageStagesId", "DemandeStageUsersId" });

            migrationBuilder.CreateIndex(
                name: "IX_stage_StageTypeStageStagesId_StageTypeStageTypeStagesId",
                table: "stage",
                columns: new[] { "StageTypeStageStagesId", "StageTypeStageTypeStagesId" });

            migrationBuilder.CreateIndex(
                name: "IX_StageTypeStages_TypeStagesId",
                table: "StageTypeStages",
                column: "TypeStagesId");

            migrationBuilder.CreateIndex(
                name: "IX_Telechargers_EbooksId",
                table: "Telechargers",
                column: "EbooksId");

            migrationBuilder.CreateIndex(
                name: "IX_Telechargers_UsersId",
                table: "Telechargers",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_TypeStage_StageTypeStageStagesId_StageTypeStageTypeStagesId",
                table: "TypeStage",
                columns: new[] { "StageTypeStageStagesId", "StageTypeStageTypeStagesId" });

            migrationBuilder.CreateIndex(
                name: "IX_UserToNewsLetters_UserNewslettersEmailUser",
                table: "UserToNewsLetters",
                column: "UserNewslettersEmailUser");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_DemandeStages_DemandeStageStagesId_DemandeStageU~",
                table: "AspNetUsers",
                columns: new[] { "DemandeStageStagesId", "DemandeStageUsersId" },
                principalTable: "DemandeStages",
                principalColumns: new[] { "StagesId", "UsersId" });

            migrationBuilder.AddForeignKey(
                name: "FK_DemandeStages_stage_StagesId",
                table: "DemandeStages",
                column: "StagesId",
                principalTable: "stage",
                principalColumn: "id_Stage",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_stage_StageTypeStages_StageTypeStageStagesId_StageTypeStageT~",
                table: "stage",
                columns: new[] { "StageTypeStageStagesId", "StageTypeStageTypeStagesId" },
                principalTable: "StageTypeStages",
                principalColumns: new[] { "StagesId", "TypeStagesId" });

            migrationBuilder.AddForeignKey(
                name: "FK_StageTypeStages_TypeStage_TypeStagesId",
                table: "StageTypeStages",
                column: "TypeStagesId",
                principalTable: "TypeStage",
                principalColumn: "id_TypeStage",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DemandeStages_AspNetUsers_UsersId",
                table: "DemandeStages");

            migrationBuilder.DropForeignKey(
                name: "FK_stage_DemandeStages_DemandeStageStagesId_DemandeStageUsersId",
                table: "stage");

            migrationBuilder.DropForeignKey(
                name: "FK_StageTypeStages_stage_StagesId",
                table: "StageTypeStages");

            migrationBuilder.DropForeignKey(
                name: "FK_TypeStage_StageTypeStages_StageTypeStageStagesId_StageTypeSt~",
                table: "TypeStage");

            migrationBuilder.DropTable(
                name: "actualite");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Consulters");

            migrationBuilder.DropTable(
                name: "DemandeEmplois");

            migrationBuilder.DropTable(
                name: "formation");

            migrationBuilder.DropTable(
                name: "image_");

            migrationBuilder.DropTable(
                name: "message");

            migrationBuilder.DropTable(
                name: "metier");

            migrationBuilder.DropTable(
                name: "partenaire");

            migrationBuilder.DropTable(
                name: "PostulerAnnonceRecrutements");

            migrationBuilder.DropTable(
                name: "projet_a_venir");

            migrationBuilder.DropTable(
                name: "projet_en_cours");

            migrationBuilder.DropTable(
                name: "projet_realises");

            migrationBuilder.DropTable(
                name: "recommandation");

            migrationBuilder.DropTable(
                name: "Telechargers");

            migrationBuilder.DropTable(
                name: "temoignage");

            migrationBuilder.DropTable(
                name: "UserToNewsLetters");

            migrationBuilder.DropTable(
                name: "video");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "emploi");

            migrationBuilder.DropTable(
                name: "annonce_recrutement");

            migrationBuilder.DropTable(
                name: "ebook");

            migrationBuilder.DropTable(
                name: "UserNewsletter");

            migrationBuilder.DropTable(
                name: "newsletter");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "DemandeStages");

            migrationBuilder.DropTable(
                name: "stage");

            migrationBuilder.DropTable(
                name: "StageTypeStages");

            migrationBuilder.DropTable(
                name: "TypeStage");
        }
    }
}
