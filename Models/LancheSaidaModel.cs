using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lanchonete_api.Models;

public class LancheSaida
{
    public int Id { get; set; }

    // Chave estrangeira
    [ForeignKey("Lanche")]
    public int LancheId { get; set; }
    [Required]
    public Lanche Lanche { get; set; } = null!;

    // Chave estranheira
    [ForeignKey("Pedido")]
    public int PedidoId { get; set; }
    [Required]
    public Pedido Pedido { get; set; } = null!;

    public int Quantidade { get; set; }
    public decimal TotalPagar { get; set; }
    public DateTime Momento { get; set; }
}
