using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ProyectoFinal.Data;
using ProyectoFinal.Models.Data.Repositories;
using ProyectoFinal.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddSingleton<ILotteryCardRepository, LotteryCardRepository>();
builder.Services.AddScoped<ILotteryCardService, LotteryCardService>();
builder.Services.AddScoped<IBolilleroRepository, BolilleroRepository>();
builder.Services.AddScoped<IBolilleroService, BolilleroService>();
builder.Services.AddScoped<ICartonesRepository, CartonesRepository>();
builder.Services.AddScoped<ICartonesServices, CartonesServices>();



builder.Services.AddDbContext<BingoContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("Connection")));
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

app.MapDefaultControllerRoute();

#region CREACIÓN DE LOS CARTONES
var numberOfCards = (int)app.Configuration.GetValue(typeof(int), "NumberOfCards");

using (var scope = app.Services.CreateScope())
{
    var cardRepository = scope.ServiceProvider.GetRequiredService<ILotteryCardRepository>();

    for (int i = 0; i < numberOfCards; i++)
    {
        cardRepository.GetOrCreateLotteryCard(null);
    }
}

#endregion

app.Run();
