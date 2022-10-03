using Microsoft.EntityFrameworkCore;
using Cars;

var builder = WebApplication.CreateBuilder(args);


//dotnet-aspnet-codegenerator controller -name HomeController -m Car -dc CarContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries -sqlite
    
// builder.Services.AddDbContext<Cars>(options =>
//     options.UseSqlite(builder.Configuration.GetConnectionString("CarContext")));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

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
