using System.ComponentModel.DataAnnotations;
namespace lanchonete_api.DTOs.PedidoDTOs;

public class PedidoUpdateDTO
{
    [Required(ErrorMessage = "Id do pedido necessario.")]
    public int Id { get; set; }

    [Required(ErrorMessage = "Id de cliente necessario.")]
    public int ClienteId { get; set; }

    [Required(ErrorMessage = "Valor total necessario.")]
    [Range(0.01, 9999.00, ErrorMessage = "Valor invalido no pagamento total.")]
    public decimal TotalPagar { get; set; }
}
