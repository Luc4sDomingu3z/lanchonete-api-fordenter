using lanchonete_api.Models;
using Microsoft.EntityFrameworkCore;

namespace lanchonete_api.Data;

public class LanchoneteApiDbContext(DbContextOptions<LanchoneteApiDbContext> options) : DbContext(options)
{

    public DbSet<Operador>? Operadores { get; set; }
    public DbSet<Pedido>? Pedidos { get; set; }
    public DbSet<Cliente>? Clientes { get; set; }
    public DbSet<Lanche>? Lanches { get; set; }
    public DbSet<LancheSaida>? LancheSaidas { get; set; }
    public DbSet<Bebida>? Bebidas { get; set; }
    public DbSet<BebidaSaida>? BebidaSaidas { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Lanche>()
            .HasMany(l => l.Saidas)
            .WithOne(s => s.Lanche)
            .HasForeignKey(s => s.LancheId)
            .OnDelete(DeleteBehavior.Cascade);
    }

}
