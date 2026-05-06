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

    /*
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Saida de bebidas para pedidos
        modelBuilder.Entity<Pedido>()
            .HasMany(p => p.Bebidas)
            .WithOne(b => b.Pedido)
            .HasForeignKey(b => b.BebidaId)
            .OnDelete(DeleteBehavior.NoAction);

        // Saida de lanches para pedidos
        modelBuilder.Entity<Pedido>()
            .HasMany(p => p.Lanches)
            .WithOne(l => l.Pedido)
            .HasForeignKey(l => l.LancheId)
            .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<Pedido>()
            .HasOne(p => p.Cliente)
            .WithMany(cli => cli.Pedidos)
            .HasForeignKey(p => p.ClienteId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Bebida>()
            .HasMany(b => b.Saidas)
            .WithOne(s => s.Bebida)
            .HasForeignKey(s => s.Id)
            .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<Lanche>()
            .HasMany(b => b.Saidas)
    }
    */

}
