using Microsoft.AspNetCore.Diagnostics;
using Microsoft.EntityFrameworkCore;
using PracticalTwentyFour.Application.Interfaces;
using PracticalTwentyFour.Data.Contexts;
using PracticalTwentyFour.Data.Interfaces;
using PracticalTwentyFour.Data.Repositories;
using PracticalTwentyTwo.Application.Services;
using PracticalTwentyTwo.Data.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Register DB Context
builder.Services.AddDbContextPool<ApplicationDbContext>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

//Register services
builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
builder.Services.AddScoped<IDepartmentRepository, DepartmentRepository>();
builder.Services.AddScoped<IEmployeeService, EmployeeService>();

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
