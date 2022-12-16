using BoutiqueEnLigne.Core.Repositories;
using BoutiqueEnLigne.Core.Services;
using BoutiqueEnLigne.Core.Repositories;
using BoutiqueEnLigne.Repositories;
using Microsoft.EntityFrameworkCore;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<MyContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("connexion")));
//builer.Configuration["ParamTest"];
//builder.Services.AddScoped<IExempleService, ExempleService>();
// /Enregistrer les services ici
    builder.Services.AddScoped<IProduitPanierRepositories, ProduitPanierRepositories>();
    builder.Services.AddScoped<IProduitRepositories, ProduitRepositories>();
    builder.Services.AddScoped<IUtilisateurRepositories, UtilisateurRepositories>();
    builder.Services.AddScoped<IProduitPanierServices, ProduitPanierServices>();
    builder.Services.AddScoped<IProduitsServices, ProduitsService>();
    builder.Services.AddScoped<IUtilisateurServices, UtilisateurServices>();


        // Configure the HTTP request pipeline.
        if (!builder.Build().Environment.IsDevelopment())
        {
            builder.Build().UseExceptionHandler("/Home/Error");
        }
        builder.Build().UseStaticFiles();
        builder.Build().UseRouting();
        builder.Build().UseAuthorization();
        builder.Build().MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");
        builder.Build().Run();
    }
}