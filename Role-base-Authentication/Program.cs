using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Role_base_Authentication.Areas.Identity.Data;
using Role_base_Authentication.Data;
using Role_base_Authentication.Helpers;
using Role_base_Authentication.Models;
var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("Role_base_AuthenticationContextConnection") ?? throw new InvalidOperationException("Connection string 'Role_base_AuthenticationContextConnection' not found.");;

builder.Services.AddDbContext<Role_base_AuthenticationContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<Role_base_AuthenticationContext>();
builder.Services.AddTransient<IEmailSender, EmailSender>();
builder.Services.Configure<SmtpSettings>(builder.Configuration.GetSection("SmtpSetting"));
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
app.UseRouting();
app.MapRazorPages();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
