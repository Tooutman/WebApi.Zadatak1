using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using Zadatak1.Data;
using Zadatak1.Data.Interfaces;
using Zadatak1.Data.Repos;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
//nakon što dodali preko nugeta Swashbuckle.AspNetCore, dodamo i ovaj red   
builder.Services.AddSwaggerGen();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(connectionString)
);

builder.Services.AddScoped<IBookRepository, BookRepository>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwagger(); //openApi specifikacija u json formatu
    app.UseSwaggerUI(); //Vizalna reprenzentacija swagera
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
