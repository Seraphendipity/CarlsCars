using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CC;


// CLI for Scaffolding (auto code gen) and Context Creation (CarsContext) 
// dotnet-aspnet-codegenerator controller -name CarsController -m Car -dc CarsContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries -sqlite

// DBContext Instantiation

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<CarsContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("CarsContext") ?? throw new InvalidOperationException("Connection string 'CarsContext' not found.")));
    

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();


using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    InitializationSeed.Initialize(services, true);
}


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
