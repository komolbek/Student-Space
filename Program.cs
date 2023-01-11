using StudentPlus.Interfaces;
using StudentPlus.Controllers;
using StudentPlus.Services;
using StudentPlus.DesignPatterns;
using StudentPlus.DataRepositories;
using Microsoft.EntityFrameworkCore;
using StudentPlus.DbContexts;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Dependency injections
builder.Services.AddTransient<IUserAccount, UserAccountServiceAdapter>();
builder.Services.AddTransient<StudentAccountService>();
builder.Services.AddTransient<SupervisorAccountService>();
builder.Services.AddTransient<StudentRepository>();

// Database and storage configurations
builder.Services.AddDbContext<AppDbContext>(options =>
   options.UseSqlite(builder.Configuration.GetConnectionString("AppDbContext")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

