using Bds_site_web.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<SiteWebBdsDbContext>();
builder.Services.AddIdentityCore<User>(option => option.User.RequireUniqueEmail = true)
    .AddEntityFrameworkStores<SiteWebBdsDbContext>();
builder.Services.AddTransient < UserManager < User > ,UserManager < User >> ();
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
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Statistiques}/{action=Statistiques}/{id?}");
app.MapGet("/temoignages", async (SiteWebBdsDbContext db) => await db.Temoignages.ToListAsync());
app.Run();
