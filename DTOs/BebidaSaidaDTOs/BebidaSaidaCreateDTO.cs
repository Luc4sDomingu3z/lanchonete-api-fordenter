using System.ComponentModel.DataAnnotations;
namespace lanchonete_api.DTOs.BebidaSaidaDTOs;

public class BebidaSaidaCreateDTO
{
    [Required(ErrorMessage = "Id de bebida necessário.")]
    public int BebidaId { get; set; }

    [Required(ErrorMessage = "Quantidade de saida necessária.")]
    public int Quantidade { get; set; }

    [Required(ErrorMessage = "Id do pedido necessário.")]
    public int PedidoId { get; set; }

    [Required(ErrorMessage = "Valor total de saida necessário;")]
    [Range(0.01, 99999.00, ErrorMessage = "Valor total de saida inválido.")]
    public decimal TotalPagar { get; set; }
}
