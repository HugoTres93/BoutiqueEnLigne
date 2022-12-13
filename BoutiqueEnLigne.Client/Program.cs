using BoutiqueEnLigne.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
//builder.Services.AddDbContext<MyContext>(options => options.UseSqlServer(builder.Configuration.GetConnextionString("")));
// builer.Configuration["ParamTest"];
// builder.Services.AddScoped<IExempleService, ExempleService>();

// Enregistrer les services ici

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
