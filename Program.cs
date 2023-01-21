using StudentPlus.Interfaces;
using StudentPlus.Controllers;
using StudentPlus.Services;
using StudentPlus.DesignPatterns;
using StudentPlus.DataRepositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using StudentPlus;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Dependency injections
builder.Services.AddTransient<IUserAccount, UserAccountServiceAdapter>();
builder.Services.AddTransient<StudentAccountService>();
builder.Services.AddTransient<SupervisorAccountService>();
builder.Services.AddTransient<SuperviseeService>();

builder.Services.AddTransient<StudentRepository>();
builder.Services.AddTransient<SupervisorRepository>();
builder.Services.AddTransient<SuperviseeRepository>();

// Database and storage configurations
builder.Services.AddDbContext<AppDbContext>(options =>
{
    // Get the connection string from appsettings.json
    var configuration = builder.Configuration;
    var connectionString = configuration.GetConnectionString("sqlite");

    // Use the connection string to configure the DbContext
    options.UseSqlite(connectionString);
});

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseDeveloperExceptionPage();
    app.UseMigrationsEndPoint();
}

//app.UseHttpsRedirection();

app.UsePathBase("/swagger");

app.UseAuthorization();

app.MapControllers();

app.Run();

