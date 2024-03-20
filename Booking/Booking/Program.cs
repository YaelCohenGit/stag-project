using Dal.Models;
using DataAccess;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using BL;
using BL.API;
using BL.BLImplementation;
using Dal;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddScoped<BLManager>();
builder.Services.AddControllers();
builder.Services.AddServices();

builder.Services.AddCors(options =>
{
    options.AddPolicy("CORSPolicy",
        builder =>
        {
            builder
            .AllowAnyMethod()
            .AllowAnyHeader()
            .AllowAnyOrigin();
        });
});

#region
/*builder.Services.AddSwaggerGen();*/

/*var provider = builder.Services.BuildServiceProvider();
var configuration = provider.GetRequiredService<IConfiguration>();

builder.Services.AddDbContext<DBContext>();*/
#endregion
DBActions actions = new DBActions(builder.Configuration); 
var connString = actions.GetConnectionString("AcademyDB");
//from appsettings.json;
builder.Services.AddDbContext<DBContext>(opt => opt.UseSqlServer(connString));

var app = builder.Build();

/*if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}*/

app.UseCors("CORSPolicy");
app.MapControllers();

app.Run();




