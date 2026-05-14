using lanchonete_api.Data;
using lanchonete_api.Interfaces.Repositories;
using lanchonete_api.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<LanchoneteApiDbContext>(options =>
{
    options.UseMySQL(builder.Configuration.GetConnectionString("Default")!);
});

builder.Services.AddOpenApi();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Scopos repositories
builder.Services.AddScoped<IPedidoRepository, PedidoRepository>();
builder.Services.AddScoped<IClienteRepository, ClienteRepository>();
builder.Services.AddScoped<IOperadorRepository, OperadorRepository>();
builder.Services.AddScoped<IBebidaRepository, BebidaRepository>();
builder.Services.AddScoped<IBebidaSaidaRepository, BebidaSaidaRepository>();
builder.Services.AddScoped<ILancheRepository, LancheRepository>();
builder.Services.AddScoped<ILancheSaidaRepository, LancheSaidaRepository>();

// Scopos de servicos
// builder.Services.AddScoped<IPedidoService, PedidoService>();
// builder.Services.AddScoped<IClienteService, ClienteService>();
// builder.Services.AddScoped<IOperadorService, OperadorService>();
// builder.Services.AddScoped<IBebidaService, BebidaService>();
// builder.Services.AddScoped<IBebidaSaidaService, BebidaSaidaService>();
// builder.Services.AddScoped<ILancheService, LancheService>();
// builder.Services.AddScoped<ILancheSaidaService, LancheSaidaService>();

builder.Services.AddControllers()
    .AddJsonOptions(options =>
        {
            options.JsonSerializerOptions.PropertyNamingPolicy = null;
        });

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

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
