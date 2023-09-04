using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Ponto.Application.Helpers;
using Ponto.Application.Interfaces;
using Ponto.Application.Services;
using Ponto.Persistence;
using Ponto.Persistence.Context;
using Ponto.Persistence.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddCors();



builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddDbContext<ColaboradorContext>(con => con.UseSqlite(builder.Configuration.GetConnectionString("Default")));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


//config automapper
var config = new MapperConfiguration(cfg =>
{
    cfg.AddProfile(new ProEventosProfile());
});

IMapper mapper = config.CreateMapper();
builder.Services.AddSingleton(mapper);   //services.AddSingleton(mapper);

builder.Services.AddScoped<IColaboradorService, ColaboradorService>();
builder.Services.AddScoped<IColaboradorPersist, ColaboradorPersistence>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(
    x => x.AllowAnyHeader()
        .AllowAnyMethod()
        .AllowAnyOrigin()
);

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
