using System.ComponentModel.DataAnnotations;

namespace lanchonete_api.DTOs.LancheSaidaDTOs;

public class LancheSaidaUpdateDTO
{
    [Required(ErrorMessage = "Id da saida de lanche necessario.")]
    public int Id { get; set; }

    [Required(ErrorMessage = "Id do lanche necessario.")]
    public int LancheId { get; set; }

    [Required(ErrorMessage = "Id do pedido necessario.")]
    public int PedidoId { get; set; }

    [Required(ErrorMessage = "Quantidade da saida necessaria.")]
    public int Quantidade { get; set; }

    [Required(ErrorMessage = "Valor total da saida necessario.")]
    public decimal TotalPagar { get; set; }

    [Required(AllowEmptyStrings = false)]
    public DateTime Momento { get; set; }
}
