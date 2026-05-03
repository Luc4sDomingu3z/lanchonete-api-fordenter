namespace lanchonete_api.Models;

public class Cliente
{
  public int Id { get; set; }
  public string? Nome { get; set; }
  public int Idade { get; set; }
  public List<Pedido>? Pedidos { get; set; }
}
