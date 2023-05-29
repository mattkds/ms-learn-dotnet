using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using simple_microservice.models;

var builder = WebApplication.CreateBuilder(args);

// Add BDD connection
builder.Services.AddDbContext<MovieContext>(options =>
options.UseNpgsql(builder.Configuration.GetConnectionString("WebApiDatabase"))
);

// Add services to the container.

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

app.UseAuthorization();

app.MapControllers();

app.Run();
