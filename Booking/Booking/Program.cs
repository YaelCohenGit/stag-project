using Dal.Models;
using DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddDbContext<DBContext>();

DBActions actions = new DBActions(builder.Configuration);
var connString = actions.GetConnectionString("AcademyDB");  //from appsettings.json
builder.Services.AddDbContext<DBContext>(opt => opt.UseSqlServer(connString));
//builder.Services.AddScoped<IUniversityRepo, UniversityRepo>();
//builder.Services.AddScoped<ICountryRepo, CountryRepo>();
//builder.Services.AddScoped<IUniversityRankingRepo, UniversityRankingRepo>();

var app = builder.Build();



app.MapGet("/", () => "Hello World!");
app.MapControllers();

app.Run();




