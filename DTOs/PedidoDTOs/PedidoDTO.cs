using lanchonete_api.DTOs.BebidaSaidaDTOs;
using lanchonete_api.DTOs.LancheSaidaDTOs;
using lanchonete_api.Models;
namespace lanchonete_api.DTOs.PedidoDTOs;

public class PedidoDTO
{
    public int Id { get; set; }

    public Cliente ClienteNome { get; set; } = null!;

    public DateTime Momento { get; set; }
    public decimal TotalPagar { get; set; }

    public ICollection<BebidaSaidaDTO>? BebidasPedido { get; set; } = [];
    public ICollection<LancheSaidaDTO>? LanchesPedido { get; set; } = [];
}
