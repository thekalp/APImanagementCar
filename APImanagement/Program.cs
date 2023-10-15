using Context.Models;
using Microsoft.EntityFrameworkCore;
using Repository;
using Repository.BaseClass;
using Repository.Interface;
using Service;
using Service.Interface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

//builder.Services.AddDbContext<TestContext>();
//builder.Services.AddScoped<ICarManagementRepository, CarManagementRepository>();
var configurationSection = builder.Configuration.GetSection("DefaultConnection");
string connectionString = configurationSection.GetValue<string>("DefaultConnection");

builder.Services.AddDbContext<TestContext>(opts => opts.UseSqlServer(connectionString));
builder.Services.AddScoped<ICarManagement, CarmanagmentService>();

builder.Services.AddScoped<ICarManagementRepository, CarManagementRepository>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
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

app.UseAuthorization();

app.MapControllers();

app.Run();
