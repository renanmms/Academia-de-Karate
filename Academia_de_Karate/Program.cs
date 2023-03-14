using Academia_de_Karate.Persistence;
using Academia_de_Karate.Persistence.Repository;
using AspNetCoreHero.ToastNotification;
using AspNetCoreHero.ToastNotification.Extensions;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("AcademiaDeKarateCS");

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IAlunoRepository, AlunoRepository>();
builder.Services.AddNotyf(config=> { config.DurationInSeconds = 10;config.IsDismissable = true;config.Position = NotyfPosition.TopRight; });

builder.Services.AddDbContext<AcademiaDeKarateDbContext>(
    options => 
    {
        options.UseSqlServer(connectionString);
    }
);

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
app.UseNotyf();
app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
