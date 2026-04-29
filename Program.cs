using Microsoft.EntityFrameworkCore.InMemory;
using Swashbuckle.AspNetCore.SwaggerUI;
using Swashbuckle.AspNetCore.SwaggerGen;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddOpenApi();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
  app.MapOpenApi();
  app.UseSwagger();
  app.UseSwaggerUI(opt =>
  {
    opt.SwaggerEndpoint("/swagger/v1/swagger.json", "Lanchonete Api - Sprint ");
  });
}

app.Run();
