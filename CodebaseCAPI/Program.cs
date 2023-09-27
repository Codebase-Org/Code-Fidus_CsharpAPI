using CodebaseCAPI.Database;
using Microsoft.EntityFrameworkCore;
using CodebaseCAPI.Controllers;
using CodebaseCAPI.Interfaces;
using CodebaseCAPI.Services;
using CodebaseCAPI.Models;
using CodebaseCAPI.Repositories;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddCors(options =>
{
    options.AddPolicy("CorsPolicy",
        builder => builder.AllowAnyOrigin()
        .AllowAnyMethod()
        .AllowAnyHeader());
});

//builder.Services.AddDbContext<DatabaseContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("Connection")));
builder.Services.AddDbContext<DatabaseContext>(options => options.UseMySql(builder.Configuration.GetConnectionString("Connection"), new MySqlServerVersion(new Version(8, 0, 27))));
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
var models = Assembly.GetExecutingAssembly().GetTypes().Where(type => !type.IsAbstract && typeof(BaseEntity).IsAssignableFrom(type));
foreach (var model in models)
{
    var baseServiceType = typeof(IBaseService<>).MakeGenericType(model);
    var baseRepositoryType = typeof(IBaseRepository<>).MakeGenericType(model);

    var baseServiceImplementationType = typeof(BaseService<>).MakeGenericType(model);
    var baseRepositoryImplementationType = typeof(BaseRepository<>).MakeGenericType(model);
    builder.Services.AddScoped(baseServiceType, baseServiceImplementationType);
    builder.Services.AddScoped(baseRepositoryType, baseRepositoryImplementationType);
    
    //builder.Services.AddScoped<IBaseService<model>, BaseService<model>>();
    //builder.Services.AddScoped<IBaseRepository<model>, BaseRepository<model>>();
}


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("CorsPolicy");

app.UseAuthorization();

app.MapControllers();

app.Run();
