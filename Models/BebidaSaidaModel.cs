namespace lanchonete_api.Models;

public class BebidaSaidaModel
{
    public int Id { get; set; }
    public int BebidaId { get; set; }
    public Bebida Bebida { get; set; } = null!;
    public int Quantidade { get; set; }
    public int PedidoId { get; set; }
    public Pedido Pedido { get; set; } = null!;
    public DateTime Momento { get; set; }
}
