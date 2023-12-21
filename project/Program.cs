using project;
using Solid.Core.Repositories;
using Solid.Core.Services;
using Solid.Core.Entities;
using Solid.Data.Repositories;
using Solid.Service;
using Solid.Data;
using DataContext = Solid.Data.DataContext;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//builder.Services.AddSingleton<DataContext>();
builder.Services.AddDbContext<DataContext>();

builder.Services.AddScoped<ICourtRepository, CourtRepository>();
builder.Services.AddScoped<IGovernmentRepository, GovernmentRepository>();
builder.Services.AddScoped<IHknessetRepository, HknessetRepository>();


builder.Services.AddScoped<ICourtService, CourtService>();
builder.Services.AddScoped<IGovernmentService, GovernmentService>();
builder.Services.AddScoped<IHknessetService, HknessetService>();

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
