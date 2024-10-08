using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using MudBlazor.Services;
using Template_Design.Components;
using Template_Design.Models;
using Template_Design.Models.Services;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
builder.Services.AddMudServices();

builder.Services.AddControllersWithViews();
//builder.Services.AddSwaggerGen();

builder.Services.AddControllers();
var connectionString = builder.Configuration.GetConnectionString("DBConnection");
builder.Services.AddDbContext<AppDbContext>(options =>
options.UseSqlServer(connectionString))
    .AddAuthentication()
    .AddBearerToken();

builder.Services.AddScoped<ITemplateService, TemplateService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseSwagger();
app.UseHttpsRedirection();
app.MapControllers();
app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
