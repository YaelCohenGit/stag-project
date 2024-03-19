using Dal.Models;
using DataAccess;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using BL;
using BL.API;
using BL.BLImplementation;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddScoped<BLManager>();
builder.Services.AddControllers();
builder.Services.AddServices();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

/*builder.Services.AddSwaggerGen();*/

/*var provider = builder.Services.BuildServiceProvider();
var configuration = provider.GetRequiredService<IConfiguration>();

builder.Services.AddDbContext<DBContext>();*/










DBActions actions = new DBActions(builder.Configuration); 
var connString = actions.GetConnectionString("AcademyDB");
//from appsettings.json;
builder.Services.AddDbContext<DBContext>(opt => opt.UseSqlServer(connString));
//builder.Services.AddScoped<IUniversityRepo, UniversityRepo>();
//builder.Services.AddScoped<ICountryRepo, CountryRepo>();
//builder.Services.AddScoped<IUniversityRankingRepo, UniversityRankingRepo>();
builder.Services.AddSingleton<IAptDetailsService, AptDetailsService>();


var app = builder.Build();

/*if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}*/

app.MapControllers();
app.MapGet("/", () => "Hello World!");


app.Run();




