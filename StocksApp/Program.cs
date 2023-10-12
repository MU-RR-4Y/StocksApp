using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Hosting.StaticWebAssets;
using Microsoft.EntityFrameworkCore;
using MudBlazor.Services;
using StocksApp.Data;
using StocksApp.Models;


var builder = WebApplication.CreateBuilder(args);

StaticWebAssetsLoader.UseStaticWebAssets(builder.Environment, builder.Configuration);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddMudServices();
var yahooApi = builder.Configuration["Stock_API_Key"];

builder.Services.AddHttpClient("yahoo", request => 
{
    request.BaseAddress = new Uri("https://apidojo-yahoo-finance-v1.p.rapidapi.com/");
    request.DefaultRequestHeaders.Add("X-RapidAPI-Key", yahooApi);
    request.DefaultRequestHeaders.Add("X-RapidAPI-Host", "apidojo-yahoo-finance-v1.p.rapidapi.com");
});

builder.Services.AddHttpClient("fx", request =>
{
    request.BaseAddress = new Uri($"https://fxmarketapi.com");
});
builder.Services.AddDbContextFactory<StockAppDbContext>( options => options.UseSqlServer(
    builder.Configuration.GetConnectionString("StockAppDb")));



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();