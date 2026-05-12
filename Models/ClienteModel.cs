namespace lanchonete_api.Models;

public class Cliente
{
    public int Id { get; set; }
    public string Nome { get; set; } = null!;
    public int Idade { get; set; }
    public ICollection<Pedido>? Pedidos { get; set; }
}
