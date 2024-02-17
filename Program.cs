using bds_site_web_version7_.Models;
using bds_site_web_version7_.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Microsoft.AspNetCore.Authentication.Cookies;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddTransient<IFileUpload, FileUpload>();
builder.Services.AddTransient<SignInManager<User>, SignInManager<User>>();
builder.Services.AddScoped<IEmailSender, EmailSender>();
var emailConfig = builder.Configuration
        .GetSection("EmailConfiguration")
        .Get<EmailConfiguration>();
builder.Services.AddSingleton(emailConfig);

// Register UserManager
builder.Services.AddTransient<UserManager<User>, UserManager<User>>();
// Add services to the container.
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
            .AddCookie(options =>
            {
                options.LoginPath = "/Account/Login";
                options.Cookie.Name = ".AspNetCore.Cookies";
                options.ExpireTimeSpan = TimeSpan.FromMinutes(10);
                options.SlidingExpiration = true;

            });
builder.Services.Configure<IdentityOptions>(opts =>
{
    opts.Password.RequiredLength = 8;
    opts.Password.RequireLowercase = true;
});

builder.Services.AddHttpContextAccessor();
builder.Services.AddDbContext<SiteWebBdsDbContext>();

builder.Services.AddIdentityCore<User>(option => option.User.RequireUniqueEmail = true)
    .AddEntityFrameworkStores<SiteWebBdsDbContext>().AddDefaultTokenProviders();

builder.Services.AddControllersWithViews();

/*builder.Services.ConfigureApplicationCookie(opts => opts.LoginPath = "/Authenticate/Login");*/

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Temoignage Api",
        Description = "get tesmony about us ",
        Version = "v1"
    });
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Testimony API V1");
});

app.UseHttpsRedirection();
app.UseDefaultFiles();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Acceuil}/{action=Acceuil}/{id?}");
app.MapGet("/temoignages", async (SiteWebBdsDbContext db) => await db.Temoignages.ToListAsync());
app.MapGet("/Banner", async (SiteWebBdsDbContext db) => await db.Images.Where(t=>t.TypeImage=="banniere").ToListAsync());
app.MapGet("/Videos", async (SiteWebBdsDbContext db) => await db.Videos.ToListAsync());
app.MapGet("/Partenaires", async (SiteWebBdsDbContext db) => await db.Partenaires.ToListAsync());
app.MapGet("/Metiers", async (SiteWebBdsDbContext db) => await db.Metiers.ToListAsync());
app.MapGet("/Actualites", async (SiteWebBdsDbContext db) => await db.Actualites.ToListAsync());
app.MapGet("/chiffres", async (SiteWebBdsDbContext db) => await db.Chiffres.ToListAsync());
app.Run();