using lanchonete_api.Models;
using Microsoft.EntityFrameworkCore;

namespace lanchonete_api.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) { }

    public DbSet<Operador>? Operadores { get; set; }
    public DbSet<Pedido>? Pedidos { get; set; }
    public DbSet<Cliente>? Clientes { get; set; }
    public DbSet<Lanche>? Lanches { get; set; }
    public DbSet<LancheSaida>? LancheSaidas { get; set; }
    public DbSet<Bebida>? Bebidas { get; set; }
    public DbSet<BebidaSaida>? BebidaSaidas { get; set; }
}
