using BL;
using BL.API;
using BL.BLImplementation;
using Dal;
using Dal.Models;
using DataAccess;

//using DataAccess;
//using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

//leah added also these usings:
//using DAL.Implementation;
//using DAL.API;
//using Microsoft.Extensions.Configuration;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddControllers();

var provider = builder.Services.BuildServiceProvider();
var configuration = provider.GetRequiredService<IConfiguration>();
builder.Services.AddCors(options =>
{
    options.AddPolicy("CORSPolicy", builder =>
    {
        builder.AllowAnyMethod().AllowAnyHeader().WithOrigins("http://localhost:3000");
    });
});

DBActions actions = new DBActions(builder.Configuration);
var connString = actions.GetConnectionString("AcademyDB");
builder.Services.AddDbContext<DBContext>(options => options.UseSqlServer(connString));
builder.Services.AddScoped<BLManager>();
builder.Services.AddScoped(b => new BLManager(connString));



//builder.Services.AddServices();


#region
/*builder.Services.AddSwaggerGen();*/

/*var provider = builder.Services.BuildServiceProvider();
var configuration = provider.GetRequiredService<IConfiguration>();

builder.Services.AddDbContext<DBContext>();*/
#endregion
//DBActions actions = new DBActions(builder.Configuration); 
//var connString = actions.GetConnectionString("AcademyDB");
//builder.Services.AddDbContext<DBContext>(opt => opt.UseSqlServer(connString));

var app = builder.Build();

/*if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}*/

app.UseCors("CORSPolicy");
app.MapGet("/", () => "Hello World!");
app.MapControllers();

app.Run();





