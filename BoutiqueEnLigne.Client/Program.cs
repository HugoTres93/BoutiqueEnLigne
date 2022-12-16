using BoutiqueEnLigne.Core.Repositories;
using BoutiqueEnLigne.Core.Services;
using BoutiqueEnLigne.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using BoutiqueEnLigne.Client.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<MyContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("connexion")));

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<BoutiqueEnLigneClientContext>();
//builer.Configuration["ParamTest"];
//builder.Services.AddScoped<IExempleService, ExempleService>();
// Enregistrer les services ici
builder.Services.AddScoped<IProduitPanierRepositories, ProduitPanierRepositories>();
builder.Services.AddScoped<IProduitRepositories, ProduitRepositories>();
builder.Services.AddScoped<IUtilisateurRepositories, UtilisateurRepositories>();
builder.Services.AddScoped<IProduitPanierServices, ProduitPanierServices>();
builder.Services.AddScoped<IProduitsServices, ProduitsService>();
builder.Services.AddScoped<IUtilisateurServices, UtilisateurServices>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();;

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
