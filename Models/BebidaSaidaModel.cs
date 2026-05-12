using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lanchonete_api.Models;

public class BebidaSaida
{
    public int Id { get; set; }

    // chave estrangeira
    [ForeignKey("Bebida")]
    public int BebidaId { get; set; }
    [Required]
    public Bebida Bebida { get; set; } = null!;

    public int Quantidade { get; set; }

    // Chave estrangeira
    [ForeignKey("Pedido")]
    public int PedidoId { get; set; }
    [Required]
    public Pedido Pedido { get; set; } = null!;

    public decimal TotalPagar { get; set; }
    public DateTime Momento { get; set; }
}
