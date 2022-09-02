using Lista_Semana_1__M3__DotNet_DevInHouse.DataBase;
using Lista_Semana_1__M3__DotNet_DevInHouse.Entities;
using Lista_Semana_1__M3__DotNet_DevInHouse.Models;
using Lista_Semana_1__M3__DotNet_DevInHouse.Repository;
using Lista_Semana_1__M3__DotNet_DevInHouse.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContextFactory<Context>(
        options => options.UseSqlServer(builder.Configuration.GetConnectionString("EventAPI")
    )
  );

builder.Services.AddScoped<IBandService, BandService>();
builder.Services.AddScoped<IBandRepository<BandModel>, BandRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
