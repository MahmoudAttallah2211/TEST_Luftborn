using FastFood.Models;
using FastFood.Repository;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration;
using TestLuftbornFastFood.Models;
using IdentityRole = Microsoft.AspNet.Identity.EntityFramework.IdentityRole;
using IdentityUser = Microsoft.AspNet.Identity.EntityFramework.IdentityUser;

///////////////in this file we need to register the instance of each entity that you deal with 
///and register the configuration of the project as all
///configure the middleware and swagger apis and controller and viewcontroller and the life time of the instance if 
///singletone,scooped,transient//////////////////

var builder = WebApplication.CreateBuilder(args);

var configuration = new ConfigurationBuilder()
     .AddJsonFile("appsettings.json")
     .Build();


// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddControllersWithViews();

builder.Services.AddControllers();

builder.Services.AddDbContext<ApplicationDbContext>(Options =>
Options.UseSqlServer(configuration.GetConnectionString("Defaultconnection")

));

//builder.Services.AddIdentity<IdentityUser, IdentityRole>()
//    .AddDefaultTokenProviders()
//    .AddEntityFrameworkStores<ApplicationDbContext>();
//builder.Services.AddScoped<IDbInitializer,DbInitializer>();
//builder.Services.AddScoped<IEmailSender, EmailSender>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseAuthorization();

app.MapGet("/hi", () => "Hello!");

app.MapDefaultControllerRoute();
app.MapRazorPages();

app.Run();

// // Add services to the container.


// var builder = WebApplication.CreateBuilder(args);

// // Add services to the container.
// ///very important step 11111
// var configuration = new ConfigurationBuilder()
//     .AddJsonFile("appsettings.json")
//     .Build();

// builder.Services.AddControllers();

// builder.Services.AddDbContext<ApplicationDbContext>(Options =>
// Options.UseSqlServer(configuration.GetConnectionString("Defaultconnection")

// ));
// builder.Services.AddIdentity< ApplicationUser,IdentityRole>();

// //builder.Services.AddIdentityCore<IdentityUser>().AddRoleManager<IdentityUser>().AddUserManager<IdentityUser>();

// builder.Services.AddControllersWithViews();

// builder.Services.AddRazorPages();

//var app = builder.Build();

// // Configure the HTTP request pipeline.
// if (!app.Environment.IsDevelopment())
// {
//     app.UseExceptionHandler("/Home/Error");
//     // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
//     app.UseHsts();
// }

// app.UseHttpsRedirection();
// app.UseStaticFiles();

// app.UseRouting();

// app.UseAuthorization();

// app.MapControllerRoute(
//     name: "default",
//     pattern: "{controller=Home}/{action=Index}/{id?}");

// app.Run();
