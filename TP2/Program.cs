using Microsoft.AspNetCore.Localization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Globalization;
using TP2.Data;
using TP2.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddScoped<IPlaneteService>(service => new PlaneteService(IPlaneteService.Type.BaseDonnées,
                                                service.GetRequiredService<PlaneteContext>()));
builder.Services.AddDbContext<PlaneteContext>(options =>
                options.UseSqlServer(
                        builder.Configuration.GetConnectionString("PlaneteContext").Replace("[PROJET]", builder.Environment.ContentRootPath)));

builder.Services.Configure<RequestLocalizationOptions>(
 options =>
 {
     var supportedCultures = new[] {
 new CultureInfo("en"),
 new CultureInfo("fr"),
 };
     options.DefaultRequestCulture = new RequestCulture("fr");
     options.SupportedCultures = supportedCultures;
     options.SupportedUICultures = supportedCultures;
 });

builder.Services.AddLocalization(options => options.ResourcesPath = "Resources");
builder.Services.AddMvc().AddViewLocalization().AddDataAnnotationsLocalization();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();
app.UseRequestLocalization(
app.Services.GetService<IOptions<RequestLocalizationOptions>>()!.Value);

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
