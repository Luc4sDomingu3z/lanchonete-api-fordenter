using System.ComponentModel.DataAnnotations;

namespace lanchonete_api.DTOs.PedidoDTOs;

public class PedidoCreateDTO
{
    [Required(ErrorMessage = "Id de cliente necessario.")]
    public int ClienteId { get; set; }

    public DateTime Momento { get; set; } = DateTime.Now;

    [Required(ErrorMessage = "Valor total necessario.")]
    [Range(0.01, 9999.00, ErrorMessage = "Valor invalido no pagamento total.")]
    public decimal TotalPagar { get; set; }
}
