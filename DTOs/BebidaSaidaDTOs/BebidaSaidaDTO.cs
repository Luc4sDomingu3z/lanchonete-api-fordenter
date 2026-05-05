namespace lanchonete_api.DTOs.BebidaSaidaDTOs;

public class BebidaSaidaDTO
{
    public int Id { get; set; }
    // De BebidaModel
    public string? BebidaNome { get; set; }
    public decimal BebidaValor { get; set; }

    public int Quantidade { get; set; }

    // De PedidoModel
    public DateTime PedidoMomento { get; set; }

    public decimal TotalPagar { get; set; }
    public DateTime Momento { get; set; }
}
