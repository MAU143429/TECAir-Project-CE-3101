global using Microsoft.EntityFrameworkCore;
global using Npgsql;
using TECAir_API;
using TECAir_API.Models;
using TECAir_API.Database;
using TECAir_API.Database.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TECAir_API.Database.Interface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
Singleton s = Singleton.Instance();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var postgreSQLConnectionConfiguration = new PostgreSQLConfiguration(builder.Configuration.GetConnectionString("PostgreSQLConnection"));
builder.Services.AddSingleton(postgreSQLConnectionConfiguration);
builder.Services.AddScoped<IPromocion, PromocionRepository>();
builder.Services.AddScoped <IVuelo,VueloRepository> ();
builder.Services.AddScoped<IMaletum, MaletumRepository>();
builder.Services.AddScoped<IReservacion, ReservacionRepository>();
builder.Services.AddScoped<ITiquete, TiqueteRepository>();
builder.Services.AddScoped<IAvion, AvionRepository>();
builder.Services.AddScoped<IAutomation, AutomationRepository>();
//configuracion del context en el programa
builder.Services.AddDbContext<TECAirContext>(
    o => o.UseNpgsql(builder.Configuration.GetConnectionString("TECAir")));
var app = builder.Build();


//builder.Services.AddScoped<,>();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(x => x
            .AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader());

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
