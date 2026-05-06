namespace lanchonete_api.Models;

public class LancheSaida
{
    public int Id { get; set; }
    public int LancheId { get; set; }
    public Lanche Lanche { get; set; } = null!;
    // Chave estranheira
    public int PedidoId { get; set; }
    public Pedido Pedido { get; set; } = null!;

    public int Quantidade { get; set; }
    public decimal TotalPagar { get; set; }
    public DateTime Momento { get; set; }

}
