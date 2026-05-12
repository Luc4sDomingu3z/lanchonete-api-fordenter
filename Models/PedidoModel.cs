using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace lanchonete_api.Models;

public class Pedido
{
    public int Id { get; set; }

    // Chave estrangeira
    [ForeignKey("Cliente")]
    public int ClienteId { get; set; }
    [Required]
    public Cliente Cliente { get; set; } = null!;

    public DateTime Momento { get; set; }
    public decimal TotalPagar { get; set; }

    public ICollection<BebidaSaida>? Bebidas { get; } = [];
    public ICollection<LancheSaida>? Lanches { get; } = [];
}
