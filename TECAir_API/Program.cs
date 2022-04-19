global using Microsoft.EntityFrameworkCore;
global using Npgsql;
using TECAir_API;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
Singleton s = Singleton.Instance();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//configuracion del context en el programa
builder.Services.AddDbContext<TECAirContext>(
    o => o.UseNpgsql(builder.Configuration.GetConnectionString("TECAir")));
var app = builder.Build();

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
