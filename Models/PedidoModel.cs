namespace lanchonete_api.Models;

public class Pedido
{
    public int Id { get; set; }
    // Chave estrangeira
    public int ClienteId { get; set; }
    public Cliente Cliente { get; set; } = null!;

    public DateTime Momento { get; set; }
    public decimal TotalPagar { get; set; }

    public ICollection<BebidaSaida>? Bebidas { get; } = [];
    public ICollection<LancheSaida>? Lanches { get; } = [];
}
