using System.ComponentModel.DataAnnotations;

namespace lanchonete_api.DTOs.BebidaSaidaDTOs;

public class BebidaSaidaUpdateDTO
{
    [Required(ErrorMessage = "Id da saida de bebida necessaria.")]
    public int Id { get; set; }

    [Required(ErrorMessage = "Id da bebida necessaria.")]
    public int BebidaId { get; set; }

    [Required(ErrorMessage = "Unidades retiradas necessaria.")]
    public int Quantidade { get; set; }

    [Required(ErrorMessage = "Id do pedido necessario.")]
    public int PedidoId { get; set; }

    [Required(ErrorMessage = "Valor total das saidas de bebida necessaria.")]
    [Range(0.01, 9999.00, ErrorMessage = "Valor invalido.")]
    public decimal TotalPagar { get; set; }
    public DateTime Momento { get; set; }
}
