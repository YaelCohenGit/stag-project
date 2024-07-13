using BL;
using BL.API;
using BL.BLImplementation;
using Dal;
using Dal.Models;
using DataAccess;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//builder.Services.AddEndpointsApiExplorer();
builder.Services.AddControllers();


//var provider = builder.Services.BuildServiceProvider();
//var configuration = provider.GetRequiredService<IConfiguration>();
builder.Services.AddCors(options =>
{
    options.AddPolicy("CORSPolicy", builder =>
    {
        builder
        .AllowAnyMethod()
        .AllowAnyHeader()
        .WithOrigins("http://localhost:3000");
    });
});

DBActions actions = new DBActions(builder.Configuration);
var connString = actions.GetConnectionString("AcademyDB");
//builder.Services.AddDbContext<DBContext>(options => options.UseSqlServer(connString));
builder.Services.AddScoped(b => new BLManager(connString));

var app = builder.Build();

//app.UseHttpsRedirection();

//app.UseRouting();

//app.UseAuthorization();

//app.UseEndpoints(endpoints =>
//{
//    endpoints.MapControllers();
//});


app.UseCors("CORSPolicy");
//app.MapGet("/", () => "Hello World!");

app.MapControllers();
app.Run();





