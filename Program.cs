using e_commerce.Data;
using e_commerce.Data.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages(); // For MVC views
builder.Services.AddControllersWithViews(); // Add MVC
builder.Services.AddServerSideBlazor();

builder.Services.AddDbContext<AppDbcontext>(options =>
    options.UseInMemoryDatabase("MyDatabase"));
builder.Services.AddScoped<IActorsService, ActorsService>();
builder.Services.AddScoped<IMovieService, MovieService>();
builder.Services.AddScoped<IProducersService, ProducerService>();

builder.Services.AddControllersWithViews();
var app = builder.Build();


if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();
app.MapControllers();
app.MapBlazorHub();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();