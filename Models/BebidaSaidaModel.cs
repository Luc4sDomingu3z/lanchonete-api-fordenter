namespace lanchonete_api.Models;

public class BebidaSaida
{
    public int Id { get; set; }
    // chave estrangeira
    public int BebidaId { get; set; }
    public Bebida Bebida { get; set; } = null!;
    public int Quantidade { get; set; }
    // Chave estrangeira
    public int PedidoId { get; set; }
    public Pedido Pedido { get; set; } = null!;

    public decimal TotalPagar { get; set; }
    public DateTime Momento { get; set; }

}
