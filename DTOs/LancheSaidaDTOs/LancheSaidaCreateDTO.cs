using System.ComponentModel.DataAnnotations;
namespace lanchonete_api.DTOs.LancheSaidaDTOs;

public class LancheSaidaCreateDTO
{
    [Required(ErrorMessage = "Id do lanche necessário")]
    public int LancheId { get; set; }

    [Required(ErrorMessage = "Id de pedido necessário.")]
    public int PedidoId { get; set; }

    [Required(ErrorMessage = "Quantidade da saida de lanche necessária.")]
    public int Quantidade { get; set; }

    [Required(ErrorMessage = "Total a pagar da saida necessario.")]
    [Range(0.01, 99999.00, ErrorMessage = "Valor total invalido.")]
    public decimal TotalPagar { get; set; }
}
